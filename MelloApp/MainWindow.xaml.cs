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

namespace MelloApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    int antalRöd = 0;
    int antalGrön = 0;
    int antalBlå = 0;
    int antalGul = 0;
    int antalLila = 0;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickRösta(object sender, RoutedEventArgs e)
    {
        // Vem klickade? 
        if (sender == röd)
        {
            // För varje klick +1
            antalRöd++;
        }
        else if (sender == grön)
        {
            // För varje klick +1
            antalGrön++;
        }
        else if (sender == blå)
        {
            // För varje klick +1
            antalBlå++;
        }
        else if (sender == gul)
        {
            // För varje klick +1
            antalGul++;
        }
        else if (sender == lila)
        {
            // För varje klick +1
            antalLila++;
        }
        txbResultat.Text = $"Röd: {antalRöd} Grön: {antalGrön} Blå: {antalBlå} Gul: {antalGul} Lila: {antalLila}";
    }

    private void KlickÅterställ(object sender, RoutedEventArgs e)
    {
        antalRöd = 0;
        antalBlå = 0;            antalGrön = 0;
        antalGul = 0;
        antalLila = 0;
        txbResultat.Text = $"Röd: {antalRöd} Grön: {antalGrön} Blå: {antalBlå} Gul: {antalGul} Lila: {antalLila}";

    }
}