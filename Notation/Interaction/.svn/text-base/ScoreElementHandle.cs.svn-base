using System.Drawing;
using Vivace.Notation.Drawing;

namespace Vivace.Notation.Interaction {
    /// <summary>
    /// 
    /// </summary>
    public class ScoreElementHandle {
        #region Declarations
        private PointF position;
        private ScoreElementBase scoreElement;
        private bool draggable;
        private bool highlighted;
        //private IInteractionLayer interactionLayer;
        private RectangleF boundingRect;
        private Pen pen = Pens.Blue;
        #endregion

        #region Public Members
        protected virtual void Move(PointF p) {
            this.position = p;
            //interactionLayer.Render();
        }

        protected virtual void Render(Graphics g) {
            g.DrawRectangle(
                pen, 
                boundingRect.X, boundingRect.Y, boundingRect.Width, boundingRect.Height
            );
        }
        #endregion

        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public PointF Position {
            get { return position; }
            set { position = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public ScoreElementBase ScoreElement {
            get { return scoreElement; }
            set { scoreElement = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool Draggable {
            get { return draggable; }
            set { draggable = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public RectangleF BoundingRect {
            get { return boundingRect; }
            set { boundingRect = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool Highlighted {
            get { return highlighted; }
            set { highlighted = value; }
        }
        #endregion
    }
}
