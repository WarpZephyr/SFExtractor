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
            this.UnpackFMS = new System.Windows.Forms.ToolStripMenuItem();
            this.RepackFMS = new System.Windows.Forms.ToolStripMenuItem();
            this.DetectTypeFMS = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsMS = new System.Windows.Forms.ToolStripMenuItem();
            this.DetectionModeOMS = new System.Windows.Forms.ToolStripMenuItem();
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
            this.OptionsMS,
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
            this.UnpackFMS,
            this.RepackFMS,
            this.DetectTypeFMS});
            this.FileMS.ForeColor = System.Drawing.SystemColors.Control;
            this.FileMS.Name = "FileMS";
            this.FileMS.Size = new System.Drawing.Size(37, 20);
            this.FileMS.Text = "File";
            // 
            // UnpackFMS
            // 
            this.UnpackFMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.UnpackFMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UnpackFMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UnpackFMS.ForeColor = System.Drawing.SystemColors.Control;
            this.UnpackFMS.Name = "UnpackFMS";
            this.UnpackFMS.Size = new System.Drawing.Size(180, 22);
            this.UnpackFMS.Text = "Unpack";
            this.UnpackFMS.ToolTipText = "Unpacks multiple FromSoft container files and decompresses FromSoft DCX files";
            this.UnpackFMS.Click += new System.EventHandler(this.UnpackMS_Click);
            // 
            // RepackFMS
            // 
            this.RepackFMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.RepackFMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RepackFMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RepackFMS.ForeColor = System.Drawing.SystemColors.Control;
            this.RepackFMS.Name = "RepackFMS";
            this.RepackFMS.Size = new System.Drawing.Size(180, 22);
            this.RepackFMS.Text = "Repack";
            this.RepackFMS.ToolTipText = "Repacks multiple FromSoftware container files and compresses FromSoftware DCX fil" +
    "es";
            this.RepackFMS.Click += new System.EventHandler(this.RepackFMS_Click);
            // 
            // DetectTypeFMS
            // 
            this.DetectTypeFMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.DetectTypeFMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DetectTypeFMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DetectTypeFMS.ForeColor = System.Drawing.SystemColors.Control;
            this.DetectTypeFMS.Name = "DetectTypeFMS";
            this.DetectTypeFMS.Size = new System.Drawing.Size(180, 22);
            this.DetectTypeFMS.Text = "Detect Type";
            this.DetectTypeFMS.ToolTipText = "Finds file type";
            this.DetectTypeFMS.Click += new System.EventHandler(this.DetectTypeFMS_Click);
            // 
            // OptionsMS
            // 
            this.OptionsMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.OptionsMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OptionsMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OptionsMS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DetectionModeOMS});
            this.OptionsMS.ForeColor = System.Drawing.SystemColors.Control;
            this.OptionsMS.Name = "OptionsMS";
            this.OptionsMS.Size = new System.Drawing.Size(61, 20);
            this.OptionsMS.Text = "Options";
            // 
            // DetectionModeOMS
            // 
            this.DetectionModeOMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.DetectionModeOMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DetectionModeOMS.CheckOnClick = true;
            this.DetectionModeOMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DetectionModeOMS.ForeColor = System.Drawing.SystemColors.Control;
            this.DetectionModeOMS.Name = "DetectionModeOMS";
            this.DetectionModeOMS.Size = new System.Drawing.Size(159, 22);
            this.DetectionModeOMS.Text = "Detection Mode";
            this.DetectionModeOMS.ToolTipText = "Makes drag and drop detect files instead of extract or repack them";
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
        private System.Windows.Forms.ToolStripMenuItem UnpackFMS;
        private System.Windows.Forms.ToolStripMenuItem DetectTypeFMS;
        private System.Windows.Forms.ToolStripMenuItem OptionsMS;
        private System.Windows.Forms.ToolStripMenuItem DetectionModeOMS;
        private System.Windows.Forms.ToolStripMenuItem RepackFMS;
    }
}

