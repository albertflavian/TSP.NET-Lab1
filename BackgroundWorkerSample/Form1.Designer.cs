namespace BackgroundWorkerSample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultLabel = new System.Windows.Forms.Label();
            this.startAsyncButton = new System.Windows.Forms.Button();
            this.cancelAsyncButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CancelAsyncButton2 = new System.Windows.Forms.Button();
            this.startAsyncButton2 = new System.Windows.Forms.Button();
            this.resultLabel2 = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.inputLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(31, 90);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(61, 17);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Text = "progres:";
            this.resultLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // startAsyncButton
            // 
            this.startAsyncButton.BackColor = System.Drawing.Color.LawnGreen;
            this.startAsyncButton.Location = new System.Drawing.Point(34, 144);
            this.startAsyncButton.Name = "startAsyncButton";
            this.startAsyncButton.Size = new System.Drawing.Size(75, 37);
            this.startAsyncButton.TabIndex = 1;
            this.startAsyncButton.Text = "Start";
            this.startAsyncButton.UseVisualStyleBackColor = false;
            this.startAsyncButton.Click += new System.EventHandler(this.startAsyncButton_Click);
            // 
            // cancelAsyncButton
            // 
            this.cancelAsyncButton.BackColor = System.Drawing.Color.Red;
            this.cancelAsyncButton.Location = new System.Drawing.Point(37, 187);
            this.cancelAsyncButton.Name = "cancelAsyncButton";
            this.cancelAsyncButton.Size = new System.Drawing.Size(75, 37);
            this.cancelAsyncButton.TabIndex = 2;
            this.cancelAsyncButton.Text = "Stop";
            this.cancelAsyncButton.UseVisualStyleBackColor = false;
            this.cancelAsyncButton.Click += new System.EventHandler(this.cancelAsyncButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged_1);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted_1);
            // 
            // CancelAsyncButton2
            // 
            this.CancelAsyncButton2.BackColor = System.Drawing.Color.Red;
            this.CancelAsyncButton2.Location = new System.Drawing.Point(186, 187);
            this.CancelAsyncButton2.Name = "CancelAsyncButton2";
            this.CancelAsyncButton2.Size = new System.Drawing.Size(75, 37);
            this.CancelAsyncButton2.TabIndex = 6;
            this.CancelAsyncButton2.Text = "Stop";
            this.CancelAsyncButton2.UseVisualStyleBackColor = false;
            this.CancelAsyncButton2.Click += new System.EventHandler(this.CancelAsyncButton2_Click);
            // 
            // startAsyncButton2
            // 
            this.startAsyncButton2.BackColor = System.Drawing.Color.LawnGreen;
            this.startAsyncButton2.Location = new System.Drawing.Point(183, 144);
            this.startAsyncButton2.Name = "startAsyncButton2";
            this.startAsyncButton2.Size = new System.Drawing.Size(75, 37);
            this.startAsyncButton2.TabIndex = 5;
            this.startAsyncButton2.Text = "Start";
            this.startAsyncButton2.UseVisualStyleBackColor = false;
            this.startAsyncButton2.Click += new System.EventHandler(this.startAsyncButton2_Click);
            // 
            // resultLabel2
            // 
            this.resultLabel2.AutoSize = true;
            this.resultLabel2.Location = new System.Drawing.Point(180, 90);
            this.resultLabel2.Name = "resultLabel2";
            this.resultLabel2.Size = new System.Drawing.Size(61, 17);
            this.resultLabel2.TabIndex = 4;
            this.resultLabel2.Text = "progres:";
            this.resultLabel2.Click += new System.EventHandler(this.label2_Click);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // inputLabel
            // 
            this.inputLabel.Location = new System.Drawing.Point(12, 12);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(100, 22);
            this.inputLabel.TabIndex = 7;
            this.inputLabel.Text = "10000";
            this.inputLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inputLabel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 317);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.CancelAsyncButton2);
            this.Controls.Add(this.startAsyncButton2);
            this.Controls.Add(this.resultLabel2);
            this.Controls.Add(this.cancelAsyncButton);
            this.Controls.Add(this.startAsyncButton);
            this.Controls.Add(this.resultLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button startAsyncButton;
        private System.Windows.Forms.Button cancelAsyncButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button CancelAsyncButton2;
        private System.Windows.Forms.Button startAsyncButton2;
        private System.Windows.Forms.Label resultLabel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TextBox inputLabel;
    }
}

