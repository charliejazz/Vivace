using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Vivace.Infrastructure.Common {
    /// <summary>
    /// 
    /// </summary>
    public class GraphicsContext {
        private Graphics graphics;
        private GraphicsDevice device = GraphicsDevice.Screen;

        public GraphicsContext(Graphics graphics, GraphicsDevice device) {
            this.graphics = graphics;
            this.device = device;
        }

        public GraphicsContext() {
        }


        public GraphicsDevice Device {
            get { return device; }
            set { device = value; }
        }

        public Graphics Graphics {
            get { return graphics; }
            set { graphics = value; }
        }
    }
}
