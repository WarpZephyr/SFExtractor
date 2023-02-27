namespace SFExtractor
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
            this.MainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMS = new System.Windows.Forms.ToolStripMenuItem();
            this.ExtractFileMS = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMS = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutHMS = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFormStatusStrip = new System.Windows.Forms.StatusStrip();
            this.MainFormStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainFormMenuStrip.SuspendLayout();
            this.MainFormStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormMenuStrip
            // 
            this.MainFormMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.MainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMS,
            this.HelpMS});
            this.MainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainFormMenuStrip.Name = "MainFormMenuStrip";
            this.MainFormMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MainFormMenuStrip.Size = new System.Drawing.Size(535, 24);
            this.MainFormMenuStrip.TabIndex = 1;
            this.MainFormMenuStrip.Text = "MainFormMenuStrip";
            // 
            // FileMS
            // 
            this.FileMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.FileMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FileMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FileMS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExtractFileMS});
            this.FileMS.ForeColor = System.Drawing.SystemColors.Control;
            this.FileMS.Name = "FileMS";
            this.FileMS.Size = new System.Drawing.Size(37, 20);
            this.FileMS.Text = "File";
            // 
            // ExtractFileMS
            // 
            this.ExtractFileMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ExtractFileMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExtractFileMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ExtractFileMS.ForeColor = System.Drawing.SystemColors.Control;
            this.ExtractFileMS.Name = "ExtractFileMS";
            this.ExtractFileMS.Size = new System.Drawing.Size(110, 22);
            this.ExtractFileMS.Text = "Extract";
            this.ExtractFileMS.ToolTipText = "Decompresses multiple FromSoft compressed file types";
            this.ExtractFileMS.Click += new System.EventHandler(this.ExtractFileMS_Click);
            // 
            // HelpMS
            // 
            this.HelpMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.HelpMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HelpMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HelpMS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutHMS});
            this.HelpMS.ForeColor = System.Drawing.SystemColors.Control;
            this.HelpMS.Name = "HelpMS";
            this.HelpMS.Size = new System.Drawing.Size(44, 20);
            this.HelpMS.Text = "Help";
            // 
            // AboutHMS
            // 
            this.AboutHMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.AboutHMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AboutHMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AboutHMS.ForeColor = System.Drawing.SystemColors.Control;
            this.AboutHMS.Name = "AboutHMS";
            this.AboutHMS.Size = new System.Drawing.Size(107, 22);
            this.AboutHMS.Text = "About";
            this.AboutHMS.ToolTipText = "TODO: About this program";
            this.AboutHMS.Click += new System.EventHandler(this.AboutHMS_Click);
            // 
            // MainFormStatusStrip
            // 
            this.MainFormStatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MainFormStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainFormStatus});
            this.MainFormStatusStrip.Location = new System.Drawing.Point(0, 348);
            this.MainFormStatusStrip.Name = "MainFormStatusStrip";
            this.MainFormStatusStrip.Size = new System.Drawing.Size(535, 22);
            this.MainFormStatusStrip.TabIndex = 2;
            // 
            // MainFormStatus
            // 
            this.MainFormStatus.Name = "MainFormStatus";
            this.MainFormStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(535, 370);
            this.Controls.Add(this.MainFormStatusStrip);
            this.Controls.Add(this.MainFormMenuStrip);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.KeyPreview = true;
            this.MainMenuStrip = this.MainFormMenuStrip;
            this.Name = "MainForm";
            this.Text = "SoulsFormats Extractor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.MainFormMenuStrip.ResumeLayout(false);
            this.MainFormMenuStrip.PerformLayout();
            this.MainFormStatusStrip.ResumeLayout(false);
            this.MainFormStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMS;
        private System.Windows.Forms.ToolStripMenuItem HelpMS;
        private System.Windows.Forms.ToolStripMenuItem AboutHMS;
        private System.Windows.Forms.StatusStrip MainFormStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel MainFormStatus;
        private System.Windows.Forms.ToolStripMenuItem ExtractFileMS;
    }
}

