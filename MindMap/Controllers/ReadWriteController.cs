using MindMap.Models;
using MindMap.View.UCcontrol;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace MindMap.Controllers
{
    public class ReadWriteController
    {

        public static void WriteXmlFile(List<Node> source, List<Node> binding, string path)
        {
            using (XmlWriter writer = XmlWriter.Create(path))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Nodes");
                for (int i = 0; i < source.Count; i++)
                {
                    writer.WriteStartElement("Node");
                    writer.WriteAttributeString("Location", source[i].Location.ToString());
                    writer.WriteAttributeString("Size", source[i].NodeSize.ToString());
                    writer.WriteAttributeString("Content", source[i].Content);
                    writer.WriteAttributeString("BackGroundColor", source[i].BackGroundColor.ToArgb().ToString());
                    writer.WriteAttributeString("BorderColor", source[i].BorderColor.ToArgb().ToString());
                    writer.WriteAttributeString("FontName", source[i].get_label_of_node.Font.Name);
                    writer.WriteAttributeString("FontStyle", source[i].get_label_of_node.Font.Style.ToString());
                    writer.WriteAttributeString("FontSize", source[i].get_label_of_node.Font.Size.ToString());
                    writer.WriteAttributeString("FontBold", source[i].get_label_of_node.Font.Bold.ToString());
                    writer.WriteAttributeString("FontItalic", source[i].get_label_of_node.Font.Italic.ToString());
                    writer.WriteAttributeString("FontUnderline", source[i].get_label_of_node.Font.Underline.ToString());
                    writer.WriteAttributeString("TextAli", source[i].get_label_of_node.TextAlign.ToString());
                    writer.WriteAttributeString("Tag", source[i].Tag.ToString());
                    writer.WriteAttributeString("NumIcon", source[i].flowLayoutPanel1.Controls.Count.ToString());
                    for (int j = 0; j < source[i].flowLayoutPanel1.Controls.Count; j++)
                    {
                        var icon = source[i].flowLayoutPanel1.Controls[j];
                        if ( icon is OvalPictureBox)
                        {
                            writer.WriteAttributeString("Icon" + j.ToString(), icon.Tag.ToString());

                        }    
                    }
                    writer.WriteEndElement();
                }
                writer.WriteStartElement("Lines");
                for (int i = 0; i < binding.Count; i++)
                {
                    writer.WriteStartElement("line");
                    writer.WriteAttributeString("NodeTag", binding[i].Tag.ToString());
                    writer.WriteEndElement();
                }
            }

        }
        public static void WriteXmlFile(string Username,List<Node> source, List<Node> binding, string path)
        {
            using (XmlWriter writer = XmlWriter.Create(path))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Nodes");
                for (int i = 0; i < source.Count; i++)
                {
                    writer.WriteStartElement("Node");
                    writer.WriteAttributeString("Location", source[i].Location.ToString());
                    writer.WriteAttributeString("Size", source[i].NodeSize.ToString());
                    writer.WriteAttributeString("Content", source[i].Content);
                    writer.WriteAttributeString("BackGroundColor", source[i].BackGroundColor.ToArgb().ToString());
                    writer.WriteAttributeString("BorderColor", source[i].BorderColor.ToArgb().ToString());
                    writer.WriteAttributeString("FontName", source[i].get_label_of_node.Font.Name);
                    writer.WriteAttributeString("FontStyle", source[i].get_label_of_node.Font.Style.ToString());
                    writer.WriteAttributeString("FontSize", source[i].get_label_of_node.Font.Size.ToString());
                    writer.WriteAttributeString("FontBold", source[i].get_label_of_node.Font.Bold.ToString());
                    writer.WriteAttributeString("FontItalic", source[i].get_label_of_node.Font.Italic.ToString());
                    writer.WriteAttributeString("FontUnderline", source[i].get_label_of_node.Font.Underline.ToString());
                    writer.WriteAttributeString("TextAli", source[i].get_label_of_node.TextAlign.ToString());
                    writer.WriteAttributeString("Tag", source[i].Tag.ToString());
                    writer.WriteAttributeString("NumIcon", source[i].flowLayoutPanel1.Controls.Count.ToString());
                    for (int j = 0; j < source[i].flowLayoutPanel1.Controls.Count; j++)
                    {
                        var icon = source[i].flowLayoutPanel1.Controls[j];
                        if (icon is OvalPictureBox)
                        {
                            writer.WriteAttributeString("Icon" + j.ToString(), icon.Tag.ToString());

                        }
                    }
                    writer.WriteEndElement();
                }
                writer.WriteStartElement("Lines");
                for (int i = 0; i < binding.Count; i++)
                {
                    writer.WriteStartElement("line");
                    writer.WriteAttributeString("NodeTag", binding[i].Tag.ToString());
                    writer.WriteEndElement();
                }
            }
            string filename = "";
            for (int i = path.Length-5; i > 0 ; i--)
            {
                if (path[i] != '\\')
                {
                    filename += path[i];
                }
                else
                    break;
            }
            var a = filename.ToCharArray();
            Array.Reverse(a);
            filename = new string(a);
            SaveIndatabase(Username,filename,path);

        }
        public static void ReadXmlFile(Control control, string path)
        {
            
            using (XmlReader reader = XmlReader.Create(path))
            {
                while(reader.Read())
                {
                    
                    if(reader.Name == "Node" && reader.IsStartElement())
                    {
                        Node node = new Node();
                        node.Location = ConvertStringtoPoint(reader.GetAttribute("Location"));
                        node.Size = ConvertStringToSize(reader.GetAttribute("Size"));
                        node.RefeshMidpoint();
                        node.Content = reader.GetAttribute("Content");
                        node.BackGroundColor = Color.FromArgb(int.Parse(reader.GetAttribute("BackGroundColor")));
                        node.BorderColor = Color.FromArgb(int.Parse(reader.GetAttribute("BorderColor")));
                        Font font = new Font(reader.GetAttribute("FontName"), float.Parse(reader.GetAttribute("FontSize")));
                        bool bold = reader.GetAttribute("FontBold") == "True" ? true : false;
                        bool Italic = reader.GetAttribute("FontItalic") == "True" ? true : false;
                        bool Underline = reader.GetAttribute("FontUnderline") == "True" ? true : false;
                        FontStyle style = font.Style;
                        if (bold)
                            style |= FontStyle.Bold;
                        if (Italic)
                            style |= FontStyle.Italic;
                        if (Underline)
                            style |= FontStyle.Underline;
                        node.NodeFont = new Font(font,style);
                        var textAli = reader.GetAttribute("TextAli");
                        if (textAli == ContentAlignment.TopCenter.ToString())
                        {
                            node.get_label_of_node.TextAlign = ContentAlignment.TopCenter;
                        }    
                        else if(textAli == ContentAlignment.TopLeft.ToString())
                        {
                            node.get_label_of_node.TextAlign = ContentAlignment.TopLeft;
                        }
                        else
                        {
                            node.get_label_of_node.TextAlign = ContentAlignment.TopRight;
                        }             
                        node.Tag = reader.GetAttribute("Tag");
                        int num = int.Parse(reader.GetAttribute("NumIcon"));
                        for (int i = 1; i < num; i++)
                        {
                            var a = UCIcon.icons.Find(x => x.Tag.ToString() == reader.GetAttribute("Icon"+i.ToString()));
                            OvalPictureBox box = new OvalPictureBox();
                            box.Size = a.Size;
                            box.Image = a.Image;
                            box.BackColor = a.BackColor;
                            box.BackgroundImage = a.BackgroundImage;
                            box.Tag = a.Tag;
                            box.DoubleClick += Box_DoubleClick;
                            node.flowLayoutPanel1.Controls.Add(box);
                        }
                        (control.Parent as MainPage).Addnode(node);
                    }
                    if(reader.Name == "line" && reader.IsStartElement())
                    {
                        var line = NodeController.FindNodeWithTag(reader.GetAttribute("NodeTag"));
                        NodeController.source.Add(line);
                    }    
                }
                NodeController.Reefeshpaint();
                (control.Parent as MainPage).Controls.Find("panelPaint", true).SingleOrDefault().Refresh();


            }                
        }

        public static void ReadXmlFile(Control control, TextReader text)
        {

            using (XmlReader reader = XmlReader.Create(text))
            {
                while (reader.Read())
                {

                    if (reader.Name == "Node" && reader.IsStartElement())
                    {
                        Node node = new Node();
                        node.Location = ConvertStringtoPoint(reader.GetAttribute("Location"));
                        node.Size = ConvertStringToSize(reader.GetAttribute("Size"));
                        node.RefeshMidpoint();
                        node.Content = reader.GetAttribute("Content");
                        node.BackGroundColor = Color.FromArgb(int.Parse(reader.GetAttribute("BackGroundColor")));
                        node.BorderColor = Color.FromArgb(int.Parse(reader.GetAttribute("BorderColor")));
                        Font font = new Font(reader.GetAttribute("FontName"), float.Parse(reader.GetAttribute("FontSize")));
                        bool bold = reader.GetAttribute("FontBold") == "True" ? true : false;
                        bool Italic = reader.GetAttribute("FontItalic") == "True" ? true : false;
                        bool Underline = reader.GetAttribute("FontUnderline") == "True" ? true : false;
                        FontStyle style = font.Style;
                        if (bold)
                            style |= FontStyle.Bold;
                        if (Italic)
                            style |= FontStyle.Italic;
                        if (Underline)
                            style |= FontStyle.Underline;
                        node.NodeFont = new Font(font, style);
                        var textAli = reader.GetAttribute("TextAli");
                        if (textAli == ContentAlignment.TopCenter.ToString())
                        {
                            node.get_label_of_node.TextAlign = ContentAlignment.TopCenter;
                        }
                        else if (textAli == ContentAlignment.TopLeft.ToString())
                        {
                            node.get_label_of_node.TextAlign = ContentAlignment.TopLeft;
                        }
                        else
                        {
                            node.get_label_of_node.TextAlign = ContentAlignment.TopRight;
                        }
                        node.Tag = reader.GetAttribute("Tag");
                        int num = int.Parse(reader.GetAttribute("NumIcon"));
                        for (int i = 1; i < num; i++)
                        {
                            var a = UCIcon.icons.Find(x => x.Tag.ToString() == reader.GetAttribute("Icon" + i.ToString()));
                            OvalPictureBox box = new OvalPictureBox();
                            box.Size = a.Size;
                            box.Image = a.Image;
                            box.BackColor = a.BackColor;
                            box.BackgroundImage = a.BackgroundImage;
                            box.Tag = a.Tag;
                            box.DoubleClick += Box_DoubleClick;
                            node.flowLayoutPanel1.Controls.Add(box);
                        }
                        (control.Parent as MainPage).Addnode(node);
                    }
                    if (reader.Name == "line" && reader.IsStartElement())
                    {
                        var line = NodeController.FindNodeWithTag(reader.GetAttribute("NodeTag"));
                        NodeController.source.Add(line);
                    }
                }
                NodeController.Reefeshpaint();
                (control.Parent as MainPage).Controls.Find("panelPaint", true).SingleOrDefault().Refresh();


            }
        }

        public static void SaveIndatabase(string Username,string filename,string path)
        {
            using (HmindMapEntities db = new HmindMapEntities())
            {
                string a = "";
                using (StreamReader reader = new StreamReader(path, Encoding.UTF8))
                {
                    a = reader.ReadToEnd();

                }
                MapUser map = new MapUser() { MapName = filename, Content = a,Username = Username};
                db.MapUsers.AddOrUpdate(map);
                db.SaveChanges();
            }
        }
        public static void GetMapMapUser(string Username)
        {
            using (HmindMapEntities db = new HmindMapEntities())
            {
                var a = db.Users.Find(Username).MapUsers.ToList();
            }
        }
        public static void LoadMap(Control control, string Xml)
        {
            //string a = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Nodes><Node Location=\"{X=283,Y=67}\" Size=\"{Width=210, Height=77}\" Content=\"Input Text\" BackGroundColor=\"-2302756\" BorderColor=\"-16777216\" FontName=\"Arial\" FontStyle=\"Regular\" FontSize=\"10\" FontBold=\"False\" FontItalic=\"False\" FontUnderline=\"False\" TextAli=\"TopCenter\" Tag=\"1\"><Icon TagIcon=\"0\" /><Icon TagIcon=\"14\" /></Node><Node Location=\"{X=222,Y=298}\" Size=\"{Width=210, Height=77}\" Content=\"Input Text\" BackGroundColor=\"-2302756\" BorderColor=\"-16777216\" FontName=\"Arial\" FontStyle=\"Regular\" FontSize=\"10\" FontBold=\"False\" FontItalic=\"False\" FontUnderline=\"False\" TextAli=\"TopCenter\" Tag=\"2\"><Icon TagIcon=\"21\" /></Node><Node Location=\"{X=0,Y=0}\" Size=\"{Width=210, Height=77}\" Content=\"Input Text\" BackGroundColor=\"-2302756\" BorderColor=\"-16777216\" FontName=\"Arial\" FontStyle=\"Regular\" FontSize=\"10\" FontBold=\"False\" FontItalic=\"False\" FontUnderline=\"False\" TextAli=\"TopCenter\" Tag=\"3\" /><Lines><line NodeTag=\"2\" /><line NodeTag=\"1\" /><line NodeTag=\"3\" /><line NodeTag=\"2\" /></Lines></Nodes>";
            using(TextReader r = new StringReader(Xml))
            {
                ReadXmlFile(control, r);
            }    
            
        }

        private static void Box_DoubleClick(object sender, EventArgs e)
        {
            (sender as OvalPictureBox).Dispose();
        }

        private static Point ConvertStringtoPoint(string rawPoint)
        {
            var a = rawPoint.Split(',');
            int x = int.Parse(a[0].Substring(3));
            int y = int.Parse(a[1].Substring(2, a[1].Length - 3));
            return new Point(x, y);
        }
        private static Size ConvertStringToSize(string rawSize)
        {
            var a = rawSize.Split(',');
            int Width = int.Parse(a[0].Substring(7));
            int Height = int.Parse(a[1].Substring(8,a[1].Length-9));
            return new Size(Width, Height);
        }
        
    }
}
