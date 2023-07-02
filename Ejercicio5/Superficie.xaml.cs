namespace Ejercicio5;

public partial class Superficie : ContentPage
{
	public Superficie()
	{
		InitializeComponent();
	}

	private void CounterBtn_Clicked(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(B.Text) && !string.IsNullOrEmpty(A.Text))
		{
			double bas, altura, super;
			bas = Convert.ToDouble(B.Text);
			altura = Convert.ToDouble(A.Text);

			super = bas * altura / 2;
			Superfic.Text = super.ToString();

		}
		else
		{
			DisplayAlert("Error", "Ingresen todos los datos", "Oki Doki Yo");
		}
	}
}