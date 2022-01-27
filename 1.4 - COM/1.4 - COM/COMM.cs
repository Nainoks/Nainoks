using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4___COM
{
    public class COMM
    {
        public string Puerto { get; set; }
        public int BaudRate { get; set; }
        public int DataBits { get; set; }
        public Parity Parity { get; set; }
        public StopBits StopBits { get; set; }
        public Handshake Handshake { get; set; }

        public COMM() {
            Puerto = "<None>";
            BaudRate = 600;
            DataBits = 7;
            Parity = Parity.None;
            StopBits = StopBits.None;
            Handshake = Handshake.None;

        }


    }
}
