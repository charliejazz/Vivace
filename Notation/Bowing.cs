using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Drawing;
using Vivace.Notation.Engraving;

namespace Vivace.Notation {
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class Bowing : PositionalMusicalTagParameter {
        #region Declarations
        private float dx1, dy1, dx2, dy2, r3, h;
        private BowingDirection curveDirection;
        #endregion

        #region Constructors
        public Bowing()
            : base() {
            dx1 = dy1 = dx2 = dy2 = r3 = h = 0;
            curveDirection = BowingDirection.Undefined;
        }
        #endregion

        #region Members
        public void SetCurve(int curve, PointF p1, PointF p2) {

            float distx = p2.X - p1.X;
            float disty = p2.Y - p2.Y;
            float alpha = (float)Math.Atan2(disty, distx);
            float myr3 = (0.5f * distx) / (float)Math.Cos(alpha) / distx;
            float myh = 0.5f;

            alpha = Math.Abs(alpha);
            if (alpha > 0.02f) {
                myh = distx * 0.5f * (float)Math.Tan(alpha) / EngravingRules.SPACE * 2;
                if (myh < 1.5f)
                    myh += 1.5f;
            }

            if (distx < 151) {
                if (myh == 1.5f)
                    myh = 0.75f;
            }

            r3 = myr3;
            h = myh;

        }
        #endregion

        #region Properties

        public BowingDirection CurveDirection {
            get { return curveDirection; }
            set { curveDirection = value; }
        }

        public float H {
            get { return h; }
            set { h = value; }
        }

        public float R3 {
            get { return r3; }
            set { r3 = value; }
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
            serializationInfo.AddValue(szDx1, dx1);
            serializationInfo.AddValue(szDy1, dy1);
            serializationInfo.AddValue(szDx2, dx2);
            serializationInfo.AddValue(szDy2, dy2);
            serializationInfo.AddValue(szR3, r3);
            serializationInfo.AddValue(szH, h);

            base.Serialize(serializationInfo, order);
        }
        /// <summary>
        /// Load object from serialization stream
        /// </summary>
        /// <param name="serializationInfo"></param>
        public virtual void Deserialize(SerializationInfo serializationInfo, int order) {
            dx1 = (float)serializationInfo.GetDouble(szDx1);
            dy1 = (float)serializationInfo.GetDouble(szDy1);
            dx2 = (float)serializationInfo.GetDouble(szDx2);
            dy2 = (float)serializationInfo.GetDouble(szDy2);
            r3 = (float)serializationInfo.GetDouble(szR3);
            h = (float)serializationInfo.GetDouble(szH);

            base.Deserialize(serializationInfo, order);
        }

        private static string szDx1 = "Dx1";
        private static string szDy1 = "Dy1";
        private static string szDx2 = "Dx2";
        private static string szDy2 = "Dy2";
        private static string szR3 = "R3";
        private static string szH = "H";
        #endregion
    }
}
