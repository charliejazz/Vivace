using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vivace.Notation {
    /// <summary>
    /// 
    /// </summary>
    public class Dynamics : PositionalMusicalTagParameter {
        private String text;
        private float val;

        public Dynamics() {
            Range = MusicalTagRange.Only;
        }
        
        public String Text {
            get { return text; }
            set { text = value; }
        }

        public float Value {
            get { return val; }
            set { val = value; }
        }
    }
}
