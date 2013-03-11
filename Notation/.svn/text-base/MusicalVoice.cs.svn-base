using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vivace.Notation {
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class MusicalVoice : MusicalEvent, IObjectList<MusicalObject> {
        private List<MusicalObject> objectList = new List<MusicalObject>();

        public MusicalVoice()
            : base(Fraction.Zero, Fraction.Zero) {
        }

        #region IObjectList<MusicalObject> Members

        public void Add(MusicalObject obj) {
            if (!objectList.Contains(obj))
                objectList.Add(obj);
        }

        public void Remove(MusicalObject obj) {
            objectList.Remove(obj);
        }

        public MusicalObject this[int index] {
            get {
                return objectList[index];
            }
            set {
                if (!objectList.Contains(value))
                    objectList[index] = value;
            }
        }

        public List<MusicalObject> InnerList {
            get { return objectList; }
        }

        #endregion
    }
}
