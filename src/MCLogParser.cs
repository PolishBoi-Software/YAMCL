using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace YAMCL
{
    public static class MCLogParser
    {
        public static (LogLevel level, DateTime time, string message) Parse(string msg)
        {
            string cleanMsg = msg.Replace("log4j:", "");

            var match = System.Text.RegularExpressions.Regex.Match(
                cleanMsg,
                @"<Event\b.*?</Event>",
                System.Text.RegularExpressions.RegexOptions.Singleline
            );

            if (!match.Success)
                return (LogLevel.Other, DateTime.Now, msg);

            try
            {
                var doc = XDocument.Parse(match.Value);
                var ev = doc.Root;

                string lvlStr = ev.Attribute("level") != null
                    ? ev.Attribute("level").Value.ToLower()
                    : "";

                LogLevel lvl;
                switch (lvlStr)
                {
                    case "info": lvl = LogLevel.Information; break;
                    case "debug": lvl = LogLevel.Debug; break;
                    case "error": lvl = LogLevel.Error; break;
                    case "fatal": lvl = LogLevel.Fatal; break;
                    case "warn": lvl = LogLevel.Warning; break;
                    case "trace": lvl = LogLevel.Trace; break;
                    default: lvl = LogLevel.Other; break;
                }

                DateTime time = DateTime.Now;

                long ts;
                if (long.TryParse(ev.Attribute("timestamp")?.Value, out ts))
                    time = DateTimeOffset.FromUnixTimeMilliseconds(ts).LocalDateTime;

                var msgNode = ev.Descendants().FirstOrDefault(x => x.Name.LocalName == "Message");
                string message = msgNode != null ? msgNode.Value.Trim() : "Unknown";

                return (lvl, time, message);
            }
            catch
            {
                return (LogLevel.Other, DateTime.Now, msg);
            }
        }
    }
}
