namespace CalculadoraIMC.Pages;

public partial class Home : ContentPage
{
    public Home()
    {
        InitializeComponent();
    }

    private void OnClicked(object sender, EventArgs e)
    {

        double peso = Convert.ToDouble(pesoEntry.Text);
        double altura = Convert.ToDouble(alturaEntry.Text);
        double imc = CalculoImc(altura, peso);
        VerificarImc(imc);
    }

    private double CalculoImc(double altura, double peso)
    {
        return peso / (altura * 2);
    }

    private void VerificarImc(double imc)
    {
        string mensagem = $"Seu imc e {Math.Round(imc, 2)}";

        switch (imc)
        {
            case <18.5:
                DisplayAlert("Abaixo do Peso", mensagem, "OK");
                break;

            case  < 25:
                DisplayAlert("Peso Adequado", mensagem, "OK");
                break;

            case < 30:
                DisplayAlert("Sobrepeso", mensagem, "OK");
                break;

            case < 35:
                DisplayAlert("Obesidade Grau 1", mensagem, "OK");
                break;

            case < 40:
                DisplayAlert("Obesidade Grau 2", mensagem, "OK");
                break;

            case < 50:
                DisplayAlert("Obesidade Grau 3", mensagem, "OK");
                break;

            case < 60:
                DisplayAlert("Obesidade Grau 4", mensagem, "OK");
                break;

            case < 61:
                DisplayAlert("Apto a competir no Quilos Mortais", mensagem, "OK");
                break;
        }
    }
}
