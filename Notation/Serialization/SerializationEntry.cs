using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vivace.Notation.Serialization {
    /// <summary>
    /// 
    /// </summary>
    public class SerializationEntryAttribute : Attribute {
        public string Key {
            get;
            set;
        }

        public SerializationEntryAttribute(string key) {
            this.Key = key;
        }
    }
}
