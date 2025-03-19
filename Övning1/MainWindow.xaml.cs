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

namespace Övning1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickRäkna(object sender, RoutedEventArgs e)
    {
        bool lyckades = int.TryParse(txbVikt.Text, out int vikt); 
        if (vikt <= 50 && lyckades == true)
        {
            lblSvar.Content = $"Brev som väger {vikt} g kostar 22 kr (1 frimärke)";     
        }
        else if (vikt <= 100 && lyckades == true)
        {
            lblSvar.Content = $"Brev som väger {vikt} g kostar 44 kr (2 frimärke)";     
        }
        else if (vikt <= 250 && lyckades == true)
        {
            lblSvar.Content = $"Brev som väger {vikt} g kostar 66 kr (3 frimärke)";     
        }
        else if (vikt <= 500 && lyckades == true)
        {
            lblSvar.Content = $"Brev som väger {vikt} g kostar 88 kr (4 frimärke)";     
        }
        else if (vikt <= 1000 && lyckades == true)
        {
            lblSvar.Content = $"Brev som väger {vikt} g kostar 132 kr (6 frimärke)";     
        }
        else if (vikt <= 2000 && lyckades == true)
        {
            lblSvar.Content = $"Brev som väger {vikt} g kostar 154 kr (7 frimärke)";     
        }
        else if (vikt > 2000 && lyckades == true)
        {
            lblSvar.Content = $"Brevet väger för mycket";     
        }
        else
        {
            lblSvar.Content = $"Ange gilltigt heltal";
        }
        
    }
}