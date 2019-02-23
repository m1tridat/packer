using System;
using System.Windows;
using System.Windows.Controls;
using System.ComponentModel;
using System.Threading;


namespace packer.pages
{
    /// <summary>
    /// Логика взаимодействия для LoadingPage.xaml
    /// </summary>
    public partial class LoadingPage : Page
    {

        private BackgroundWorker WorkerThread = new BackgroundWorker();

        public LoadingPage()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
        }
        
        
        private void InitializeBackgroundWorker()
        {
            try
            {
                WorkerThread.WorkerReportsProgress = true;
                WorkerThread.DoWork += new DoWorkEventHandler(WorkerThread_DoWork);
                WorkerThread.ProgressChanged += new ProgressChangedEventHandler(WorkerThread_ProgressChanged);
                WorkerThread.RunWorkerCompleted += new RunWorkerCompletedEventHandler(WorkerThread_RunWorkerCompleted);
                WorkerThread.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        void WorkerThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                PBar.Value = PBar.Maximum;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void WorkerThread_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                PBar.Value = e.ProgressPercentage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void WorkerThread_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(1000);
                    WorkerThread.ReportProgress(i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
