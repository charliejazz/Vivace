using System.Drawing;

namespace Vivace.UI.Controls.ViewPort {
    /// <summary>
    /// 
    /// </summary>
    public class ElementHandle {
        #region Declarations
        private PointF position;
        private ViewPortElement viewPortElement;
        private bool draggable;
        private bool highlighted;
        private RectangleF boundingRect;
        private Pen pen = Pens.Blue;
        private int handleId;
        #endregion

        #region Constructors
        public ElementHandle(PointF p) {
            this.position = p;
        }
        #endregion

        #region Public Members
        protected virtual void Move(PointF p) {
            this.position = p;
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
        public ViewPortElement ViewPortElement {
            get { return viewPortElement; }
            set { viewPortElement = value; }
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
        public virtual RectangleF BoundingRect {
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
