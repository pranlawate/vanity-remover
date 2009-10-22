﻿namespace GeekyProductions.FolderVanityRemover
{
    partial class MainForm
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
            this.folderTextbox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.lblDrop = new System.Windows.Forms.Label();
            this.cleanButton = new System.Windows.Forms.Button();
            this.folderButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // folderTextbox
            // 
            this.folderTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.folderTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.folderTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.folderTextbox.Location = new System.Drawing.Point(6, 7);
            this.folderTextbox.Name = "folderTextbox";
            this.folderTextbox.Size = new System.Drawing.Size(178, 20);
            this.folderTextbox.TabIndex = 0;
            this.folderTextbox.TextChanged += new System.EventHandler(this.folderTextbox_TextChanged);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Please select the folder to clean:";
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // lblDrop
            // 
            this.lblDrop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDrop.AutoSize = true;
            this.lblDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrop.ForeColor = System.Drawing.Color.Gray;
            this.lblDrop.Location = new System.Drawing.Point(52, 53);
            this.lblDrop.Name = "lblDrop";
            this.lblDrop.Size = new System.Drawing.Size(117, 16);
            this.lblDrop.TabIndex = 3;
            this.lblDrop.Text = "(Or drop one here)";
            // 
            // cleanButton
            // 
            this.cleanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cleanButton.Enabled = false;
            this.cleanButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.cleanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleanButton.Location = new System.Drawing.Point(6, 96);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(27, 24);
            this.cleanButton.TabIndex = 7;
            this.cleanButton.Tag = "";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanButtonClick);
            // 
            // folderButton
            // 
            this.folderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.folderButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.folderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.folderButton.Location = new System.Drawing.Point(190, 4);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(27, 24);
            this.folderButton.TabIndex = 2;
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.folderButtonClick);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(39, 98);
            this.progressBar.MarqueeAnimationSpeed = 20;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(178, 20);
            this.progressBar.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 126);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.lblDrop);
            this.Controls.Add(this.folderButton);
            this.Controls.Add(this.folderTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(230, 150);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folder Vanity Remover";
            this.TopMost = true;
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox folderTextbox;
        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label lblDrop;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}