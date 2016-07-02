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
    /// Interaction logic for LinerSystem.xaml
    /// </summary>
    public partial class LinearSystem : UserControl
    {
        private int n; //number equations
        public float[,] Matrix;
        String Maple1, Maple2; // 1 is VT, 2 is VP

        public MainWindow Main { get; set; }
        private int index;
        OpenMaple openMaple;

        private string AssemblyPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

        public LinearSystem()
        {
            InitializeComponent();

            this.n = 2;
            this.index = 0;
            InitLinearSystem();
            openMaple = new OpenMaple();
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
        private void InitLinearSystem()
        {
            listEqs.Items.Clear();
            for (int i = 0; i < n; i++)
            {
                listEqs.Items.Add(new Equation(n));
            }
        }

        private void CreateRandomSystem()
        {
            Random rand = new Random(System.DateTime.Now.Millisecond);

            foreach (Equation eq in listEqs.Items)
            {
                int i;
                for (i = 0; i < n; i++)
                {
                    Variable tmp = (Variable)eq.Main.Children[i];
                    tmp.tbValue.Text = rand.Next(50).ToString();
                }
                TextBox tbtmp = (TextBox)eq.Main.Children[i];
                tbtmp.Text = rand.Next(50).ToString();
            }
        }

        private void GetMatrix()
        {
            Maple1 = "Matrix(" + n.ToString() + "," + n.ToString() + ",[";
            Maple2 = "Matrix(" + n.ToString() + ",1,[";
            Matrix = new float[n, n+1];
            int i = 0;
            foreach (Equation eq in listEqs.Items)
            {
                Maple1 += "[";
                int j;
                for (j = 0; j < n; j++)
                {
                    Variable tmp = (Variable)eq.Main.Children[j];
                    Matrix[i, j] = tmp.Value;
                    Maple1 += Matrix[i, j].ToString();

                    if (j != n - 1) 
                        Maple1 += ",";
                }
                TextBox tbtmp = (TextBox)eq.Main.Children[j];
                if (tbtmp.Text.Length == 0)
                    tbtmp.Text = "0";
                Matrix[i, j] = Int32.Parse(tbtmp.Text);
                Maple2 += Matrix[i, j].ToString() + ",";
                if (i < n - 1)
                    Maple1 += "],";
                else
                    Maple1 += "]])";
                i++;
            }
            Maple2 = Maple2.Remove(Maple2.Length - 1, 1);
            Maple2 += "])";

            //return Maple;
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
        private void tbNumEquations_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbNumEquations.Text.Length == 0)
                tbNumEquations.Text = "0";

            n = Int32.Parse(tbNumEquations.Text);
            if(n < 0)
            {

            }

            InitLinearSystem();
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
            GetMatrix();

            index = cmbQuestion.SelectedIndex;
            Main.lbSolution.Items.Clear();

            #region create .mpl
            StreamWriter writer = new StreamWriter(AssemblyPath + "\\solve.mpl");
            writer.WriteLine("restart;");
            writer.WriteLine("packageDir:=cat(currentdir(),kernelopts(dirsep),\"package.mla\"):");
            writer.WriteLine("march('open',packageDir):");
            writer.WriteLine("with(DSTT):");
            writer.WriteLine("X:=" + Maple1 + ":");
            writer.WriteLine("Y:=" + Maple2 + ":");
            #endregion

            switch (index)
            {
                case 0: // Cramer
                    writer.WriteLine("K:=Cramer(X,Y):");
                    WriteFile(writer);
                    writer.Close();
                    break;
                default: // Gauss
                    writer.WriteLine("K:=Gauss(X,Y):");
                    WriteFile(writer);
                    writer.Close();
                    break;
            }

            System.Diagnostics.Process.Start(AssemblyPath + "\\Solve.bat");

            Main.lbSolution.Items.Add("Giải thành công, bấm Xem Lời Giải để xem lời giải chi tiết");

        }

        private void tbRandom_Click(object sender, RoutedEventArgs e)
        {
            CreateRandomSystem();
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

        #endregion
    }
}
