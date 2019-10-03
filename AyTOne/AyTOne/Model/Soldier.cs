using AyTOne.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AyTOne.Model
{
    public class Soldier : ISoldier
    {
        public Soldier()
        {
            Mision = "Sin mision asignada";
        }

        public Soldier(string MisionAsignada)
        {
            Mision = MisionAsignada;
        }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
        private string Mision { get; set; }

        public string DeServicio(bool Estado)
        {
            if(Estado == true)
            {
                return "Militar de servicio";
            }
            else
            {
                return "Militar de licencia";
            }
        }

        public void ObtenerMision(string TipoOficial)
        {
            string Respuesta;
            if(TipoOficial == "Superior")
            {
                Respuesta = Mision;

            }
            else
            {
                Respuesta = "Informacion confidencial";
            }
            App.Current.MainPage.DisplayAlert("Mision", Respuesta, "ok");
        }
    }
}
