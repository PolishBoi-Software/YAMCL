using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Avalonia.Controls;
using CustomMessageBox.Avalonia;
using Modrinth;
using Modrinth.Exceptions;
using Modrinth.Models;

namespace YetAnotherMinecraftLauncher.Core.Utils
{
    public static class ModrinthUtils
    {
        /// <summary>
        /// The client used to interact with Modrinth's API
        /// </summary>
        public static ModrinthClient Client { get; private set; }
        private static HttpClient http;

        /// <summary>
        /// The user agent.
        /// </summary>
        public static UserAgent UserAgent { get; private set; }

        public static void Init()
        {
            UserAgent = new UserAgent()
            {
                ProjectName = "YAMCL",
                ProjectVersion = "2.0.0",
                GitHubUsername = "PolishBoi-Software",
                Contact = "https://polishboi-software.github.io/YAMCL"
            };

            Client = new ModrinthClient(new ModrinthClientConfig
            {
                UserAgent = UserAgent.ToString()
            });

            byte[] buffer = new byte[262144];
            http = new HttpClient();
            http.Timeout = TimeSpan.FromMinutes(30);
        }

        public static async Task<Project[]> GetMods(string query, FacetCollection facets = null)
        {
            try
            {
                var searches = await Client.Project.SearchAsync(query, limit: 25, facets: facets ?? new FacetCollection());

                Project[] projects = await Task.WhenAll(searches.Hits.Select(async h => await Client.Project.GetAsync(h.ProjectId)));

                return projects;
            }
            catch
            {
                throw;
            }
        }

        public static async Task DownloadMod(Project mod, ModLoader loader, string mcVersion, string outputDir, ProgressBar bar = null)
        {
            try
            {
                if (mod.Status != Modrinth.Models.Enums.Project.ProjectStatus.Approved) return;

                var versions = await Task.WhenAll(mod.Versions.Select(async v => await Client.Version.GetAsync(v)));

                var version = versions.FirstOrDefault(v => v.SupportsLoader(loader) && v.SupportsMinecraftVersion(mcVersion));

                if (version == null)
                {
                    await MessageBox.Show($"No compatible version of {mod.Title} found!", "YAMCL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var fileUrl = version.Files[0].Url;
                var filePath = Path.Combine(outputDir, version.Files[0].FileName);

                var prog = new Progress<float>((progress) =>
                {
                    if (bar != null)
                        Avalonia.Threading.Dispatcher.UIThread.Invoke(() => bar.Value = progress * 100);
                });

                using (var stream = await http.GetStreamAsync(fileUrl))
                {
                    using (var fs = new FileStream(filePath, FileMode.OpenOrCreate))
                    {
                        await http.DownloadAsync(fileUrl, fs, prog);
                    }
                }

                var deps = await Task.WhenAll(version.Dependencies.Select(async (dep) => await Client.Project.GetAsync(dep.ProjectId)));

                for (int i = 0; i < deps.Length; i++)
                {
                    var dep = deps[i];

                    if (version.Dependencies[i].DependencyType == Modrinth.Models.Enums.Version.DependencyType.Required)
                        await DownloadMod(dep, loader, mcVersion, outputDir, bar);
                }
            }
            catch
            {
                throw;
            }
        }

        public static bool SupportsMinecraftVersion(this Modrinth.Models.Version version, string mcVersion)
        {
            return version.GameVersions.Contains(mcVersion);
        }

        public static bool SupportsLoader(this Modrinth.Models.Version version, ModLoader loader)
        {
            return version.Loaders.Contains(loader.ToString().ToLower());
        }

        public static void Free()
        {
            http.Dispose();
            Client.Dispose();
        }
    }
}
