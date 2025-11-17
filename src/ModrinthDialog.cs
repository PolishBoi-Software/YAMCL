using Modrinth;
using Modrinth.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YAMCL
{
    public partial class ModrinthDialog : Form
    {
        private ModrinthClient client;
        private VersionInstance instance;
        private List<SearchResult> results = new List<SearchResult>();

        public ModrinthDialog(VersionInstance instance)
        {
            InitializeComponent();

            var userAgent = new UserAgent
            {
                ProjectName = "YAMCL",
                ProjectVersion = "1.1.0",
                GitHubUsername = "PolishBoiYT"
            };

            client = new ModrinthClient(new ModrinthClientConfig
            {
                UserAgent = userAgent.ToString(),
                MaxConcurrentRequests = 25
            });

            this.instance = instance;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private async Task DisplayMods(string term = "")
        {
            results.Clear();
            modList.Items.Clear();

            var facets = new FacetCollection();
            facets.Add(Facet.Version(instance.BaseVersion));

            var search = await client.Project.SearchAsync(term, facets: facets, limit: 50);
            results.AddRange(search.Hits);
            
            foreach (var result in results)
            {
                var proj = await client.Project.GetAsync(result.ProjectId);
                if (result.LatestVersion == instance.BaseVersion || result.ProjectType == Modrinth.Models.Enums.Project.ProjectType.Mod || proj.Loaders.Contains(instance.Loader.ToString()))
                    modList.Items.Add(result.Title);
            }

            statusLbl.Content = $"Found {search.TotalHits} results, showing {search.Hits.Length}";
        }

        private void ModrinthDialog_Load(object sender, EventArgs e)
        {
            _ = DisplayMods();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            _ = DisplayMods(searchBox.Content);
        }

        private string GetMod()
        {
            if (modList.SelectedItem == null)
            {
                return string.Empty;
            }

            var item = results[modList.SelectedIndex];
            return item.ProjectId;
        }

        private void InstallMod(WebClient web, Modrinth.Models.File file)
        {
            string modDir = Path.Combine(instance.DirectoryPath, "mods");
            string modFile = Path.Combine(modDir, file.FileName);

            web.DownloadProgressChanged += (s, ev) =>
            {
                this.Invoke(new Action(() => progBar.Value = ev.ProgressPercentage));
            };

            web.DownloadFileCompleted += (s, ev) =>
            {
                this.Invoke(new Action(() =>
                {
                    statusLbl.Content = "Finished!";
                    progBar.Value = 0;
                }));
            };

            statusLbl.Content = $"Downloading {file.FileName}...";
            web.DownloadFileAsync(new Uri(file.Url), modFile);
        }

        private async void installBtn_Click(object sender, EventArgs e)
        {
            if (modList.SelectedItem == null)
            {
                MessageBox.Show("Please select a mod!", "YAMCL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var mod = await client.Project.GetAsync(GetMod());
                var version = await client.Version.GetAsync(mod.Versions.Last());

                var file = Array.Find(version.Files, f => f.FileName.Contains(instance.Loader.ToString().ToLower()) && f.FileName.Contains(instance.BaseVersion));

                if (file == null)
                {
                    MessageBox.Show($"Couldn't find a version of {mod.Title} that supports {instance.Loader} with {instance.BaseVersion}!", "YAMCL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var web = new WebClient())
                {
                    InstallMod(web, file);

                    foreach (var dep in version.Dependencies)
                    {
                        if (dep.DependencyType == Modrinth.Models.Enums.Version.DependencyType.Required || dep.DependencyType == Modrinth.Models.Enums.Version.DependencyType.Embedded)
                        {
                            var depMod = await client.Project.GetAsync(dep.ProjectId);
                            var depVersion = await client.Version.GetAsync(depMod.Versions.Last());

                            var depFile = depVersion.Files[0];
                            InstallMod(web, depFile);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
