using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Vivace.Notation {
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class Text : PositionalMusicalTagParameter {
        #region Declarations
        private string text;
        private string textFormat;
        private string font;
        private float fontSize;
        private float yPosition;
        private FontStyle fontStyle;
        #endregion
    }
}
