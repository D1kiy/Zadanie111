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
    public partial class MdiForm : Form
    {
        public MdiForm()
        {
            InitializeComponent();
        }


        private void OpemMdibutton_Click_1(object sender, EventArgs e)
        {
            string s = ((Button)sender).Text;

            bool isOpen = false;
            foreach (var item in this.MdiChildren)
            {
                if (item.Text == s)
                {
                    isOpen = true;
                    item.Activate();
                    break;
                }
            }

            if (!isOpen)
            {
                Form form = new TitleForm(s);
                form.MdiParent = this;
                form.Show();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string s = ((Button)sender).Text;
            Form form = new TitleForm(s);
            form.MdiParent = this;
            form.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string s = ((Button)sender).Text;
            Form form = new TitleForm(s);
            form.MdiParent = this;
            form.Show();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            string s = ((Button)sender).Text;
            Form form = new TitleForm(s);
            form.MdiParent = this;
            form.Show();
        }

        private void CloseFormButton_Click_1(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                item.Close();
            }
        }
    }
}
