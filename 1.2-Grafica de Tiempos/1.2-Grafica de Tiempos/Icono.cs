using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_Grafica_de_Tiempos
{
    internal class Icono
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Evento Evento { get; set; }
        public DateTime FechaHora { get; set; }
        public string code { get; set; }

        public Icono(int X,int Y, Evento Icono,DateTime FechaHora,string code) { 
            this.X = X;
            this.Y = Y; 
            this.Evento = Icono;
            this.FechaHora = FechaHora;
            this.code = code;
        }
    }
}
