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
            this.them_bt = new System.Windows.Forms.Button();
            this.Anh_txb = new System.Windows.Forms.TextBox();
            this.Viet_txb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // them_bt
            // 
            this.them_bt.Location = new System.Drawing.Point(65, 106);
            this.them_bt.Name = "them_bt";
            this.them_bt.Size = new System.Drawing.Size(75, 23);
            this.them_bt.TabIndex = 4;
            this.them_bt.Text = "Thêm";
            this.them_bt.UseVisualStyleBackColor = true;
            this.them_bt.Click += new System.EventHandler(this.them_bt_Click);
            // 
            // Anh_txb
            // 
            this.Anh_txb.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anh_txb.Location = new System.Drawing.Point(272, 50);
            this.Anh_txb.Multiline = true;
            this.Anh_txb.Name = "Anh_txb";
            this.Anh_txb.Size = new System.Drawing.Size(331, 264);
            this.Anh_txb.TabIndex = 2;
            // 
            // Viet_txb
            // 
            this.Viet_txb.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Viet_txb.Location = new System.Drawing.Point(65, 50);
            this.Viet_txb.Multiline = true;
            this.Viet_txb.Name = "Viet_txb";
            this.Viet_txb.Size = new System.Drawing.Size(153, 30);
            this.Viet_txb.TabIndex = 3;
            // 
            // ThemTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 365);
            this.Controls.Add(this.them_bt);
            this.Controls.Add(this.Anh_txb);
            this.Controls.Add(this.Viet_txb);
            this.Name = "ThemTu";
            this.Text = "ThemTu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button them_bt;
        private System.Windows.Forms.TextBox Anh_txb;
        private System.Windows.Forms.TextBox Viet_txb;
    }
}