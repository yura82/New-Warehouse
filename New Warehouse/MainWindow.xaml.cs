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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace New_Warehouse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string paswoord = txtPaswoord.Text;
            if (txtUsername.Text == "" || txtPaswoord.Text == "")
            {
                MessageBox.Show("Please fill in User name and Pasword ");
            }
            using (WareHouseBEntities cxt = new WareHouseBEntities())
            {
                var checkPaswoord = cxt.Paswoords.Where(p => p.UserName == username && p.UserPaswoord == paswoord).Count();
                if (checkPaswoord == 1)
                {
                    Paswoord login = cxt.Paswoords.Where(p => p.UserName == username).FirstOrDefault();
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Not corect paswoord or username", "Error Box");
                }

            }

        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            StartMenu startMenu = new StartMenu();
            startMenu.Show();
            this.Close();
        }
    }
}
