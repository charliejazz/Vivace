using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Vivace.UI.Controls.ViewPort {
    /// <summary>
    /// 
    /// </summary>
    public class Layer : ILayer {
        #region Declarations
        private ScoreViewPort viewPort;
        private ILayerMap layerMap;
        #endregion

        #region Constructors
        public Layer(ScoreViewPort viewPort) {
            this.viewPort = viewPort;
        }

        #endregion

        #region ILayer Members

        public ILayer Next {
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
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

        #endregion

        #region ILayer Members


        public PointF Position {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public RectangleF Rectangle {
            get { throw new NotImplementedException(); }
        }

        public ILayerMap LayerMap {
            get { return layerMap; }
            set { layerMap = value; }
        }


        #endregion
    }
}
