using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace examen1
{
    public partial class MainPage : ContentPage
    {
        public static List<Preguntas> listapreguntas = new List<Preguntas>
        {
            new Preguntas
            {
                Id = 1,
                Quest_ = "1.Las herramientas básicas de la gestión de memoria son",
                resp1_ = "La paginación y la segmentación.",
                resp2_ = "La segmentación y la reubicación.",
                resp3_ = "La reubicación y el almacenamiento.",
                resp4_ = "El almacenamiento y la flexibilidad.",
                Correcto = "La paginación y la segmentación.",
            },
            new Preguntas
            {
                Id = 2,
                Quest_ = "2.El procesador es, en sí mismo, un recurso y es administrado por.",
                resp1_ = "El sistema operativo",
                resp2_ = " La memoria principal",
                resp3_ = "El usuario final",
                resp4_ = "El programador",
                Correcto = "El sistema operativo",
            },
            new Preguntas
            {
                Id = 3,
                Quest_ = "3.Un sistema informático consta de.",
                resp1_ = "Monitor, pantalla y teclado",
                resp2_ = "Mouse, sistema operativo y CPU",
                resp3_ = "Procesador, memoria y componentes de Entrada y Salida",
                resp4_ = "Redes, equipos móviles y fijos",
                Correcto = "Procesador, memoria y componentes de Entrada y Salida"
            },
            new Preguntas
            {
                Id = 4,
                Quest_ = "4.La memoria cache es usada por.",
                resp1_ = "La memoria principal para guardar información detallada de los programas",
                resp2_ = "El procesador para reducir el tiempo de acceso a datos ubicados en la memoria principal",
                resp3_ = "La memoria RAM para ejecutar de manera rápida el SO, programas y software",
                resp4_ = "Todas las anteriores",
                Correcto = "El procesador para reducir el tiempo de acceso a datos ubicados en la memoria principal"

            }
        };
        int point = 1, score = 0;
        string RespuestaCorrecta;
        public MainPage()
        {
            InitializeComponent();
        }

        protected void OnNavigatedTo(NavigationEventArgs e)
        {

        }

        private string SetPregunta(int ID)
        {
            Preguntas list = listapreguntas.Where(a => a.Id == ID).SingleOrDefault();
            try
            {
                lblpreguntita.Text = list.Quest_;
                btnresp1.Text = list.resp1_;
                btnresp2.Text = list.resp2_;
                btnresp3.Text = list.resp3_;
                btnresp4.Text = list.resp4_;
                RespuestaCorrecta = list.Correcto;
            }
            catch (Exception)
            {

            }

            return RespuestaCorrecta;
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            if (btnresp1.Text == RespuestaCorrecta)
            {
                score++;
            }
            point++;
            SetPregunta(point);
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            if (btnresp2.Text == RespuestaCorrecta)
            {
                score++;
            }
            point++;
            SetPregunta(point);
        }

        private void Button3_Clicked(object sender, EventArgs e)
        {
            if (btnresp3.Text == RespuestaCorrecta)
            {
                score++;
            }
            point++;
            SetPregunta(point);
        }

        private void Button4_Clicked(object sender, EventArgs e)
        {
            if (btnresp4.Text == RespuestaCorrecta)
            {
                score++;
            }
            point++;
            SetPregunta(point);
            btnPuntuacion.IsVisible = true;

        }
        async void MostrarAlerta(object sender, EventArgs e)
        {
            await DisplayAlert("Puntuación", "Su Puntuación final es de: " + score + " / 4 puntos.", "OK");
        }
    }
}
