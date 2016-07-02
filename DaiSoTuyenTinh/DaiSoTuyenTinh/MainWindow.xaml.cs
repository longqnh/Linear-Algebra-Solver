using DaiSoTuyenTinh.Controls;
using System.Windows;
using System.Windows.Media;
using System.IO;

namespace DaiSoTuyenTinh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LinearSys.Main = this;
            Matrix.Main = this;
            i = 0;
        }

        public int i; //number of gif file
        public string AssemblyPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

        private void rbHPT_Checked(object sender, RoutedEventArgs e)
        {
            LinearSys.Visibility = Visibility.Visible;
            Matrix.Visibility = Visibility.Hidden;
            i = 0;
        }

        private void rbMT_Checked(object sender, RoutedEventArgs e)
        {
            LinearSys.Visibility = Visibility.Hidden;
            Matrix.Visibility = Visibility.Visible;
            i = 0;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //lbSolution.Items.Clear();
            //for (int j = i - 1; j > 0 ; j--)
            //{
            //    File.Delete(Path.Combine(AssemblyPath, "EquationImage" + j.ToString() + ".gif"));
            //}
        }
    }
}
