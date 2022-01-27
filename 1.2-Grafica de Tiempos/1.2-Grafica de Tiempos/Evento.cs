using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_Grafica_de_Tiempos
{
    internal class Evento
    {
        //                            if (evento.ToString() == "Evento/Ignición OFF")
        //DibujarForma(Convert.ToDouble(Minuto), Hora, Segundo, "OFF", 2.5, Brushes.Gray, Brushes.White, lstEventos.IndexOf(evento));
        public string Titulo { get; set; }
        public string Etiqueta { get; set; }
        public string Codigo { get; set; }
        public Brush ColorRelleno { get; set; }
        public Brush ColorLetra { get; set; }
        public int TamanoLetra { get; set; }
        public Evento(string Titulo,string Etiqueta, string Codigo, Brush ColorRelleno, Brush ColorLetra, int TamanoLetra) { 
            this.Titulo = Titulo;   
            this.Etiqueta = Etiqueta;
            this.ColorRelleno = ColorRelleno;
            this.ColorLetra = ColorLetra;   
            this.TamanoLetra  = TamanoLetra; 
            this.Codigo = Codigo;
        }
        
    }
}
