﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Pav.U3.Delegados.Dominio
{
    public delegate void DesaparecerDelegate(Estrella estrella);
    public class Estrella
    {
        public int Edad { get; set; }
        public int TiempoDeVida { get; set; }
        public int Genetica { get; set; }
        public int Temperatura { get; set; }
        public Luminosidad Luminosidad { get; set; }
        public Tamanio Tamanio { get; set; }

        private readonly Func<Luminosidad, string> _iluminar;
        private readonly Action<Tamanio> _tamanio;
        public event DesaparecerDelegate Desaparecer;

        public Estrella(int tiempoDeVida, int genetica, Func<Luminosidad, string> iluminar, Action<Tamanio> establecerTamanio)
        {
            TiempoDeVida = tiempoDeVida;
            Genetica = genetica;
            Edad = 0;
            _iluminar = iluminar;
            _tamanio = establecerTamanio;
            Temperatura = 0;
        }

        // Si nace >50 crece
        // Con el paso del tiempo cambia la temperatura -> Cambia el tamaño.
        // Manejar temperatura en numero 
        // La temperatura cambia de 3 en 3
        // Dependiendo de la edad, crece con una tasa mayor
        
        public void CrecimientoGenetica()
        {
            if (Genetica < 60)
            {
                Tamanio = Tamanio.Pequenia;
            }
            else if (Genetica >= 60)
            {
                Tamanio = Tamanio.Normal;
            }
            else Tamanio = Tamanio.Normal;
            _tamanio(Tamanio);            
        }

        public void PasoDelTiempo()
        {
            CrecimientoGenetica();
            if (Edad <= TiempoDeVida * 0.1)
            {
                Luminosidad = Luminosidad.Media;
            }
            else if (Edad > TiempoDeVida * 0.1 && Edad <= TiempoDeVida * 0.8)
            {
                Luminosidad = Luminosidad.Alta;
                Temperatura++;
            }            
            else
            {
                Luminosidad = Luminosidad.Baja;
                Temperatura--;
            }

            if (Edad <= TiempoDeVida)
            {
                Edad++;
            }
            else
            {
                Luminosidad = Luminosidad.Nula;
                OnDesaparecer();
            }

            

            if (Temperatura >= 15){
                Tamanio++;
            }
            else if (Temperatura >= 25)
            {
                Tamanio++;
            }
            else if (Temperatura <= 5)
            {
                Tamanio--;
            }
            
            
            _tamanio(Tamanio);
            _iluminar(Luminosidad);
        }

        private void OnDesaparecer()
        {
            Desaparecer?.Invoke(this);
        }
    }
}
