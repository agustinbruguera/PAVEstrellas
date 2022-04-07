using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Pav.U3.DelegadosProblema
{
    public class Estrella
    {
        public int Edad { get; set; }
        public int TiempoDeVida { get; set; }
        public Luminosidad Luminosidad { get; set; }

        public Estrella(int tiempoDeVida)
        {
            TiempoDeVida = tiempoDeVida;
            Edad = 0;
        }

        public void PasoDelTiempo()
        {
            if (Edad <= TiempoDeVida * 0.1)
            {
                Luminosidad = Luminosidad.Media;
            }
            else if (Edad > TiempoDeVida * 0.1 && Edad <= TiempoDeVida * 0.8)
            {
                Luminosidad = Luminosidad.Alta;
            }
            else
            {
                Luminosidad = Luminosidad.Baja;
            }

            if (Edad <= TiempoDeVida)
            {
                Edad++;
            }
            else
            {
                Luminosidad = Luminosidad.Nula;
            }
        }
    }
}
