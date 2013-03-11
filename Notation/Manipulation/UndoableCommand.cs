using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vivace.Notation.Manipulation {
    /// <summary>
    /// 
    /// </summary>
    public class UndoableCommand : Command, IUndoableCommand {
        #region IUndoableCommand Members
        /// <summary>
        /// 
        /// </summary>
        public virtual void Undo() {
            throw new NotImplementedException();
        }

        #endregion
    }
}
