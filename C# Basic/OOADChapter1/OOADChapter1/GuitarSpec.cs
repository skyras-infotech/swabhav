using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADChapter1
{
    class GuitarSpec
    {
        private Type type;
        private Builder builder;
        private Wood backWood, topWood;
        private string model;
        private int numStrings;

        public GuitarSpec(Type type, Builder builder, Wood backWood, Wood topWood, string model,int numStrings)
        {
            this.type = type;
            this.builder = builder;
            this.backWood = backWood;
            this.topWood = topWood;
            this.model = model;
            this.numStrings = numStrings;
        }

        public int NumStrings
        {
            get { return numStrings; }
        }

        public Builder GetBuilder
        {
            get { return builder; }
        }
        public string Model
        {
            get { return model; }
        }
        public Type GetType
        {
            get { return type; }
        }

        public Wood BackWood
        {
            get { return backWood; }
        }
        public Wood TopWood
        {
            get { return topWood; }
        }

        public bool Matches(GuitarSpec otherSpec)
        {
            if (builder != otherSpec.builder)
                return false;
            if ((model != null) && (!model.Equals("")) && (!model.Equals(otherSpec.model)))
                return false;
            if (type != otherSpec.type)
                return false;
            if (numStrings != otherSpec.numStrings)
                return false;
            if (backWood != otherSpec.backWood)
                return false;
            if (topWood != otherSpec.topWood)
                return false;
            return true;
        }
    }


}
