using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConnector
{
    public class IniParser
    {
        private readonly Dictionary<string, Dictionary<string, string>> sections;

        public IniParser(string iniContent)
        {
            sections = new Dictionary<string, Dictionary<string, string>>();
            Parse(iniContent);
        }

        private void Parse(string iniContent)
        {
            using (var reader = new StringReader(iniContent))
            {
                string currentSection = null;

                while (true)
                {
                    var line = reader.ReadLine();
                    if (line == null)
                        break;

                    line = line.Trim();

                    if (line.StartsWith("[") && line.EndsWith("]"))
                    {
                        currentSection = line.Substring(1, line.Length - 2);
                        sections[currentSection] = new Dictionary<string, string>();
                    }
                    else if (!string.IsNullOrEmpty(currentSection) && line.Contains("="))
                    {
                        var parts = line.Split('=');
                        var key = parts[0].Trim();
                        var value = parts[1].Trim();
                        sections[currentSection][key] = value;
                    }
                }
            }
        }

        public string GetValue(string section, string key)
        {
            if (sections.TryGetValue(section, out var sectionData))
            {
                if (sectionData.TryGetValue(key, out var value))
                    return value;
            }

            return null;
        }
    }
}
