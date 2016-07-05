using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace restaurantPOS
{
    internal class GelButton : Button
    {
        private Color gradientTop = Color.FromArgb(250, 126, 10);

        private Color gradientBottom = Color.FromArgb(247, 246, 222);

        [Category("Appearance"),
         Description("The color to use for the top portion of the gradient fill of the component.")]

        public Color GradientTop
        {

            get
            {

                return this.gradientTop;

            }

            set
            {

                this.gradientTop = value;

                this.Invalidate();

            }

        }

        [Category("Appearance"),
         Description("The color to use for the bottom portion of the gradient fill of the component.")]

        public Color GradientBottom
        {

            get
            {

                return this.gradientBottom;

            }

            set
            {

                this.gradientBottom = value;

                this.Invalidate();

            }

        }



        protected override void OnPaint(PaintEventArgs pevent)
        {

            Graphics g = pevent.Graphics;

            // Fill the background

            using (SolidBrush backgroundBrush = new SolidBrush(this.BackColor))
            {

                g.FillRectangle(backgroundBrush, this.ClientRectangle);

            }

            // Paint the outer rounded rectangle

            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle outerRect = new Rectangle(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width - 1,
                ClientRectangle.Height - 1);

            using (GraphicsPath outerPath = RoundedRectangle(outerRect, 5, 0))
            {

                using (
                    LinearGradientBrush outerBrush = new LinearGradientBrush(outerRect, gradientTop, gradientBottom,
                        LinearGradientMode.Vertical))
                {

                    g.FillPath(outerBrush, outerPath);

                }

                using (Pen outlinePen = new Pen(gradientTop))
                {

                    g.DrawPath(outlinePen, outerPath);

                }

            }

            // Paint the highlight rounded rectangle

            Rectangle innerRect = new Rectangle(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width - 1,
                ClientRectangle.Height/2 - 1);

            using (GraphicsPath innerPath = RoundedRectangle(innerRect, 5, 2))
            {

                using (
                    LinearGradientBrush innerBrush = new LinearGradientBrush(innerRect, Color.FromArgb(255, Color.White),
                        Color.FromArgb(0, Color.White), LinearGradientMode.Vertical))
                {

                    g.FillPath(innerBrush, innerPath);

                }

            }

            // Paint the text

            TextRenderer.DrawText(g, this.Text, this.Font, outerRect, this.ForeColor, Color.Transparent,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

        }

        private GraphicsPath RoundedRectangle(Rectangle boundingRect, int cornerRadius, int margin)
        {

            GraphicsPath roundedRect = new GraphicsPath();

            roundedRect.AddArc(boundingRect.X + margin, boundingRect.Y + margin, cornerRadius*2, cornerRadius*2, 180, 90);

            roundedRect.AddArc(boundingRect.X + boundingRect.Width - margin - cornerRadius*2, boundingRect.Y + margin,
                cornerRadius*2, cornerRadius*2, 270, 90);

            roundedRect.AddArc(boundingRect.X + boundingRect.Width - margin - cornerRadius*2,
                boundingRect.Y + boundingRect.Height - margin - cornerRadius*2, cornerRadius*2, cornerRadius*2, 0, 90);

            roundedRect.AddArc(boundingRect.X + margin, boundingRect.Y + boundingRect.Height - margin - cornerRadius*2,
                cornerRadius*2, cornerRadius*2, 90, 90);


            roundedRect.CloseFigure();

            return roundedRect;

        }
    }

}
