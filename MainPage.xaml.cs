using System.Globalization;

namespace Practica4_Calculadora_Interactiva;

public partial class MainPage : ContentPage
{
    private double primerNumero;
    private double segundoNumero;
    private string operadorActual = string.Empty;
    private bool operacionPendiente;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnNumberClicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        var numeroPresionado = button.Text ?? string.Empty;

        if (lblDisplay.Text == "0" || operacionPendiente)
        {
            lblDisplay.Text = numeroPresionado == "." ? "0." : numeroPresionado;
            operacionPendiente = false;
            return;
        }

        if (numeroPresionado == "." && lblDisplay.Text?.Contains('.') == true)
        {
            return;
        }

        lblDisplay.Text += numeroPresionado;
    }

    private void OnOperatorClicked(object sender, EventArgs e)
    {
        var button = (Button)sender;

        if (!TryGetDisplayValue(out primerNumero))
        {
            lblDisplay.Text = "Error";
            operacionPendiente = true;
            return;
        }

        operadorActual = button.Text ?? string.Empty;
        operacionPendiente = true;
    }

    private void OnEqualsClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(operadorActual))
        {
            return;
        }

        if (!TryGetDisplayValue(out segundoNumero))
        {
            lblDisplay.Text = "Error";
            operacionPendiente = true;
            return;
        }

        double resultado;

        switch (operadorActual)
        {
            case "+":
                resultado = primerNumero + segundoNumero;
                break;
            case "-":
                resultado = primerNumero - segundoNumero;
                break;
            case "×":
                resultado = primerNumero * segundoNumero;
                break;
            case "÷":
                if (segundoNumero != 0)
                {
                    resultado = primerNumero / segundoNumero;
                    break;
                }

                lblDisplay.Text = "Error";
                operacionPendiente = true;
                return;
            default:
                return;
        }

        lblDisplay.Text = FormatNumber(resultado);
        AgregarHistorial(primerNumero, operadorActual, segundoNumero, resultado);
        operacionPendiente = true;
        operadorActual = string.Empty;
    }

    private void OnClearClicked(object sender, EventArgs e)
    {
        lblDisplay.Text = "0";
        lblHistorial.Text = string.Empty;
        primerNumero = 0;
        segundoNumero = 0;
        operadorActual = string.Empty;
        operacionPendiente = false;
    }

    private bool TryGetDisplayValue(out double value)
    {
        return double.TryParse(
            lblDisplay.Text,
            NumberStyles.Float,
            CultureInfo.InvariantCulture,
            out value);
    }

    private static string FormatNumber(double value)
    {
        return value.ToString(CultureInfo.InvariantCulture);
    }

    private void AgregarHistorial(double primerValor, string operador, double segundoValor, double resultado)
    {
        var operacion = $"{FormatNumber(primerValor)} {operador} {FormatNumber(segundoValor)} = {FormatNumber(resultado)}";
        var lineasActuales = lblHistorial.Text?.Split('\n', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();
        var nuevasLineas = new[] { operacion }.Concat(lineasActuales).Take(3);
        lblHistorial.Text = string.Join('\n', nuevasLineas);
    }
}
