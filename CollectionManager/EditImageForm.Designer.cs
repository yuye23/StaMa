namespace CollectionManager
{
    partial class EditImageForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLRotate = new System.Windows.Forms.Button();
            this.btnRRotate = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnCut = new System.Windows.Forms.Button();
            this.btnL90 = new System.Windows.Forms.Button();
            this.btnR90 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnEndView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(579, 16);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLRotate
            // 
            this.btnLRotate.Location = new System.Drawing.Point(118, 16);
            this.btnLRotate.Name = "btnLRotate";
            this.btnLRotate.Size = new System.Drawing.Size(100, 30);
            this.btnLRotate.TabIndex = 2;
            this.btnLRotate.Text = "左转微调";
            this.btnLRotate.UseVisualStyleBackColor = true;
            this.btnLRotate.Click += new System.EventHandler(this.btnLRotate_Click);
            // 
            // btnRRotate
            // 
            this.btnRRotate.Location = new System.Drawing.Point(436, 16);
            this.btnRRotate.Name = "btnRRotate";
            this.btnRRotate.Size = new System.Drawing.Size(100, 30);
            this.btnRRotate.TabIndex = 3;
            this.btnRRotate.Text = "右转微调";
            this.btnRRotate.UseVisualStyleBackColor = true;
            this.btnRRotate.Click += new System.EventHandler(this.btnRRotate_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Location = new System.Drawing.Point(686, 16);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(100, 30);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "退出编辑";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnCut
            // 
            this.btnCut.Location = new System.Drawing.Point(12, 16);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(100, 30);
            this.btnCut.TabIndex = 5;
            this.btnCut.Text = "剪裁";
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnL90
            // 
            this.btnL90.Location = new System.Drawing.Point(224, 16);
            this.btnL90.Name = "btnL90";
            this.btnL90.Size = new System.Drawing.Size(100, 30);
            this.btnL90.TabIndex = 6;
            this.btnL90.Text = "左转90度";
            this.btnL90.UseVisualStyleBackColor = true;
            this.btnL90.Click += new System.EventHandler(this.btnL90_Click);
            // 
            // btnR90
            // 
            this.btnR90.Location = new System.Drawing.Point(330, 16);
            this.btnR90.Name = "btnR90";
            this.btnR90.Size = new System.Drawing.Size(100, 30);
            this.btnR90.TabIndex = 7;
            this.btnR90.Text = "右转90度";
            this.btnR90.UseVisualStyleBackColor = true;
            this.btnR90.Click += new System.EventHandler(this.btnR90_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnEndView);
            this.splitContainer1.Panel2.Controls.Add(this.btnR90);
            this.splitContainer1.Panel2.Controls.Add(this.btnL90);
            this.splitContainer1.Panel2.Controls.Add(this.btnCut);
            this.splitContainer1.Panel2.Controls.Add(this.btnQuit);
            this.splitContainer1.Panel2.Controls.Add(this.btnRRotate);
            this.splitContainer1.Panel2.Controls.Add(this.btnLRotate);
            this.splitContainer1.Panel2.Controls.Add(this.btnSave);
            this.splitContainer1.Size = new System.Drawing.Size(800, 666);
            this.splitContainer1.SplitterDistance = 600;
            this.splitContainer1.TabIndex = 8;
            // 
            // btnEndView
            // 
            this.btnEndView.Location = new System.Drawing.Point(631, 16);
            this.btnEndView.Name = "btnEndView";
            this.btnEndView.Size = new System.Drawing.Size(100, 30);
            this.btnEndView.TabIndex = 9;
            this.btnEndView.Text = "退出";
            this.btnEndView.UseVisualStyleBackColor = true;
            this.btnEndView.Visible = false;
            this.btnEndView.Click += new System.EventHandler(this.btnEndView_Click);
            // 
            // EditImageForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(800, 666);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditImageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "编辑图片";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditImageForm_FormClosing);
            this.Load += new System.EventHandler(this.EditImageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLRotate;
        private System.Windows.Forms.Button btnRRotate;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Button btnL90;
        private System.Windows.Forms.Button btnR90;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnEndView;
    }
}