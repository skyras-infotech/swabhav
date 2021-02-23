using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADChapter5_Part_1.Model
{
    class GuitarSpec : InstrumentSpec
    {
        private int _numStrings;

        public GuitarSpec(Type type, Builder builder, Wood backWood, Wood topWood, string model, int numStrings)
            : base(type,builder,backWood,topWood,model)
        {
          
            _numStrings = numStrings;
        }

        public int NumStrings
        {
            get { return _numStrings; }
        }

        public bool Matches(InstrumentSpec otherSpec)
        {
            if (!base.Matches(otherSpec)) {
                return false;
            }
            if (!(otherSpec is GuitarSpec)){
                return false;
            }
            GuitarSpec guitarSpec = (GuitarSpec)otherSpec;
            if (_numStrings != guitarSpec._numStrings)
            {
                return false;
            }
            return true;
        }
    }
}
