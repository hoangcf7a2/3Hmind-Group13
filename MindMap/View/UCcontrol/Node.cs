using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MindMap.Models;
using MindMap.Controllers;

namespace MindMap.View.UCcontrol
{
    public partial class Node : UserControl

    {
        public event Refeshpaint Refesh = null;
        public event clicknode clicknode = null;
        List<Panel> Magin = new List<Panel>();
        bool IsSizeableMode;
        bool IsMoveMode;
        private bool isChoose;
        private Color color_old = Color.Gainsboro;
        Point mousePosition;
        public Point MidPoint;
        
        #region Huong
        

        public Size NodeSize
        {
            get => this.Size;
        }
        public Color BorderColor
        {
            get => Lmargin.BackColor;
            set
            {
                foreach (var item in Magin)
                {
                    item.BackColor = value;
                }
            }
        }
        public Color BackGroundColor
        {
            get => lbContent.BackColor;
            set
            {
                lbContent.BackColor = value;
                flowLayoutPanel1.BackColor = value;
            }
        }
        public string Content
        {
            get => lbContent.Text;
            set
            {
                lbContent.Text = value;
            }
        }
        public Font NodeFont
        {
            get => lbContent.Font;
            set
            {
                lbContent.Font = value;
            }
        }

        public bool IsChoose
        {
            get =>this.isChoose ;
            set
            {
                this.isChoose = value;
                if (value == true)
                {
                    for (int i = 0; i < Magin.Count; i++)
                    {
                        Magin[i].Visible = true;
                    }

                }
                else
                {
                    for (int i = 0; i < Magin.Count; i++)
                    {
                        Magin[i].Visible = false;
                    }
                }
            }

        }
        #endregion

        #region hoang
        public Label get_label_of_node
        {
            get => lbContent;
        }
        public Color Color_old
        {
            get => color_old;
            set
            {
                color_old = this.lbContent.BackColor;
            }
        }
        public void setcolor(Color color_set)
        {
            this.lbContent.BackColor = color_set;
            this.flowLayoutPanel1.BackColor = color_set;

        }
        public void setcolor_border(Color color_set)
        {
            foreach (var item in Magin)
            {
                item.BackColor = color_set;
            }
        }
        public void setcolor_text(Color color_set)
        {
            this.lbContent.ForeColor = color_set;
        }
        public void set_font(Font font, FontStyle fontstyle,float fontsize)
        {
            this.lbContent.Font = font;
            this.lbContent.Font = new Font(font.Name, fontsize, fontstyle);
        }
        
        public FontStyle get_font_style(Node node)
        {
            return node.lbContent.Font.Style;
        }
        public void set_style_font_text(FontStyle fontstyle)
        {
            if (fontstyle != FontStyle.Regular)
            {

                this.lbContent.Font = new Font(lbContent.Font, fontstyle);
            }
            else
            {
                this.lbContent.Font = new Font(lbContent.Font, FontStyle.Regular);
            }
        }
        #endregion
        
        
        
        
   
        public Node()
        {
            InitializeComponent();
            Magin.Add(Umargin);
            Magin.Add(Lmargin);
            Magin.Add(Dmargin);
            Magin.Add(Rmargin);
            for (int i = 0; i < Magin.Count; i++)
            {
                Magin[i].MouseDown += Magin_MouseDown;
                Magin[i].MouseMove += Margin_MouseMove;
                Magin[i].MouseUp += Margin_MouseUp;
                Magin[i].Visible = false;
            }
        }
        
        private void Margin_MouseUp(object sender, MouseEventArgs e)
        {
            IsSizeableMode = false;
        }

        private void Margin_MouseMove(object sender, MouseEventArgs e)
        {
            string ResizeWay = (sender as Panel).Tag.ToString();
            if(IsSizeableMode)
            { 
                
                if(this.Height <20)
                {
                    this.Height = 40;
                    IsSizeableMode = false;
                    return;
                }   
                if(this.Width < 10)
                {
                    this.Width = 20;
                    IsSizeableMode = false;
                    return;
                }    
                // nếu Là Rmagin
                if(ResizeWay == "R")
                {
                    // Thay đổi size
                    this.Size = new Size(this.Size.Width + e.X, this.Height);
                }
                // nếu Là Umagin
                if (ResizeWay == "U")
                {
                    
                    this.Top = e.Y + this.Top;
                    this.Size = new Size(this.Size.Width , this.Height - e.Y);
                }
                // nếu Là Lmagin
                if (ResizeWay == "L")
                {
                    if(this.Left>0)
                    {
                        this.Left = e.X + this.Left;
                        this.Size = new Size(this.Size.Width - e.X, this.Height);
                    }
                    else 
                    {
                        this.Left = 1;
                        this.IsSizeableMode = false;    
                    }
                    
                }
                // nếu Là Dmagin
                if (ResizeWay == "D")
                {
                    this.Size = new Size(this.Size.Width, this.Height + e.Y);
                }
                RefeshMidpoint();
                NodeController.Reefeshpaint();
                this.Parent.Refresh();
                


            }    
        }

