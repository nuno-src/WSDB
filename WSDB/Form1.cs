using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        //Ver Lista























































        //Adicionar/Editar
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Msa ptemp = new Msa(textBoxNome.Text, textBoxTipo.Text, dateTimePicker1.Value.Year,
                 int.Parse(numericUpDown1.Value.ToString()), textBoxPathImg.Text, textBoxDescr.Text);

            listBox1.Items.Add(ptemp);
        }









    }
}
