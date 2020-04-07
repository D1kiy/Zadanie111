using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadanieNaProvrku_1
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            Form form = new TitleForm();
            form.Show();
        }

        private void OpenDialogButton_Click(object sender, EventArgs e)
        {
            Form form = new TitleForm();
            form.ShowDialog();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenParametrButton_Click_1(object sender, EventArgs e)
        {
            Form form = new TitleForm(textBox1.Text);
            form.Show();
        }

        private void OpenMdiFormButton_Click_1(object sender, EventArgs e)
        {
            Form form = new MdiForm();
            form.Show();
        }

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы хотите закрыть форму?",
                "Закрытие",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
