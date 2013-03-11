using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Vivace.Infrastructure.Common;
using System.Windows.Forms;

namespace Vivace.Notation.Drawing.ViewPort {
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public abstract class ViewPortElement {
        #region Declarations
        private PointF position;
        private RectangleF boundingRect;
        private Boolean selected = false;
        private bool focused = false;
        private bool dragable;
        private bool resizeable;
        private bool dragging;
        private List<ElementHandle> handles = new List<ElementHandle>();
        private PageElement layer;
        #endregion

        #region Constructors
        public ViewPortElement(PageElement layer) {
            this.layer = layer;
        }
        #endregion

        #region Members
        /// <summary>
        /// Renders the score element
        /// </summary>
        /// <param name="g"></param>
        public abstract void Render(GraphicsContext g);
        /// <summary>
        /// Render an outline of the score element, used for score preview
        /// </summary>
        /// <param name="g"></param>
        protected abstract void RenderOutline(GraphicsContext g);
        /// <summary>
        /// Create handles that are used to interact with the element
        /// </summary>
        public virtual void CreateHandles() {

        }
        /// <summary>
        /// Create handles that are used to interact with the element
        /// </summary>
        public virtual void UpdateHandles() {

        }
        /// <summary>
        /// Called when object is to be dragged
        /// </summary>
        /// <param name="p">Position to drag to</param>
        /// <returns></returns>
        public abstract bool OnDrag(PointF p);
        /// <summary>
        /// Is called when a handle is dragged
        /// </summary>
        /// <param name="handle">handle being dragged</param>
        /// <param name="p">Position to drag handle to</param>
        /// <returns></returns>
        public abstract bool OnDragHandle(ElementHandle handle, PointF position);
        /// <summary>
        /// Determines if the object can be selected with the speified point
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public virtual bool CanSelectWithPoint(PointF p) {
            // default implementation
            return this.boundingRect.Contains(p);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        public virtual void OnMouseDown(MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {

            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        public virtual void OnMouseUp(MouseEventArgs e) {
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual void OnClick() {
            this.layer.ViewPort.FocusElement(this);
        }
        #endregion

        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public Boolean Selected {
            get { return selected; }
            set { selected = value; }
        }
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
        public RectangleF BoundingRect {
            get { return boundingRect; }
            set { boundingRect = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public List<ElementHandle> Handles {
            get {
                return handles;
            }
        }
        #endregion
    }
}
