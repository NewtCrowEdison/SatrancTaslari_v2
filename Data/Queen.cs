using SatrancTaslari_v2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatrancTaslari_v2.Data
{
    internal class Queen : Piece
    {
        public override string Name { get; set; } = "Vezir";
        public override string Color { get; set; }

        public override void Move()
        {
            Console.WriteLine("İleri, geri, sağ, sol ve çapraz. Birim sınırı yok.");
        }
    }
}
