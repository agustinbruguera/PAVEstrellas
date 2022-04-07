using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Pav.U3.Delegados.Dominio
{
    //public delegate void UbicarDelegate(double x, double y);
    //public delegate string IluminarDelegate(Luminosidad luminosidad);
    //public delegate void PasoDelTiempoDelegate();

    public class Constelacion
    {
        private double _ancho;
        private double _alto;
        private readonly Timer _lineaDeTiempo;

        private Action _pasoDelTiempo;
        public event EventHandler<int> Novedades;

        public string Nombre { get; set; }
        public List<Estrella> Estrellas { get; set; }
        

        public Constelacion()
        {
            _ancho = 100;
            _alto = 80;
            Estrellas = new List<Estrella>();
            _lineaDeTiempo = new Timer(250);
            _lineaDeTiempo.Elapsed += PasoDelTiempo;
            _lineaDeTiempo.Start();
        }

        private void PasoDelTiempo(object sender, ElapsedEventArgs e)
        {
            if (_pasoDelTiempo == null) return;
            _pasoDelTiempo();
        }

        public void CrearEstrella(Action<double, double> ubicar, Func<Luminosidad, string> iluminar, Action<Tamanio> tamanio)
        {
            var random = new Random();
            var x = random.Next(1, (int)_ancho) / _ancho;
            var y = random.Next(1, (int)_alto) / _alto;
            var vida = random.Next(1, 300);
            var genetica = random.Next(1, 100);
            //var luminosidad = (Luminosidad)random.Next(1, 4);
            var estrella = new Estrella(vida, genetica, iluminar, tamanio);
            _pasoDelTiempo += estrella.PasoDelTiempo;
            estrella.Desaparecer += EstrellaDesaparecer;
            Estrellas.Add(estrella);
            ubicar(x, y);
            //iluminar(luminosidad);
        }

        private void EstrellaDesaparecer(Estrella estrella)
        {
            _pasoDelTiempo -= estrella.PasoDelTiempo;
            estrella.Desaparecer -= EstrellaDesaparecer;
            Estrellas.Remove(estrella);
            OnNovedades();
        }

        public void Eliminar()
        {
            //var resultado = MessageBox.Show("¿Seguro desea eliminar la constelación?", "PAV", 
            //    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
            //if (resultado)
            //{
            //    constelacionControl.Controls.Clear();
            //    Estrellas.Clear();
            //}
        }



        private void DetenerEstrella(Estrella estrella)
        {
            
        }

        private void EstrellaDesaparece(Estrella estrella)
        {
            DetenerEstrella(estrella);
            Estrellas.Remove(estrella);
        }

        private void OnNovedades()
        {
            Novedades?.Invoke(this, Estrellas.Count);
        }
    }
}
