using MindMap.Controllers;
using MindMap.Models;
using MindMap.View;
using MindMap.View.UCcontrol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindMap
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            ucFormat1.Width = 0;
            ucIcon1.Width = 0;
            ucMapUser1.Width = 30;
            ucToolBar1.FormatButtonClicked += UcToolBar1_FormatButtonClicked;
            ucToolBar1.toppicButtonClicked += UcToolBar1_toppicButtonClicked;
            ucToolBar1.IconsClicked += UcToolBar1_IconsClicked;
            
            
        }
        private void UcToolBar1_IconsClicked(object sender, IconButton_Clicked e)
        {
            if (e.IconButtonState)
            {
                timeIconSlideIn.Enabled = true;
                timeIconslideOut.Enabled = false;
                timeIconSlideIn.Start();
            }
            else
            {
                timeIconSlideIn.Enabled = false;
                timeIconslideOut.Enabled = true;
                timeIconslideOut.Start();
            }
        }

        private void UcToolBar1_toppicButtonClicked(object sender, Models.ToppicButton_Clicked e)
        {
            Node node = new Node();
            node.Tag = NodeController.GetNumTag();
            Addnode(node);
            
            

        }
        public void SetName(string name)
        {
            ucToolBar1.Username.Text = name;
            if(name == "Guest")
            {
                ucToolBar1.Controls.Find("btnIcon",true).SingleOrDefault().Enabled = false;
                ucToolBar1.Controls.Find("btnFormat",true).SingleOrDefault().Enabled = false;
                ucMapUser1.Dispose();
            }    
        }
        public void Addnode(Node node)
        {
            node.Refesh += Node_Refesh;
            NodeController.NodesList.Add(node);
            node.clicknode += Node_clicknode;
            panelPaint.Controls.Add(node);
        }
        #region Hoang
        private void Node_clicknode(object sender, Click_node e)
        {
            ucFormat1.ColorChoosen.BackColor = e.color_of_node;
            ucFormat1.BorderColorChoosen.BackColor = e.color_of_border;
            ucFormat1.TextColorChoosen.BackColor = e.color_of_text;
            ucFormat1.get_font(e.font_of_text);
            ucFormat1.checkstate_btn_font_style(sender as Node);
            ucFormat1.check_state_align_label(sender as Node);
            ucFormat1.checkstate_isfill((sender as Node).get_label_of_node.BackColor);
        }
        
#endregion 

        private void Node_Refesh(object sender, RefeshPaint e)
        {

            panelPaint.Refresh();
        }

        private void UcToolBar1_FormatButtonClicked(object sender, Models.FormatButton_Clicked e)
        {
            if(e.FormatButtonState)
            {
                timeSlideIn.Enabled = true;
                timeSlideOut.Enabled = false;
                timeSlideIn.Start();
            }   
            else
            {
                timeSlideIn.Enabled = false;
                timeSlideOut.Enabled = true;
                timeSlideOut.Start();
            }    
        }

        private void time_Tick(object sender, EventArgs e)
        {
            if(ucFormat1.Width < 268)
            {
                ucFormat1.Width += 10;
                
            }
            if(ucFormat1.Width > 267)
            {
                ucFormat1.Width = 267;
                timeSlideIn.Stop();
                timeSlideIn.Enabled = false;
            }    
        }

        private void timeSlideOut_Tick(object sender, EventArgs e)
        {
            if (ucFormat1.Width > 0)
            {
                ucFormat1.Width -= 10;

            }
            if (ucFormat1.Width < 0)
            {
                ucFormat1.Width = 0;
                timeSlideOut.Stop();
                timeSlideOut.Enabled = false;
            }
        }
        private void MainPage_Load(object sender, EventArgs e)
        {




        }

        private void timeIconslideOut_Tick(object sender, EventArgs e)
        {
            if (ucIcon1.Width > 0)
            {
                ucIcon1.Width -= 10;

            }
            if (ucIcon1.Width < 0)
            {
                ucIcon1.Width = 0;
                timeIconslideOut.Stop();
                timeIconslideOut.Enabled = false;
            }
        }

        private void timeIconSlideIn_Tick(object sender, EventArgs e)
        {
            if (ucIcon1.Width < 268)
            {
                ucIcon1.Width += 10;

            }
            if (ucIcon1.Width > 267)
            {
                ucIcon1.Width = 267;
                timeIconSlideIn.Stop();
                timeIconSlideIn.Enabled = false;
            }
        }

        private void ucToolBar1_Load(object sender, EventArgs e)
        {

        }

        private void panelPaint_Paint_1(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            var a = NodeController.lines;
            foreach (var item in a)
            {
                item.Draw(e.Graphics);
            }
        }
        public override string ToString()
        {
            return ucToolBar1.Username.Text;
        }

        

        

        
    }
}
