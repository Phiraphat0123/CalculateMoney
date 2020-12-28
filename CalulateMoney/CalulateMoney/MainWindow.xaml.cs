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

namespace CalulateMoney
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double expenditure ;
        private double revenue ;
        private double price ;
        private double resultNumber ;
        public MainWindow()
        {
            InitializeComponent();
          
        }

        
        
    private void Calculate(object sender, RoutedEventArgs e)
        {  expenditure = double.Parse(txtExpenditure.Text);
            revenue = double.Parse(txtRevenue.Text);
            price = double.Parse(inPutPrice.Text);
            resultNumber = price / (revenue - expenditure);
            //บัญญัติไตรยางค์ ^ มี (revenue - expenditure) บาทใน1วัน ถ้าจะมี price บาทแล้วจะเป็นกี่วัน
            if ((revenue - expenditure) <= 0)
            {
                MessageBox.Show("เกิดข้อผิดพลาด เงินคงเหลือของคุณไม่สามารถติดลบได้", "Error");
            }
            else {
                string getReusult= resultNumber.ToString();
                result.Text = getReusult;
            }
            
           
           
           
            
            
        }

        private void Restart(object sender, RoutedEventArgs e)
        {
            txtExpenditure.Text = "";
            txtRevenue.Text = "";
            inPutPrice.Text = "";
            result.Text = "";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtRevenue_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
