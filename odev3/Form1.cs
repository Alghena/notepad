using System.Windows.Forms;

namespace odev3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void geriAlmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
            if (geriAlmaToolStripMenuItem.Pressed)
                toolStripStatusLabel1.Text = "geri al�nd�";

        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {

            openFileDialog1.FileName = "*";
            openFileDialog1.Filter = "zengin metin bi�imi |*.rtf|normak yaz�|*.text";
            openFileDialog1.Title = "a��lacak dosya se�im ekran�";
            openFileDialog1.ShowDialog();
            richTextBox1.LoadFile(openFileDialog1.FileName);
            if (openToolStripButton.Pressed)
                openToolStripButton.Text = "yeni dosya a��ld�";


        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (saveToolStripButton.Pressed)
                toolStripStatusLabel1.Text = "kaydedildi";
            saveFileDialog1.FileName = "*";
            saveFileDialog1.Filter = "zengin metin bi�imi |*.rtf|normak yaz�|*.text";
            saveFileDialog1.Title = "kay�t yeri";
            saveFileDialog1.ShowDialog();
            richTextBox1.SaveFile(saveFileDialog1.FileName);

        }

        private void yeniDosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ResetText();
            if (yeniDosyaToolStripMenuItem.Pressed)
                toolStripStatusLabel1.Text = "Yeni dosya a��ld�";
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.ResetText();
            if (newToolStripButton.Pressed)
                toolStripStatusLabel1.Text = "Yeni dosya a��ld�";
        }

        private void a�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yinelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
            if (yinelemeToolStripMenuItem.Pressed)
                toolStripStatusLabel1.Text = "yinelendi";

        }

        private void kesmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
            if (kesmeToolStripMenuItem.Pressed)
                toolStripStatusLabel1.Text = "kesme i�lemi yap�ld�";

        }

        private void kopyalamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
            if (kopyalamaToolStripMenuItem.Pressed)
                toolStripStatusLabel1.Text = "kopyalama i�lemi yap�ld�";
        }

        private void yap��t�rmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
            if (yap��t�rmaToolStripMenuItem.Pressed)
                toolStripStatusLabel1.Text = "yap��t�rma i�lemi yap�ld�";

        }

        private void t�m�n�Se�meToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            if (t�m�n�Se�meToolStripMenuItem.Pressed)
                toolStripStatusLabel1.Text = "t�m� se�ildi";
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem4.Checked)
                toolStripStatusLabel1.Text = "Notepad++ Tasar�m= Alghena ANIS";

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
            if (toolStripButton1.Pressed)
                toolStripStatusLabel1.Text = "geri al�nd�";
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
            if (pasteToolStripButton.Pressed)
                toolStripStatusLabel1.Text = "yap��t�rma i�lemi yap�ld�";
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
            if (copyToolStripButton.Pressed)
                toolStripStatusLabel1.Text = "kopyalama i�lemi yap�ld�";
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
            if (cutToolStripButton.Pressed)
                toolStripStatusLabel1.Text = "kesme i�lemi yap�ld�";
        }
    }
}
