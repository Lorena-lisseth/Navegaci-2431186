namespace Ejercicio5;

public partial class Cambio : ContentPage
{
	public Cambio()
	{
		InitializeComponent();
	}

	private void vuvu_Clicked(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(Cost.Text) && !string.IsNullOrEmpty(Cant.Text))
		{
			double costo, money, Vuel;
			costo = Convert.ToDouble(Cost.Text);
			money = Convert.ToDouble(Cant.Text);

			Vuel = costo - money;
			Vuelto.Text = Vuel.ToString();
		}
		else
		{
			DisplayAlert("Error", "Ingrese todos los datos", "Oki Doki Yo");
		}
	}
}