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

namespace dz5_maks_
{
    class Product
    {
        private int articyl;
        public int Articyl
        {
            get
            {
                return articyl;
            }
            set
            {
                articyl = value;
            }
        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private decimal price;
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        private int srok;
        public int Srok
        {
            get
            {
                return srok;
            }
            set
            {
                srok = value;
            }
        }
        private DateTime release;
        public DateTime Release
        {
            get
            {
                return release;
            }
            set
            {
                release = value;
            }
        }
        private DateTime year_release;
       
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>





    public partial class MainWindow : Window

    {
        Product[] myMassive = new Product[5];

        void init()
        {
            Product pr1 = new Product();
            pr1.Name = "Паста арахисовая";
            pr1.Articyl = 123469;
            pr1.Price = 354;
            pr1.Srok = 8;
            pr1.Release = new DateTime(2022, 04, 28);
          

            Product pr2 = new Product();
            pr2.Name = "Коктель Молотого";
            pr2.Articyl = 678687;
            pr2.Price = 3000;
            pr2.Srok = 2;
            pr2.Release = new DateTime(2023, 01, 14);
           
            
            Product pr3 = new Product();
            pr3.Name = "Кроссовки";
            pr3.Articyl = 575768;
            pr3.Price = 2000;
            pr3.Srok = 3;
            pr3.Release = new DateTime(2022, 06, 13);
           
            
            Product pr4 = new Product();
            pr4.Name = "АК-47";
            pr4.Price = 777797;
            pr4.Price = 20000;
            pr4.Srok = 9;
            pr4.Release = new DateTime(2022, 07, 20);
           
            
            Product pr5 = new Product();
            pr5.Name = "Курсовая";
            pr5.Articyl = 544644;
            pr5.Price = 45000;
            pr5.Srok = 5;
            pr5.Release = new DateTime(2022, 09, 05);
          

            myMassive[0] = pr1;
            myMassive[1] = pr2;
            myMassive[2] = pr3;
            myMassive[3] = pr4;
            myMassive[4] = pr5;
        }

        public MainWindow()
        {
            //InitializeComponent(); 
            init();

        }





        private void B1_Click(object sender, RoutedEventArgs e)
        {

            Ss.Clear();
            for (int i = 0; i < myMassive.Length; i++)
            {
                Ss.Text += Convert.ToString(myMassive[i].Name) + '\n';
                Ss.Text += Convert.ToString(myMassive[i].Release) + '\n';
                Ss.Text += Convert.ToString(myMassive[i].Price) + '\n';
                Ss.Text += Convert.ToString(myMassive[i].Articyl) + '\n';
                Ss.Text += Convert.ToString(myMassive[i].Srok) + '\n';


            }

        }
        private void B2_Click(object sender, RoutedEventArgs e)
        {
            DateTime z = new DateTime();
            z = DateTime.Now;
            Ss.Clear();
            for (int i = 0; i < myMassive.Length; i++)
            {

                if (z < myMassive[i].Release)
                {
                    Ss.Text += Convert.ToString(myMassive[i].Name) + '\n';
                    Ss.Text += Convert.ToString(myMassive[i].Release) + '\n';
                    Ss.Text += Convert.ToString(myMassive[i].Price) + '\n';
                    Ss.Text += Convert.ToString(myMassive[i].Articyl) + '\n';
                    Ss.Text += Convert.ToString(myMassive[i].Srok) + '\n';
                }
            }
        }


    }

}
