using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vivace.Notation.Engraving {
    /// <summary>
    /// 
    /// </summary>
    public class EngravingRules {
        #region Declarations
        #endregion

        #region Members
        #endregion

        #region Constants
        // SPACE constant
        public const float SPACE = 50f;

        /// <summary>
        /// Convert virtual units to cm/inches
        /// </summary>
        public const float VirtualToCm = (float)((3.0 * 2.0 * 2.54) / (SPACE * 72.27));
        public const float CmToVirtual = (float)1.0 / VirtualToCm;
        public const float VirtualToInch = VirtualToCm / (float)2.54;
        public const float InchToVirtual = (float)1.0 / VirtualToInch;
        public const float VirtualToPixel = (float)(((VirtualToCm) / 2.54) * 96);
        public const float PixelToVirtual = (float)((CmToVirtual * 2.54) / 96);

        /// <summary>
        /// Stem dimensions
        /// </summary>
        public const float StemLength = (float)(3.5 * SPACE);
        /// <summary>
        /// default spring constants
        /// </summary>
        public const float SpringConstant_Bar = 7.0f;
        public const float SpringConstant_Clef = 100.0f;
        public const float SpringConstant_Default = 20.0f;
        public const float SpringConstant_GlueStart = 50.0f;
        public const float SpringConstant_GlueNoStart = 7.0f;
        public const float SpringConstant_key = 100.0f;
        public const float SpringConstant_Intens = 100.0f;
        public const float SpringConstant_Meter = 100.0f;

        /// <summary>
        /// Thickness of a staff line
        /// </summary>
        public const float StaffLineThickness = SPACE * 0.1f;
        /// <summary>
        /// Default Layout Values
        /// </summary>
        public const float DefaultSystemDistance = (float)(1.5 * SPACE);
        public const float DefaultForce = 750.0f;
        public const float DefaultSpring = 1.1f;
        /// <summary>
        /// ???
        /// </summary>
        public const int NumNotes = 12;
        /// <summary>
        /// The number of line segments used to draw the curves - 
        /// should be a variable so it can be increased during printing 
        /// 5 can be used for quick drawing and 100 or more for higher 
        /// resolution
        /// </summary>
        public const int DefaultSlurSegments = 25;
        #endregion
    }
}
