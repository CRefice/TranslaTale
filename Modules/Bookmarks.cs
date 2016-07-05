using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace TranslaTale.Bookmarks
{
    class Bookmark
    {
        public int Line { get; set; }
        public string Tag { get; set; }

        public Bookmark(int line, string tag)
        {
            Line = line;
            Tag = tag;
        }

        public static Bookmark[] GetList()
        {
            var returnList = new List<Bookmark>();
            var doc = XDocument.Parse(Properties.Settings.Default.Bookmarks);
            var root = doc.Descendants("Bookmarks").FirstOrDefault();

            foreach (XElement element in root.Elements("Bookmark"))
            {
                var line = element.Descendants("Line").FirstOrDefault().Value;
                var tag = element.Descendants("Tag").FirstOrDefault().Value;
                returnList.Add(new Bookmark(int.Parse(line), tag));
            }

            returnList = returnList.OrderBy(x => x.Line).ToList();
            return returnList.ToArray();
        }

        public void Add()
        {
            var doc = XDocument.Parse(Properties.Settings.Default.Bookmarks);
            var root = doc.Descendants("Bookmarks").FirstOrDefault();

            if (root.Descendants("Bookmark").FirstOrDefault() == null
                || root.Descendants("Bookmark").Descendants("Line").Any(x => x.Value == Line.ToString()) == false)
            {
                root.Add(new XElement("Bookmark",
                    new XElement("Line", Line),
                    new XElement("Tag", Tag)));
                Properties.Settings.Default.Bookmarks = doc.ToString();
                Properties.Settings.Default.Save();
            }
        }

        public static void Remove(int index)
        {
            var doc = XDocument.Parse(Properties.Settings.Default.Bookmarks);
            var root = doc.Descendants("Bookmarks").FirstOrDefault().Descendants("Bookmark");

            root.ElementAt(index).Remove();

            Properties.Settings.Default.Bookmarks = doc.ToString();
            Properties.Settings.Default.Save();
        }

        new public string[] ToString()
        {
            return new string[] { Line.ToString(), Tag };
        }
    }
}
