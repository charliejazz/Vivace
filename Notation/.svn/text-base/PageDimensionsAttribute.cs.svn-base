using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Vivace.Notation {
    /// <summary>
    /// Defines the dimensions of a page in centimeters
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class PageDimensionsAttribute : Attribute {
        #region Private
        private float pageWidth, pageHeight, marginLeft, marginRight, marginTop, marginBottom;
        #endregion

        #region Properties
        public float MarginBottom {
            get { return marginBottom; }
            set { marginBottom = value; }
        }

        public float MarginRight {
            get { return marginRight; }
            set { marginRight = value; }
        }

        public float MarginTop {
            get { return marginTop; }
            set { marginTop = value; }
        }

        public float MarginLeft {
            get { return marginLeft; }
            set { marginLeft = value; }
        }

        public float PageHeight {
            get { return pageHeight; }
            set { pageHeight = value; }
        }

        public float PageWidth {
            get { return pageWidth; }
            set { pageWidth = value; }
        }
        #endregion

        #region Constructor
        public PageDimensionsAttribute(
            float width,
            float height,
            float left,
            float right,
            float top,
            float bottom
        ) {

            pageWidth = width;
            pageHeight = height;
            marginBottom = bottom;
            marginLeft = left;
            marginTop = top;
            marginRight = right;
        }
        #endregion

        #region Members
        /// <summary>
        /// Gets the page dimension attribute instance of the specified NXPageSize
        /// </summary>
        /// <param name="pageFormat"></param>
        /// <returns></returns>
        public static PageDimensionsAttribute GetPageDimensions(PageSize pageFormat) {
            FieldInfo fi = pageFormat.GetType().GetField(pageFormat.ToString());
            Object[] attrs = fi.GetCustomAttributes(
                typeof(PageDimensionsAttribute), false
            );

            if (attrs.Length > 0 && attrs[0] is PageDimensionsAttribute)
                return attrs[0] as PageDimensionsAttribute;
            else
                return null;
        }
        #endregion
    }
}
