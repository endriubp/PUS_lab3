using Lab2.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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

namespace Lab2
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

        ServiceReference1.Servicee1Client client = new ServiceReference1.Servicee1Client();

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a_real = double.Parse(a_realtb.Text);
                double a_imaginary = double.Parse(a_imaginarytb.Text);
                double b_real = double.Parse(b_realtb.Text);
                double b_imaginary = double.Parse(b_imaginarytb.Text);
                Complex result = client.Add(a_real, a_imaginary, b_real, b_imaginary);
                tbresult1.Text = result.Real.ToString();
                tbresult2.Text = result.Imaginary.ToString();
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (System.ServiceModel.CommunicationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void substractbtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a_real = double.Parse(a_realtb.Text);
                double a_imaginary = double.Parse(a_imaginarytb.Text);
                double b_real = double.Parse(b_realtb.Text);
                double b_imaginary = double.Parse(b_imaginarytb.Text);
                Complex result = client.Substract(a_real, a_imaginary, b_real, b_imaginary);
                tbresult1.Text = result.Real.ToString();
                tbresult2.Text = result.Imaginary.ToString();
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (System.ServiceModel.CommunicationException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void multiplybtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a_real = double.Parse(a_realtb.Text);
                double a_imaginary = double.Parse(a_imaginarytb.Text);
                double b_real = double.Parse(b_realtb.Text);
                double b_imaginary = double.Parse(b_imaginarytb.Text);
                Complex result = client.Multiply(a_real, a_imaginary, b_real, b_imaginary);
                tbresult1.Text = result.Real.ToString();
                tbresult2.Text = result.Imaginary.ToString();
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (System.ServiceModel.CommunicationException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dividebtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a_real = double.Parse(a_realtb.Text);
                double a_imaginary = double.Parse(a_imaginarytb.Text);
                double b_real = double.Parse(b_realtb.Text);
                double b_imaginary = double.Parse(b_imaginarytb.Text);
                Complex result = client.Divide(a_real, a_imaginary, b_real, b_imaginary);
                tbresult1.Text = result.Real.ToString();
                tbresult2.Text = result.Imaginary.ToString();
            }
            catch (FaultException<ServiceReference1.DivideByZeroException> ex)
            {
                MessageBox.Show(ex.Detail.Message + "\nDivided numbers: a_real:" + (ex.Detail.Divided_complex_number.Real).ToString() + ", a_imaginary: "+ (ex.Detail.Divided_complex_number.Imaginary).ToString(), "FaultException<DivideByZeroException> Caught");
            }
            catch(System.FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (System.ServiceModel.CommunicationException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
