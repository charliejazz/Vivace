using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Security.Permissions;
using Vivace.Infrastructure.Common;

namespace Vivace.Notation {
    /// <summary>
    /// The music score
    /// </summary>
    [Serializable] // ?
    public class Score : ISerializable {
        #region Declarations
        private List<Page> pages;
        private float worldX, worldY;
        private float zoomFactor = 1.0f;
        private UndoManager undoManager;
        #endregion

        #region Constructors
        public Score() {
            pages = new List<Page>();
            worldX = worldY = 250;

            undoManager = new UndoManager();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public Score(SerializationInfo info, StreamingContext context) {
        }
        #endregion

        #region Properties
        public List<Page> Pages {
            get { return pages; }
            set { pages = value; }
        }
        #endregion

        #region ISerializable Members
        /// <summary>
        /// Serialize the score
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public void GetObjectData(SerializationInfo info, StreamingContext context) {

        }

        #endregion
    }
}
