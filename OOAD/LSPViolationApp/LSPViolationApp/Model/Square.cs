using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPViolationApp.Model
{
    class Square : Rectangle
    {
        private int side;
        public Square(int side) : base(side,side)
        {
            Length = side;
            Height = side;
        }

        public override int Length { get => this.side; set => this.side = value; }
       // public override int Length { get => base.Length; set => base.Length = value; }
        public override int Height { get => this.side; set => this.side = value; }
       // public override int Height { get => base.Height; set => base.Height = value; }
    }
}
