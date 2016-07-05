using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace TranslaTale.Projects
{
    public class Project
    {
        public static Project CurrentProject { get; set; }
        public string Path { get; set; } = "";

        public string Name { get; set; } = "";
        public string CleanFilePath { get; set; } = "";
        public string TransFilePath { get; set; } = "";

        public string ImageFilesPath { get; set; } = "";
        public string BaseGamePath { get; set; } = "";
        public string CompilePath { get; set; } = "";

        public Project(string name, string cleanFilePath, string transFilePath)
        {
            Name = name;
            CleanFilePath = cleanFilePath;
            TransFilePath = transFilePath;
        }
        public Project(string name)
        {
            Name = name;
        }

        public static Project Read(string filePath)
        {
            try
            {
                var doc = XDocument.Load(filePath);
                string name = doc.Descendants("Name").FirstOrDefault().Value;
                string cleanFile = doc.Descendants("CleanScriptPath").FirstOrDefault().Value;
                string transFile = doc.Descendants("TranslationPath").FirstOrDefault().Value;

                return new Project(name, cleanFile, transFile)
                {
                    Path = filePath,
                    ImageFilesPath = doc.Descendants("ImagesPath").FirstOrDefault().Value,
                    BaseGamePath = doc.Descendants("CleanGamePath").FirstOrDefault().Value,
                    CompilePath = doc.Descendants("TranslatedGamePath").FirstOrDefault().Value
                };
            }
            catch
            {
                return null;
            }
        }

        public void Write(string filePath)
        {
            Path = filePath;

            Write();
        }
        public void Write()
        {
            XmlTextWriter TextWriter = new XmlTextWriter(Path, Encoding.UTF8);
        TextWriter.Formatting = Formatting.Indented;

            TextWriter.WriteStartDocument(true);
            TextWriter.WriteStartElement("Settings");
            TextWriter.WriteElementString("Name", Name);
            TextWriter.WriteElementString("CleanScriptPath", CleanFilePath);
            TextWriter.WriteElementString("TranslationPath", TransFilePath);
            TextWriter.WriteElementString("ImagesPath", ImageFilesPath);
            TextWriter.WriteElementString("CleanGamePath", BaseGamePath);
            TextWriter.WriteElementString("TranslatedGamePath", CompilePath);
            TextWriter.WriteEndElement();
            TextWriter.WriteEndDocument();
            TextWriter.Close();
        }

}
}
