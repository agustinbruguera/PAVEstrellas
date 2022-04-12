using Pav.U3.Delegados.Dominio;
using System;
using System.Windows.Forms;

namespace Pav.U3.DelegadosProblema
{
    public partial class ConstelacionVista : Form
    {
        private Constelacion _constelacion;
        public ConstelacionVista()
        {
            InitializeComponent();
            _constelacion = new Constelacion();
            _constelacion.Novedades += ConstelacionNovedades;
        }

        private void ConstelacionNovedades(object sender, int totalEstrellas)
        {
            ActualizarTotal(totalEstrellas);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var estrella = new EstrellaControl(pConstelacion);
            _constelacion.CrearEstrella(estrella.Ubicar, estrella.Iluminar, estrella.EstablecerTamanio);
            ActualizarTotal(_constelacion.Estrellas.Count);
        }

        private void ActualizarTotal(int total)
        {
            if (InvokeRequired)
            {
                BeginInvoke((Action)(() =>
                {
                    ActualizarLabel(total);
                }));
            }
            else
            {
                ActualizarLabel(total);
            }   
        }

        private void ActualizarLabel(int total)
        {
            lblNovedades.Text = $"Cantidad de Estrellas: {total}";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _constelacion.Eliminar(EliminarConstelacion);
            ActualizarTotal(_constelacion.Estrellas.Count);
        }

        public void EliminarConstelacion()
        {
            pConstelacion.Controls.Clear();
        }
    }
}
