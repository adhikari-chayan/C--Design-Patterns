using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Command
{
    public class UpdateForeColor : ICommand
    {
        public Control UI { get ; set ; }
        public Color Color { get ; set ; }

        public void UpdateColor()
        {
            UI.ForeColor = Color;
        }
    }
}
