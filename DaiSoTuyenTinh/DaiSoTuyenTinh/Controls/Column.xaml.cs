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
    /// Interaction logic for Column.xaml
    /// </summary>
    public partial class Column : UserControl
    {
        private int n;
        public Column(int n = 2)
        {
            InitializeComponent();

            this.n = n;
            InitCol();
        }

        private void InitCol()
        {
            Label lbtmp = new Label();
            lbtmp.Width = 25;
            lbtmp.VerticalContentAlignment = VerticalAlignment.Center;
            lbtmp.HorizontalContentAlignment = HorizontalAlignment.Center;
            Main.Children.Add(lbtmp);

            for (int i = 0; i < n; i++)
            {
                Label tmp = new Label();
                tmp.Content = i.ToString();
                tmp.Width = 25;
                tmp.VerticalContentAlignment = VerticalAlignment.Center;
                tmp.HorizontalContentAlignment = HorizontalAlignment.Center;
                Main.Children.Add(tmp);
            }
        }
    }
}
