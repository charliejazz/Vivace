using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Vivace.Notation {
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class Bar : MusicalTagParameter {
        #region Declarations
        private int barNumber;
        #endregion

        #region Constructors
        public Bar()
            : base(Fraction.Zero, null) {
            barNumber = -1;
        }

        public Bar(Fraction tp)
            : base(tp, null) {
            barNumber = -1;
        }

        #endregion

        #region Members
        public override bool Equals(object obj) {
            if (obj is Bar) {
                Bar b = obj as Bar;
                return (this.BarNumber == b.BarNumber);
            }
            return false;
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }

        public override MusicalObject Clone() {
            Bar b = InternalClone<Bar>();
            b.barNumber = this.barNumber;
            return b;
        }
        #endregion

        #region Properties
        public int BarNumber {
            get { return barNumber; }
            set { barNumber = value; }
        }
        #endregion

        #region Serialization
        /// <summary>
        /// Save object to serialization stream
        /// </summary>
        /// <param name="serializationInfo"></param>
        public virtual void Serialize(SerializationInfo serializationInfo, int order) {
            serializationInfo.AddValue(FormatSerializationEntry(szBarNumber, order), barNumber);
            base.Serialize(serializationInfo, order);
        }
        /// <summary>
        /// Load object from serialization stream
        /// </summary>
        /// <param name="serializationInfo"></param>
        public virtual void Deserialize(SerializationInfo serializationInfo, int order) {
            barNumber = serializationInfo.GetInt32(FormatSerializationEntry(szBarNumber, order));
            base.Deserialize(serializationInfo, order);

        }

        private static string szBarNumber = "BarNumber";
        #endregion
    }
}
