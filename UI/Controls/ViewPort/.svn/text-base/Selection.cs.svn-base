using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vivace.UI.Controls.ViewPort {
    /// <summary>
    /// Represents the selection within a viewport
    /// </summary>
    public class Selection {
        #region Declarations
        private List<ViewPortElement> elements = new List<ViewPortElement>();
        private ScoreViewPort viewPort;
        #endregion

        #region Constructors
        public Selection(ScoreViewPort viewPort) {
            this.viewPort = viewPort;
        }
        #endregion

        #region Members
        public void Add(ViewPortElement el) {
            if (!elements.Contains(el))
                elements.Add(el);
        }

        public void Toggle(ViewPortElement el) {
            if (el.Selected) {
            }
            
        }

        public void Remove(ViewPortElement el) {
            //el.Selected = false;
            if(elements.Contains(el))
                elements.Remove(el);
        }
        #endregion
    }
}
