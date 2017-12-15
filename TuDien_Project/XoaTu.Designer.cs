namespace TuDien_Project
{
    partial class XoaTu
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
            this.label1 = new System.Windows.Forms.Label();
            this.xoa_bt = new System.Windows.Forms.Button();
            this.Anh_txb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "English:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // xoa_bt
            // 
            this.xoa_bt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa_bt.Location = new System.Drawing.Point(297, 174);
            this.xoa_bt.Name = "xoa_bt";
            this.xoa_bt.Size = new System.Drawing.Size(75, 56);
            this.xoa_bt.TabIndex = 8;
            this.xoa_bt.Text = "Xóa";
            this.xoa_bt.UseVisualStyleBackColor = true;
            this.xoa_bt.Click += new System.EventHandler(this.them_bt_Click);
            // 
            // Anh_txb
            // 
            this.Anh_txb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anh_txb.Location = new System.Drawing.Point(234, 32);
            this.Anh_txb.Multiline = true;
            this.Anh_txb.Name = "Anh_txb";
            this.Anh_txb.Size = new System.Drawing.Size(243, 89);
            this.Anh_txb.TabIndex = 6;
            this.Anh_txb.TextChanged += new System.EventHandler(this.Anh_txb_TextChanged);
            // 
            // XoaTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xoa_bt);
            this.Controls.Add(this.Anh_txb);
            this.Name = "XoaTu";
            this.Text = "XoaTu";
            this.Load += new System.EventHandler(this.XoaTu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button xoa_bt;
        private System.Windows.Forms.TextBox Anh_txb;
    }
}