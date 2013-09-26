namespace CollectionManager
{
    partial class ProcessBarForm
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
            this.prcBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // prcBar
            // 
            this.prcBar.Location = new System.Drawing.Point(17, 23);
            this.prcBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prcBar.Name = "prcBar";
            this.prcBar.Size = new System.Drawing.Size(522, 31);
            this.prcBar.TabIndex = 0;
            // 
            // ProcessBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 69);
            this.Controls.Add(this.prcBar);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProcessBarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProcessBar_Form";
            this.Shown += new System.EventHandler(this.ProcessBarForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar prcBar;
    }
}