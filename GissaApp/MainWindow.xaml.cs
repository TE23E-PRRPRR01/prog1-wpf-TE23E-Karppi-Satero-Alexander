using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GissaApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    // Slumpa fram ett heltal 1-1000
    int slumptal = Random.Shared.Next(1, 1001);
    List<int> listaGissningar = [];

    public MainWindow()
    {
        InitializeComponent();
    }
    private void KlickGissa(object sender, RoutedEventArgs e)
    {
        // Läs av ruta gissning
        string input = txbGissning.Text;

        // Konvertera till heltal
        bool lyckades = int.TryParse(input, out int gissning);
        // Lyckades konvertering
        if (lyckades && gissning < 1001 && gissning > 0)
        {
            // Lagra i listan
            listaGissningar.Add(gissning);

            if (gissning == slumptal)
            {
                txbResultat.Text = $"Rätt. {gissning} är det gömda talet";
            }
            else if (gissning < slumptal)
            {
                txbResultat.Text = $"Fel. {gissning} är mindre än det slumpade talet";
            }
            else if (gissning > slumptal)
            {
                txbResultat.Text = $"Fel. {gissning} är större än det slumpade talet";
            }
        }
        else
        {
            txbResultat.Text = $"Ogiltig inmatning";
        }
    }
    private void KlickVisaFacit(object sender, RoutedEventArgs e)
    {
        txbResultat.Text = $"Rätt svar är {slumptal}";
    }
    private void KlickVisaGissningar(object sender, RoutedEventArgs e)
    {
        // Skriv ut alla gissningar som finns i lista i stora rutan txbGissningar
        foreach (var tal in listaGissningar)
        {
            txbGissningar.Text += $"{tal}\n";
        }
    }
    private void KlickÅterställ(object sender, RoutedEventArgs e)
    {
        int slumptal = Random.Shared.Next(1, 1001);
        listaGissningar = [];
        txbGissning.Text = "";
        txbResultat.Text = "..Återställt..";
        txbGissningar.Text = "";
    }
}