using MindMap.Models;
using MindMap.View.UCcontrol;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindMap.Controllers
{
    class NodeController
    {
        public static Color colorpaint = Color.Red;
        public static int width = 3;
        public static BindingSource source = new BindingSource();

        public static List<Node> NodesList = new List<Node>();
        public static List<Line> lines = new List<Line>();
        public static void Connect(Node node)
        {
            if (source.Count % 2 == 0)
            {
                source.Add(node);
            }
            else
            {
                source.Add(node);
                Reefeshpaint();


            }
        }
        public static int GetNumTag()
        {
            int id = 0;
            for (int i = 0; i < NodeController.NodesList.Count; i++)
            {
                 if (int.Parse(NodeController.NodesList[i].Tag.ToString()) >= id)
                 {
                        id = int.Parse(NodeController.NodesList[i].Tag.ToString());
                 }
            }
            id++;
            return id;
        }
        public static void Reefeshpaint()
        {
            if (source.Count % 2 == 0)
            {
                lines.Clear();
                for (int i = 0; i < source.Count; i += 2)
                {
                    Line line = new Line();
                    line.Color = colorpaint;
                    line.Width = width;
                    line.BeginPoint = (source[i] as Node).MidPoint;
                    line.EndPoint = (source[i + 1] as Node).MidPoint;
                    lines.Add(line);
                }
            }


        }
        public static void Selected(Node node)
        {
            foreach (var item in NodesList)
            {
                item.IsChoose = false;
                if (item.Tag == node.Tag)
                {
                    item.IsChoose = true;
                }
            }
        }
        public static Node Get_Node_Selected()
        {
            return NodesList.Find(x => x.IsChoose == true);
        }
        public static Node FindNodeWithTag(string Tag)
        {
            return NodesList.Find(x => x.Tag.ToString() == Tag);
        }
    }
}
