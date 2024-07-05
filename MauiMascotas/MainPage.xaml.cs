using MauiMascotas.vistas;
using Microsoft.Win32;

namespace MauiMascotas
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            var titleLabel = new Label
            {
                Text = "login",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                FontSize = 40, // Ajusta el tamaño de la fuente si es necesario
                TextColor = Colors.Black // Cambia el color del texto si es necesario
            };

            NavigationPage.SetTitleView(this, titleLabel);
        }

        private void btIngresar_Clicked(object sender, EventArgs e)
        {

        }

        private void btregistrarse_Clicked(object sender, EventArgs e)
        {
           Navigation.PushAsync(new PagRegistro());

        }

        private void RecuperearContrasena(object sender, TappedEventArgs e)
        {

        }
    }
}
