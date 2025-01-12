using SatrancTaslari_v2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatrancTaslari_v2.Data
{
    internal class Pawn : Piece
    {
        public override string Name { get; set; } = "Piyon";
        public override string Color { get; set; }

        public override void Move()
        {
            Console.WriteLine("Başlangıçta 2 ileri veya 1 ileri sonra hep 1 ileri.");
        }
        public void Promote ()
        {
            Console.WriteLine("Piyon karşı tarafa ulaştı. Terfiye etmek istediğiniz taşı seçiniz.\n1.Kale\n2.At\n3.Fil\n4.Vezir");
        }
    }
}
