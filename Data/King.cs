using SatrancTaslari_v2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatrancTaslari_v2.Data
{
    internal class King : Piece
    {
        public override string Name { get; set; } = "Şah";
        public override string Color { get; set; }

        public override void Move()
        {
            Console.WriteLine("Sadece bir birim. İleri, geri, sağ, sol veya çapraz.");
        }
    }
}
