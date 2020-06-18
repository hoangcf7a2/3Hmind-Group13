namespace MindMap
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.timeSlideIn = new System.Windows.Forms.Timer(this.components);
            this.timeSlideOut = new System.Windows.Forms.Timer(this.components);
            this.timeIconSlideIn = new System.Windows.Forms.Timer(this.components);
            this.timeIconslideOut = new System.Windows.Forms.Timer(this.components);
            this.panelPaint = new MindMap.View.UCcontrol.PanelPaint();
            this.ucMapUser1 = new MindMap.View.UCcontrol.UcMapUser();
            this.ucIcon1 = new MindMap.View.UCcontrol.UCIcon();
            this.ucFormat1 = new MindMap.View.UCcontrol.UCFormat();
            this.ucToolBar1 = new MindMap.View.UCcontrol.UCToolBar();
            this.SuspendLayout();
            // 
            // timeSlideIn
            // 
            this.timeSlideIn.Interval = 10;
            this.timeSlideIn.Tick += new System.EventHandler(this.time_Tick);
            // 
            // timeSlideOut
            // 
            this.timeSlideOut.Interval = 10;
            this.timeSlideOut.Tick += new System.EventHandler(this.timeSlideOut_Tick);
            // 
            // timeIconSlideIn
            // 
            this.timeIconSlideIn.Interval = 10;
            this.timeIconSlideIn.Tick += new System.EventHandler(this.timeIconSlideIn_Tick);
            // 
            // timeIconslideOut
            // 
            this.timeIconslideOut.Interval = 10;
            this.timeIconslideOut.Tick += new System.EventHandler(this.timeIconslideOut_Tick);
            // 
            // panelPaint
            // 
            this.panelPaint.AutoScroll = true;
            this.panelPaint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPaint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPaint.Location = new System.Drawing.Point(130, 75);
            this.panelPaint.Name = "panelPaint";
            this.panelPaint.Size = new System.Drawing.Size(279, 464);
            this.panelPaint.TabIndex = 4;
            this.panelPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPaint_Paint_1);
            // 
            // ucMapUser1
            // 
            this.ucMapUser1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucMapUser1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucMapUser1.Location = new System.Drawing.Point(0, 75);
            this.ucMapUser1.Name = "ucMapUser1";
            this.ucMapUser1.Size = new System.Drawing.Size(130, 464);
            this.ucMapUser1.TabIndex = 5;
            // 
            // ucIcon1
            // 
            this.ucIcon1.Dock = System.Windows.Forms.DockStyle.Right;
            this.ucIcon1.Location = new System.Drawing.Point(409, 75);
            this.ucIcon1.Name = "ucIcon1";
            this.ucIcon1.Size = new System.Drawing.Size(267, 464);
            this.ucIcon1.TabIndex = 3;
            // 
            // ucFormat1
            // 
            this.ucFormat1.BackColor = System.Drawing.Color.White;
            this.ucFormat1.Dock = System.Windows.Forms.DockStyle.Right;
            this.ucFormat1.Location = new System.Drawing.Point(676, 75);
            this.ucFormat1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucFormat1.Name = "ucFormat1";
            this.ucFormat1.Size = new System.Drawing.Size(267, 464);
            this.ucFormat1.TabIndex = 1;
            // 
            // ucToolBar1
            // 
            this.ucToolBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ucToolBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucToolBar1.Location = new System.Drawing.Point(0, 0);
            this.ucToolBar1.Name = "ucToolBar1";
            this.ucToolBar1.Size = new System.Drawing.Size(943, 75);
            this.ucToolBar1.TabIndex = 0;
            this.ucToolBar1.Load += new System.EventHandler(this.ucToolBar1_Load);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(943, 539);
            this.Controls.Add(this.panelPaint);
            this.Controls.Add(this.ucMapUser1);
            this.Controls.Add(this.ucIcon1);
            this.Controls.Add(this.ucFormat1);
            this.Controls.Add(this.ucToolBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timeSlideIn;
        private System.Windows.Forms.Timer timeSlideOut;
        private View.UCcontrol.UCToolBar ucToolBar1;
        private View.UCcontrol.UCFormat ucFormat1;
        private View.UCcontrol.UCIcon ucIcon1;
        private View.UCcontrol.PanelPaint panelPaint;
        private System.Windows.Forms.Timer timeIconSlideIn;
        private System.Windows.Forms.Timer timeIconslideOut;
        private View.UCcontrol.UcMapUser ucMapUser1;
    }
}

