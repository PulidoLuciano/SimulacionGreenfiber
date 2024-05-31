using Presentacion.Presentadores;
using Presentacion.Vistas;
using Vistas.Interfaces;

namespace Vistas
{
    public partial class VistaContenedora : VistaContenedoraConPresentador, IVistaContenedora
    {
        public VistaContenedora()
        {
            InitializeComponent();
            titleLabel.Text = "Greenfiber";
            DoubleBuffered = true;
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;
            PaddingMaximize();
        }

        event EventHandler IVistaContenedora.AlCargar
        {
            add
            {
                Load += value;
            }

            remove
            {
                Load -= value;
            }
        }

        public void CerrarVista()
        {
            this.Close();
        }

        public void MaximizarVista()
        {
            WindowState = (WindowState == FormWindowState.Normal) ? FormWindowState.Maximized
                                                                  : FormWindowState.Normal;
        }

        public void MinimizarVista()
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PaddingMaximize()
        {
            if (WindowState == FormWindowState.Normal) Padding = new Padding(1);
            else Padding = new Padding(0);
        }

        #region Arrastrar
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        public void ArrastrarVista(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                // Checks if Y = 0, if so maximize the form
                if (this.Location.Y == 0) { this.WindowState = FormWindowState.Maximized; }
            }
        }

        #region Eventos
        private void Form1_Resize(object sender, EventArgs e)
        {
            PaddingMaximize();
        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            CerrarVista();
        }

        private void botonMaximizar_Click(object sender, EventArgs e)
        {
            MaximizarVista();
        }

        private void botonMinimizar_Click(object sender, EventArgs e)
        {
            MinimizarVista();
        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            ArrastrarVista(e);
        }

        private void topPanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MaximizarVista();
        }
        #endregion

        #region Resize
        private const int
        HTLEFT = 10,
        HTRIGHT = 11,
        HTTOP = 12,
        HTTOPLEFT = 13,
        HTTOPRIGHT = 14,
        HTBOTTOM = 15,
        HTBOTTOMLEFT = 16,
        HTBOTTOMRIGHT = 17;

        const int _ = 10;

        new Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, _); } }
        new Rectangle Left { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }
        new Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }
        new Rectangle Right { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }

        Rectangle TopLeft { get { return new Rectangle(0, 0, _, _); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - _, 0, _, _); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - _, _, _); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }


        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84) // WM_NCHITTEST
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (Top.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                else if (Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
            }
        }
        #endregion
    }

    public class VistaContenedoraConPresentador : VistaBase<PresentadorContenedora> { }
}
