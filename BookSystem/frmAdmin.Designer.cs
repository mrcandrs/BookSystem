﻿namespace BookSystem
{
    partial class frmAdmin
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
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.lblRefresh = new System.Windows.Forms.Label();
            this.lblAddbook = new System.Windows.Forms.Label();
            this.lblRemoveBook = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(13, 110);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.Size = new System.Drawing.Size(644, 216);
            this.dgvBooks.TabIndex = 0;
            // 
            // lblRefresh
            // 
            this.lblRefresh.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblRefresh.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefresh.Location = new System.Drawing.Point(594, 44);
            this.lblRefresh.Name = "lblRefresh";
            this.lblRefresh.Size = new System.Drawing.Size(63, 23);
            this.lblRefresh.TabIndex = 1;
            this.lblRefresh.Text = "Refresh";
            this.lblRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRefresh.Click += new System.EventHandler(this.lblRefresh_Click);
            // 
            // lblAddbook
            // 
            this.lblAddbook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAddbook.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblAddbook.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblAddbook.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddbook.Location = new System.Drawing.Point(469, 341);
            this.lblAddbook.Name = "lblAddbook";
            this.lblAddbook.Size = new System.Drawing.Size(78, 24);
            this.lblAddbook.TabIndex = 2;
            this.lblAddbook.Text = "Add Book";
            this.lblAddbook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddbook.Click += new System.EventHandler(this.lblAddbook_Click);
            // 
            // lblRemoveBook
            // 
            this.lblRemoveBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRemoveBook.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblRemoveBook.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveBook.Location = new System.Drawing.Point(557, 341);
            this.lblRemoveBook.Name = "lblRemoveBook";
            this.lblRemoveBook.Size = new System.Drawing.Size(100, 24);
            this.lblRemoveBook.TabIndex = 3;
            this.lblRemoveBook.Text = "Remove Book";
            this.lblRemoveBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRemoveBook.Click += new System.EventHandler(this.lblRemoveBook_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(13, 41);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(232, 26);
            this.txtSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(184)))), ((int)(((byte)(254)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearch.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(262, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookSystem.Properties.Resources.pp;
            this.pictureBox1.Location = new System.Drawing.Point(0, -212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(691, 829);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblLogout
            // 
            this.lblLogout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblLogout.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.Location = new System.Drawing.Point(594, 9);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(63, 23);
            this.lblLogout.TabIndex = 7;
            this.lblLogout.Text = "Log Out?";
            this.lblLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookSystem.Properties.Resources.Minimal_World_Book_Public_Library_Education_Logo_Template__1_3;
            this.ClientSize = new System.Drawing.Size(669, 439);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblRemoveBook);
            this.Controls.Add(this.lblAddbook);
            this.Controls.Add(this.lblRefresh);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Label lblRefresh;
        private System.Windows.Forms.Label lblAddbook;
        private System.Windows.Forms.Label lblRemoveBook;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLogout;
    }
}