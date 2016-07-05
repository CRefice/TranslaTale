using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranslaTale
{
    public abstract partial class LoadingDialog : Form
    {
        protected BackgroundWorker LoadWorker = new BackgroundWorker();

        public LoadingDialog(string loadMessage)
        {
            InitializeComponent();

            this.Text = loadMessage;
            LoadMessageLabel.Text = loadMessage;
        }
        protected void StartAsync()
        {
            LoadWorker.WorkerReportsProgress = true;

            LoadWorker.DoWork += LoadWorker_DoWork;
            LoadWorker.ProgressChanged += LoadWorker_ProgressChanged;
            LoadWorker.RunWorkerCompleted += LoadWorker_Completed;

            LoadWorker.RunWorkerAsync();
        }

        protected abstract void LoadWorker_DoWork(object sender, DoWorkEventArgs e);

        protected virtual void LoadWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            LoadingBar.Value = e.ProgressPercentage;
            LoadMessageLabel.Text = e.UserState.ToString() ?? LoadMessageLabel.Text;
        }
        protected virtual void LoadWorker_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            Close();
        }

    }
}
