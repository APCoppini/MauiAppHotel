namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}

   

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new Sobre());
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao navegar: {ex.Message}");
            await DisplayAlert("Erro", "Ocorreu um erro na página Sobre.", "OK");
        }

    }
    

    
}