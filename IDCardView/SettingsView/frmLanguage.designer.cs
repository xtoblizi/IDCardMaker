﻿namespace IDCardView.Settings
{
    partial class frmLanguage
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
            this.grpBoxLanguage = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbSelectLanguage = new System.Windows.Forms.ComboBox();
            this.lstBoxLanguageDetails = new System.Windows.Forms.ListBox();
            this.grpBoxLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxLanguage
            // 
            this.grpBoxLanguage.Controls.Add(this.cmbSelectLanguage);
            this.grpBoxLanguage.Location = new System.Drawing.Point(19, 24);
            this.grpBoxLanguage.Name = "grpBoxLanguage";
            this.grpBoxLanguage.Size = new System.Drawing.Size(185, 96);
            this.grpBoxLanguage.TabIndex = 0;
            this.grpBoxLanguage.TabStop = false;
            this.grpBoxLanguage.Text = "Choose Language";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOk.Location = new System.Drawing.Point(20, 129);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(69, 36);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancel.Location = new System.Drawing.Point(96, 129);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 36);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // cmbSelectLanguage
            // 
            this.cmbSelectLanguage.FormattingEnabled = true;
            this.cmbSelectLanguage.Location = new System.Drawing.Point(9, 29);
            this.cmbSelectLanguage.Name = "cmbSelectLanguage";
            this.cmbSelectLanguage.Size = new System.Drawing.Size(158, 21);
            this.cmbSelectLanguage.TabIndex = 0;
            // 
            // lstBoxLanguageDetails
            // 
            this.lstBoxLanguageDetails.BackColor = System.Drawing.SystemColors.Control;
            this.lstBoxLanguageDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstBoxLanguageDetails.FormattingEnabled = true;
            this.lstBoxLanguageDetails.Location = new System.Drawing.Point(221, 29);
            this.lstBoxLanguageDetails.Name = "lstBoxLanguageDetails";
            this.lstBoxLanguageDetails.Size = new System.Drawing.Size(93, 130);
            this.lstBoxLanguageDetails.TabIndex = 3;
            // 
            // frmLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(327, 177);
            this.Controls.Add(this.lstBoxLanguageDetails);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grpBoxLanguage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "frmLanguage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Language";
            this.grpBoxLanguage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxLanguage;
        private System.Windows.Forms.ComboBox cmbSelectLanguage;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lstBoxLanguageDetails;
    }
}