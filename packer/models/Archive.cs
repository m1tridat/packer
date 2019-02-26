using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace packer
{
    class Archive
    {

        public string defaultName = "pucker.zip";
        public string Name;

        public List<string> files;
        public List<string> folders;

        public string defaulOutputPath = Environment.SpecialFolder.Desktop.ToString();


        public Archive()
        {
            this.Name = defaultName;
        }

        public Archive (string name)
        {
            this.Name = name;
        }


        public void addFileToArchive(string file)
        {
            this.files.Add(file);
        }

        public void addFolderToArchive(string folder)
        {
            this.folders.Add(folder);
        }



    }
}
