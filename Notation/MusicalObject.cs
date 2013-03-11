using System;
using System.Collections.Generic;
using System.Text;
using Vivace.Notation.Drawing;
using System.Runtime.Serialization;
using System.Globalization;

namespace Vivace.Notation {
    /// <summary>
    /// Base class for all Musical Object classes
    /// </summary>
    [Serializable]
    public class MusicalObject {
        #region Private Members
        private Fraction relativeTimePosition;
        private Fraction duration;
        private List<ScoreElementBase> grList;
        private Guid objectId = Guid.NewGuid();
        #endregion

        #region Constructors

        public MusicalObject() {
            relativeTimePosition = Fraction.Zero;
        }

        public MusicalObject(Fraction timePosition) {
            relativeTimePosition = timePosition;
        }
        #endregion

        #region Properties
        public virtual Fraction RelativeEndTimePosition {
            get { return relativeTimePosition + duration; }
            set {
                duration = value - relativeTimePosition;
            }
        }

        public virtual Fraction RelativeTimePosition {
            get { return relativeTimePosition; }
            set { relativeTimePosition = value; }
        }

        public virtual Fraction Duration {
            get { return duration; }
            set { duration = value; }
        }

        public Guid ObjectId {
            get {
                return objectId;
            }
        }
        #endregion

        #region Members
        public virtual void AddGraphicalRepresentation(ScoreElementBase obj) {
            if (grList == null)
                grList = new List<ScoreElementBase>();

            grList.Add(obj);
        }

        public virtual void ResetGraphicalRepresentation() {
            if (grList != null)
                grList.Clear();
        }

        public virtual ScoreElementBase GetFirstGraphicalRepresentation() {
            if (grList == null || grList.Count == 0)
                return null;

            return grList[0];
        }

        public virtual ScoreElementBase GetLastGraphicalRepresentation() {
            if (grList == null || grList.Count == 0)
                return null;

            return grList[grList.Count - 1];
        }

        public virtual void RemoveGraphicalRepresentation(ScoreElementBase obj) {
            if (grList == null)
                return;

            grList.Remove(obj);
        }
        #endregion

        #region Serialization
        /// <summary>
        /// Save object to serialization stream
        /// </summary>
        /// <param name="serializationInfo"></param>
        public virtual void Serialize(SerializationInfo serializationInfo, int order) {
            serializationInfo.AddValue(szTimePosition, (double)relativeTimePosition);
            serializationInfo.AddValue(szDuration, (double)duration);
            serializationInfo.AddValue(szObjectId, objectId);
            serializationInfo.AddValue("grCount", grList.Count);

            foreach (ScoreElementBase el in grList) {
                serializationInfo.AddValue("grType", el.GetType().FullName);
                el.Serialize(serializationInfo, order);
            }
        }
        /// <summary>
        /// Load object from serialization stream
        /// </summary>
        /// <param name="serializationInfo"></param>
        public virtual void Deserialize(SerializationInfo serializationInfo, int order) {
            relativeTimePosition = serializationInfo.GetDouble(FormatSerializationEntry(szTimePosition, order));
            duration = serializationInfo.GetDouble(FormatSerializationEntry(szDuration, order));
            objectId = (Guid)serializationInfo.GetValue(szObjectId, typeof(Guid));
            int grCount = serializationInfo.GetInt32("grCount");

            string grType;
            for (int i = 0; i < grCount; i++) {
                grType = serializationInfo.GetString("grType");
                ScoreElementBase se = (ScoreElementBase)Activator.CreateInstance(Type.GetType(grType));
                se.Deserialize(serializationInfo, order);
                if (se is ScoreNotationElement && se.GetType().IsGenericType) {
                    ScoreNotationElement<MusicalObject> el = (ScoreNotationElement<MusicalObject>)se;
                    el.MusicalObject = this;
                }
                i++;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        protected string FormatSerializationEntry(string name, int order) {
            return String.Format(
                CultureInfo.InvariantCulture,
                "{0}{1}", name, order.ToString()
            );
        }
        /// <summary>
        /// generates a unique id for this object
        /// </summary>
        /// <returns></returns>
        public static string GenerateObjectId() {
            return Guid.NewGuid().ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="order"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        protected string FormatSerializationEntry(string name, int order, int index) {
            return String.Format(
                CultureInfo.InvariantCulture,
                "{0}{1}-{2}", name, order.ToString(CultureInfo.InvariantCulture), 
                index.ToString(CultureInfo.InvariantCulture)
            );
        }

        private static string szTimePosition = "TimePosition";
        private static string szDuration = "Duration";
        private static string szObjectId = "ObjectId";
        // common serialization entries
        public static string szObjectType = "ObjectType";
        public static string szObjectCount = "ObjectCount";
        #endregion

        #region static members
        public static Boolean IsPowerOfTwoDenom(Fraction dur) {
            int x = (int)dur.Denominator;
            return ((x & -x) == x);
        }
        #endregion

        #region Cloneable Members

        public virtual MusicalObject Clone() {
            return this;
        }

        public T InternalClone<T>() where T : MusicalObject, new() {
            T obj = new T();
            obj.Duration = this.duration;
            obj.RelativeTimePosition = this.relativeTimePosition;
            return obj;
        }

        #endregion
    }
}
