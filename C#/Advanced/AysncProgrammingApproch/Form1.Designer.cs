
namespace AysncProgrammingApproch
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
            this.btnHello = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.btnThread = new System.Windows.Forms.Button();
            this.btnTask = new System.Windows.Forms.Button();
            this.btnAsync = new System.Windows.Forms.Button();
            this.btnAsyncResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(53, 66);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(112, 45);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(247, 66);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(112, 45);
            this.btnSync.TabIndex = 1;
            this.btnSync.Text = "Sync";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // btnThread
            // 
            this.btnThread.Location = new System.Drawing.Point(444, 66);
            this.btnThread.Name = "btnThread";
            this.btnThread.Size = new System.Drawing.Size(112, 45);
            this.btnThread.TabIndex = 2;
            this.btnThread.Text = "Thread";
            this.btnThread.UseVisualStyleBackColor = true;
            this.btnThread.Click += new System.EventHandler(this.btnThread_Click);
            // 
            // btnTask
            // 
            this.btnTask.Location = new System.Drawing.Point(175, 200);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(112, 45);
            this.btnTask.TabIndex = 3;
            this.btnTask.Text = "Task";
            this.btnTask.UseVisualStyleBackColor = true;
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // btnAsync
            // 
            this.btnAsync.Location = new System.Drawing.Point(378, 200);
            this.btnAsync.Name = "btnAsync";
            this.btnAsync.Size = new System.Drawing.Size(112, 45);
            this.btnAsync.TabIndex = 4;
            this.btnAsync.Text = "Async";
            this.btnAsync.UseVisualStyleBackColor = true;
            this.btnAsync.Click += new System.EventHandler(this.btnAsync_Click);
            // 
            // btnAsyncResult
            // 
            this.btnAsyncResult.Location = new System.Drawing.Point(571, 200);
            this.btnAsyncResult.Name = "btnAsyncResult";
            this.btnAsyncResult.Size = new System.Drawing.Size(112, 45);
            this.btnAsyncResult.TabIndex = 5;
            this.btnAsyncResult.Text = "Async Result";
            this.btnAsyncResult.UseVisualStyleBackColor = true;
            this.btnAsyncResult.Click += new System.EventHandler(this.btnAsyncResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAsyncResult);
            this.Controls.Add(this.btnAsync);
            this.Controls.Add(this.btnTask);
            this.Controls.Add(this.btnThread);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.btnHello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnThread;
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.Button btnAsync;
        private System.Windows.Forms.Button btnAsyncResult;
    }
}

