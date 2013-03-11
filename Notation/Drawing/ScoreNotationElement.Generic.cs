using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Vivace.Notation.Drawing {
    /// <summary>
    /// Base implementation for a score notation element
    /// </summary>
    /// <typeparam name="TMusicalObject"></typeparam>
    [Serializable]
    public class ScoreNotationElement<TMusicalObject> : ScoreNotationElement where TMusicalObject : MusicalObject {
        #region Declarations
        private TMusicalObject musicalObject;
        private bool ownsMusicalObject;
        #endregion

        #region Constructors
        public ScoreNotationElement() {
            musicalObject = default(TMusicalObject);
        }
        public ScoreNotationElement(TMusicalObject musicalObject) {
            this.musicalObject = musicalObject;
        }
        #endregion

        #region Properties
        public TMusicalObject MusicalObject {
            get { return musicalObject; }
            set { musicalObject = value; }
        }

        public bool OwnsMusicalObject {
            get { return ownsMusicalObject; }
            set { ownsMusicalObject = value; }
        }

        #endregion

        #region Serialization
        /// <summary>
        /// 
        /// </summary>
        /// <param name="serializationInfo"></param>
        public override void Serialize(SerializationInfo serializationInfo, int order) {
            base.Serialize(serializationInfo, order);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="serializationInfo"></param>
        public override void Deserialize(SerializationInfo serializationInfo, int order) {
            //load
            //musicalObject.AddGraphicalRepresentation(this);
            base.Deserialize(serializationInfo, order);
        }
        #endregion
    }
}
