using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vivace.Notation {
    /// <summary>
    /// 
    /// </summary>
    public class DisplayDuration : PositionalMusicalTagParameter {
        private Fraction displayableDuration;
        private int dots;

        public DisplayDuration(Fraction duration, int dots) {
            displayableDuration = duration;
            this.dots = dots;
        }

        public int Dots {
            get { return dots; }
            set { dots = value; }
        }

        public Fraction DisplayableDuration {
            get { return displayableDuration; }
        }

        public void SetDisplayDuration(Fraction dur) {
            Fraction.ReduceFraction(ref dur);
            if (dur.Numerator == 1)
                dots = 0;
            else if (dur.Numerator == 3 && dur.Denominator > 1) {
                dots = 1;
                dur.Numerator = 1;
                dur.Denominator = dur.Denominator / 2;
            } else if (dur.Numerator == 7 && dur.Denominator > 1) {
                dots = 2;
                dur.Numerator = 1;
                dur.Denominator = dur.Denominator / 4;
            }
            displayableDuration = dur;
        }

        public void SetDisplayDuration(Fraction dur, int dots) {
            this.displayableDuration = dur;
            this.dots = dots;
        }
    }
}
