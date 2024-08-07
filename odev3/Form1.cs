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
                toolStripStatusLabel1.Text = "geri alýndý";

        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {

            openFileDialog1.FileName = "*";
            openFileDialog1.Filter = "zengin metin biçimi |*.rtf|normak yazý|*.text";
            openFileDialog1.Title = "açýlacak dosya seçim ekraný";
            openFileDialog1.ShowDialog();
            richTextBox1.LoadFile(openFileDialog1.FileName);
            if (openToolStripButton.Pressed)
                openToolStripButton.Text = "yeni dosya açýldý";


        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (saveToolStripButton.Pressed)
                toolStripStatusLabel1.Text = "kaydedildi";
            saveFileDialog1.FileName = "*";
            saveFileDialog1.Filter = "zengin metin biçimi |*.rtf|normak yazý|*.text";
            saveFileDialog1.Title = "kayýt yeri";
            saveFileDialog1.ShowDialog();
            richTextBox1.SaveFile(saveFileDialog1.FileName);

        }

        private void yeniDosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ResetText();
            if (yeniDosyaToolStripMenuItem.Pressed)
                toolStripStatusLabel1.Text = "Yeni dosya açýldý";
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.ResetText();
            if (newToolStripButton.Pressed)
                toolStripStatusLabel1.Text = "Yeni dosya açýldý";
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
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
                toolStripStatusLabel1.Text = "kesme iþlemi yapýldý";

        }

        private void kopyalamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
            if (kopyalamaToolStripMenuItem.Pressed)
                toolStripStatusLabel1.Text = "kopyalama iþlemi yapýldý";
        }

        private void yapýþtýrmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
            if (yapýþtýrmaToolStripMenuItem.Pressed)
                toolStripStatusLabel1.Text = "yapýþtýrma iþlemi yapýldý";

        }

        private void tümünüSeçmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            if (tümünüSeçmeToolStripMenuItem.Pressed)
                toolStripStatusLabel1.Text = "tümü seçildi";
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem4.Checked)
                toolStripStatusLabel1.Text = "Notepad++ Tasarým= Alghena ANIS";

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
            if (toolStripButton1.Pressed)
                toolStripStatusLabel1.Text = "geri alýndý";
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
            if (pasteToolStripButton.Pressed)
                toolStripStatusLabel1.Text = "yapýþtýrma iþlemi yapýldý";
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
            if (copyToolStripButton.Pressed)
                toolStripStatusLabel1.Text = "kopyalama iþlemi yapýldý";
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
            if (cutToolStripButton.Pressed)
                toolStripStatusLabel1.Text = "kesme iþlemi yapýldý";
        }
    }
}
