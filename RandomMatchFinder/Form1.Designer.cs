namespace RandomMatchFinder
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtbxFoundMatch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtbxAddMatch = new System.Windows.Forms.TextBox();
            this.lstbxMatches = new System.Windows.Forms.ListBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tilføjFraClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbxFoundMatch
            // 
            this.txtbxFoundMatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxFoundMatch.Location = new System.Drawing.Point(12, 216);
            this.txtbxFoundMatch.Name = "txtbxFoundMatch";
            this.txtbxFoundMatch.ReadOnly = true;
            this.txtbxFoundMatch.Size = new System.Drawing.Size(167, 20);
            this.txtbxFoundMatch.TabIndex = 12;
            this.txtbxFoundMatch.Click += new System.EventHandler(this.txtbxFoundMatch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(185, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 20);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Tilføj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtbxAddMatch
            // 
            this.txtbxAddMatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxAddMatch.Location = new System.Drawing.Point(12, 190);
            this.txtbxAddMatch.Name = "txtbxAddMatch";
            this.txtbxAddMatch.Size = new System.Drawing.Size(167, 20);
            this.txtbxAddMatch.TabIndex = 10;
            // 
            // lstbxMatches
            // 
            this.lstbxMatches.AllowDrop = true;
            this.lstbxMatches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbxMatches.ContextMenuStrip = this.contextMenuStrip1;
            this.lstbxMatches.FormattingEnabled = true;
            this.lstbxMatches.Location = new System.Drawing.Point(12, 12);
            this.lstbxMatches.Name = "lstbxMatches";
            this.lstbxMatches.Size = new System.Drawing.Size(248, 160);
            this.lstbxMatches.TabIndex = 9;
            this.lstbxMatches.DoubleClick += new System.EventHandler(this.lstbxMatches_DoubleClick);
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.Location = new System.Drawing.Point(185, 216);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 20);
            this.btnFind.TabIndex = 8;
            this.btnFind.Text = "Vælg kamp";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tilføjFraClipboardToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 26);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // tilføjFraClipboardToolStripMenuItem
            // 
            this.tilføjFraClipboardToolStripMenuItem.Name = "tilføjFraClipboardToolStripMenuItem";
            this.tilføjFraClipboardToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.tilføjFraClipboardToolStripMenuItem.Text = "Tilføj fra clipboard";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 248);
            this.Controls.Add(this.txtbxFoundMatch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtbxAddMatch);
            this.Controls.Add(this.lstbxMatches);
            this.Controls.Add(this.btnFind);
            this.MinimumSize = new System.Drawing.Size(294, 286);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Random Match Finder";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxFoundMatch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtbxAddMatch;
        private System.Windows.Forms.ListBox lstbxMatches;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tilføjFraClipboardToolStripMenuItem;
    }
}

