using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADChapter5_Part_1.Model
{
    class MandolinSpec : InstrumentSpec
    {
        private Style _style;

        public MandolinSpec(Type type, Builder builder, Wood backWood, Wood topWood, string model, Style style)
            : base(type,builder,backWood,topWood,model)
        {
            _style = style;
        }

        public Style GetStyle
        {
            get { return _style; }
        }

        public bool Matches(InstrumentSpec otherSpec)
        {
            if (!base.Matches(otherSpec)) {
                return false;
            }
            if (!(otherSpec is MandolinSpec)){
                return false;
            }
            MandolinSpec mandolinSpec = (MandolinSpec)otherSpec;
            if (_style != mandolinSpec._style)
            {
                return false;
            }
            return true;
        }
    }
}
