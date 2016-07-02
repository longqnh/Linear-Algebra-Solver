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

namespace DaiSoTuyenTinh.Controls
{
    /// <summary>
    /// Interaction logic for Equation.xaml
    /// </summary>
    public partial class Equation : UserControl
    {
        private int n; //num of var

        public Equation(int n = 2)
        {
            InitializeComponent();

            this.n = n;
            InitEquation();
        }

        private void InitEquation()
        {
            int i;
            for (i = 0; i < n - 1; i++)
            {
                Variable var = new Variable();
                var.tbVarName.Text = "x" + i.ToString() + " + ";
                //var.Width = var.tbValue.Width + var.tbVarName.Width;
                
                Main.Children.Add(var);
            }

            Variable var_last = new Variable();
            var_last.tbVarName.Text = "x" + i.ToString() + " = ";
            //var_last.Width = var_last.tbValue.Width + var_last.tbVarName.Width;
            
            Main.Children.Add(var_last);

            TextBox result = new TextBox();
            //result.Height = var_last.tbValue.Height;
            result.Width = var_last.tbValue.Width;
            result.VerticalContentAlignment = VerticalAlignment.Center;
            result.HorizontalContentAlignment = HorizontalAlignment.Center;
            result.PreviewTextInput += Result_PreviewTextInput;
            result.PreviewKeyDown += Result_PreviewKeyDown;
            //result.TextChanged += Result_TextChanged;
            result.Text = "0";

            Main.Children.Add(result);

            //this.Height = var_last.Height;
            //this.Width = sumwidth + var_last.Width + result.Width;
        }

        private void Result_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        private void Result_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            char c = Convert.ToChar(e.Text);
            e.Handled = false;
            if (Char.IsNumber(c) || c == '.')
            {
                e.Handled = false;
            }
            else
                e.Handled = true;

            base.OnPreviewTextInput(e);
        }

        private void Result_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tmp = (TextBox)Main.Children[n + 1];
            if (tmp.Text.Length == 0)
                tmp.Text = "0";
        }
    }
}