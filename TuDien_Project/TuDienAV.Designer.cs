﻿namespace TuDien_Project
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TimKiem_ComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchWeb = new System.Windows.Forms.PictureBox();
            this.LikeWord = new System.Windows.Forms.PictureBox();
            this.EditWord = new System.Windows.Forms.PictureBox();
            this.Nghia_TextBox = new System.Windows.Forms.TextBox();
            this.Search_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Them_Button = new System.Windows.Forms.Button();
            this.Xoa_button = new System.Windows.Forms.Button();
            this.SoundWord = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchWeb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LikeWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditWord)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(758, 24);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAnhViet);
            this.groupBox1.Controls.Add(this.TimKiem_ComboBox);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(266, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 78);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Từ điển";
            // 
            // TimKiem_ComboBox
            // 
            this.TimKiem_ComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimKiem_ComboBox.FormattingEnabled = true;
            this.TimKiem_ComboBox.Location = new System.Drawing.Point(6, 46);
            this.TimKiem_ComboBox.Name = "TimKiem_ComboBox";
            this.TimKiem_ComboBox.Size = new System.Drawing.Size(209, 26);
            this.TimKiem_ComboBox.TabIndex = 15;
            this.TimKiem_ComboBox.SelectedIndexChanged += new System.EventHandler(this.TimKiem_ComboBox_SelectedIndexChanged);
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
            this.SearchWeb.Image = global::TuDien_Project.Properties.Resources.search;
            this.SearchWeb.Location = new System.Drawing.Point(179, 82);
            this.SearchWeb.Name = "SearchWeb";
            this.SearchWeb.Size = new System.Drawing.Size(33, 31);
            this.SearchWeb.TabIndex = 14;
            this.SearchWeb.TabStop = false;
            this.SearchWeb.Click += new System.EventHandler(this.SearchWeb_Click);
            // 
            // LikeWord
            // 
            this.LikeWord.Image = global::TuDien_Project.Properties.Resources.like;
            this.LikeWord.Location = new System.Drawing.Point(121, 82);
            this.LikeWord.Name = "LikeWord";
            this.LikeWord.Size = new System.Drawing.Size(33, 31);
            this.LikeWord.TabIndex = 13;
            this.LikeWord.TabStop = false;
            this.LikeWord.Click += new System.EventHandler(this.LikeWord_Click);
            // 
            // EditWord
            // 
            this.EditWord.Image = global::TuDien_Project.Properties.Resources.edit;
            this.EditWord.Location = new System.Drawing.Point(63, 82);
            this.EditWord.Name = "EditWord";
            this.EditWord.Size = new System.Drawing.Size(33, 31);
            this.EditWord.TabIndex = 11;
            this.EditWord.TabStop = false;
            this.EditWord.Click += new System.EventHandler(this.EditWord_Click);
            // 
            // Nghia_TextBox
            // 
            this.Nghia_TextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nghia_TextBox.Location = new System.Drawing.Point(6, 119);
            this.Nghia_TextBox.Multiline = true;
            this.Nghia_TextBox.Name = "Nghia_TextBox";
            this.Nghia_TextBox.Size = new System.Drawing.Size(481, 301);
            this.Nghia_TextBox.TabIndex = 16;
            // 
            // Search_TextBox
            // 
            this.Search_TextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Search_TextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Search_TextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_TextBox.Location = new System.Drawing.Point(6, 20);
            this.Search_TextBox.Name = "Search_TextBox";
            this.Search_TextBox.Size = new System.Drawing.Size(202, 26);
            this.Search_TextBox.TabIndex = 18;
            this.Search_TextBox.TextChanged += new System.EventHandler(this.Search_TextBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.Search_TextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 433);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 28);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.Them_Button);
            this.groupBox3.Controls.Add(this.Xoa_button);
            this.groupBox3.Controls.Add(this.Nghia_TextBox);
            this.groupBox3.Controls.Add(this.SearchWeb);
            this.groupBox3.Controls.Add(this.SoundWord);
            this.groupBox3.Controls.Add(this.LikeWord);
            this.groupBox3.Controls.Add(this.EditWord);
            this.groupBox3.Location = new System.Drawing.Point(236, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(493, 433);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // Them_Button
            // 
            this.Them_Button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Them_Button.Location = new System.Drawing.Point(6, 21);
            this.Them_Button.Name = "Them_Button";
            this.Them_Button.Size = new System.Drawing.Size(92, 34);
            this.Them_Button.TabIndex = 19;
            this.Them_Button.Text = "Thêm Từ";
            this.Them_Button.UseVisualStyleBackColor = true;
            this.Them_Button.Click += new System.EventHandler(this.Them_Button_Click);
            // 
            // Xoa_button
            // 
            this.Xoa_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa_button.Location = new System.Drawing.Point(137, 22);
            this.Xoa_button.Name = "Xoa_button";
            this.Xoa_button.Size = new System.Drawing.Size(75, 34);
            this.Xoa_button.TabIndex = 19;
            this.Xoa_button.Text = "Xóa Từ";
            this.Xoa_button.UseVisualStyleBackColor = true;
            this.Xoa_button.Click += new System.EventHandler(this.Xoa_button_Click);
            // 
            // SoundWord
            // 
            this.SoundWord.Image = global::TuDien_Project.Properties.Resources.sound;
            this.SoundWord.Location = new System.Drawing.Point(6, 82);
            this.SoundWord.Name = "SoundWord";
            this.SoundWord.Size = new System.Drawing.Size(33, 31);
            this.SoundWord.TabIndex = 10;
            this.SoundWord.TabStop = false;
            this.SoundWord.Click += new System.EventHandler(this.SoundWord_Click);
            // 
            // TuDienAV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(758, 542);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TuDienAV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.TuDienAV_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchWeb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LikeWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditWord)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoundWord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbAnhViet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox EditWord;
        private System.Windows.Forms.PictureBox LikeWord;
        private System.Windows.Forms.PictureBox SearchWeb;
        private System.Windows.Forms.ComboBox TimKiem_ComboBox;
        private System.Windows.Forms.TextBox Nghia_TextBox;
        private System.Windows.Forms.TextBox Search_TextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Them_Button;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Xoa_button;
        private System.Windows.Forms.PictureBox SoundWord;
    }
}

