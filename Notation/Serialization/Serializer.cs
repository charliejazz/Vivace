using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Vivace.Notation.Serialization {
    public class Serializer {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <param name="entry"></param>
        public void SerializeEntry(SerializationInfo info, object entry) {
            Type type = entry.GetType();
            SerializationEntryAttribute[] attr = type.GetCustomAttributes(
                typeof(SerializationEntryAttribute), false
            );

            if (attr == null || attr.Length == 0) {
                throw new Exception("No SerializationEntryAttribute specified");
            }

            SerializationEntryAttribute entry = attr[0];
            info.AddValue(entry.Key, entry);
        }

        public void SerializeObject(SerializationInfo info, object obj) {

        }
    }
}
