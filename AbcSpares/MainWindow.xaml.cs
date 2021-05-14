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

namespace AbcSpares
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Inventory> inventoryList = new List<Inventory>();

        public MainWindow()
        {
            InitializeComponent();
            lvSpares.ItemsSource = inventoryList;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = txbName.Text;
                string description = txbDescription.Text;
                string type = cmbType.Text;
                string brand = txbBrand.Text;
                double price = Convert.ToDouble(txbPrice.Text);

                Inventory inventory = new Inventory(name, description, type, brand, price);
                inventoryList.Add(inventory);
                MessageBox.Show("Inventory added !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.ToString());
            }
            txbName.Clear();
            txbDescription.Clear();
            cmbType.SelectedItem = null;
            txbBrand.Clear();
            txbPrice.Clear();

            Logger logger = Logger.GetLogger();
            logger.WriteMessage();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lvSpares.ItemsSource = inventoryList;
        }
    }
}
