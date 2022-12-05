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

namespace dz5_13
{
    class Product
    {
        private int article_number;
        public int Article_number
        {
            get
            {
                return article_number;
            }
            set
            {
                article_number = value;
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
        private int term;
        public int Term
        {
            get
            {
                return term;
            }
            set
            {
                term = value;
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
            pr1.Article_number = 123469;
            pr1.Price = 354;
            pr1.Term = 8;
            pr1.Release = new DateTime(04);


            Product pr2 = new Product();
            pr2.Name = "Коктель Молотого";
            pr2.Article_number = 678687;
            pr2.Price = 3000;
            pr2.Term = 2;
            pr2.Release = new DateTime(05);

            Product pr3 = new Product();
            pr3.Name = "Кроссовки";
            pr3.Article_number = 575768;
            pr3.Price = 2000;
            pr3.Term = 3;
            pr3.Release = new DateTime(08);

            Product pr4 = new Product();
            pr4.Name = "АК-47";
            pr4.Article_number = 777797;
            pr4.Price = 20000;
            pr4.Term = 9;
            pr4.Release = new DateTime(01);

            Product pr5 = new Product();
            pr5.Name = "Курсовая";
            pr5.Article_number = 544644;
            pr5.Price = 45000;
            pr5.Term = 5;
            pr5.Release = new DateTime(09);


            myMassive[0] = pr1;
            myMassive[1] = pr2;
            myMassive[2] = pr3;
            myMassive[3] = pr4;
            myMassive[4] = pr5;
        }

        public MainWindow()
        {
            InitializeComponent();
            init();

        }

        



        private void B1_Click(object sender, RoutedEventArgs e)
        {

            for (int i = 0; i < myMassive.Length; i++)
            {


                Ss.Text += myMassive[i].Name + '\n';
                Ss.Text += Convert.ToString(myMassive[i].Release) + '\n';
                Ss.Text += Convert.ToString(myMassive[i].Price) + '\n';
                Ss.Text += Convert.ToString(myMassive[i].Article_number) + '\n';

            }
        }
        private void B2_Click(object sender, RoutedEventArgs e)
        {

            DateTime z = new
            DateTime();
            z = DateTime.Now;

            for (uint i = 0; i < myMassive.Length; i++)
            {

                if (z >= myMassive[i].Release)
                {
                    
                    Ss.Text += myMassive[i].Name + '\n';
                    Ss.Text += Convert.ToString(myMassive[i].Term) + '\n';
                    Ss.Text += Convert.ToString(myMassive[i].Price) + '\n';
                    Ss.Text += Convert.ToString(myMassive[i].Article_number) + '\n';

                }
            }
        }

        
    }
}
