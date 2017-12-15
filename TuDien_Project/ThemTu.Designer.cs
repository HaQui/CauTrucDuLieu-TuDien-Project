namespace TuDien_Project
{
    partial class ThemTu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemTu));
            this.them_bt = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThemNghia = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Anh_txb = new System.Windows.Forms.TextBox();
            this.Viet_txb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // them_bt
            // 
            this.them_bt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them_bt.Location = new System.Drawing.Point(575, 137);
            this.them_bt.Name = "them_bt";
            this.them_bt.Size = new System.Drawing.Size(75, 32);
            this.them_bt.TabIndex = 4;
            this.them_bt.Text = "Thêm";
            this.them_bt.UseVisualStyleBackColor = true;
            this.them_bt.Click += new System.EventHandler(this.them_bt_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(575, 187);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 32);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThemNghia
            // 
            this.btnThemNghia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNghia.Location = new System.Drawing.Point(575, 75);
            this.btnThemNghia.Name = "btnThemNghia";
            this.btnThemNghia.Size = new System.Drawing.Size(75, 56);
            this.btnThemNghia.TabIndex = 16;
            this.btnThemNghia.Text = "Thêm Nghĩa";
            this.btnThemNghia.UseVisualStyleBackColor = true;
            this.btnThemNghia.Click += new System.EventHandler(this.btnThemNghia_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(268, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Chọn Từ Loại";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "(v)",
            "(n)",
            "(adj)",
            "(adv)"});
            this.comboBox1.Location = new System.Drawing.Point(268, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(301, 28);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Vietnamese:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "English:";
            // 
            // Anh_txb
            // 
            this.Anh_txb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anh_txb.Location = new System.Drawing.Point(19, 52);
            this.Anh_txb.Multiline = true;
            this.Anh_txb.Name = "Anh_txb";
            this.Anh_txb.Size = new System.Drawing.Size(243, 167);
            this.Anh_txb.TabIndex = 10;
            // 
            // Viet_txb
            // 
            this.Viet_txb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Viet_txb.Location = new System.Drawing.Point(268, 109);
            this.Viet_txb.Multiline = true;
            this.Viet_txb.Name = "Viet_txb";
            this.Viet_txb.Size = new System.Drawing.Size(301, 110);
            this.Viet_txb.TabIndex = 11;
            // 
            // ThemTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(669, 246);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThemNghia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Anh_txb);
            this.Controls.Add(this.Viet_txb);
            this.Controls.Add(this.them_bt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThemTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Từ";
            this.Load += new System.EventHandler(this.ThemTu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button them_bt;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThemNghia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Anh_txb;
        private System.Windows.Forms.TextBox Viet_txb;
    }
}