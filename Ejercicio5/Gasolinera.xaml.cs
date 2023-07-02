namespace Ejercicio5;

public partial class Gasolinera : ContentPage
{
	public Gasolinera()
	{
		InitializeComponent();
	}

	private void Galon_Clicked(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(Gal.Text))
		{
			double galo, Lit;
			galo = Convert.ToDouble(Gal.Text);

			Lit = galo * 3.78541;
			litro.Text = Lit.ToString("N2");
		}
		else
		{
			DisplayAlert("Error", "Por favor ingrese el dato", "Ok");
		}
	}
}