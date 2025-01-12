using SatrancTaslari_v2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatrancTaslari_v2.Data
{
    internal class Knight : Piece
    {
        public override string Name { get; set; } = "At";
        public override string Color { get; set; }

        public override void Move()
        {
            Console.WriteLine("L harfi şeklinde ve L harfinin çevrilmiş türevleri olarak ilerleyebilir.");
        }
    }
}
