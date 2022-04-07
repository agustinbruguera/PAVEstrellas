using System.Drawing;
using System.Windows.Forms;
using Pav.U3.Delegados.Dominio;

namespace Pav.U3.DelegadosProblema
{
    public partial class EstrellaControl : UserControl
    {
        public EstrellaControl()
        {
            InitializeComponent();
            Iluminar(Luminosidad.Nula);
            EstablecerTamanio(Tamanio.Normal);
        }

        public EstrellaControl(Control parent):this()
        {
            Parent = parent;
            Parent.Controls.Add(this);
        }

        public void Ubicar(double x, double y)
        {
            Location = new Point((int)(x * Parent.Width), (int)(y * Parent.Height));
        }

        public string Iluminar(Luminosidad luminosidad)
        {
            if (luminosidad == Luminosidad.Baja)
            {
                lblEstrella.ForeColor = Color.DimGray;
            }
            else if (luminosidad == Luminosidad.Media)
            {
                lblEstrella.ForeColor = Color.Gray;
            }
            else if(luminosidad == Luminosidad.Alta)
            {
                lblEstrella.ForeColor = Color.White;
            }
            else
            {
                lblEstrella.ForeColor = Color.Black;
            }

            return lblEstrella.ForeColor.ToString();
        }

        public void EstablecerTamanio(Tamanio tamanio)
        {
            if (tamanio == Tamanio.Pequenia)
            {
                lblEstrella.Font = new Font(lblEstrella.Font.FontFamily, 32);
            }
            else if (tamanio == Tamanio.Normal)
            {
                lblEstrella.Font = new Font(lblEstrella.Font.FontFamily, 42);
            }
            else if (tamanio == Tamanio.Grande)
            {
                lblEstrella.Font = new Font(lblEstrella.Font.FontFamily, 49);
            }
            else if (tamanio == Tamanio.Gigante)
            {
                lblEstrella.Font = new Font(lblEstrella.Font.FontFamily, 56);
            }
            else
            {
                lblEstrella.Font = new Font(lblEstrella.Font.FontFamily, 24);
            }
        }
    }
}
