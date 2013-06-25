namespace CollectionManager
{
    partial class AddStampForm
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.stampclassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collectionDataSet = new CollectionManager.Database.CollectionDataSet();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.stamptypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.stampunitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSPrice = new System.Windows.Forms.TextBox();
            this.tbSPubDate = new System.Windows.Forms.TextBox();
            this.tbSName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtMemo = new System.Windows.Forms.RichTextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnAddImg = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.stampunitTableAdapter = new CollectionManager.Database.CollectionDataSetTableAdapters.stampunitTableAdapter();
            this.stamptypeTableAdapter = new CollectionManager.Database.CollectionDataSetTableAdapters.stamptypeTableAdapter();
            this.stampclassTableAdapter = new CollectionManager.Database.CollectionDataSetTableAdapters.stampclassTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stampclassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stamptypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stampunitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnCancel);
            this.splitContainer1.Panel2.Controls.Add(this.btnAccept);
            this.splitContainer1.Size = new System.Drawing.Size(784, 662);
            this.splitContainer1.SplitterDistance = 613;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer3.Size = new System.Drawing.Size(784, 613);
            this.splitContainer3.SplitterDistance = 340;
            this.splitContainer3.SplitterWidth = 2;
            this.splitContainer3.TabIndex = 2;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.cbClass);
            this.splitContainer4.Panel1.Controls.Add(this.cbType);
            this.splitContainer4.Panel1.Controls.Add(this.cbUnit);
            this.splitContainer4.Panel1.Controls.Add(this.label9);
            this.splitContainer4.Panel1.Controls.Add(this.label8);
            this.splitContainer4.Panel1.Controls.Add(this.tbSPrice);
            this.splitContainer4.Panel1.Controls.Add(this.tbSPubDate);
            this.splitContainer4.Panel1.Controls.Add(this.tbSName);
            this.splitContainer4.Panel1.Controls.Add(this.label7);
            this.splitContainer4.Panel1.Controls.Add(this.label6);
            this.splitContainer4.Panel1.Controls.Add(this.label5);
            this.splitContainer4.Panel1.Controls.Add(this.label4);
            this.splitContainer4.Panel1.Controls.Add(this.label3);
            this.splitContainer4.Panel1.Controls.Add(this.label2);
            this.splitContainer4.Panel1.Controls.Add(this.tbSCode);
            this.splitContainer4.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.rtMemo);
            this.splitContainer4.Size = new System.Drawing.Size(338, 611);
            this.splitContainer4.SplitterDistance = 228;
            this.splitContainer4.SplitterWidth = 5;
            this.splitContainer4.TabIndex = 16;
            // 
            // cbClass
            // 
            this.cbClass.DataSource = this.stampclassBindingSource;
            this.cbClass.DisplayMember = "classname";
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(89, 194);
            this.cbClass.Margin = new System.Windows.Forms.Padding(4);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(120, 24);
            this.cbClass.TabIndex = 19;
            this.cbClass.ValueMember = "id";
            // 
            // stampclassBindingSource
            // 
            this.stampclassBindingSource.DataMember = "stampclass";
            this.stampclassBindingSource.DataSource = this.collectionDataSet;
            // 
            // collectionDataSet
            // 
            this.collectionDataSet.DataSetName = "CollectionDataSet";
            this.collectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbType
            // 
            this.cbType.DataSource = this.stamptypeBindingSource;
            this.cbType.DisplayMember = "typename";
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(89, 165);
            this.cbType.Margin = new System.Windows.Forms.Padding(4);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(120, 24);
            this.cbType.TabIndex = 18;
            this.cbType.ValueMember = "id";
            // 
            // stamptypeBindingSource
            // 
            this.stamptypeBindingSource.DataMember = "stamptype";
            this.stamptypeBindingSource.DataSource = this.collectionDataSet;
            // 
            // cbUnit
            // 
            this.cbUnit.DataSource = this.stampunitBindingSource;
            this.cbUnit.DisplayMember = "unitname";
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Location = new System.Drawing.Point(89, 103);
            this.cbUnit.Margin = new System.Windows.Forms.Padding(4);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(120, 24);
            this.cbUnit.TabIndex = 17;
            this.cbUnit.ValueMember = "id";
            // 
            // stampunitBindingSource
            // 
            this.stampunitBindingSource.DataMember = "stampunit";
            this.stampunitBindingSource.DataSource = this.collectionDataSet;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(211, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "格式：1970/1/1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 277);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "备    注：";
            // 
            // tbSPrice
            // 
            this.tbSPrice.Location = new System.Drawing.Point(89, 133);
            this.tbSPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbSPrice.Name = "tbSPrice";
            this.tbSPrice.Size = new System.Drawing.Size(120, 26);
            this.tbSPrice.TabIndex = 11;
            // 
            // tbSPubDate
            // 
            this.tbSPubDate.Location = new System.Drawing.Point(89, 72);
            this.tbSPubDate.Margin = new System.Windows.Forms.Padding(4);
            this.tbSPubDate.Name = "tbSPubDate";
            this.tbSPubDate.Size = new System.Drawing.Size(120, 26);
            this.tbSPubDate.TabIndex = 9;
            this.tbSPubDate.Validating += new System.ComponentModel.CancelEventHandler(this.tbSPubDate_Validating);
            // 
            // tbSName
            // 
            this.tbSName.Location = new System.Drawing.Point(89, 41);
            this.tbSName.Margin = new System.Windows.Forms.Padding(4);
            this.tbSName.Name = "tbSName";
            this.tbSName.Size = new System.Drawing.Size(240, 26);
            this.tbSName.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 198);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "类    型：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "自建分类：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "面    值：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "单    位：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "出版日期：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "名    称：";
            // 
            // tbSCode
            // 
            this.tbSCode.Location = new System.Drawing.Point(89, 9);
            this.tbSCode.Margin = new System.Windows.Forms.Padding(4);
            this.tbSCode.Name = "tbSCode";
            this.tbSCode.Size = new System.Drawing.Size(240, 26);
            this.tbSCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "志    号：";
            // 
            // rtMemo
            // 
            this.rtMemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtMemo.Location = new System.Drawing.Point(0, 0);
            this.rtMemo.Margin = new System.Windows.Forms.Padding(4);
            this.rtMemo.Name = "rtMemo";
            this.rtMemo.Size = new System.Drawing.Size(338, 378);
            this.rtMemo.TabIndex = 0;
            this.rtMemo.Text = "";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Controls.Add(this.btnAddImg);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer2.Size = new System.Drawing.Size(440, 611);
            this.splitContainer2.SplitterDistance = 43;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnAddImg
            // 
            this.btnAddImg.Location = new System.Drawing.Point(38, 8);
            this.btnAddImg.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddImg.Name = "btnAddImg";
            this.btnAddImg.Size = new System.Drawing.Size(100, 30);
            this.btnAddImg.TabIndex = 0;
            this.btnAddImg.Text = "插入图片";
            this.btnAddImg.UseVisualStyleBackColor = true;
            this.btnAddImg.Click += new System.EventHandler(this.btnAddImg_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(440, 563);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(460, 7);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(240, 8);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(100, 30);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "确定新增";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // stampunitTableAdapter
            // 
            this.stampunitTableAdapter.ClearBeforeFill = true;
            // 
            // stamptypeTableAdapter
            // 
            this.stamptypeTableAdapter.ClearBeforeFill = true;
            // 
            // stampclassTableAdapter
            // 
            this.stampclassTableAdapter.ClearBeforeFill = true;
            // 
            // AddStampForm
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(784, 662);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStampForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新增邮票";
            this.Load += new System.EventHandler(this.AddStampForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stampclassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stamptypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stampunitBindingSource)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSPrice;
        private System.Windows.Forms.TextBox tbSPubDate;
        private System.Windows.Forms.TextBox tbSName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtMemo;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private Database.CollectionDataSet collectionDataSet;
        private System.Windows.Forms.BindingSource stampunitBindingSource;
        private Database.CollectionDataSetTableAdapters.stampunitTableAdapter stampunitTableAdapter;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.BindingSource stamptypeBindingSource;
        private Database.CollectionDataSetTableAdapters.stamptypeTableAdapter stamptypeTableAdapter;
        private System.Windows.Forms.BindingSource stampclassBindingSource;
        private Database.CollectionDataSetTableAdapters.stampclassTableAdapter stampclassTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnAddImg;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

    }
}