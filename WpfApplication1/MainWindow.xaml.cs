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

namespace WpfApplication1
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

        private void CaixaUm_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void clickAND(object sender, RoutedEventArgs e)
        {
            bool var1 = Convert.ToBoolean(Convert.ToInt16(txtCaixaUm.Text)) && Convert.ToBoolean(Convert.ToInt16(txtCaixaDois.Text));
            bool var2 = Convert.ToBoolean(Convert.ToInt16(txtCaixaDois.Text)) && Convert.ToBoolean(Convert.ToInt16(txtCaixaUm.Text));

            bool varResult = var1 && var2;
            txtCaixaResult.Text = varResult.ToString();
        }

        private void clickOR(object sender, RoutedEventArgs e)
        {
            bool var1 = Convert.ToBoolean(Convert.ToInt16(txtCaixaUm.Text)) || Convert.ToBoolean(Convert.ToInt16(txtCaixaDois.Text));
            bool var2 = Convert.ToBoolean(Convert.ToInt16(txtCaixaDois.Text)) || Convert.ToBoolean(Convert.ToInt16(txtCaixaUm.Text));

            bool varResult = var1 || var2;
            txtCaixaResult.Text = varResult.ToString();
        }

        private void clickNeg(object sender, RoutedEventArgs e)
        {
            bool var1 = Convert.ToBoolean(Convert.ToInt16(txtCaixaUm.Text)) ^! Convert.ToBoolean(Convert.ToInt16(txtCaixaDois.Text));
            bool var2 = Convert.ToBoolean(Convert.ToInt16(txtCaixaDois.Text)) ^! Convert.ToBoolean(Convert.ToInt16(txtCaixaUm.Text));

            bool varResult = var1 ^! var2;
            txtCaixaResult.Text = varResult.ToString();
        }

        private void clickXor(object sender, RoutedEventArgs e)
        {
            bool var1 = Convert.ToBoolean(Convert.ToInt16(txtCaixaUm.Text)) ^ Convert.ToBoolean(Convert.ToInt16(txtCaixaDois.Text));
            bool var2 = Convert.ToBoolean(Convert.ToInt16(txtCaixaDois.Text)) ^ Convert.ToBoolean(Convert.ToInt16(txtCaixaUm.Text));

            bool varResult = var1 ^ var2;
            txtCaixaResult.Text = varResult.ToString();
        }

        private void Neg2_Checked(object sender, RoutedEventArgs e)
        {
            bool var2 = ((bool)Neg2.IsChecked ? Convert.ToBoolean(Convert.ToInt16(txtCaixaDois.Text)) : !Convert.ToBoolean(Convert.ToInt16(txtCaixaDois.Text)));
            bool varResult = !var2;
            txtCaixaResult.Text = varResult.ToString();
        }

        private void Neg1_Checked(object sender, RoutedEventArgs e)
        {
            bool var1 = ((bool)Neg1.IsChecked ? Convert.ToBoolean(Convert.ToInt16(txtCaixaUm.Text)) : !Convert.ToBoolean(Convert.ToInt16(txtCaixaUm.Text)));
            bool varResult = !var1;
            txtCaixaResult.Text = varResult.ToString();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtCaixaUm.Clear();
            txtCaixaDois.Clear();
            txtCaixaResult.Clear();
        }
    }
}
