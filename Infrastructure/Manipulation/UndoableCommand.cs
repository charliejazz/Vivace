using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vivace.Infrastructure.Manipulation {
    /// <summary>
    /// 
    /// </summary>
    public class UndoableCommand : Command, IUndoableCommand {
        #region IUndoableCommand Members

        public virtual void Undo() {
            throw new NotImplementedException();
        }

        #endregion
    }
}
