using System;
using System.Collections.Generic;
using System.Data;
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

                var viewquery = cxt.Klants.Select(k => k);
                dataKlanten.ItemsSource = viewquery.ToList();
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
            using (WareHouseBEntities cxt = new WareHouseBEntities())
            {
                var viewworkerquery = cxt.Leveranciers.Select(l=>l);
                dtWorkers.ItemsSource = viewworkerquery.ToList();
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            using (WareHouseBEntities cxt = new WareHouseBEntities())
            {
               
               
            }
        }

        private void dataKlanten_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            {
                DataGrid dg = (DataGrid)sender;
                DataRowView dataRowView = dg.SelectedItem as DataRowView;
                if (dataRowView != null)
                {
                    txtEmail.Text = dataRowView["Emaiadress"].ToString();
                }
            }
        }
    }
}
