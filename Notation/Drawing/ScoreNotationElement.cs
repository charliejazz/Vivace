﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Vivace.Infrastructure.Common;
using Vivace.Notation.Interaction;
using Vivace.Notation.Drawing.ViewPort;

namespace Vivace.Notation.Drawing {
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class ScoreNotationElement : ScoreElementBase {

        public ScoreNotationElement()
            : base(null) {
        }
        /// <summary>
        /// Renders the notation element
        /// </summary>
        /// <param name="g"></param>
        public override void Render(GraphicsContext g) {
            throw new NotImplementedException();
        }
 
        /// <summary>
        /// Notifies associated elements of the element position 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="position"></param>
        public override void NotifyPosition(ScoreElementBase obj, PointF position) {
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
