using Lab1_threadsAndEvents;
using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace BackgroundWorkerSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void startAsyncButton_Click(object sender, EventArgs e)
        { 
            backgroundWorker1.RunWorkerAsync();
        }

        private void cancelAsyncButton_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                backgroundWorker1.CancelAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            int n = Int32.Parse(inputLabel.Text);
            int tmp;
            if ((n - 1) % 2 == 0)
                tmp = n - 2;
            else
                tmp = n - 1;
            for (int i = tmp; i >= 2; i -= 2)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                if (Prim.IsPrim1(i))
                {
                    worker.ReportProgress(i);
                    break;
                }
                    
                Thread.Sleep(200);
                worker.ReportProgress(i);
            }

        }
      

    

        private void backgroundWorker1_ProgressChanged_1(object sender, ProgressChangedEventArgs e)
        {
            resultLabel.Text = (e.ProgressPercentage.ToString());
        }

        private void backgroundWorker1_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                resultLabel.Text = "Canceled!";
            }
            else if (e.Error != null)
            {
                resultLabel.Text = "Error: " + e.Error.Message;
            }
            else
            {
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            int n = Int32.Parse(inputLabel.Text);


            for (int i = n - 1; i >= 1; i--)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }

                Thread.Sleep(100);
                bool prim = true;
                for (int j = i / 2; j > 1; j--)
                    if (i % j == 0)
                        prim = false;

                if (prim)
                {
                    worker.ReportProgress(i);
                    break;
                }

                Thread.Sleep(200);
                worker.ReportProgress(i);
            }
            

            

        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            resultLabel2.Text = (e.ProgressPercentage.ToString());
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                resultLabel.Text = "Canceled!";
            }
            else if (e.Error != null)
            {
                resultLabel.Text = "Error: " + e.Error.Message;
            }
            else
            {

            }
        }

        private void startAsyncButton2_Click(object sender, EventArgs e)
        {
            backgroundWorker2.RunWorkerAsync();
        }

        private void CancelAsyncButton2_Click(object sender, EventArgs e)
        {
            if (backgroundWorker2.WorkerSupportsCancellation == true)
            {
                backgroundWorker2.CancelAsync();
            }
        }

        private void inputLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
