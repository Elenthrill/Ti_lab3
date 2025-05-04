using System.Numerics;
using System.Text;
using Ti_3.BackEnd;

namespace Ti_3
{
    public partial class Form1 : Form
    {
        static string Path = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Cipher_Click(object sender, EventArgs e)
        {
            long p = BackEnd.Algoritm.CheckP(tbox_P.Text);
            long x = BackEnd.Algoritm.CheckX(tbox_X.Text, p);
            long k = BackEnd.Algoritm.CheckK(tbox_K.Text, p);
            Algoritm.PervRoots = Algoritm.FindRoots(p);
            long g = BackEnd.Algoritm.CheckG(tbox_G.Text);
            if (p == 0 || x == 0 || k == 0 || g == 0)
            {
                MessageBox.Show("Некорректный ввод", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Path != null)
            {
                tbox_ciphertekst.Text = BackEnd.Algoritm.Cipher(g, x, p, k, Path);
            }
            else { MessageBox.Show("Укажите файл для шифрования", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void загрузитьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Path = openFileDialog1.FileName;
                using (FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                {
                    List<BigInteger> plaintextBytes = new List<BigInteger>();

                    StringBuilder plaintextString = new StringBuilder();
                    while (fs.Position < fs.Length)
                    {
                        int symbol = fs.ReadByte();
                        plaintextBytes.Add(symbol);
                        plaintextString.Append(symbol.ToString() + " ");
                    }
                    tbox_plaintext.Text = plaintextString.ToString();
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void btn_Decipher_Click(object sender, EventArgs e)
        {
            long p = BackEnd.Algoritm.CheckP(tbox_P.Text);
            long x = BackEnd.Algoritm.CheckX(tbox_X.Text, p);
            long k = BackEnd.Algoritm.CheckK(tbox_K.Text, p);
            long g = BackEnd.Algoritm.CheckG(tbox_G.Text);
            if (p == 0 || x == 0 || k == 0 || g == 0)
            {
                MessageBox.Show("Некорректный ввод", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Path != null)
            {
                tbox_ciphertekst.Text = BackEnd.Algoritm.Decipher(p, x, Path);
            }
            else { MessageBox.Show("Укажите файл для шифрования", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void btn_find_pervRoots_Click(object sender, EventArgs e)
        {
            long p = BackEnd.Algoritm.CheckP(tbox_P.Text);
            if (p == 0)
            {
                MessageBox.Show("Некорректный ввод P", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            tbox_ListG.Text = "";
            Algoritm.PervRoots = Algoritm.FindRoots(p);
            tbox_ListG.Text += "Имееться" + Algoritm.PervRoots.Count().ToString() + "корней" + Environment.NewLine;
            Algoritm.PervRoots.ForEach(x => { tbox_ListG.Text += x.ToString() + " " + Environment.NewLine; });
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbox_P_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