        private void Magin_MouseDown(object sender, MouseEventArgs e)
        {
            IsSizeableMode = true;
            mousePosition = e.Location;
        }

        private void MoveArea_MouseUp(object sender, MouseEventArgs e)
        {
            IsMoveMode = false;
        }

        private void MoveArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMoveMode)
            {
                if (this.Location.X<0 || this.Location.Y < 0)
                { 
                    IsMoveMode = false;
                    if (this.Location.X < 0)
                        Location = new Point(1,Location.Y);
                    if (this.Location.Y < 0)
                        Location = new Point(Location.X,1 );
                    return;
                }
                else
                {
                    this.Left = e.X + this.Left - mousePosition.X;
                    this.Top = e.Y + this.Top - mousePosition.Y;
                    MidPoint.X = this.Location.X + this.Width / 2;
                    MidPoint.Y = this.Location.Y + this.Height / 2;
                    if (Refesh != null)
                        Refesh(this, new RefeshPaint());
                    if (NodeController.source.Count % 2 == 0)
                        NodeController.Reefeshpaint();
                }
                
                
            }
        }

        private void MoveArea_MouseDown(object sender, MouseEventArgs e)
        {
            mousePosition = e.Location;
            IsMoveMode = true;
            
            
        }
        private void Box_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                (sender as TextBox).Dispose();
            }    
        }

        private void Box_TextChanged(object sender, EventArgs e)
        {
            lbContent.Text = (sender as TextBox).Text;
        }

        private void lbContent_MouseClick(object sender, MouseEventArgs e)
        {


            if (e.Button == MouseButtons.Left)
            {
                NodeController.Selected(this);
                if(clicknode != null)
                    clicknode(this, new Click_node { color_of_node = this.lbContent.BackColor ,color_of_border = this.Lmargin.BackColor,color_of_text= this.lbContent.ForeColor,font_of_text = this.lbContent.Font});
                
            }
            if (e.Button == MouseButtons.Right)
            {
                if (NodeController.source.Count % 2 != 0)
                {
                    contextMenu.Items[0].Text = "Connnect To";
                }
                else
                {
                    contextMenu.Items[0].Text = "Connnect";
                }
                contextMenu.Show(lbContent, e.Location);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < NodeController.source.Count; i++)
                {
                if ((NodeController.source[i] as Node).Tag == this.Tag)
                {
                    if (i % 2 == 0)
                    {
                        NodeController.source.RemoveAt(i);
                        NodeController.source.RemoveAt(i);
                        i = -1;

                    }
                    else
                    {
                        NodeController.source.RemoveAt(i - 1);
                        NodeController.source.RemoveAt(i - 1);
                        i = -1;
                    }
                }
            }
            NodeController.Reefeshpaint();
            if (Refesh != null)
                Refesh(this, new RefeshPaint());



            this.Dispose();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NodeController.Connect(this);
            if(Refesh!= null)
            {
                Refesh(this, new RefeshPaint());
            }    
        }

        private void lbContent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TextBox box = new TextBox()
            {
                Size = this.Size,
                Text = lbContent.Text,

            };
            box.Dock = DockStyle.Fill;
            box.TextChanged += Box_TextChanged;
            box.KeyDown += Box_KeyDown;
            lbContent.Controls.Add(box);
            box.Select();
        }
        public void RefeshMidpoint()
        {
            MidPoint.X = this.Location.X + this.Width / 2;
            MidPoint.Y = this.Location.Y + this.Height / 2;
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            
            lbContent_MouseClick(lbContent, new MouseEventArgs(MouseButtons.Left,1,1,1,1)); // gọi lbcontent
        }

        private void flowLayoutPanel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
