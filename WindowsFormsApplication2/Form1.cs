using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Walidator
{
    public partial class Walidator : Form
    {
        public Walidator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String pesel = textbox.Text;
            PESELWalidator pw = new PESELWalidator(pesel);
            textBox1.Text = pw.DateOfBirth();
        }

        private void Dane_Click(object sender, EventArgs e)
        {

        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
