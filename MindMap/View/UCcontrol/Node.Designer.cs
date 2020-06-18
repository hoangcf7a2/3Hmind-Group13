namespace MindMap.View.UCcontrol
{
    partial class Node
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Rmargin = new System.Windows.Forms.Panel();
            this.Lmargin = new System.Windows.Forms.Panel();
            this.Dmargin = new System.Windows.Forms.Panel();
            this.Umargin = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MoveArea = new System.Windows.Forms.PictureBox();
            this.lbContent = new System.Windows.Forms.Label();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoveArea)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rmargin
            // 
            this.Rmargin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Rmargin.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.Rmargin.Dock = System.Windows.Forms.DockStyle.Right;
            this.Rmargin.Location = new System.Drawing.Point(208, 0);
            this.Rmargin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rmargin.Name = "Rmargin";
            this.Rmargin.Size = new System.Drawing.Size(2, 77);
            this.Rmargin.TabIndex = 0;
            this.Rmargin.Tag = "R";
            // 
            // Lmargin
            // 
            this.Lmargin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lmargin.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.Lmargin.Dock = System.Windows.Forms.DockStyle.Left;
            this.Lmargin.Location = new System.Drawing.Point(0, 0);
            this.Lmargin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Lmargin.Name = "Lmargin";
            this.Lmargin.Size = new System.Drawing.Size(2, 77);
            this.Lmargin.TabIndex = 1;
            this.Lmargin.Tag = "L";
            // 
            // Dmargin
            // 
            this.Dmargin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dmargin.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.Dmargin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dmargin.Location = new System.Drawing.Point(2, 75);
            this.Dmargin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dmargin.Name = "Dmargin";
            this.Dmargin.Size = new System.Drawing.Size(206, 2);
            this.Dmargin.TabIndex = 2;
            this.Dmargin.Tag = "D";
            // 
            // Umargin
            // 
            this.Umargin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Umargin.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.Umargin.Dock = System.Windows.Forms.DockStyle.Top;
            this.Umargin.Location = new System.Drawing.Point(2, 0);
            this.Umargin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Umargin.Name = "Umargin";
            this.Umargin.Size = new System.Drawing.Size(206, 2);
            this.Umargin.TabIndex = 3;
            this.Umargin.Tag = "U";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.MoveArea);
            this.flowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(206, 31);
            this.flowLayoutPanel1.TabIndex = 4;
            this.flowLayoutPanel1.Click += new System.EventHandler(this.flowLayoutPanel1_Click);
            this.flowLayoutPanel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseDoubleClick);
            // 
            // MoveArea
            // 
            this.MoveArea.Image = global::MindMap.Properties.Resources._512px_Move_icon_svg;
            this.MoveArea.Location = new System.Drawing.Point(3, 4);
            this.MoveArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MoveArea.Name = "MoveArea";
            this.MoveArea.Size = new System.Drawing.Size(24, 25);
            this.MoveArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MoveArea.TabIndex = 0;
            this.MoveArea.TabStop = false;
            this.MoveArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveArea_MouseDown);
            this.MoveArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveArea_MouseMove);
            this.MoveArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoveArea_MouseUp);
            // 
            // lbContent
            // 
            this.lbContent.BackColor = System.Drawing.Color.Gainsboro;
            this.lbContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbContent.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContent.Location = new System.Drawing.Point(2, 33);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(206, 42);
            this.lbContent.TabIndex = 5;
            this.lbContent.Text = "Input Text";
            this.lbContent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbContent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbContent_MouseClick);
            this.lbContent.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbContent_MouseDoubleClick);
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(181, 70);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // Node
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Umargin);
            this.Controls.Add(this.Dmargin);
            this.Controls.Add(this.Lmargin);
            this.Controls.Add(this.Rmargin);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Node";
            this.Size = new System.Drawing.Size(210, 77);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MoveArea)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Rmargin;
        private System.Windows.Forms.Panel Lmargin;
        private System.Windows.Forms.Panel Dmargin;
        private System.Windows.Forms.Panel Umargin;
        private System.Windows.Forms.PictureBox MoveArea;
        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
