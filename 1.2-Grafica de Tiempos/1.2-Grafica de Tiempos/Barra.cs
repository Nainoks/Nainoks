using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_Grafica_de_Tiempos
{
    internal class Barra
    {
        public Rectangle Rectangulo { get; set; }
        public Brush Color { get; set; }
        public Barra(Rectangle Rectangulo, Brush Color)
        {
            this.Rectangulo = Rectangulo;   
            this.Color = Color;
        }
    }
}
