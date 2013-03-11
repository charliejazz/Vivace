using System.Drawing;

namespace Vivace.UI.Controls.ViewPort {
    // represents a page
    public interface ILayer {
        ILayer Next { get; set; }
        ScoreViewPort ViewPort { get; }
        void Render(Graphics g);
        void RenderOutline(Graphics g);
        PointF Position { get; set; }
        RectangleF Rectangle { get; }
    }
}
