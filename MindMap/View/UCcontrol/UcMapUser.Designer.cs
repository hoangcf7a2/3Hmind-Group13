namespace MindMap.View.UCcontrol
{
    partial class UcMapUser
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
            this.panelUser = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteMap = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUser
            // 
            this.panelUser.AutoScroll = true;
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUser.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelUser.Location = new System.Drawing.Point(0, 29);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(128, 406);
            this.panelUser.TabIndex = 1;
            this.panelUser.WrapContents = false;
            this.panelUser.MouseEnter += new System.EventHandler(this.panelUser_MouseEnter);
            this.panelUser.MouseLeave += new System.EventHandler(this.panelUser_MouseLeave);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteMap});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteMap
            // 
            this.deleteMap.Name = "deleteMap";
            this.deleteMap.Size = new System.Drawing.Size(107, 22);
            this.deleteMap.Text = "Delete";
            this.deleteMap.Click += new System.EventHandler(this.deleteMap_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "List MindMap  ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MindMap.Properties.Resources.Hamburger_icon_svg;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // UcMapUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.label1);
            this.Name = "UcMapUser";
            this.Size = new System.Drawing.Size(128, 435);
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel panelUser;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteMap;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
