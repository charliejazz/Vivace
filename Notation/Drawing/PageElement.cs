using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Vivace.Notation.Drawing.ViewPort;
using System.Drawing;

namespace Vivace.Notation.Drawing {
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class PageElement {
        #region Declarations
        private ScoreViewPort viewPort;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewPort"></param>
        public PageElement(ScoreViewPort viewPort) {
            this.viewPort = viewPort;
        }

        public ScoreViewPort ViewPort {
            get { throw new NotImplementedException(); }
        }

        public virtual void Render(Graphics g) {
            throw new NotImplementedException();
        }

        public virtual void RenderOutline(Graphics g) {
            throw new NotImplementedException();
        }

        public PointF Position {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public RectangleF Rectangle {
            get { throw new NotImplementedException(); }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="serializationInfo"></param>
        /// <param name="order"></param>
        public virtual void Serialise(SerializationInfo serializationInfo, int order) {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="serializationInfo"></param>
        /// <param name="order"></param>
        public virtual void Deserialise(SerializationInfo serializationInfo, int order) {
        }
    }
}
