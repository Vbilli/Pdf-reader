
namespace PDF_reader
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
			this.ColumnNum = new System.Windows.Forms.Button();
			this.GenarateH5 = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.PreviewH5 = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.button5 = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ColumnName = new System.Windows.Forms.TextBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// axAcroPDF1
			// 
			this.axAcroPDF1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.axAcroPDF1.Enabled = true;
			this.axAcroPDF1.Location = new System.Drawing.Point(12, 64);
			this.axAcroPDF1.Name = "axAcroPDF1";
			this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
			this.axAcroPDF1.Size = new System.Drawing.Size(668, 457);
			this.axAcroPDF1.TabIndex = 0;
			this.axAcroPDF1.Visible = false;
			// 
			// ColumnNum
			// 
			this.ColumnNum.Location = new System.Drawing.Point(17, 12);
			this.ColumnNum.Name = "ColumnNum";
			this.ColumnNum.Size = new System.Drawing.Size(75, 25);
			this.ColumnNum.TabIndex = 1;
			this.ColumnNum.Text = "添加PDF";
			this.ColumnNum.UseVisualStyleBackColor = true;
			this.ColumnNum.Click += new System.EventHandler(this.button1_Click);
			// 
			// GenarateH5
			// 
			this.GenarateH5.Location = new System.Drawing.Point(895, 11);
			this.GenarateH5.Name = "GenarateH5";
			this.GenarateH5.Size = new System.Drawing.Size(75, 25);
			this.GenarateH5.TabIndex = 2;
			this.GenarateH5.Text = "生成H5";
			this.GenarateH5.UseVisualStyleBackColor = true;
			this.GenarateH5.Click += new System.EventHandler(this.button2_Click);
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// PreviewH5
			// 
			this.PreviewH5.Location = new System.Drawing.Point(792, 11);
			this.PreviewH5.Name = "PreviewH5";
			this.PreviewH5.Size = new System.Drawing.Size(75, 25);
			this.PreviewH5.TabIndex = 7;
			this.PreviewH5.Text = "预览";
			this.PreviewH5.UseVisualStyleBackColor = true;
			this.PreviewH5.Click += new System.EventHandler(this.button3_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(12, 44);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
			this.splitContainer1.Panel1.Controls.Add(this.listView1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.label5);
			this.splitContainer1.Panel2.Controls.Add(this.label4);
			this.splitContainer1.Panel2.Controls.Add(this.label3);
			this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
			this.splitContainer1.Size = new System.Drawing.Size(989, 473);
			this.splitContainer1.SplitterDistance = 652;
			this.splitContainer1.TabIndex = 9;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(163, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(486, 467);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
			this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
			this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
			this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.listView1.Location = new System.Drawing.Point(5, 3);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(152, 467);
			this.listView1.TabIndex = 7;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			this.listView1.MouseHover += new System.EventHandler(this.listView1_MouseHover);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(686, 5);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(100, 38);
			this.button5.TabIndex = 8;
			this.button5.Text = "截屏";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(192, 95);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(23, 25);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 8;
			this.pictureBox2.TabStop = false;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(310, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(249, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "目录级别";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(414, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "目录名称";
			// 
			// ColumnName
			// 
			this.ColumnName.Location = new System.Drawing.Point(475, 12);
			this.ColumnName.Name = "ColumnName";
			this.ColumnName.Size = new System.Drawing.Size(100, 20);
			this.ColumnName.TabIndex = 12;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.Controls.Add(this.label6);
			this.flowLayoutPanel1.Controls.Add(this.button1);
			this.flowLayoutPanel1.Controls.Add(this.button2);
			this.flowLayoutPanel1.Controls.Add(this.label7);
			this.flowLayoutPanel1.Controls.Add(this.button3);
			this.flowLayoutPanel1.Controls.Add(this.button4);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 51);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(327, 419);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(18, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "序号";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(117, 13);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 19);
			this.label4.TabIndex = 2;
			this.label4.Text = "触控区";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(242, 13);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 19);
			this.label5.TabIndex = 3;
			this.label5.Text = "音频区";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(3, 10);
			this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.label6.Name = "label6";
			this.label6.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
			this.label6.Size = new System.Drawing.Size(53, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(109, 3);
			this.button1.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(237, 3);
			this.button2.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(3, 39);
			this.label7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.label7.Name = "label7";
			this.label7.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
			this.label7.Size = new System.Drawing.Size(53, 13);
			this.label7.TabIndex = 3;
			this.label7.Text = "1";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(109, 32);
			this.button3.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(237, 32);
			this.button4.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 5;
			this.button4.Text = "button4";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1013, 531);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.ColumnName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.PreviewH5);
			this.Controls.Add(this.GenarateH5);
			this.Controls.Add(this.ColumnNum);
			this.Controls.Add(this.axAcroPDF1);
			this.Controls.Add(this.pictureBox2);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Button ColumnNum;
        private System.Windows.Forms.Button GenarateH5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button PreviewH5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button5;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox ColumnName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
	}
}

