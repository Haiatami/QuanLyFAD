namespace QL
{
    partial class THONGKEDANHTHU
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgHoadon = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btTim = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btload1 = new System.Windows.Forms.Button();
            this.btTim1 = new System.Windows.Forms.Button();
            this.btXemct = new System.Windows.Forms.Button();
            this.btTinh = new System.Windows.Forms.Button();
            this.rdNgay = new System.Windows.Forms.RadioButton();
            this.rdThang = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.cbNgay = new System.Windows.Forms.ComboBox();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHoadon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgHoadon);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(364, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 732);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn của quán";
            // 
            // dgHoadon
            // 
            this.dgHoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgHoadon.Location = new System.Drawing.Point(3, 23);
            this.dgHoadon.Name = "dgHoadon";
            this.dgHoadon.RowHeadersWidth = 50;
            this.dgHoadon.RowTemplate.Height = 29;
            this.dgHoadon.Size = new System.Drawing.Size(430, 706);
            this.dgHoadon.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btXemct);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 123);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xem chi tiết";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbNam);
            this.groupBox3.Controls.Add(this.cbThang);
            this.groupBox3.Controls.Add(this.cbNgay);
            this.groupBox3.Controls.Add(this.rdNam);
            this.groupBox3.Controls.Add(this.rdThang);
            this.groupBox3.Controls.Add(this.rdNgay);
            this.groupBox3.Controls.Add(this.btTinh);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 123);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tính danh thu";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btTim1);
            this.groupBox4.Controls.Add(this.btload1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.numericUpDown1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 246);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(364, 130);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm hóa đơn của bàn";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btLoad);
            this.groupBox5.Controls.Add(this.btTim);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.txtTen);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 376);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(364, 133);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tìm hóa đơn nhân viên";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(141, 28);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(216, 27);
            this.txtTen.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên:";
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(62, 80);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(92, 28);
            this.btTim.TabIndex = 0;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(187, 80);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(92, 28);
            this.btLoad.TabIndex = 1;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(77, 30);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(108, 27);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bàn số:";
            // 
            // btload1
            // 
            this.btload1.Location = new System.Drawing.Point(191, 71);
            this.btload1.Name = "btload1";
            this.btload1.Size = new System.Drawing.Size(59, 33);
            this.btload1.TabIndex = 2;
            this.btload1.Text = "Load";
            this.btload1.UseVisualStyleBackColor = true;
            // 
            // btTim1
            // 
            this.btTim1.Location = new System.Drawing.Point(191, 32);
            this.btTim1.Name = "btTim1";
            this.btTim1.Size = new System.Drawing.Size(59, 33);
            this.btTim1.TabIndex = 3;
            this.btTim1.Text = "Tìm";
            this.btTim1.UseVisualStyleBackColor = true;
            // 
            // btXemct
            // 
            this.btXemct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btXemct.Location = new System.Drawing.Point(3, 23);
            this.btXemct.Name = "btXemct";
            this.btXemct.Size = new System.Drawing.Size(358, 97);
            this.btXemct.TabIndex = 0;
            this.btXemct.Text = "Xem chi tiết hóa đơn";
            this.btXemct.UseVisualStyleBackColor = true;
            // 
            // btTinh
            // 
            this.btTinh.Location = new System.Drawing.Point(12, 26);
            this.btTinh.Name = "btTinh";
            this.btTinh.Size = new System.Drawing.Size(92, 91);
            this.btTinh.TabIndex = 0;
            this.btTinh.Text = "Tính";
            this.btTinh.UseVisualStyleBackColor = true;
            // 
            // rdNgay
            // 
            this.rdNgay.AutoSize = true;
            this.rdNgay.Location = new System.Drawing.Point(110, 26);
            this.rdNgay.Name = "rdNgay";
            this.rdNgay.Size = new System.Drawing.Size(65, 25);
            this.rdNgay.TabIndex = 1;
            this.rdNgay.TabStop = true;
            this.rdNgay.Text = "Ngày";
            this.rdNgay.UseVisualStyleBackColor = true;
            // 
            // rdThang
            // 
            this.rdThang.AutoSize = true;
            this.rdThang.Location = new System.Drawing.Point(110, 57);
            this.rdThang.Name = "rdThang";
            this.rdThang.Size = new System.Drawing.Size(71, 25);
            this.rdThang.TabIndex = 2;
            this.rdThang.TabStop = true;
            this.rdThang.Text = "Tháng";
            this.rdThang.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(110, 88);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(62, 25);
            this.rdNam.TabIndex = 3;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Năm";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // cbNgay
            // 
            this.cbNgay.FormattingEnabled = true;
            this.cbNgay.Location = new System.Drawing.Point(181, 26);
            this.cbNgay.Name = "cbNgay";
            this.cbNgay.Size = new System.Drawing.Size(98, 28);
            this.cbNgay.TabIndex = 4;
            // 
            // cbThang
            // 
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Location = new System.Drawing.Point(181, 56);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(98, 28);
            this.cbThang.TabIndex = 5;
            // 
            // cbNam
            // 
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Location = new System.Drawing.Point(181, 85);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(98, 28);
            this.cbNam.TabIndex = 6;
            // 
            // THONGKEDANHTHU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 732);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "THONGKEDANHTHU";
            this.Text = "THONGKEDANHTHU";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgHoadon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgHoadon;
        private GroupBox groupBox2;
        private Button btXemct;
        private GroupBox groupBox3;
        private ComboBox cbNam;
        private ComboBox cbThang;
        private ComboBox cbNgay;
        private RadioButton rdNam;
        private RadioButton rdThang;
        private RadioButton rdNgay;
        private Button btTinh;
        private GroupBox groupBox4;
        private Button btTim1;
        private Button btload1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private GroupBox groupBox5;
        private Button btLoad;
        private Button btTim;
        private Label label1;
        private TextBox txtTen;
    }
}