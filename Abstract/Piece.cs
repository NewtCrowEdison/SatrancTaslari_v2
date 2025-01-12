using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatrancTaslari_v2.Abstract
{
    internal abstract class Piece
    {
        public abstract string Name { get; set; }
        public abstract string Color { get; set; }
        public abstract void Move();
    }
}
