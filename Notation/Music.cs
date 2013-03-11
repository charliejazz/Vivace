using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vivace.Notation {
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class Music : MusicalEvent, IObjectList<Voice> {
        #region IObjectList<Voice> Members

        public void Add(Voice obj) {
            throw new NotImplementedException();
        }

        public void Remove(Voice obj) {
            throw new NotImplementedException();
        }

        public Voice this[int index] {
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }

        public List<Voice> InnerList {
            get { throw new NotImplementedException(); }
        }

        #endregion
    }
}
