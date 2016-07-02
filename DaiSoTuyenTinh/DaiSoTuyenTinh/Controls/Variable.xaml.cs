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
    /// Interaction logic for Variable.xaml
    /// </summary>
    public partial class Variable : UserControl
    {
        public float Value;

        public Variable()
        {
            InitializeComponent();
        }

        private void tbValue_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            char c = Convert.ToChar(e.Text);
            e.Handled = false;
            if (Char.IsNumber(c) || c == '.' || c == '-')
            {
                e.Handled = false;
            }
            else
                e.Handled = true;

            base.OnPreviewTextInput(e);
        }

        private void tbValue_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        private void tbValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbValue.Text.Length == 0)
            {
                tbValue.Text = "0";
            }
            Value = float.Parse(tbValue.Text);
        }
    }
}
