namespace CollectionManager
{
    partial class AddCoinForm
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
            this.cbCClass = new System.Windows.Forms.ComboBox();
            this.cbCType = new System.Windows.Forms.ComboBox();
            this.cbCUnit = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCPrice = new System.Windows.Forms.TextBox();
            this.tbCPubDate = new System.Windows.Forms.TextBox();
            this.tbCPublisher = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtCMemo = new System.Windows.Forms.RichTextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnAddImg = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.collectionDataSet = new CollectionManager.DATA.Database.CollectionDataSet();
            this.coinunitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coinunitTableAdapter = new CollectionManager.DATA.Database.CollectionDataSetTableAdapters.coinunitTableAdapter();
            this.cointypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cointypeTableAdapter = new CollectionManager.DATA.Database.CollectionDataSetTableAdapters.cointypeTableAdapter();
            this.coinclassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coinclassTableAdapter = new CollectionManager.DATA.Database.CollectionDataSetTableAdapters.coinclassTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinunitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cointypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinclassBindingSource)).BeginInit();
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
            this.splitContainer1.TabIndex = 1;
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
            this.splitContainer4.Panel1.Controls.Add(this.cbCClass);
            this.splitContainer4.Panel1.Controls.Add(this.cbCType);
            this.splitContainer4.Panel1.Controls.Add(this.cbCUnit);
            this.splitContainer4.Panel1.Controls.Add(this.label9);
            this.splitContainer4.Panel1.Controls.Add(this.label8);
            this.splitContainer4.Panel1.Controls.Add(this.tbCPrice);
            this.splitContainer4.Panel1.Controls.Add(this.tbCPubDate);
            this.splitContainer4.Panel1.Controls.Add(this.tbCPublisher);
            this.splitContainer4.Panel1.Controls.Add(this.label7);
            this.splitContainer4.Panel1.Controls.Add(this.label6);
            this.splitContainer4.Panel1.Controls.Add(this.label5);
            this.splitContainer4.Panel1.Controls.Add(this.label4);
            this.splitContainer4.Panel1.Controls.Add(this.label3);
            this.splitContainer4.Panel1.Controls.Add(this.label2);
            this.splitContainer4.Panel1.Controls.Add(this.tbCName);
            this.splitContainer4.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.rtCMemo);
            this.splitContainer4.Size = new System.Drawing.Size(338, 611);
            this.splitContainer4.SplitterDistance = 228;
            this.splitContainer4.SplitterWidth = 5;
            this.splitContainer4.TabIndex = 16;
            // 
            // cbCClass
            // 
            this.cbCClass.DataSource = this.coinclassBindingSource;
            this.cbCClass.DisplayMember = "classname";
            this.cbCClass.FormattingEnabled = true;
            this.cbCClass.Location = new System.Drawing.Point(89, 194);
            this.cbCClass.Margin = new System.Windows.Forms.Padding(4);
            this.cbCClass.Name = "cbCClass";
            this.cbCClass.Size = new System.Drawing.Size(120, 24);
            this.cbCClass.TabIndex = 19;
            this.cbCClass.ValueMember = "id";
            // 
            // cbCType
            // 
            this.cbCType.DataSource = this.cointypeBindingSource;
            this.cbCType.DisplayMember = "typename";
            this.cbCType.FormattingEnabled = true;
            this.cbCType.Location = new System.Drawing.Point(89, 165);
            this.cbCType.Margin = new System.Windows.Forms.Padding(4);
            this.cbCType.Name = "cbCType";
            this.cbCType.Size = new System.Drawing.Size(120, 24);
            this.cbCType.TabIndex = 18;
            this.cbCType.ValueMember = "id";
            // 
            // cbCUnit
            // 
            this.cbCUnit.DataSource = this.coinunitBindingSource;
            this.cbCUnit.DisplayMember = "unitname";
            this.cbCUnit.FormattingEnabled = true;
            this.cbCUnit.Location = new System.Drawing.Point(89, 103);
            this.cbCUnit.Margin = new System.Windows.Forms.Padding(4);
            this.cbCUnit.Name = "cbCUnit";
            this.cbCUnit.Size = new System.Drawing.Size(120, 24);
            this.cbCUnit.TabIndex = 17;
            this.cbCUnit.ValueMember = "id";
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
            // tbCPrice
            // 
            this.tbCPrice.Location = new System.Drawing.Point(89, 133);
            this.tbCPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbCPrice.Name = "tbCPrice";
            this.tbCPrice.Size = new System.Drawing.Size(120, 26);
            this.tbCPrice.TabIndex = 11;
            // 
            // tbCPubDate
            // 
            this.tbCPubDate.Location = new System.Drawing.Point(89, 72);
            this.tbCPubDate.Margin = new System.Windows.Forms.Padding(4);
            this.tbCPubDate.Name = "tbCPubDate";
            this.tbCPubDate.Size = new System.Drawing.Size(120, 26);
            this.tbCPubDate.TabIndex = 9;
            this.tbCPubDate.Validating += new System.ComponentModel.CancelEventHandler(this.tbCPubDate_Validating);
            // 
            // tbCPublisher
            // 
            this.tbCPublisher.Location = new System.Drawing.Point(89, 41);
            this.tbCPublisher.Margin = new System.Windows.Forms.Padding(4);
            this.tbCPublisher.Name = "tbCPublisher";
            this.tbCPublisher.Size = new System.Drawing.Size(240, 26);
            this.tbCPublisher.TabIndex = 8;
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
            this.label2.Text = "发行单位：";
            // 
            // tbCName
            // 
            this.tbCName.Location = new System.Drawing.Point(89, 9);
            this.tbCName.Margin = new System.Windows.Forms.Padding(4);
            this.tbCName.Name = "tbCName";
            this.tbCName.Size = new System.Drawing.Size(240, 26);
            this.tbCName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "名    称：";
            // 
            // rtCMemo
            // 
            this.rtCMemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtCMemo.Location = new System.Drawing.Point(0, 0);
            this.rtCMemo.Margin = new System.Windows.Forms.Padding(4);
            this.rtCMemo.Name = "rtCMemo";
            this.rtCMemo.Size = new System.Drawing.Size(338, 378);
            this.rtCMemo.TabIndex = 0;
            this.rtCMemo.Text = "";
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
            // collectionDataSet
            // 
            this.collectionDataSet.DataSetName = "CollectionDataSet";
            this.collectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coinunitBindingSource
            // 
            this.coinunitBindingSource.DataMember = "coinunit";
            this.coinunitBindingSource.DataSource = this.collectionDataSet;
            // 
            // coinunitTableAdapter
            // 
            this.coinunitTableAdapter.ClearBeforeFill = true;
            // 
            // cointypeBindingSource
            // 
            this.cointypeBindingSource.DataMember = "cointype";
            this.cointypeBindingSource.DataSource = this.collectionDataSet;
            // 
            // cointypeTableAdapter
            // 
            this.cointypeTableAdapter.ClearBeforeFill = true;
            // 
            // coinclassBindingSource
            // 
            this.coinclassBindingSource.DataMember = "coinclass";
            this.coinclassBindingSource.DataSource = this.collectionDataSet;
            // 
            // coinclassTableAdapter
            // 
            this.coinclassTableAdapter.ClearBeforeFill = true;
            // 
            // AddCoinForm
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(784, 662);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCoinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新增钱币";
            this.Load += new System.EventHandler(this.AddCoinForm_Load);
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
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinunitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cointypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinclassBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.ComboBox cbCClass;
        private System.Windows.Forms.ComboBox cbCType;
        private System.Windows.Forms.ComboBox cbCUnit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCPrice;
        private System.Windows.Forms.TextBox tbCPubDate;
        private System.Windows.Forms.TextBox tbCPublisher;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtCMemo;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnAddImg;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private DATA.Database.CollectionDataSet collectionDataSet;
        private System.Windows.Forms.BindingSource coinunitBindingSource;
        private DATA.Database.CollectionDataSetTableAdapters.coinunitTableAdapter coinunitTableAdapter;
        private System.Windows.Forms.BindingSource cointypeBindingSource;
        private DATA.Database.CollectionDataSetTableAdapters.cointypeTableAdapter cointypeTableAdapter;
        private System.Windows.Forms.BindingSource coinclassBindingSource;
        private DATA.Database.CollectionDataSetTableAdapters.coinclassTableAdapter coinclassTableAdapter;


    }
}