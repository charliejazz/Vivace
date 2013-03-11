using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Reflection;

namespace Vivace.Notation {
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class Chord : MusicalEvent {
        private List<MusicalObject> elements;

        public Chord()
            : base(Fraction.Zero, Fraction.Zero) {
        }

        public override bool CanBeMerged(MusicalEvent ev) {
            if (ev is Chord) {
                Chord chord = ev as Chord;
                MusicalEvent ev1 = null, ev2 = null;
                IEnumerator<MusicalObject> enumerator1, enumerator2;

                enumerator1 = elements.GetEnumerator();
                enumerator2 = chord.Elements.GetEnumerator();

                while (enumerator1.MoveNext() && enumerator2.MoveNext()) {
                    ev1 = (MusicalEvent)enumerator1.Current;
                    ev2 = (MusicalEvent)enumerator2.Current;

                    if (!ev1.CanBeMerged(ev2))
                        return false;
                }

                if ((ev1 == null && ev2 != null) || (ev1 != null || ev2 == null))
                    return false;

                return true;
            }

            return false;
        }

        public void AddElement(MusicalObject obj) {
            obj.RelativeTimePosition = this.RelativeTimePosition;
            if (Duration < obj.Duration)
                Duration = obj.Duration;
            elements.Add(obj);
        }

        public List<MusicalObject> Elements {
            get { return elements; }
            set { elements = value; }
        }

        public override Fraction RelativeTimePosition {
            get {
                return base.RelativeTimePosition;
            }
            set {
                base.RelativeTimePosition = value;
                foreach (MusicalObject o in elements)
                    o.RelativeTimePosition = value;
            }
        }

        public override Fraction Duration {
            get {
                return base.Duration;
            }
            set {
                base.Duration = value;
                foreach (MusicalObject o in elements)
                    o.Duration = value;
            }
        }

        #region Serialization
        /// <summary>
        /// Save object to serialization stream
        /// </summary>
        /// <param name="serializationInfo"></param>
        public virtual void Serialize(SerializationInfo serializationInfo, int order) {
            serializationInfo.AddValue(szObjectCount, elements.Count);
            foreach(MusicalObject obj in elements) {
                serializationInfo.AddValue(szObjectType, obj.GetType().FullName);
                obj.Serialize(serializationInfo, order);
            }
            base.Serialize(serializationInfo, order);
        }
        /// <summary>
        /// Load object from serialization stream
        /// </summary>
        /// <param name="serializationInfo"></param>
        public virtual void Deserialize(SerializationInfo serializationInfo, int order) {
            int count;
            string typeName;

            count = serializationInfo.GetInt32(szObjectCount);
            for (int i = 0; i < count; i++) {
                typeName = serializationInfo.GetString(szObjectType);
                MusicalObject musicalObject;
                musicalObject = (MusicalObject)Assembly.GetExecutingAssembly().CreateInstance(typeName);
                musicalObject.Deserialize(serializationInfo, order);
                elements.Add(musicalObject);
            }
            base.Deserialize(serializationInfo, order);
        }

        #endregion
    }
}
