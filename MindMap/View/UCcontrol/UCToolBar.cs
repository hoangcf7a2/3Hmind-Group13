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

    
    public partial class UCToolBar : UserControl
    {
        public event FireEventFormatButtonClicked FormatButtonClicked = null;
        public event ToppicButtonClicked toppicButtonClicked = null;
        public event IconButtonClicked IconsClicked = null;
        Point MouseLocation;
        bool IsMouseDown = false;
        bool IsClickIconbtn = false;
        bool IsClickFormatbtn = false;

        public UCToolBar()
        {
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            (this.Parent as Form).WindowState = FormWindowState.Minimized;
        }

        private void btnMinOrMaximize_Click(object sender, EventArgs e)
        {
            if((this.Parent as Form).WindowState == FormWindowState.Normal)
            {
                (this.Parent as Form).WindowState = FormWindowState.Maximized;
            }
            else
                (this.Parent as Form).WindowState = FormWindowState.Normal;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.OpenForms["LoginForm"].Close();
            (this.Parent as Form).Close();
        }

        private void UCToolBar_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;
            MouseLocation = e.Location;
        }

        private void UCToolBar_MouseMove(object sender, MouseEventArgs e)
        {
            if( IsMouseDown == true)
            {
                (this.Parent as Form).SetDesktopLocation(MousePosition.X - MouseLocation.X, MousePosition.Y - MouseLocation.Y);
            }
        }

        private void UCToolBar_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
        }

        private void btnIcon_Click(object sender, EventArgs e)
        {
            IsClickIconbtn = !IsClickIconbtn;
            IsClickFormatbtn = false;
            if ( IsClickIconbtn)
            {
                btnIcon.BackColor = Color.FromArgb(222, 222, 222);
                btnFormat.BackColor = Color.White;
            }
            else
            {
                btnIcon.BackColor = Color.White;
            }
            if (IconsClicked != null)
                IconsClicked(this, new IconButton_Clicked() { IconButtonState = IsClickIconbtn});

        }
        private void btnFormat_Click(object sender, EventArgs e)
        {
            IsClickFormatbtn = !IsClickFormatbtn;
            IsClickIconbtn = false;
            if (IsClickFormatbtn)
            {
                btnFormat.BackColor = Color.FromArgb(222, 222, 222);
                btnIcon.BackColor = Color.White;
            }
            else
            {
                btnFormat.BackColor = Color.White;
            }
            if(FormatButtonClicked != null )
            {
                FormatButtonClicked(this, new FormatButton_Clicked { FormatButtonState = IsClickFormatbtn });
            }    


        }

        private void btnTopic_Click(object sender, EventArgs e)
        {
            if(toppicButtonClicked != null)
            {
                toppicButtonClicked(this, new ToppicButton_Clicked());
            }    
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            

            
            
        }

        private void btnBoundary_Click(object sender, EventArgs e)
        {
            
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile.Filter = "XML File|*.xml";
            var a = saveFile.ShowDialog();
            if (a == DialogResult.OK)
            {
                if (Username.Text != "Guest")
                {
                    ReadWriteController.WriteXmlFile(Username.Text, NodeController.NodesList, NodeController.source.Cast<Node>().ToList(), saveFile.FileName);
                    (Parent.Controls.Find("ucMapUser1", true).SingleOrDefault() as UcMapUser).LoadButton();
                }
                else
                    ReadWriteController.WriteXmlFile(NodeController.NodesList, NodeController.source.Cast<Node>().ToList(), saveFile.FileName);
                     
                    


            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile.Filter = "XML File|*.xml";
            var a = openFile.ShowDialog();
            if(a == DialogResult.OK)
            {
                //var b = MessageBox.Show("This Action Will Clear Your Data If You Dont Save Yet ", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                //if (b == DialogResult.OK)
                //{
                //    NodeController.NodesList.Clear();
                //    NodeController.source.Clear();
                //    NodeController.Reefeshpaint();
                //    Parent.Controls.Find("panelPaint", true).SingleOrDefault().Controls.Clear();
                //    Parent.Controls.Find("panelPaint", true).SingleOrDefault().Refresh();
                    ReadWriteController.ReadXmlFile(this, openFile.FileName);
                //}
                
            }    
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = MessageBox.Show("Are you sure to clear your data","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if(a == DialogResult.OK)
            {
                NodeController.NodesList.Clear();
                NodeController.source.Clear();
                NodeController.Reefeshpaint();
                Parent.Controls.Find("panelPaint", true).SingleOrDefault().Controls.Clear();
                Parent.Controls.Find("panelPaint", true).SingleOrDefault().Refresh();
            }    
            
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSubtopic_Click(object sender, EventArgs e)
        {
            var a = NodeController.Get_Node_Selected();
            if(a != null)
            {
                Node node = new Node();
                node.Location = new Point(a.Location.X + a.Width + 50, a.Location.Y);
                node.RefeshMidpoint();
                node.Tag = NodeController.GetNumTag();
                (Parent as MainPage).Addnode(node);
                NodeController.Connect(a);
                NodeController.Connect(node);
                NodeController.Reefeshpaint();
                (Parent as MainPage).Controls.Find("panelPaint", true).SingleOrDefault().Refresh();

            }    
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                contextMenu.Show(pictureBox2, e.Location);
            }    
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parent.Dispose();
            Application.OpenForms["LoginForm"].Show();

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                contextMenu.Show(pictureBox2, e.Location);
            }
        }
    }
}
