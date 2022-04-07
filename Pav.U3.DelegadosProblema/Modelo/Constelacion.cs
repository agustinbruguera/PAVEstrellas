using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Pav.U3.DelegadosProblema
{

    public class Constelacion
    {
        private double _ancho;
        private double _alto;

        public string Nombre { get; set; }
        public List<Estrella> Estrellas { get; set; }

        public Constelacion()
        {
            _ancho = 100;
            _alto = 80;
            Estrellas = new List<Estrella>();
        }

        public void CrearEstrella(EstrellaControl control)
        {
            var random = new Random();
            var x = random.Next(1, (int)_ancho) / _ancho;
            var y = random.Next(1, (int)_alto) / _alto;
            var vida = random.Next(1, 300);
            var luminosidad = (Luminosidad)random.Next(1, 4);
            var estrella = new Estrella(vida);
            Estrellas.Add(estrella);
            control.Ubicar(x, y);
            control.Iluminar(luminosidad);
        }

        public void Eliminar(Control constelacionControl)
        {
            var resultado = MessageBox.Show("¿Seguro desea eliminar la constelación?", "PAV", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
            if (resultado)
            {
                constelacionControl.Controls.Clear();
                Estrellas.Clear();
            }
        }



        private void DetenerEstrella(Estrella estrella)
        {
            
        }

        private void EstrellaDesaparece(Estrella estrella)
        {
            DetenerEstrella(estrella);
            Estrellas.Remove(estrella);
        }
    }
}
