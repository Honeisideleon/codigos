namespace MauiApp7B;

public partial class MainPage : ContentPage
{
    // Variable para saber el estado
    bool encendido = false;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnBotonClicked_IfElse(object sender, EventArgs e)
    {
        // Cambiamos el valor
        encendido = !encendido;

        // Estructura IF/ELSE para cambiar el dibujo
        if (encendido)
        {
            // Foco encendido
            bombilloEmoji.Text = "💡";
        }
        else
        {
            // Círculo negro (apagado)
            bombilloEmoji.Text = "⚫";
        }
    }
}