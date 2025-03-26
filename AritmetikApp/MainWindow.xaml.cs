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

        string matteTyp = txbOperator.Text.Trim();

        

        if (double.TryParse(tal1Text, out double tal1) && double.TryParse(tal2Text, out double tal2))
        {
            if (matteTyp == "+")
            {
                lblResultat.Content = tal1 + tal2;
            }
            else if (matteTyp == "-")
            {
                lblResultat.Content = tal1 - tal2;
            }
            else if (matteTyp == "/")
            {
                lblResultat.Content = tal1 / tal2;
            }
            else if (matteTyp == "*")
            {
                lblResultat.Content = tal1 * tal2;
            }
            else
            {
                lblResultat.Content = "Fel. Ange giltig operator";
            }
        }
        else
        {
            lblResultat.Content = "Fel. Ange giltigt heltal";
        }
    }
}
