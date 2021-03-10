
namespace ChangeFormColorApp
{
    partial class ColorChangedForm
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
            this.redBtn = new System.Windows.Forms.Button();
            this.blueBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // redBtn
            // 
            this.redBtn.Location = new System.Drawing.Point(204, 168);
            this.redBtn.Name = "redBtn";
            this.redBtn.Size = new System.Drawing.Size(124, 60);
            this.redBtn.TabIndex = 0;
            this.redBtn.Text = "Red";
            this.redBtn.UseVisualStyleBackColor = true;
            this.redBtn.Click += new System.EventHandler(this.redBtn_Click);
            // 
            // blueBtn
            // 
            this.blueBtn.Location = new System.Drawing.Point(412, 168);
            this.blueBtn.Name = "blueBtn";
            this.blueBtn.Size = new System.Drawing.Size(124, 60);
            this.blueBtn.TabIndex = 0;
            this.blueBtn.Text = "Blue";
            this.blueBtn.UseVisualStyleBackColor = true;
            this.blueBtn.Click += new System.EventHandler(this.blueBtn_Click);
            // 
            // ColorChangedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.blueBtn);
            this.Controls.Add(this.redBtn);
            this.Name = "ColorChangedForm";
            this.Text = "ColorChangedForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button redBtn;
        private System.Windows.Forms.Button blueBtn;
    }
}