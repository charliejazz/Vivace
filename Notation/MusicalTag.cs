using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Vivace.Notation {
    /// <summary>
    /// 
    /// </summary>
    public class MusicalTag : MusicalObject {
        private MusicalTagAssociation association = MusicalTagAssociation.DontCare;
        private MusicalTagRange range = MusicalTagRange.No;
        private float dx;
        private float dy;
        private float size;
        Color color = Color.Black;
        int id;
        bool auto;
        bool isStateTag;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="timePosition"></param>
        /// <param name="obj"></param>
        public MusicalTag(Fraction timePosition, MusicalTag obj) {
            RelativeTimePosition = timePosition;
            Duration = Fraction.Zero;
        }
        /// <summary>
        /// 
        /// </summary>
        public MusicalTag() {
            RelativeTimePosition = Fraction.Zero;
            Duration = Fraction.Zero;
        }
        /// <summary>
        /// 
        /// </summary>
        private MusicalTagAssociation Association {
            get { return association; }
            set { association = value; }
        }
        /// <summary>
        /// Range setting
        /// </summary>
        public MusicalTagRange Range {
            get { return range; }
            set { range = value; }
        }

        public float Dx {
            get { return dx; }
            set { dx = value; }
        }

        public float Dy {
            get { return dy; }
            set { dy = value; }
        }

        public float Size {
            get { return size; }
            set { size = value; }
        }

        public Color Color {
            get { return color; }
            set { color = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Id {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool Auto {
            get { return auto; }
            set { auto = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsStateTag {
            get { return isStateTag; }
            set { isStateTag = value; }
        }
    }
}
