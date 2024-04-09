using static System.Runtime.InteropServices.JavaScript.JSType;

namespace caltamiranoS2.Vistas;

public partial class vElementos : ContentPage
{
	public vElementos()
	{
		InitializeComponent();
	}

    private void btnPicker_Clicked(object sender, EventArgs e)
    {
		if (pkCiudad.SelectedIndex == 1) {
            DisplayAlert("Alerta","Seleccione un pais","Cerrar");
        }
        else { 

        string dato = pkCiudad.Items[pkCiudad.SelectedIndex].ToString();
        lblDatopk.Text ="El dato seleccionado es: "+dato;
			}
	
    }

    private void btnFechas_Clicked(object sender, EventArgs e)
    {
        string fecha = dpFecha.Date.ToString();
        lblDatopk.Text = "El dato seleccionado es: " + ;
    }
}