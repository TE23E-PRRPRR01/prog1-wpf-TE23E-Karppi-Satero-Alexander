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

namespace KlappApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    //Våra variabler
    int maxJulklappar = 0;
    List<string> listaJulklappar = [];

    public MainWindow()
    {
        InitializeComponent();

        // Lås gränssnitt
        stpInmatning.IsEnabled = false;
        stpListan.IsEnabled = false;

        // Koppla List till listbox
        lsbJulklappar.ItemsSource = listaJulklappar;
    }

    private void KlickAnge(object sender, RoutedEventArgs e)
    {
        // Läs av rutan
        string antal = txbAntal.Text;

        // Första kontroll
        if (antal == "")
        {
            txbStatus.Text = "Ange ett heltal";
        }
        else
        {
            bool lyckades = int.TryParse(antal, out int talet);
            if (lyckades == true)
            {
                maxJulklappar = talet;   
                txbStatus.Text = $"Max julklappar är {maxJulklappar}";


                // Lås upp gränssnitt
                stpMax.IsEnabled = false;
                stpInmatning.IsEnabled = true;
                stpListan.IsEnabled = true;
            }
            else
            {
                txbStatus.Text = "Ange ett heltal";
            }
        }
    }

    private void KlickLäggTill(object sender, RoutedEventArgs e)
    {
        // läs av textrutorna
        string julklapp = txbJulklapp.Text;
        string mottagare = txbMottagare.Text; 

        if (julklapp == "")
        {
            txbStatus.Text = "Ange en julklapp";
        }
        else if (mottagare == "")
        {
            txbStatus.Text = "Ange en mottagare";
        }
        else
        {    
            listaJulklappar.Add($"{julklapp} till {mottagare}");
            lsbJulklappar.Items.Refresh();
        }
    }

    private void KlickBytUt(object sender, RoutedEventArgs e)
    {
        
    }
}