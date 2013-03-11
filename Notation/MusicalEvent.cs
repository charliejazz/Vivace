using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Vivace.Notation {
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class MusicalEvent : MusicalObject {
        /// <summary>
        /// number of dots after event
        /// </summary>
        private int points;

        #region Constructors
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="num">duration numerator</param>
        /// <param name="den">duration denominator</param>
        public MusicalEvent(int num, int den) {
            this.Duration = new Fraction(num, den);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="relativeTP">time position</param>
        /// <param name="d">duration</param>
        public MusicalEvent(Fraction relativeTP, Fraction d)
            : base(relativeTP) {
            this.Duration = d;
        }

        public MusicalEvent()
            : base() {
        }
        #endregion

        #region Properties
        /// <summary>
        /// Sets the number of points and changes the duration accordingly
        /// </summary>
        public int Points {
            get { return points; }
            set {
                int p = value;
                if (p > 0 && p < 4) {
                    points = p;
                    Fraction d = new Fraction(Duration);
                    for (int i = 1, n = 1; i <= points; i++) {
                        n <<= 1;
                        Duration += d * new Fraction(1, n);
                    }
                }
            }
        }
        #endregion
        /// <summary>
        /// Set the number of points without altering the duration
        /// </summary>
        /// <param name="p">number of points</param>
        public void SetPointsNoDurationChange(int p) { points = p; }
        /// <summary>
        /// Default implementation. Determines if two musical events can be merged
        /// </summary>
        /// <param name="ev"></param>
        /// <returns></returns>
        public virtual Boolean CanBeMerged(MusicalEvent ev) {
            return this.GetType().Equals(ev.GetType());
        }

        #region Serialization
        /// <summary>
        /// Save object to serialization stream
        /// </summary>
        /// <param name="serializationInfo"></param>
        public virtual void Serialize(SerializationInfo serializationInfo, int order) {
            serializationInfo.AddValue(szPoints, points);
            base.Serialize(serializationInfo, order);
        }
        /// <summary>
        /// Load object from serialization stream
        /// </summary>
        /// <param name="serializationInfo"></param>
        public virtual void Deserialize(SerializationInfo serializationInfo, int order) {
            points = serializationInfo.GetInt32(szPoints);
            base.Deserialize(serializationInfo, order);
        }

        private static string szPoints = "Points";
        #endregion
    }
}
