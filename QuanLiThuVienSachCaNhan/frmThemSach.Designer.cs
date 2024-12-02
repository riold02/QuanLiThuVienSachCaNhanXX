namespace QuanLiThuVienSachCaNhan
{
    partial class frmThemSach
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
            this.txtIDSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bntThemSach = new System.Windows.Forms.Button();
            this.cbbTheLoai = new System.Windows.Forms.ComboBox();
            this.rdKeA = new System.Windows.Forms.RadioButton();
            this.rdKeB = new System.Windows.Forms.RadioButton();
            this.rdKeC = new System.Windows.Forms.RadioButton();
            this.rdKeD = new System.Windows.Forms.RadioButton();
            this.cbbTacGia = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIDSach
            // 
            this.txtIDSach.Location = new System.Drawing.Point(193, 51);
            this.txtIDSach.Name = "txtIDSach";
            this.txtIDSach.Size = new System.Drawing.Size(160, 20);
            this.txtIDSach.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên sách:";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(193, 83);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(160, 20);
            this.txtTenSach.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tác giả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Thể loại:";
            // 
            // bntThemSach
            // 
            this.bntThemSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThemSach.Location = new System.Drawing.Point(205, 297);
            this.bntThemSach.Name = "bntThemSach";
            this.bntThemSach.Size = new System.Drawing.Size(99, 48);
            this.bntThemSach.TabIndex = 12;
            this.bntThemSach.Text = "Thêm sách";
            this.bntThemSach.UseVisualStyleBackColor = true;
            this.bntThemSach.Click += new System.EventHandler(this.bnt_themsach_Click);
            // 
            // cbbTheLoai
            // 
            this.cbbTheLoai.FormattingEnabled = true;
            this.cbbTheLoai.Location = new System.Drawing.Point(193, 167);
            this.cbbTheLoai.Name = "cbbTheLoai";
            this.cbbTheLoai.Size = new System.Drawing.Size(160, 21);
            this.cbbTheLoai.TabIndex = 15;
            this.cbbTheLoai.SelectedIndexChanged += new System.EventHandler(this.cbbChuDe_SelectedIndexChanged);
            // 
            // rdKeA
            // 
            this.rdKeA.AutoSize = true;
            this.rdKeA.Checked = true;
            this.rdKeA.Location = new System.Drawing.Point(65, 19);
            this.rdKeA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdKeA.Name = "rdKeA";
            this.rdKeA.Size = new System.Drawing.Size(50, 19);
            this.rdKeA.TabIndex = 19;
            this.rdKeA.TabStop = true;
            this.rdKeA.Text = "Kệ A";
            this.rdKeA.UseVisualStyleBackColor = true;
            // 
            // rdKeB
            // 
            this.rdKeB.AutoSize = true;
            this.rdKeB.Location = new System.Drawing.Point(161, 19);
            this.rdKeB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdKeB.Name = "rdKeB";
            this.rdKeB.Size = new System.Drawing.Size(51, 19);
            this.rdKeB.TabIndex = 19;
            this.rdKeB.Text = "Kệ B";
            this.rdKeB.UseVisualStyleBackColor = true;
            // 
            // rdKeC
            // 
            this.rdKeC.AutoSize = true;
            this.rdKeC.Location = new System.Drawing.Point(65, 58);
            this.rdKeC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdKeC.Name = "rdKeC";
            this.rdKeC.Size = new System.Drawing.Size(51, 19);
            this.rdKeC.TabIndex = 19;
            this.rdKeC.Text = "Kệ C";
            this.rdKeC.UseVisualStyleBackColor = true;
            // 
            // rdKeD
            // 
            this.rdKeD.AutoSize = true;
            this.rdKeD.Location = new System.Drawing.Point(160, 58);
            this.rdKeD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdKeD.Name = "rdKeD";
            this.rdKeD.Size = new System.Drawing.Size(52, 19);
            this.rdKeD.TabIndex = 19;
            this.rdKeD.Text = "Kệ D";
            this.rdKeD.UseVisualStyleBackColor = true;
            // 
            // cbbTacGia
            // 
            this.cbbTacGia.FormattingEnabled = true;
            this.cbbTacGia.Location = new System.Drawing.Point(193, 124);
            this.cbbTacGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbTacGia.Name = "cbbTacGia";
            this.cbbTacGia.Size = new System.Drawing.Size(160, 21);
            this.cbbTacGia.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdKeA);
            this.groupBox1.Controls.Add(this.rdKeB);
            this.groupBox1.Controls.Add(this.rdKeD);
            this.groupBox1.Controls.Add(this.rdKeC);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(128, 202);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(224, 81);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vị trí";
            // 
            // frmThemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbbTacGia);
            this.Controls.Add(this.cbbTheLoai);
            this.Controls.Add(this.bntThemSach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDSach);
            this.Name = "frmThemSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Sách";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bntThemSach;
        private System.Windows.Forms.ComboBox cbbTheLoai;
        private System.Windows.Forms.RadioButton rdKeA;
        private System.Windows.Forms.RadioButton rdKeB;
        private System.Windows.Forms.RadioButton rdKeC;
        private System.Windows.Forms.RadioButton rdKeD;
        private System.Windows.Forms.ComboBox cbbTacGia;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}