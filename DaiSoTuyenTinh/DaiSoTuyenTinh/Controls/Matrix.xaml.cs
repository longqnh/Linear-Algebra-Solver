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
using System.IO;

namespace DaiSoTuyenTinh.Controls
{
    /// <summary>
    /// Interaction logic for Matrix.xaml
    /// </summary>
    public partial class Matrix : UserControl
    {
        private int n_Rows, n_Cols;
        public float[,] Mtrix;
        public MainWindow Main { get; set; }
        private int index;
        OpenMaple openMaple;

        private string AssemblyPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        public Matrix()
        {
            InitializeComponent();

            this.n_Rows = 2;
            this.n_Cols = 2;
            this.index = 0;

            InitMatrix();
            openMaple = new OpenMaple();

            tbRows.TextChanged += tb_TextChanged;
            tbCols.TextChanged += tb_TextChanged;
            tbRows.PreviewKeyDown += tb_PreviewKeyDown;
            tbCols.PreviewKeyDown += tb_PreviewKeyDown;
            tbRows.PreviewTextInput += tb_PreviewTextInput;
            tbCols.PreviewTextInput += tb_PreviewTextInput;
        }

        private string GetResultFromMaple(string querry)
        {
            openMaple.Open();
            openMaple.Run(querry);
            return OpenMaple.result;
        }

        #region Xử lý Latex
        private string GetGifPathFile(int i)
        {
            return System.IO.Path.Combine(AssemblyPath, "EquationImage" + i.ToString() + ".gif");
        }

        private void WriteEquation(string equation, ListBox lb)
        {
            string gifFilePath = GetGifPathFile(Main.i++);

            NativeMethods.CreateGifFromEq(equation, gifFilePath);
            BitmapImage xaicainaydumt = new BitmapImage(new Uri(gifFilePath));
            Image voicainaycuawpf = new Image();
            voicainaycuawpf.Source = xaicainaydumt;

            lb.Items.Add(voicainaycuawpf);
        }

        private void WriteText(string text, ListBox lb)
        {
            lb.Items.Add(text);
        }
        #endregion

        #region Methods
        private void InitMatrix()
        {
            lbMatrix.Items.Clear();
            lbMatrix.Items.Add(new Column(n_Cols));
            for (int i = 0; i < n_Rows; i++)
            {
                Row tmp = new Row(i, n_Cols);
                lbMatrix.Items.Add(tmp);
            }
        }

        private void CreateRandomMatrix()
        {
            Random rand = new Random(System.DateTime.Now.Millisecond);

            for (int i = 1; i <= n_Rows; i++) //first lbMatrix.Items is column indices (lable)
            {
                Row tmp = (Row)lbMatrix.Items[i];
                for (int j = 1; j <= n_Cols; j++) //first tmp.Main Items is row index
                {
                    TextBox value = (TextBox)tmp.Main.Children[j];
                    value.Text = rand.Next(50).ToString();
                }
            }
        }

        private string GetMatrix()
        {
            String Maple = "Matrix(" + n_Rows.ToString() + "," + n_Cols.ToString() + ",[";
            Mtrix = new float[n_Rows, n_Cols];
            for (int i = 1; i <= n_Rows; i++) //first lbMatrix.Items is column indices (lable)
            {
                Row tmp = (Row)lbMatrix.Items[i];
                Maple += "[";
                for (int j = 1; j <= n_Cols; j++) //first tmp.Main Items is row index
                {
                    TextBox value = (TextBox)tmp.Main.Children[j];
                    if (value.Text.Length == 0)
                        value.Text = "0";

                    Mtrix[i - 1, j - 1] = Int32.Parse(value.Text);
                    Maple += Mtrix[i - 1, j - 1].ToString() + ",";
                }
                Maple = Maple.Remove(Maple.Length - 1, 1);
                Maple += "],";
            }
            Maple = Maple.Remove(Maple.Length - 1, 1);
            Maple += "])";

            return Maple;
        }

        private bool IsLatex(String st)
        {
            if (st == null) return false;
            if (st.Substring(0, 1) == @"\")
                return true;
            return false;
        }

        #endregion

        #region Events
        private void tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbRows.Text.Length == 0)
                tbRows.Text = "0";
            if (tbCols.Text.Length == 0)
                tbCols.Text = "0";

            n_Rows = Int32.Parse(tbRows.Text);
            n_Cols = Int32.Parse(tbCols.Text);

            InitMatrix();
        }

        private void tb_PreviewTextInput(object sender, TextCompositionEventArgs e)
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

        private void tb_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        private void tbRandom_Click(object sender, RoutedEventArgs e)
        {
            CreateRandomMatrix();
        }

        private void WriteFile(StreamWriter writer)
        {
            writer.WriteLine("L:=StepSolve(K):");
            writer.WriteLine("dir := FileTools:-JoinPath([convert(currentdir(),string),\"output.txt\"]):");
            writer.WriteLine("if not FileTools:-Exists(dir) then Export(dir, \"\"): fi:");
            writer.WriteLine("FileTools[Text]:-Open(dir, overwrite):");
            writer.WriteLine("for i from 1 to nops(L) do "
                            + "FileTools[Text]:-WriteString(dir, op(i,L)); "
                            + "FileTools[Text]:-WriteString(dir, \"\\n\"); od:");
            writer.WriteLine("FileTools[Text]:-Close(dir);");
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            String MapleMatrix = GetMatrix();

            index = cmbQuestion.SelectedIndex;

            Main.lbSolution.Items.Clear();

            #region create .mpl
            StreamWriter writer = new StreamWriter(AssemblyPath + "\\solve.mpl");
            writer.WriteLine("restart;");
            writer.WriteLine("packageDir:=cat(currentdir(),kernelopts(dirsep),\"package.mla\"):");
            writer.WriteLine("march('open',packageDir):");
            writer.WriteLine("with(DSTT):");
            writer.WriteLine("X:=" + MapleMatrix + ":");
            #endregion

            switch (index)
            {
                case 0: // định thức
                    writer.WriteLine("K:=TinhDet(X):");
                    WriteFile(writer);
                    writer.Close();
                    break;
                case 1: // hạng
                    writer.WriteLine("K:=Hang(X):");
                    WriteFile(writer);
                    writer.Close();
                    break;
                case 2: // bậc thang
                    writer.WriteLine("K:=BacThang(X):");
                    WriteFile(writer);
                    writer.Close();
                    break;
                default: // nghịch đảo
                    writer.WriteLine("K:=NghichDao(X):");
                    WriteFile(writer);
                    writer.Close();                    
                    break;
            }

            System.Diagnostics.Process.Start(AssemblyPath + "\\Solve.bat");

            Main.lbSolution.Items.Add("Giải thành công, bấm Xem Lời Giải để xem lời giải chi tiết");

        }
        #endregion

        private void ShowSol_Click(object sender, RoutedEventArgs e)
        {
            Main.lbSolution.Items.Clear();
            #region Xuất kq
            StreamReader reader = File.OpenText(AssemblyPath + "\\output.txt");
            String str = reader.ReadLine();
            WriteText(str, Main.lbSolution);

            while (str != null)
            {
                str = reader.ReadLine();
                if (IsLatex(str))
                {
                    WriteEquation(str, Main.lbSolution);
                }
                else
                {
                    WriteText(str, Main.lbSolution);
                }
            }

            reader.Close();
            #endregion
        }
    }
}
