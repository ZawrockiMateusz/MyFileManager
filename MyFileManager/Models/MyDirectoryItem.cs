using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFileManager.Models
{
    /// <summary>
    /// Klasa reprezentująca Plik lub Katalog
    /// </summary>
    public class MyDirectoryItem
    {
        public MyDirectoryItem(){}

        private string path;
        private string name;
        private DirectorySystemItemType type;
        private DateTime creationDate;
        private string size;
        private string gridViewName;

        public string Path
        {
            get { return path; }
            set { path = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string FullName
        {
            get
            {
                if (!String.IsNullOrEmpty(Path))
                    return System.IO.Path.Combine(Path, Name);
                else
                    return Name;
            }
        }
        public DirectorySystemItemType Type
        {
            get { return type; }
            set { type = value; }
        }
        public DateTime CreationDate
        {
            get { return creationDate; }
            set { creationDate = value; }
        }
        public string Size
        {
            get { return size; }
            set { size = value; }
        }
        public string GridViewName
        {
            get { return gridViewName; }
            set { gridViewName = value; }
        }

    }

    /// <summary>
    /// Enum określający czy dany element jest Plikiem czy Katalogiem
    /// </summary>
    public enum DirectorySystemItemType
    {
        Null = 0,
        Directory = 1,
        File = 2
    }
}
