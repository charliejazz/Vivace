using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vivace.Notation {
    /// <summary>
    /// 
    /// </summary>
    public class PositionalMusicalTagParameter : MusicalTagParameter {
        private PositionTag correspondence;
        private MusicalObject position;
        private MusicalObject endPosition;

        public MusicalObject EndPosition {
            get { return endPosition; }
            set { endPosition = value; }
        }

        public MusicalObject Position {
            get { return position; }
            set { position = value; }
        }

        public MusicalObject StartPosition { get { return position; } }

        public PositionTag Correspondence {
            get { return correspondence; }
            set { correspondence = value; }
        }
    }
}
