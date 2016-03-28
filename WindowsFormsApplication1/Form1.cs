using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Lista listaZaIspis;
        List<Lista> svi_zapisi = new List<Lista>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            Lista novi = new Lista();
            novi.unos(txtIme.Text, TxtPrezime.Text, txtOIB.Text);
            svi_zapisi.Add(novi);
            textBox1.Text = "";
            foreach (var item in svi_zapisi)
            {
                textBox1.Text += item.ispis();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
