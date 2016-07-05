using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

using TranslaTale.Settings;

namespace TranslaTale.Text
{
    public class Lines
    {
        public static Line[] LineArray;

        public static Line Get(int index)
        {
            return LineArray[index];
        }

        public static int Count
        {
            get
            {
                return LineArray.Count();
            }
        }

        public static void Open(string cleanScriptPath, string transScriptPath)
        {
                var CleanScriptLines = File.ReadAllLines(cleanScriptPath);
                var TransScriptLines = File.ReadAllLines(transScriptPath);

                int CleanLineNum = CleanScriptLines.Count();
                int TransLineNum = TransScriptLines.Count();

                if (CleanLineNum != TransLineNum) throw new DifferentFileSizeException("The two files must be of equal size!");
                if (CleanLineNum < 1 || TransLineNum < 1) throw new EmptyFileException("One or more files are empty!");

                LineArray = new Line[CleanLineNum];

                for (int i = 0; i < CleanLineNum; i++)
                    LineArray[i] = new Line(i, CleanScriptLines[i], TransScriptLines[i]);


                RecentFileSettings.SaveRecentBaseFile(cleanScriptPath);
        }

        public static void Save(string path)
        {
            using (var Writer = new StreamWriter(path, false))
            {
                foreach(var line in LineArray)
                {
                    Writer.WriteLine(line.TranslatedString);
                }
            }
        }
    }

    public enum SearchMode { Base, Translation, Both };

    public class Line
    {
        public int Number { get; set; }
        public string BaseString { get; set; }
        public string TranslatedString { get; set; }

        public Line(int number, string baseString, string translatedString)
        {
            Number = number;
            BaseString = baseString;
            TranslatedString = translatedString;
        }

        public ListViewItem ToListViewItem(bool colored)
        {
            var Item = new ListViewItem(new[] { Number.ToString(), BaseString, TranslatedString });
            if (colored)
                Item.BackColor = IsEdited() ? Color.LightGreen : Color.LightSalmon;
            return Item;
        }

        public bool IsEdited()
        {
            return BaseString != TranslatedString;
        }

        public bool Contains(string searchTerm, SearchMode searchMode = SearchMode.Both,
                             RegexOptions regexOptions = RegexOptions.None, bool escapeRegex = true)
        {
            if (escapeRegex) searchTerm = Regex.Escape(searchTerm);
            switch (searchMode)
            {
                case SearchMode.Base:
                    return Regex.IsMatch(BaseString, searchTerm, regexOptions);

                case SearchMode.Translation:
                    return Regex.IsMatch(TranslatedString, searchTerm, regexOptions);

                default:
                    return Regex.IsMatch(BaseString, searchTerm, regexOptions)
                        || Regex.IsMatch(TranslatedString, searchTerm, regexOptions);
            }
        }
    }

    public class DifferentFileSizeException : Exception
    {
        public DifferentFileSizeException() : base() { }
        public DifferentFileSizeException(string message) : base(message) { }
        public DifferentFileSizeException(string message, Exception inner) : base(message, inner) { }
    }
    public class EmptyFileException : Exception
    {
        public EmptyFileException() : base() { }
        public EmptyFileException(string message) : base(message) { }
        public EmptyFileException(string message, Exception inner) : base(message, inner) { }
    }
}
