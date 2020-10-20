using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace New_Warehouse
{
    /// <summary>
    /// Interaction logic for StartMenu.xaml
    /// </summary>
    public partial class StartMenu : Window
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            using (WareHouseBEntities cxt = new WareHouseBEntities())
            {
                cxt.Klants.Add(new Klant()
                {
                    Voornaam = txtVoornam.Text.Trim(),
                    Achternaam = txtAChternaam.Text.Trim(),
                    Straatnaam = txtStraatnaam.Text.Trim(),
                    Huisnummer = Convert.ToInt32(txtHuisnummer.Text.Trim()),
                    Postcode = Convert.ToInt32(txtPostcode.Text.Trim()),
                    Gemeente = txtGemeente.Text.Trim(),
                    Emaiadress = txtEmail.Text.Trim(),
                    Telefoonnummer = Convert.ToInt32(txtTelefonnummer.Text.Trim()),
                    AangemaaktOp = dtAangemaktop.SelectedDate,
                    Opmerking = txtOpmerking.Text.Trim()
                    
                }) ;
                cxt.SaveChanges();
            }
            using (WareHouseBEntities cxt = new WareHouseBEntities())
            {
                Random random = new Random();
                for (int i = 0; i < 5; i++)
                {
                    random.Next();
                }
                int randompaswoord = random.Next();
                cxt.Paswoords.Add(new Paswoord()
                {
                    UserName = txtVoornam.Text ,
                    UserPaswoord = randompaswoord.ToString(),
                    UserType = "Klant"
                }) ;
                MessageBox.Show($"Your user name is{txtVoornam.Text} and paswoord is {randompaswoord} ");
                cxt.SaveChanges();
            }

        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }
        public void Reset()
        {
            txtAChternaam.Text = "";
            txtEmail.Text = "";
            txtVoornam.Text = "";
            txtOpmerking.Text = "";
            txtPostcode.Text = "";
            txtGemeente.Text = "";
            txtStraatnaam.Text = "";
            txtHuisnummer.Text = "";
        }

        private void btnCansel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
