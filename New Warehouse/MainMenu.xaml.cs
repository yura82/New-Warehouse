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
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnShopping_Click(object sender, RoutedEventArgs e)
        {
            ShopScreen shopScreen = new ShopScreen();
            shopScreen.Show();
            this.Close();
        }

        private void btnStrings_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnWinds_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnProductInfor_Click(object sender, RoutedEventArgs e)
        {
            using (WareHouseBEntities cxt = new WareHouseBEntities())
            {
                
            }
        }

        
    }
}
