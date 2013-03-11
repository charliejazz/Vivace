using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vivace.Notation {
    /// <summary>
    /// 
    /// </summary>
    public class ClefInfo {
        private ClefName clefName;
        private OctavaType octava;

        public ClefInfo(ClefName name, OctavaType oct) {
            clefName = name;
            octava = oct;
        }

        public ClefName ClefName {
            get { return clefName; }
            set { clefName = value; }
        }

        public OctavaType Octava {
            get { return octava; }
            set { octava = value; }
        }
    }
}
