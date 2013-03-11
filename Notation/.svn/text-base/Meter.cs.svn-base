using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Vivace.Notation {
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class Meter : MusicalTagParameter {
        #region Declarations
        private Fraction timeOffset;
        private int measureNumber;
        private float size;
        private Boolean autoBarLines;
        private int numerator, denominator;
        private MeterType meterType;
        #endregion

        #region Constructor
        public Meter() {
            autoBarLines = true;
        }

        public Meter(int p_numerator, int p_denominator) {
            numerator = p_numerator;
            denominator = p_denominator;
            meterType = MeterType.Numeric;
            autoBarLines = true;
        }
        #endregion

        #region Properties
        public String MeterName {
            get { return String.Format("{0}/{1}", numerator, denominator); }
        }

        public Fraction MeterTime {
            get { return new Fraction(numerator, denominator); }
        }

        public MeterType MeterType {
            get { return meterType; }
            set { meterType = value; }
        }

        public Boolean AutoBarLines {
            get { return autoBarLines; }
            set { autoBarLines = value; }
        }
        public int Denominator {
            get { return denominator; }
            set { denominator = value; }
        }

        public int Numerator {
            get { return numerator; }
            set { numerator = value; }
        }
        public float Size {
            get { return size; }
            set { size = value; }
        }
        public Fraction TimeOffset {
            get { return timeOffset; }
            set { timeOffset = value; }
        }

        public int MeasureNumber {
            get { return measureNumber; }
            set { measureNumber = value; }
        }
        #endregion

        #region Serialization
        /// <summary>
        /// Save object to serialization stream
        /// </summary>
        /// <param name="serializationInfo"></param>
        public virtual void Serialize(SerializationInfo serializationInfo, int order) {
            serializationInfo.AddValue(szTimeOffset, timeOffset);
            serializationInfo.AddValue(szMeasurNumber, measureNumber);
            serializationInfo.AddValue(szSize, size);
            serializationInfo.AddValue(szAutoBarLines, autoBarLines);
            serializationInfo.AddValue(szNum, numerator);
            serializationInfo.AddValue(szDen, denominator);
            serializationInfo.AddValue(szMeterType, meterType);
            base.Serialize(serializationInfo, order);
        }
        /// <summary>
        /// Load object from serialization stream
        /// </summary>
        /// <param name="serializationInfo"></param>
        public virtual void Deserialize(SerializationInfo serializationInfo, int order) {
            timeOffset = (Fraction)serializationInfo.GetValue(szTimeOffset, typeof(Fraction));
            measureNumber = serializationInfo.GetInt32(szMeasurNumber);
            size = serializationInfo.GetInt32(szSize);
            autoBarLines = serializationInfo.GetBoolean(szAutoBarLines);
            numerator = serializationInfo.GetInt32(szNum);
            denominator = serializationInfo.GetInt32(szDen);
            meterType = (MeterType)serializationInfo.GetValue(szMeterType, typeof(MeterType));
            base.Deserialize(serializationInfo, order);
        }

        private static string szTimeOffset = "TimeOffset";
        private static string szMeasurNumber = "MeasurNumber";
        private static string szSize = "Size";
        private static string szAutoBarLines = "AutoBarLines";
        private static string szNum = "Numerator";
        private static string szDen = "Denominator";
        private static string szMeterType = "MeterType";
        #endregion
    }
}
