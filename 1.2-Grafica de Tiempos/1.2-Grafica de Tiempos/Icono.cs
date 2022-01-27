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
        public double Longitud { get; set; }
        public double Latitud { get; set; }
        public Icono(int X,int Y, Evento Evento, DateTime FechaHora,string code, double Longitud, double Latitud) { 
            this.X = X;
            this.Y = Y; 
            this.Evento = Evento;
            this.FechaHora = FechaHora;
            this.code = code;
            this.Longitud = Longitud;
            this.Latitud = Latitud;
        }
        public Icono(DateTime FechaHora,string code) { 
            this.code=code;
            this.FechaHora=FechaHora;

        }
        public Icono( Evento Evento, DateTime Fechahora, string code) { 
            this.Evento=Evento;
            this.FechaHora = Fechahora;
            this.code = code;
        }
    }
}
