namespace TuDien_Project
{
    partial class TuDienAV
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
                //              components.Dispose();
            }
            base.Dispose(disposing);
        }


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rbAnhViet = new System.Windows.Forms.RadioButton();
            this.rbVietAnh = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchWeb = new System.Windows.Forms.PictureBox();
            this.EditWord = new System.Windows.Forms.PictureBox();
            this.LikeWord = new System.Windows.Forms.PictureBox();
            this.SoundWord = new System.Windows.Forms.PictureBox();
            this.TimKiem_ComboBox = new System.Windows.Forms.ComboBox();
            this.Nghia_TextBox = new System.Windows.Forms.TextBox();
            this.English_ListView = new System.Windows.Forms.ListView();
            this.Search_TextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchWeb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LikeWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoundWord)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SeaGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(750, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // rbAnhViet
            // 
            this.rbAnhViet.AutoSize = true;
            this.rbAnhViet.Checked = true;
            this.rbAnhViet.Location = new System.Drawing.Point(20, 18);
            this.rbAnhViet.Name = "rbAnhViet";
            this.rbAnhViet.Size = new System.Drawing.Size(68, 18);
            this.rbAnhViet.TabIndex = 4;
            this.rbAnhViet.TabStop = true;
            this.rbAnhViet.Text = "Anh-Việt";
            this.rbAnhViet.UseVisualStyleBackColor = true;
            // 
            // rbVietAnh
            // 
            this.rbVietAnh.AutoSize = true;
            this.rbVietAnh.Location = new System.Drawing.Point(117, 19);
            this.rbVietAnh.Name = "rbVietAnh";
            this.rbVietAnh.Size = new System.Drawing.Size(68, 18);
            this.rbVietAnh.TabIndex = 5;
            this.rbVietAnh.Text = "Việt-Anh";
            this.rbVietAnh.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAnhViet);
            this.groupBox1.Controls.Add(this.rbVietAnh);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(501, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 46);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Từ điển";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tìm :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Font = new System.Drawing.Font("Goudy Stout", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(671, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "English-VietNamese Dictionary";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchWeb
            // 
            this.SearchWeb.Location = new System.Drawing.Point(453, 105);
            this.SearchWeb.Name = "SearchWeb";
            this.SearchWeb.Size = new System.Drawing.Size(33, 31);
            this.SearchWeb.TabIndex = 14;
            this.SearchWeb.TabStop = false;
            // 
            // EditWord
            // 
            this.EditWord.Location = new System.Drawing.Point(395, 105);
            this.EditWord.Name = "EditWord";
            this.EditWord.Size = new System.Drawing.Size(33, 31);
            this.EditWord.TabIndex = 13;
            this.EditWord.TabStop = false;
            // 
            // LikeWord
            // 
            this.LikeWord.Location = new System.Drawing.Point(337, 105);
            this.LikeWord.Name = "LikeWord";
            this.LikeWord.Size = new System.Drawing.Size(33, 31);
            this.LikeWord.TabIndex = 11;
            this.LikeWord.TabStop = false;
            // 
            // SoundWord
            // 
            this.SoundWord.Location = new System.Drawing.Point(281, 105);
            this.SoundWord.Name = "SoundWord";
            this.SoundWord.Size = new System.Drawing.Size(33, 31);
            this.SoundWord.TabIndex = 10;
            this.SoundWord.TabStop = false;
            // 
            // TimKiem_ComboBox
            // 
            this.TimKiem_ComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimKiem_ComboBox.FormattingEnabled = true;
            this.TimKiem_ComboBox.Location = new System.Drawing.Point(12, 224);
            this.TimKiem_ComboBox.Name = "TimKiem_ComboBox";
            this.TimKiem_ComboBox.Size = new System.Drawing.Size(208, 26);
            this.TimKiem_ComboBox.TabIndex = 15;
            this.TimKiem_ComboBox.SelectedIndexChanged += new System.EventHandler(this.TimKiem_ComboBox_SelectedIndexChanged);
            // 
            // Nghia_TextBox
            // 
            this.Nghia_TextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nghia_TextBox.Location = new System.Drawing.Point(230, 180);
            this.Nghia_TextBox.Multiline = true;
            this.Nghia_TextBox.Name = "Nghia_TextBox";
            this.Nghia_TextBox.Size = new System.Drawing.Size(479, 342);
            this.Nghia_TextBox.TabIndex = 16;
            // 
            // English_ListView
            // 
            this.English_ListView.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.English_ListView.FullRowSelect = true;
            this.English_ListView.Location = new System.Drawing.Point(12, 268);
            this.English_ListView.MultiSelect = false;
            this.English_ListView.Name = "English_ListView";
            this.English_ListView.Size = new System.Drawing.Size(208, 254);
            this.English_ListView.TabIndex = 17;
            this.English_ListView.UseCompatibleStateImageBehavior = false;
            this.English_ListView.View = System.Windows.Forms.View.List;
            this.English_ListView.SelectedIndexChanged += new System.EventHandler(this.English_ListView_SelectedIndexChanged);
            // 
            // Search_TextBox
            // 
            this.Search_TextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_TextBox.Location = new System.Drawing.Point(15, 180);
            this.Search_TextBox.Name = "Search_TextBox";
            this.Search_TextBox.Size = new System.Drawing.Size(209, 26);
            this.Search_TextBox.TabIndex = 18;
            this.Search_TextBox.TextChanged += new System.EventHandler(this.Search_TextBox_TextChanged);
            // 
            // TuDienAV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 542);
            this.Controls.Add(this.Search_TextBox);
            this.Controls.Add(this.English_ListView);
            this.Controls.Add(this.Nghia_TextBox);
            this.Controls.Add(this.TimKiem_ComboBox);
            this.Controls.Add(this.SearchWeb);
            this.Controls.Add(this.EditWord);
            this.Controls.Add(this.LikeWord);
            this.Controls.Add(this.SoundWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TuDienAV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchWeb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LikeWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoundWord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbAnhViet;
        private System.Windows.Forms.RadioButton rbVietAnh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox SoundWord;
        private System.Windows.Forms.PictureBox LikeWord;
        private System.Windows.Forms.PictureBox EditWord;
        private System.Windows.Forms.PictureBox SearchWeb;
        private System.Windows.Forms.ComboBox TimKiem_ComboBox;
        private System.Windows.Forms.TextBox Nghia_TextBox;
        private System.Windows.Forms.ListView English_ListView;
        private System.Windows.Forms.TextBox Search_TextBox;
    }
}

