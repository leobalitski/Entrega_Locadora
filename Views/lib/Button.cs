using System;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public class Button : System.Windows.Forms.Button
    {

        public Button()
        {
            this.Size = new Size(200, 25);
            this.BackColor = Color.DarkGray;
            this.ForeColor = Color.Black;
        }
    }
}