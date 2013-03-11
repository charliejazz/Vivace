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
    public class Beam : PositionalMusicalTagParameter {
        
        #region Declarations
        private float dx1, dy1, dx2, dy2, dx3, dy3, dx4, dy4;
        #endregion

        #region Constructors
        public Beam()
            : base() {
        }
        #endregion

        #region Properties
        public float Dy3 {
            get { return dy3; }
            set { dy3 = value; }
        }

        public float Dy4 {
            get { return dy4; }
            set { dy4 = value; }
        }

        public float Dx4 {
            get { return dx4; }
            set { dx4 = value; }
        }

        public float Dx3 {
            get { return dx3; }
            set { dx3 = value; }
        }

        public float Dy2 {
            get { return dy2; }
            set { dy2 = value; }
        }

        public float Dx2 {
            get { return dx2; }
            set { dx2 = value; }
        }

        public float Dy1 {
            get { return dy1; }
            set { dy1 = value; }
        }

        public float Dx1 {
            get { return dx1; }
            set { dx1 = value; }
        }
        #endregion

        #region Serialization
        /// <summary>
        /// Save object to serialization stream
        /// </summary>
        /// <param name="serializationInfo"></param>
        public virtual void Serialize(SerializationInfo serializationInfo, int order) {
            serializationInfo.AddValue(FormatSerializationEntry(szDx1, order), dx1);
            serializationInfo.AddValue(FormatSerializationEntry(szDy1, order), dy1);
            serializationInfo.AddValue(FormatSerializationEntry(szDx2, order), dx2);
            serializationInfo.AddValue(FormatSerializationEntry(szDy2, order), dy2);
            serializationInfo.AddValue(FormatSerializationEntry(szDx3, order), dx3);
            serializationInfo.AddValue(FormatSerializationEntry(szDy3, order), dy3);
            serializationInfo.AddValue(FormatSerializationEntry(szDx4, order), dx4);
            serializationInfo.AddValue(FormatSerializationEntry(szDy4, order), dy4);
            base.Serialize(serializationInfo, order);
        }
        /// <summary>
        /// Load object from serialization stream
        /// </summary>
        /// <param name="serializationInfo"></param>
        public virtual void Deserialize(SerializationInfo serializationInfo, int order) {
            dx1 = (float)serializationInfo.GetDouble(FormatSerializationEntry(szDx1, order));
            dy1 = (float)serializationInfo.GetDouble(FormatSerializationEntry(szDy1, order));
            dx2 = (float)serializationInfo.GetDouble(FormatSerializationEntry(szDx2, order));
            dy2 = (float)serializationInfo.GetDouble(FormatSerializationEntry(szDy2, order));
            dx3 = (float)serializationInfo.GetDouble(FormatSerializationEntry(szDx3, order));
            dy3 = (float)serializationInfo.GetDouble(FormatSerializationEntry(szDy3, order));
            dx4 = (float)serializationInfo.GetDouble(FormatSerializationEntry(szDx4, order));
            dy4 = (float)serializationInfo.GetDouble(FormatSerializationEntry(szDy4, order));
            base.Deserialize(serializationInfo, order);
        }
        private static string szDx1 = "Dx1";
        private static string szDy1 = "Dy1";
        private static string szDx2 = "Dx2";
        private static string szDy2 = "Dy2";
        private static string szDx3 = "Dx3";
        private static string szDy3 = "Dy3";
        private static string szDx4 = "Dx4";
        private static string szDy4 = "Dy4";
        #endregion
    }
}
