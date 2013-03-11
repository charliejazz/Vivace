using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Vivace.Notation.Interaction;
using Vivace.Notation.Engraving;
using System.Runtime.Serialization;
using Vivace.Infrastructure.Common;
using Vivace.Notation.Drawing.ViewPort;

namespace Vivace.Notation.Drawing {
    /// <summary>
    /// base class for all vivace score objects
    /// </summary>
    [Serializable]
    public abstract class ScoreElementBase : ViewPortElement {

        #region Declarations
        private Font font;
        private PointF position;
        private PointF offset;
        private RectangleF boundingRect;
        private int fontSize = (int)(1.5f * EngravingRules.SPACE);
        private Boolean selected = false;
        private bool focused = false;
        private float size = 1.0f;
        private SizeF minSize;
        private bool dragable;
        private bool resizeable;
        private bool dragging;
        private Pen pen;
        #endregion

        #region Constructors
        public ScoreElementBase(PageElement page)
            : base((PageElement)page) {
        }
        #endregion

        #region Members
        /// <summary>
        /// Called when another score element, wants to notify you of its position
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="position"></param>
        public abstract void NotifyPosition(ScoreElementBase obj, PointF position);
        /// <summary>
        /// relayout element
        /// </summary>
        /// <param name="rules"></param>
        public virtual void Layout() {
        }
        /// <summary>
        /// Determines if position is on staff line
        /// </summary>
        /// <param name="pos_y"></param>
        /// <param name="space"></param>
        /// <returns></returns>
        public static bool PositionIsOnStaffLine(float pos_y, float space) {
            int n = (int)(pos_y / (space * 0.5f));
            return ((n | 1) != n);
        }
        #endregion

        #region Serialization
        /// <summary>
        /// Save object to serialization stream
        /// </summary>
        /// <param name="serializationInfo"></param>
        public virtual void Serialize(SerializationInfo serializationInfo, int order) {
            serializationInfo.AddValue(szFont, font);
            serializationInfo.AddValue(szPosition, position);
            serializationInfo.AddValue(szOffset, offset);
        }
        /// <summary>
        /// Load object from serialization stream
        /// </summary>
        /// <param name="serializationInfo"></param>
        public virtual void Deserialize(SerializationInfo serializationInfo, int order) {
            font = (Font)serializationInfo.GetValue(szFont, typeof(Font));
            position = (PointF)serializationInfo.GetValue(szPosition, typeof(PointF));
            offset = (PointF)serializationInfo.GetValue(szOffset, typeof(PointF));
        }

        public static string szFont = "Font";
        public static string szPosition = "Position";
        public static string szOffset = "Offset";
        #endregion

        public override void Render(GraphicsContext g) {
            throw new NotImplementedException();
        }

        protected override void RenderOutline(GraphicsContext g) {
            throw new NotImplementedException();
        }

        public override bool OnDrag(PointF p) {
            throw new NotImplementedException();
        }

        public override bool OnDragHandle(ElementHandle handle, PointF position) {
            throw new NotImplementedException();
        }
    }
}
