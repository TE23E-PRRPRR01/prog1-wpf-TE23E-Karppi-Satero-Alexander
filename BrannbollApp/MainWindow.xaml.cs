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

namespace BrannbollApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    //Skapa variablerna för lagen
    int poängInne = 0;
    int poängUte = 0;

    public MainWindow()
    {
        InitializeComponent();
    }


    private void KlickFrivarv(object sender, RoutedEventArgs e)
    {
        // Lägg till poäng
        poängInne += 5;

        // Skriv ut poängen
        txbInne.Text = $"{poängInne}";

        //historik.Add += $"\n{DateTime.Now.ToString("HH:mm:ss")} Frivarv +5 poäng inne";
        // Skriv i historiken

        string tidigareText = txbHistorik.Text;
        txbHistorik.Text = "";
        txbHistorik.Text += $"""
        {DateTime.Now.ToString("HH:mm:ss")} Frivarv +5 poäng lag inne | Total Inne: {poängInne}
        {tidigareText}
        """;

    }
    private void KlickBränning(object sender, RoutedEventArgs e)
    {
        poängUte += 2;
        txbUte.Text = $"{poängUte}";

        // Skriv i historiken

        string tidigareText = txbHistorik.Text;
        txbHistorik.Text = "";
        txbHistorik.Text += $"""
        {DateTime.Now.ToString("HH:mm:ss")} Bränning +2 poäng lag ute | Total Ute: {poängUte}
        {tidigareText}
        """;
    }
    private void KlickLyra(object sender, RoutedEventArgs e)
    {
        poängUte += 3;
        txbUte.Text = $"{poängUte}";

        // Skriv i historiken

        string tidigareText = txbHistorik.Text;
        txbHistorik.Text = "";
        txbHistorik.Text += $"""
        {DateTime.Now.ToString("HH:mm:ss")} Lyra +3 poäng lag ute | Total Ute: {poängUte}
        {tidigareText}
        """;
    }
    private void KlickVarv(object sender, RoutedEventArgs e)
    {
        poängInne++;
        txbInne.Text = $"{poängInne}";

        // Skriv i historiken

        string tidigareText = txbHistorik.Text;
        txbHistorik.Text = "";
        txbHistorik.Text += $"""
        {DateTime.Now.ToString("HH:mm:ss")} Varv +1 poäng lag inne | Total Inne: {poängInne}
        {tidigareText}
        """;
    }
}