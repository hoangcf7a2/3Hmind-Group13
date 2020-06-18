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
    public partial class UCFormat : UserControl
    {
        public event clicknode click_colorchoosen = null;
        

        public UCFormat()
        {
            InitializeComponent();
        }

        
        private void btnStyle_Click(object sender, EventArgs e)
        {
            btnStyle.BackColor = Color.FromArgb(6, 114, 229);
            btnMap.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            btnMap.BackColor = Color.FromArgb(6, 114, 229);
            btnStyle.BackColor = Color.FromArgb(240, 240, 240);
        }
        #region hoang
        private void label1_Click(object sender, EventArgs e) // label 1 la color cua border
        {
            var a = colorDialog1.ShowDialog(); 
            if (a == DialogResult.OK)
            {
                (sender as Label).BackColor = colorDialog1.Color;
            }
            var b = NodeController.Get_Node_Selected();
            if(b!= null)
            {
                b.setcolor((sender as Label).BackColor);
                b.Color_old = (sender as Label).BackColor;
            }    
        }

        private void BorderColorChoosen_Click(object sender, EventArgs e)
        {
            var a = colorDialog1.ShowDialog();
            if (a == DialogResult.OK)
            {
                (sender as Label).BackColor = colorDialog1.Color;
                
            }
            var b = NodeController.Get_Node_Selected();
            if(b!=null)
                b.setcolor_border((sender as Label).BackColor);
        }

        private void TextColorChoosen_Click(object sender, EventArgs e)
        {
            var a = colorDialog1.ShowDialog();
            if (a == DialogResult.OK)
            {
                (sender as Label).BackColor = colorDialog1.Color;
            }
            var b = NodeController.Get_Node_Selected();
            if(b!=null)
            b.setcolor_text((sender as Label).BackColor);
        }

        private void LineColorChoosen_Click(object sender, EventArgs e)
        {
            var a = colorDialog1.ShowDialog();
            if (a == DialogResult.OK)
            {
                (sender as Label).BackColor = colorDialog1.Color;
                NodeController.colorpaint = colorDialog1.Color;
                NodeController.Reefeshpaint();
                this.Parent.Controls.Find("PanelPaint",true).SingleOrDefault().Refresh();
            }
        }
        private void FontFamily_Click(object sender, EventArgs e)
        {
            var a = fontDialog1.ShowDialog();
            if (a == DialogResult.OK)
            {
                (sender as TextBox).Text = fontDialog1.Font.FontFamily.Name;
                var b = NodeController.Get_Node_Selected();
                if (b != null)
                {
                    var c = fontDialog1.Font;
                    b.NodeFont = c;
                    TextSize.Value = decimal.Parse(fontDialog1.Font.Size.ToString());
                }
            }
            
        }
        public void get_font(Font font)
        {
            FontFamily.Text = font.Name;
            fontDialog1.Font = font;
            TextSize.Value = decimal.Parse(font.Size.ToString());
        }
        private void IsFill_CheckedChanged(object sender, EventArgs e)
        {
                if (this.IsFill.Checked)
                {
                    this.ColorChoosen.Visible = true;
                    var a = NodeController.Get_Node_Selected();
                    if (a != null)
                    {
                        a.setcolor(a.Color_old);
                        this.ColorChoosen.BackColor = a.Color_old;

                       // click_isfill(this, new Click_node { color_of_node = this.ColorChoosen.BackColor });
                    }
                }
                else
                {
                    this.ColorChoosen.Visible = false;
                    var a = NodeController.Get_Node_Selected();
                    if (a != null)
                    {
                        a.setcolor(Color.Gainsboro);
                       // click_isfill(this, new Click_node { color_of_node = this.ColorChoosen.BackColor });
                    }

                }
            
        }
        public void checkstate_isfill(Color color)
        {
            if(color == Color.Gainsboro)
            {
                IsFill.Checked = false;
            }
            else
            {
                IsFill.Checked = true;
            }
        }
        private void TextSize_ValueChanged(object sender, EventArgs e)
        {
            var a = NodeController.Get_Node_Selected();
            a.set_font(fontDialog1.Font,fontDialog1.Font.Style, float.Parse(TextSize.Value.ToString()));
            fontDialog1.Font = new Font(fontDialog1.Font.Name, float.Parse(TextSize.Value.ToString()),fontDialog1.Font.Style);
        }

        private void btnBold_Click(object sender, EventArgs e)// tìm node đã selected, nếu node đó 
        {

            var a = NodeController.Get_Node_Selected();
            if (a != null)
            {
                var b = a.get_font_style(a);
                if (b.HasFlag(FontStyle.Bold) == false)
                {
                    btnBold.BackColor =  Color.Silver;
                    b |= FontStyle.Bold;
                }
                else
                {
                    btnBold.BackColor = Color.White;
                    b = b & ~FontStyle.Bold; // & ~ : & là lấy chung giữa 2 thằng , ~ là không lấy , tức là ở đây lấy chung list thuộc tính của B với list thuộc tính không chứa bold
                }
                a.set_style_font_text(b);
                var c = a.NodeFont;
                fontDialog1.Font = new Font(c.Name, c.Size, c.Style);
            }
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            var a = NodeController.Get_Node_Selected();
            if (a != null)
            {
                var b = a.get_font_style(a);
                if (b.HasFlag(FontStyle.Italic) == false)
                {
                    btnItalic.BackColor = Color.Silver;
                    b |= FontStyle.Italic;
                }
                else
                {
                    btnItalic.BackColor = Color.White; 
                    b = b & ~FontStyle.Italic;
                }
                a.set_style_font_text(b);
                var c = a.NodeFont;
                fontDialog1.Font = new Font(c.Name, c.Size, c.Style);
            }
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            var a = NodeController.Get_Node_Selected();
            if (a != null)
            {
                var b = a.get_font_style(a);
                if (b.HasFlag(FontStyle.Underline) == false)
                {
                    btnUnderline.BackColor = Color.Silver;
                    b |= FontStyle.Underline;

                }
                else
                {
                    btnUnderline.BackColor = Color.White;
                    b = b & ~FontStyle.Underline;
                }
                a.set_style_font_text(b);
                var c = a.NodeFont;
                fontDialog1.Font = new Font(c.Name, c.Size, c.Style);
            }
        }
        public void checkstate_btn_font_style(Node node)
        {
            var b = node.get_font_style(node);
            if (b.HasFlag(FontStyle.Bold) == true)
            {
                btnBold.BackColor = Color.Silver;
            }
            else btnBold.BackColor = Color.White;
            if (b.HasFlag(FontStyle.Italic) == true)
            {
                btnItalic.BackColor = Color.Silver;
            }
            else
                btnItalic.BackColor = Color.White;
            if (b.HasFlag(FontStyle.Underline) == true)
                btnUnderline.BackColor = Color.Silver;
            else
                btnUnderline.BackColor = Color.White;
        }
        #endregion

        private void btn_align_left_Click(object sender, EventArgs e)
        {
            var a = NodeController.Get_Node_Selected();
            if(a!=null)
            a.get_label_of_node.TextAlign = ContentAlignment.TopLeft;
            btn_align_left.BackColor = Color.Silver;
            btn_align_right.BackColor = Color.White;
            btn_align_center.BackColor = Color.White;
        }

        private void btn_align_center_Click(object sender, EventArgs e)
        {
            var a = NodeController.Get_Node_Selected();
            if(a!=null)
            a.get_label_of_node.TextAlign = ContentAlignment.TopCenter;
            btn_align_left.BackColor = Color.White;
            btn_align_right.BackColor = Color.White;
            btn_align_center.BackColor = Color.Silver;

        }

        private void btn_align_right_Click(object sender, EventArgs e)
        {
            var a = NodeController.Get_Node_Selected();
            if(a!=null)
            a.get_label_of_node.TextAlign = ContentAlignment.TopRight;
            btn_align_left.BackColor = Color.White;
            btn_align_right.BackColor = Color.Silver;
            btn_align_center.BackColor = Color.White;
        }
        public void check_state_align_label(Node node)
        {
            if(node.get_label_of_node.TextAlign == ContentAlignment.TopLeft)
            {
                btn_align_left.BackColor = Color.Silver;
            }
            else
                btn_align_left.BackColor = Color.White;
            if(node.get_label_of_node.TextAlign == ContentAlignment.TopCenter)
            {
                btn_align_center.BackColor = Color.Silver;
            }
            else
                btn_align_center.BackColor = Color.White;
            if (node.get_label_of_node.TextAlign == ContentAlignment.TopRight)
            {
                btn_align_right.BackColor = Color.Silver;
            }
            else
                btn_align_right.BackColor = Color.White;

        }

        private void NumLineWidth_ValueChanged(object sender, EventArgs e)
        {
            NodeController.width = int.Parse(NumLineWidth.Value.ToString());
            NodeController.Reefeshpaint();
            this.Parent.Controls.Find("PanelPaint", true).SingleOrDefault().Refresh();
        }
    }
}
