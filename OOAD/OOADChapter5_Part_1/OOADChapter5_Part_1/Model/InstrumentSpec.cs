using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADChapter5_Part_1.Model
{
    abstract class InstrumentSpec
    {
        private Type _type;
        private Builder _builder;
        private Wood _backWood, _topWood;
        private string _model;

        protected InstrumentSpec(Type type, Builder builder, Wood backWood, Wood topWood, string model)
        {
            _type = type;
            _builder = builder;
            _backWood = backWood;
            _topWood = topWood;
            _model = model;
        }

        public Builder GetBuilder
        {
            get { return _builder; }
        }
        public string Model
        {
            get { return _model; }
        }
        public Type GetInsType
        {
            get { return _type; }
        }

        public Wood BackWood
        {
            get { return _backWood; }
        }
        public Wood TopWood
        {
            get { return _topWood; }
        }

        public bool Matches(InstrumentSpec otherSpec)
        {
            if (_builder != otherSpec._builder)
                return false;
            if ((_model != null) && (!_model.Equals("")) && (!_model.Equals(otherSpec._model)))
                return false;
            if (_type != otherSpec._type)
                return false;
            if (_backWood != otherSpec._backWood)
                return false;
            if (_topWood != otherSpec._topWood)
                return false;
            return true;
        }
    }
}
