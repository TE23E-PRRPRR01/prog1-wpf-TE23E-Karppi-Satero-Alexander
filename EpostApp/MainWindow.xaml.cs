using System.Windows;
using System.Net.Mail;


namespace EpostApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void KlickSkicka(object sender, RoutedEventArgs e)
    {
        // Läs av epost och meddelanden
        string epost = txbEpost.Text;
        string meddelanden = txbMeddelande.Text;

        // Koppla upp på en mail-server 
        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
        smtp.EnableSsl = true;
        smtp.Credentials = new NetworkCredential("user", "pass");


        // Sanity check
        if (epost != "" && meddelanden != "")
        {
            smtp.Send(id, epost, "Meddelande från WPF", meddelanden);
            lblStatus.Content = "Ok";
        }
        else
        {
            lblStatus.Content = "Fel! Något av fälten är tomma.";
        }
    }

    private void ChangedEpost(object sender, RoutedEventArgs e)
    {
        // Läs av epost
        string epost = txbEpost.Text;

        // Kontrollera epostformatet med regex
        string regexEpost = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        if (!Regex.IsMatch(epost, regexEpost))
        {
            // Visa felmeddelande
            lblStatus.Content = "Du måste ange en giltig epostadress!";
        }
        else
        {
        }
    }
}