using Microsoft.Win32;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using Ookii.Dialogs.Wpf;

namespace packer.pages
{
    /// <summary>
    /// Логика взаимодействия для FileOpen.xaml
    /// </summary>
    public partial class FileOpen : Page
    {

        public string folder;
        public string OutputArchive;

        public FileOpen()
        {
            InitializeComponent();
        }
        

        private void ShowFolderBrowserDialog(object sender, RoutedEventArgs e)
        {
            VistaFolderBrowserDialog dialog = new VistaFolderBrowserDialog();
            VistaSaveFileDialog saveFileDialog = new VistaSaveFileDialog();
            dialog.Description = "Please select a folder.";
            dialog.UseDescriptionForTitle = true;
            if ((bool)dialog.ShowDialog() == true)
            {
                if((bool)saveFileDialog.ShowDialog() == true)
                {
                    OutputArchive = saveFileDialog.FileName;
                }
            
                folder = dialog.SelectedPath;
                ZipFile.CreateFromDirectory(folder, OutputArchive);
            }
        }
        
    }
}
