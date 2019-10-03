using AyTOne.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AyTOne.View
{
	public class PersonaView : ContentPage
	{
		public PersonaView ()
		{
            EntryNombre = new Entry()
            {
                Placeholder = "Nombre",
                
            };
            EntryDireccion = new Entry()
            {
                Placeholder = "Direccion"
            };
            EntryDUI = new Entry()
            {
                Placeholder = "DUI"
               
            };
            EntryTipoPersona = new Entry()
            {
                Placeholder = "Tipo de persona"
            };

            BtnPersona = new Button()
            {
                Text = "Conocer o identificar persona",
                BackgroundColor = Color.FromHex("#6A7580"),

            };
            lblPersona = new Label()
            {

            };
            BtnPersona.Clicked += BtnPersona_Clicked;
            Content = new StackLayout {
                Padding = 10,
                BackgroundColor = Color.FromHex("#355D80"),
                Children =
                {
                    EntryNombre, EntryDireccion, EntryDUI, EntryTipoPersona, BtnPersona, lblPersona
                }

            };

		}

        private void BtnPersona_Clicked(object sender, EventArgs e)
        {
            PersonaModel Person = new PersonaModel(EntryDUI.Text);
            Person.Direccion = EntryDireccion.Text;
            lblPersona.Text += Person.Presentarse();
            Person.DarIformacionConfidencial(EntryTipoPersona.Text);
        }

        Entry EntryNombre, EntryDireccion, EntryDUI, EntryTipoPersona;
        Button BtnPersona;
        Label lblPersona;
	}
}