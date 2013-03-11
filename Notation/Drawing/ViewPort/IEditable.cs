using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vivace.Notation.Drawing.ViewPort {
    /// <summary>
    /// 
    /// </summary>
    public interface IEditable {
        void BeginEdit();
        void EndEdit();
        Control GetEditControl();
    }
}
