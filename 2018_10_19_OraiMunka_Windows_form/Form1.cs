using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2018_10_19_OraiMunka_Windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static StreamWriter Fajlkiiras = new StreamWriter("valami.txt");

        private void Button_hobbi_hozzaadas_Click(object sender, EventArgs e)
        {
            if (Combobox_hobbik.Items.Contains(TextBox_uj_hobbi.Text))
            {
                MessageBox.Show("A \"" + TextBox_uj_hobbi.Text +  "\" elem már létezik");
            }
            else
            {
                Combobox_hobbik.Items.Add(TextBox_uj_hobbi.Text);
                
            }
        }

        private void Button_save_Click(object sender, EventArgs e)
        {
            Fajlkiiras.WriteLine(Label_nev.Text + ";" + TextBox_nev.Text);
            Fajlkiiras.WriteLine(Label_szuletesi_datum.Text + ";" + DateTimePicker_szul_datum.Value);
            if (RadioButton_ferfi.Checked == true)
            {
                Fajlkiiras.WriteLine(Label_nem.Text + ";" + RadioButton_ferfi.Text);
            }
            else if (RadioButton_no.Checked == true)
            {
                Fajlkiiras.WriteLine(Label_nem.Text + ";" + RadioButton_no.Text);
            }
            Fajlkiiras.Close();
            this.Close();
        }
    }
}
