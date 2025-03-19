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

namespace AritmetikApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void KlickBeräkna(object sender, RoutedEventArgs e)
    {
        string tal1Text = txbTal1.Text.Trim();
        string tal2Text = txbTal2.Text.Trim();

        int tal1 = StringTillInt(tal1Text);
        int tal2 = StringTillInt(tal2Text);
        string matteTyp = txbOperator.Text;

        if (matteTyp == "*")
        {
            lblResultat.Content = tal1 * tal2;
        }
        else
        {

        }

    }

    private int StringTillInt(string text)
    {
        int.TryParse(text, out int tal);
        return tal;
    }
}
