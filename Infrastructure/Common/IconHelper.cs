using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

namespace Vivace.Infrastructure.Common {
    /// <summary>
    /// 
    /// </summary>
    public static class IconHelper {
        /// <summary>
        /// Load an icon from an embedded resource
        /// </summary>
        /// <param name="resourceName">name of resource</param>
        /// <returns></returns>
        public static Icon LoadIcon(string resourceName) {
            return new Icon(resourceName);
        }
    }
}
