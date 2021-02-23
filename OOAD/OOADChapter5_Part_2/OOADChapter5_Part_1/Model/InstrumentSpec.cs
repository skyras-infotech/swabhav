using System;
using System.Collections;

namespace OOADChapter5_Part_2.Model
{
    class InstrumentSpec
    {
        private Hashtable _properties;

        public InstrumentSpec(Hashtable properties)
        {
            if (properties == null)
            {
                _properties = new Hashtable();
            }
            else {
                 _properties = new Hashtable(properties);
            }
        }

        public Object GetProperty(string propertyName) {
            return _properties[propertyName];
        }

        public Hashtable GetProperties {
            get { return _properties; }
        }

        public bool Matches(InstrumentSpec otherSpec)
        {
            foreach (var item in otherSpec._properties.Keys)
            {

                string propertyName = (string)item;
                if (!_properties[propertyName].Equals(otherSpec.GetProperty(propertyName))) {
                    return false;
                }
            }
            return true;
        }
    }
}
