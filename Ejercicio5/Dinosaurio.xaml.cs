namespace Ejercicio5;

public partial class Dinosaurio : ContentPage
{
	public Dinosaurio()
	{
		InitializeComponent();
	}

	private void Dindin_Clicked(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(K.Text) && !string.IsNullOrEmpty(Nom.Text) && !string.IsNullOrEmpty(Mt.Text))
		{

			var Noom = Convert.ToString(Nom.Text);


			double libr, metros, kilos, Cent;
			kilos = Convert.ToDouble(K.Text);
			libr = kilos * 2.2;
			Libras.Text = libr.ToString("N2");
			metros = Convert.ToDouble(Mt.Text);
			Cent = metros * 100;
			Centimetros.Text = Cent.ToString();

		}
		else
		{
			DisplayAlert("Error", "Ingrese todos los datos", "Oki Doki Yo");
		}
	}
}