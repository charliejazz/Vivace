using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vivace.Notation.Manipulation {
    /// <summary>
    /// 
    /// </summary>
    public interface IUndoableCommand : ICommand {
        void Undo();
    }
}
