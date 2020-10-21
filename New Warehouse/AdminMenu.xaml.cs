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
    /// Interaction logic for AdminMenu.xaml
    /// </summary>
    public partial class AdminMenu : Window
    {
        

        public AdminMenu()
        {
            InitializeComponent();

        }
       

        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            using (WareHouseBEntities cxt = new WareHouseBEntities())
            {
                var viewquery = cxt.Klants.Select(k=>k);
                dataKlanten.ItemsSource = cxt.Klants.ToList();
            }

        }

        private void btnSaveChanges_Click(object sender, RoutedEventArgs e)
        {
            using (WareHouseBEntities cxt = new WareHouseBEntities())
            {
                
                cxt.SaveChanges();
            }
            
        }

        private void btnViewWorkers_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
