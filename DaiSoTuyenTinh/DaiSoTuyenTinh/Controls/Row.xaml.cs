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
    /// Interaction logic for Row.xaml
    /// </summary>
    public partial class Row : UserControl
    {
        private int n;
        public Row(int id, int n = 2)
        {
            InitializeComponent();

            this.n = n;
            InitRow(id);
        }

        private void InitRow(int id)
        {
            Label tmptmp = new Label();
            tmptmp.Content = id.ToString();
            tmptmp.Width = 25;
            tmptmp.VerticalContentAlignment = VerticalAlignment.Center;
            tmptmp.HorizontalContentAlignment = HorizontalAlignment.Center;
            Main.Children.Add(tmptmp);

            int i;
            for (i = 0; i < n; i++)
            {
                TextBox tmp = new TextBox();
                tmp.Text = "0";
                tmp.Width = 25;
                tmp.VerticalContentAlignment = VerticalAlignment.Center;
                tmp.HorizontalContentAlignment = HorizontalAlignment.Center;
                tmp.PreviewTextInput += tb_PreviewTextInput;
                tmp.PreviewKeyDown += tb_PreviewKeyDown;

                Main.Children.Add(tmp);
            }
        }

        //width 25, height 18
        private void tb_PreviewTextInput(object sender, TextCompositionEventArgs e)
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

        private void tb_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }
    }
}
