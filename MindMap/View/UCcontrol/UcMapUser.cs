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
    public partial class UcMapUser : UserControl
    {
        private List<MapUser> MapUsers; 
        private Button CurrentButton;
        public UcMapUser()
        {
            InitializeComponent();
            LoadButton();
        }
        public void LoadButton()
        {
            panelUser.Controls.Clear();
            MapUsers = UserController.GetMapUsers();
            int num = MapUsers != null ? MapUsers.Count : 0;
            for (int i = 0; i < num; i++)
            {
                Button button = new Button() { FlatAppearance = { BorderSize = 0 } };
                button.FlatStyle = FlatStyle.Flat;
                button.BackColor = Color.DodgerBlue;
                button.TabStop = false;
                button.Text = MapUsers[i].MapName;
                button.Tag = MapUsers[i].Content;
                button.Size = new Size(122, 35);
                button.MouseClick += Button_MouseClick;
                button.MouseDown += Button_MouseDown;
                button.MouseEnter += Button_MouseEnter;
                button.MouseLeave += Button_MouseLeave;
                
                panelUser.Controls.Add(button);
                
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            panelUser_MouseLeave(panelUser, e);
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            panelUser_MouseEnter(panelUser, e);
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button== MouseButtons.Right)
            {
                contextMenu.Show(sender as Button, e.Location);
                CurrentButton = sender as Button;
            }
        }

        private void Button_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                var a = MessageBox.Show("Are you sure to clear your data", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (a == DialogResult.OK)
                {
                    NodeController.NodesList.Clear();
                    NodeController.source.Clear();
                    NodeController.Reefeshpaint();
                    Parent.Controls.Find("panelPaint", true).SingleOrDefault().Controls.Clear();
                    Parent.Controls.Find("panelPaint", true).SingleOrDefault().Refresh();
                    ReadWriteController.LoadMap(this, (sender as Button).Tag.ToString());
                }
                
            }    
        }

        private void LoadMap_Click(object sender, EventArgs e)
        {
            
           
        }

        private void updateMap_Click(object sender, EventArgs e)
        {

        }

        private void deleteMap_Click(object sender, EventArgs e)
        {
            var a = MessageBox.Show("Are you sure to clear your data", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(a == DialogResult.OK)
            {
                UserController.DeletedMap(CurrentButton.Text);
                CurrentButton.Dispose();
            }    
            
        }

        private void panelUser_MouseEnter(object sender, EventArgs e)
        {
            this.Width = 128;
        }

        private void panelUser_MouseLeave(object sender, EventArgs e)
        {
            this.Width = 30;
        }
    }
}
