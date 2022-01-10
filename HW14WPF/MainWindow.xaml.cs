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
using System.Collections.ObjectModel;

namespace HW14WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Product> products;

        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProductName = "Хлеб",
                ProductPrice = 45,
                Image = 1,
                ProductType = ProductTypes.Food
            });
            products.Add(new Product()
            {
                ProductName = "Сыр",
                ProductPrice = 415,
                Image = 1,
                ProductType = ProductTypes.Food
            });
            products.Add(new Product()
            {
                ProductName = "Пылесос",
                ProductPrice = 4580,
                Image = 2,
                ProductType = ProductTypes.Appliances
            });

            lstBox.ItemsSource = products;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            products.Add(new Product()
            {
                ProductName = "Микроволновка",
                ProductPrice = 3415,
                Image = 2,
                ProductType = ProductTypes.Appliances
            });
        }
    }
}
