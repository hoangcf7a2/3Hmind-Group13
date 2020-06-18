namespace MindMap.View.UCcontrol
{
    partial class UCFormat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCFormat));
            this.btnStyle = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.IsFill = new System.Windows.Forms.CheckBox();
            this.ColorChoosen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BorderColorChoosen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FontFamily = new System.Windows.Forms.TextBox();
            this.TextColorChoosen = new System.Windows.Forms.Label();
            this.TextSize = new System.Windows.Forms.NumericUpDown();
            this.btnBold = new System.Windows.Forms.Button();
            this.btnItalic = new System.Windows.Forms.Button();
            this.btnUnderline = new System.Windows.Forms.Button();
            this.btn_align_right = new System.Windows.Forms.Button();
            this.btn_align_center = new System.Windows.Forms.Button();
            this.btn_align_left = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NumLineWidth = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.LineColorChoosen = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.TextSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumLineWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStyle
            // 
            this.btnStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnStyle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnStyle.FlatAppearance.BorderSize = 2;
            this.btnStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStyle.Location = new System.Drawing.Point(-1, -1);
            this.btnStyle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStyle.Name = "btnStyle";
            this.btnStyle.Size = new System.Drawing.Size(136, 43);
            this.btnStyle.TabIndex = 0;
            this.btnStyle.Text = "Style";
            this.btnStyle.UseVisualStyleBackColor = false;
            this.btnStyle.Click += new System.EventHandler(this.btnStyle_Click);
            // 
            // btnMap
            // 
            this.btnMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnMap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnMap.FlatAppearance.BorderSize = 2;
            this.btnMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMap.Location = new System.Drawing.Point(132, -1);
            this.btnMap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(136, 43);
            this.btnMap.TabIndex = 1;
            this.btnMap.Text = "Map";
            this.btnMap.UseVisualStyleBackColor = false;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // IsFill
            // 
            this.IsFill.AutoSize = true;
            this.IsFill.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsFill.Location = new System.Drawing.Point(32, 76);
            this.IsFill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IsFill.Name = "IsFill";
            this.IsFill.Size = new System.Drawing.Size(45, 20);
            this.IsFill.TabIndex = 2;
            this.IsFill.Text = "Fill";
            this.IsFill.UseVisualStyleBackColor = true;
            this.IsFill.CheckedChanged += new System.EventHandler(this.IsFill_CheckedChanged);
            // 
            // ColorChoosen
            // 
            this.ColorChoosen.BackColor = System.Drawing.Color.White;
            this.ColorChoosen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorChoosen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ColorChoosen.Location = new System.Drawing.Point(188, 74);
            this.ColorChoosen.Name = "ColorChoosen";
            this.ColorChoosen.Size = new System.Drawing.Size(48, 25);
            this.ColorChoosen.TabIndex = 3;
            this.ColorChoosen.Visible = false;
            this.ColorChoosen.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Border Color";
            // 
            // BorderColorChoosen
            // 
            this.BorderColorChoosen.BackColor = System.Drawing.Color.White;
            this.BorderColorChoosen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BorderColorChoosen.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BorderColorChoosen.Location = new System.Drawing.Point(188, 116);
            this.BorderColorChoosen.Name = "BorderColorChoosen";
            this.BorderColorChoosen.Size = new System.Drawing.Size(48, 25);
            this.BorderColorChoosen.TabIndex = 5;
            this.BorderColorChoosen.Click += new System.EventHandler(this.BorderColorChoosen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "____________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "____________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Text";
            // 
            // FontFamily
            // 
            this.FontFamily.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontFamily.Location = new System.Drawing.Point(19, 209);
            this.FontFamily.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FontFamily.Name = "FontFamily";
            this.FontFamily.ReadOnly = true;
            this.FontFamily.Size = new System.Drawing.Size(149, 23);
            this.FontFamily.TabIndex = 9;
            this.FontFamily.Click += new System.EventHandler(this.FontFamily_Click);
            // 
            // TextColorChoosen
            // 
            this.TextColorChoosen.BackColor = System.Drawing.Color.Black;
            this.TextColorChoosen.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.TextColorChoosen.Location = new System.Drawing.Point(188, 209);
            this.TextColorChoosen.Name = "TextColorChoosen";
            this.TextColorChoosen.Size = new System.Drawing.Size(48, 24);
            this.TextColorChoosen.TabIndex = 10;
            this.TextColorChoosen.Click += new System.EventHandler(this.TextColorChoosen_Click);
            // 
            // TextSize
            // 
            this.TextSize.Location = new System.Drawing.Point(185, 248);
            this.TextSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextSize.Name = "TextSize";
            this.TextSize.Size = new System.Drawing.Size(51, 20);
            this.TextSize.TabIndex = 11;
            this.TextSize.ValueChanged += new System.EventHandler(this.TextSize_ValueChanged);
            // 
            // btnBold
            // 
            this.btnBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBold.Image = ((System.Drawing.Image)(resources.GetObject("btnBold.Image")));
            this.btnBold.Location = new System.Drawing.Point(32, 246);
            this.btnBold.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(37, 24);
            this.btnBold.TabIndex = 12;
            this.btnBold.UseVisualStyleBackColor = true;
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItalic.Image = ((System.Drawing.Image)(resources.GetObject("btnItalic.Image")));
            this.btnItalic.Location = new System.Drawing.Point(68, 246);
            this.btnItalic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(37, 24);
            this.btnItalic.TabIndex = 13;
            this.btnItalic.UseVisualStyleBackColor = true;
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnderline.Image = ((System.Drawing.Image)(resources.GetObject("btnUnderline.Image")));
            this.btnUnderline.Location = new System.Drawing.Point(104, 246);
            this.btnUnderline.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(37, 24);
            this.btnUnderline.TabIndex = 14;
            this.btnUnderline.UseVisualStyleBackColor = true;
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // btn_align_right
            // 
            this.btn_align_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_align_right.Image = ((System.Drawing.Image)(resources.GetObject("btn_align_right.Image")));
            this.btn_align_right.Location = new System.Drawing.Point(104, 276);
            this.btn_align_right.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_align_right.Name = "btn_align_right";
            this.btn_align_right.Size = new System.Drawing.Size(37, 24);
            this.btn_align_right.TabIndex = 17;
            this.btn_align_right.UseVisualStyleBackColor = true;
            this.btn_align_right.Click += new System.EventHandler(this.btn_align_right_Click);
            // 
            // btn_align_center
            // 
            this.btn_align_center.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_align_center.Image = ((System.Drawing.Image)(resources.GetObject("btn_align_center.Image")));
            this.btn_align_center.Location = new System.Drawing.Point(68, 276);
            this.btn_align_center.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_align_center.Name = "btn_align_center";
            this.btn_align_center.Size = new System.Drawing.Size(37, 24);
            this.btn_align_center.TabIndex = 16;
            this.btn_align_center.UseVisualStyleBackColor = true;
            this.btn_align_center.Click += new System.EventHandler(this.btn_align_center_Click);
            // 
            // btn_align_left
            // 
            this.btn_align_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_align_left.Image = ((System.Drawing.Image)(resources.GetObject("btn_align_left.Image")));
            this.btn_align_left.Location = new System.Drawing.Point(32, 276);
            this.btn_align_left.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_align_left.Name = "btn_align_left";
            this.btn_align_left.Size = new System.Drawing.Size(37, 24);
            this.btn_align_left.TabIndex = 15;
            this.btn_align_left.UseVisualStyleBackColor = true;
            this.btn_align_left.Click += new System.EventHandler(this.btn_align_left_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "____________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Line";
            // 
            // NumLineWidth
            // 
            this.NumLineWidth.Location = new System.Drawing.Point(68, 382);
            this.NumLineWidth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumLineWidth.Name = "NumLineWidth";
            this.NumLineWidth.Size = new System.Drawing.Size(100, 20);
            this.NumLineWidth.TabIndex = 20;
            this.NumLineWidth.ValueChanged += new System.EventHandler(this.NumLineWidth_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 14);
            this.label8.TabIndex = 21;
            this.label8.Text = "Width";
            // 
            // LineColorChoosen
            // 
            this.LineColorChoosen.BackColor = System.Drawing.Color.Black;
            this.LineColorChoosen.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LineColorChoosen.Location = new System.Drawing.Point(188, 379);
            this.LineColorChoosen.Name = "LineColorChoosen";
            this.LineColorChoosen.Size = new System.Drawing.Size(48, 24);
            this.LineColorChoosen.TabIndex = 22;
            this.LineColorChoosen.Click += new System.EventHandler(this.LineColorChoosen_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowEffects = false;
            // 
            // UCFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LineColorChoosen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NumLineWidth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_align_right);
            this.Controls.Add(this.btn_align_center);
            this.Controls.Add(this.btn_align_left);
            this.Controls.Add(this.btnUnderline);
            this.Controls.Add(this.btnItalic);
            this.Controls.Add(this.btnBold);
            this.Controls.Add(this.TextSize);
            this.Controls.Add(this.TextColorChoosen);
            this.Controls.Add(this.FontFamily);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BorderColorChoosen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColorChoosen);
            this.Controls.Add(this.IsFill);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.btnStyle);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCFormat";
            this.Size = new System.Drawing.Size(267, 471);
            ((System.ComponentModel.ISupportInitialize)(this.TextSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumLineWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStyle;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.CheckBox IsFill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FontFamily;
        private System.Windows.Forms.NumericUpDown TextSize;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Button btnItalic;
        private System.Windows.Forms.Button btnUnderline;
        private System.Windows.Forms.Button btn_align_right;
        private System.Windows.Forms.Button btn_align_center;
        private System.Windows.Forms.Button btn_align_left;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NumLineWidth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LineColorChoosen;
        private System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.Label ColorChoosen;
        public System.Windows.Forms.Label BorderColorChoosen;
        public System.Windows.Forms.Label TextColorChoosen;
        public System.Windows.Forms.FontDialog fontDialog1;
    }
}
