﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vivace.Infrastructure.Manipulation {
    /// <summary>
    /// 
    /// </summary>
    public class Command : ICommand {

        #region ICommand Members

        public virtual void Execute() {
            throw new NotImplementedException();
        }

        #endregion
    }
}
