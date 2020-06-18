using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MindMap.Controllers;

namespace MindMap.View.UCcontrol
{
    public partial class UCIcon : UserControl
    {
        public static List<OvalPictureBox> icons;
        public UCIcon()
        {
            
            InitializeComponent();
            icons = new List<OvalPictureBox>();
            icons.Add(tag_1);
            icons.Add(tag_2);
            icons.Add(tag_3);
            icons.Add(tag_4);
            icons.Add(tag_5);
            icons.Add(tag_6);
            icons.Add(tag_7);
            icons.Add(prior_1);
            icons.Add(prior_2);
            icons.Add(prior_3);
            icons.Add(prior_4);
            icons.Add(prior_5);
            icons.Add(prior_6);
            icons.Add(prior_7);
            icons.Add(mood_1);
            icons.Add(mood_2);
            icons.Add(mood_3);
            icons.Add(mood_4);
            icons.Add(mood_5);
            icons.Add(mood_6);
            icons.Add(mood_7);
            icons.Add(mood_8);
            icons.Add(mood_9);
            icons.Add(mood_10);
            icons.Add(mood_11);
            icons.Add(mood_12);
            icons.Add(mood_13);
            icons.Add(mood_14);
            for (int i = 0; i < icons.Count; i++)
            {
                icons[i].Click += Icon_Click;
                icons[i].Tag = i;

            }
        }

        private void Icon_Click(object sender, EventArgs e)
        {

            OvalPictureBox icon = new OvalPictureBox();
            icon.Size = (sender as OvalPictureBox).Size;
            icon.Image = (sender as OvalPictureBox).Image;
            icon.BackColor = (sender as OvalPictureBox).BackColor;
            icon.BackgroundImage= (sender as OvalPictureBox).BackgroundImage;
            icon.Tag = (sender as OvalPictureBox).Tag;
            icon.DoubleClick += Icon_DoubleClick;
            var a = NodeController.Get_Node_Selected();
            if(a!= null)
            {
                a.flowLayoutPanel1.Controls.Add(icon);
            }
        }

        private void Icon_DoubleClick(object sender, EventArgs e)
        {
            (sender as OvalPictureBox).Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
