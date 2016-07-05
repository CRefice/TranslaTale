using System.Linq;
using System.Xml.Linq;

using TranslaTale.Projects;

namespace TranslaTale.Settings
{
    public static class RecentProjects
    {
        public static int Count
        {
            get
            {
                var doc = XDocument.Parse(Properties.Settings.Default.RecentProjects);
                var root = doc.Descendants("RecentProjects").FirstOrDefault();
                return root.Elements("Project").Count();
            }
        }

        public static void Add(string path)
        {
            var doc = XDocument.Parse(Properties.Settings.Default.RecentProjects);
            var root = doc.Descendants("RecentProjects").FirstOrDefault();

            if (root.Elements("Project").FirstOrDefault() == null
                || root.Elements("Project").Any(x => x.Value == path) == false)
            {
                root.Add(new XElement("Project", path));
                Properties.Settings.Default.RecentProjects = doc.ToString();
                Properties.Settings.Default.Save();
            }
        }
        public static void Add(Project project)
        {
            Add(project.Path);
        }

        public static void Remove(int index)
        {
            var doc = XDocument.Parse(Properties.Settings.Default.RecentProjects);
            var root = doc.Descendants("RecentProjects").FirstOrDefault().Descendants("Project");

            root.ElementAt(index).Remove();

            Properties.Settings.Default.RecentProjects = doc.ToString();
            Properties.Settings.Default.Save();
        }

        public static Project Get(int index)
        {
                var doc = XDocument.Parse(Properties.Settings.Default.RecentProjects);
                var root = doc.Descendants("RecentProjects").FirstOrDefault();

                var element = root.Elements("Project").ElementAt(index);

                return Project.Read(element.Value);
        }
    }

    public static class RecentFileSettings
    {
        public static void SaveRecentBaseFile(string filePath)
        {
            Properties.Settings.Default.RecentBaseFile = filePath;
            Properties.Settings.Default.Save();
        }
        public static string GetRecentBaseFile()
        {
            return Properties.Settings.Default.RecentBaseFile;
        }
    }

    public static class SearchSettings
    {
        public static string LastSearchTerm
        {
            get
            {
                return Properties.Settings.Default.LastSearchTerm;
            }
            set
            {
                Properties.Settings.Default.LastSearchTerm = value;
                Properties.Settings.Default.Save();
            }
        }
        public static string LastReplaceTerm
        {
            get
            {
                return Properties.Settings.Default.LastReplaceTerm;
            }
            set
            {
                Properties.Settings.Default.LastReplaceTerm = value;
                Properties.Settings.Default.Save();
            }
        }

        public static bool CaseSensitive
        {
            get
            {
                return Properties.Settings.Default.CaseSensitiveSearch;
            }
            set
            {
                Properties.Settings.Default.CaseSensitiveSearch = value;
                Properties.Settings.Default.Save();
            }
        }
        public static bool RegexSearch
        {
            get
            {
                return Properties.Settings.Default.RegexSearch;
            }
            set
            {
                Properties.Settings.Default.RegexSearch = value;
                Properties.Settings.Default.Save();
            }
        }
    }
}