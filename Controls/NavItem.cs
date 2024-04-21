using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Aromalia
{
    internal class NavItem : Panel
    {
        private int radius = 20; // Radio de los bordes redondeados (puedes ajustarlo según tus necesidades)

        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                Invalidate(); // Invalida el control para que se vuelva a dibujar con los nuevos valores
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (var path = new GraphicsPath())
            {
                path.AddArc(ClientRectangle.X, ClientRectangle.Y, 2 * radius, 2 * radius, 180, 90); // Esquina superior izquierda
                path.AddLine(ClientRectangle.X + radius, ClientRectangle.Y, ClientRectangle.Width - radius, ClientRectangle.Y); // Borde superior
                path.AddArc(ClientRectangle.Width - 2 * radius, ClientRectangle.Y, 2 * radius, 2 * radius, 270, 90); // Esquina superior derecha
                path.AddLine(ClientRectangle.Width, ClientRectangle.Y + radius, ClientRectangle.Width, ClientRectangle.Height - radius); // Borde derecho
                path.AddLine(ClientRectangle.Width, ClientRectangle.Height - radius, ClientRectangle.Width - radius, ClientRectangle.Height); // Borde inferior
                path.AddArc(ClientRectangle.Width - 2 * radius, ClientRectangle.Height - 2 * radius, 2 * radius, 2 * radius, 0, 90); // Esquina inferior derecha
                path.AddLine(ClientRectangle.Width - radius, ClientRectangle.Height, ClientRectangle.X + radius, ClientRectangle.Height); // Borde inferior
                path.AddArc(ClientRectangle.X, ClientRectangle.Height - 2 * radius, 2 * radius, 2 * radius, 90, 90); // Esquina inferior izquierda
                path.CloseFigure();

                Region = new Region(path);
                using (var pen = new Pen(BackColor, 1))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            Invalidate(); // Invalida el control cuando cambia su tamaño para que se vuelva a dibujar
        }
    }
}
