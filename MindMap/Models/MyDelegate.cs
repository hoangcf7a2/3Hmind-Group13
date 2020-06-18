using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindMap.Models
{
    public delegate void FireEventFormatButtonClicked(object sender, FormatButton_Clicked e);
    public delegate void ToppicButtonClicked(object sender, ToppicButton_Clicked e);
    public delegate void Refeshpaint(object sender, RefeshPaint e);
    public delegate void IconButtonClicked(object sender, IconButton_Clicked e);
    #region hoang
    public delegate void clicknode(object sender, Click_node e);
    public class Click_node : EventArgs
    {
        public Color color_of_node { get; set; }
        public Color color_of_border { get; set; }
        public Color color_of_text { get; set; }
        public Font font_of_text { get; set; }

    }
    #endregion 

    public class FormatButton_Clicked : EventArgs
    {
        public bool FormatButtonState { get; set; }
    }
    public class ToppicButton_Clicked: EventArgs
    {

    }
    public class RefeshPaint: EventArgs
    {

    }
    public class IconButton_Clicked:EventArgs
    {
        public bool IconButtonState { get; set; }
    }

}
