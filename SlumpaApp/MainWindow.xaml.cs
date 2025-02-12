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

namespace SlumpaApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickSlumpa(object sender, RoutedEventArgs e)
    {
        bool lyckades = int.TryParse(txbMaxGräns.Text, out int maxGräns);
        if (lyckades == false)
        {
            txbFel.Text = "Fel. Ange ett giltigt maxvärde";
            return;
        }
        else
        {
            txbFel.Text= "";
        }
        //Slumpa ett tal
        int slumptal = Random.Shared.Next(1, maxGräns+1);

        // Skriv ut slumptalet i textboxen
        txbResultat.Text = slumptal.ToString();
    }
}