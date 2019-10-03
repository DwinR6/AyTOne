using AyTOne.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AyTOne.Model
{
   public class PersonaModel : IPersona
    {
        public PersonaModel(string DUI)
        {
            this.DUI = DUI;
        }
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        private string DUI { get; set; }

        public void DarIformacionConfidencial(string TipoPersona)
        {
            if (TipoPersona == "Autoridad")
            {
                App.Current.MainPage.DisplayAlert("Confidencial", $"Mi documento es: {DUI}", "ok");
            }
            else
            {
                App.Current.MainPage.DisplayAlert("", "Denegado", "ok");
            }
        }

        public string Presentarse()
        {
            string respuesta = $"Me llamo {Nombre} y vivo en : {Direccion}";
            return respuesta;
        }
    }
}
