namespace caltamiranoS2.Vistas;

public partial class vLogin : ContentPage
{
	public vLogin()
	{
		InitializeComponent();
	}

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
		string Usuario = "uisrael";
		string contrasena = "12345";
		if (Usuario==txtUsuario.Text && contrasena == txtContrasena.Text)
		{
			Navigation.PushAsync(new vElementos());
		}
		else
		{
			DisplayAlert("Alerta","Usuario/ Contrase�a incorrectos","Cerrar");
			txtUsuario.Text = "";
			txtContrasena.Text = "";

		}

    }
}