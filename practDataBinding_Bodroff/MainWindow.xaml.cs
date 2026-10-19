using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace practDataBinding_Bodroff
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Product Product = new Product();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = Product;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //сохранить

            //int chekid = 1;

            //if (Product.Name != "" && Product.Category != "" && Product.Price > 0 && Product.Quantity > 0)
            //{

                //Product product = new Product();

                //product.Name = Product.Name;

                //product.Category = Product.Category;

                //product.Price = Product.Price;

                //product.Quantity = Product.Quantity;

                //while(File.Exists(chekid + ".json"))
                //{

                //    chekid++;

                //}

                //product.Id = chekid;

                //string namefile = chekid + ".json";

                //string json = JsonSerializer.Serialize(product);

                //File.WriteAllText(namefile, json);

                //MessageBox.Show("Сохраненно в файл = " + namefile);


                if (Product.Name != "" && Product.Category != "" && Product.Price > 0 && Product.Quantity > 0)
                {

                    
                        int chekid = 1;

                        while (File.Exists(chekid + ".json"))
                        {
                            chekid++;
                        }

                        Product.Id = chekid;
                    

                    string namefile = Product.Id + ".json";

                    string json = JsonSerializer.Serialize(Product);

                    File.WriteAllText(namefile, json);

                    MessageBox.Show("Сохранено в файл = " + namefile);
            }
                else
                {
                    MessageBox.Show("Заполните поля!");
                }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //новая запись

            Product = new Product();

            int chekid = 1;

            while (File.Exists(chekid + ".json"))
            {
                chekid++;
            }

            Product.Id = chekid;

            DataContext = Product;

            MessageBox.Show("Объект создан");

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //найти

            if (polepoisk != null)
            {

                 int id = Convert.ToInt32(polepoisk.Text);

                 string namefile = id + ".json";

                 if (File.Exists(namefile))
                 {
                    string json = File.ReadAllText(namefile);

                    Product = JsonSerializer.Deserialize<Product>(json);

                    DataContext = Product;
                 }
                 else
                 {
                     MessageBox.Show("Товар не найден!");
                 }

            }
            else
            {
                MessageBox.Show("Введите id Для поиска");

            }

          


        }
    }
}