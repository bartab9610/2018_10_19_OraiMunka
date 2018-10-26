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
            // Fajlkiiras.WriteLine("Név" + ";" + "SzületésiDátum" + ";" + "Neme" + ";" + "KedvencHobbi;");
        }
        // static StreamWriter Fajlkiiras = new StreamWriter("Fájlkiiras.txt",true);

        public void Mentes()
        {
            string Kezdes = "Név;" + "SzületésiDátum;" + "Neme;" + "KedvencHobbi;" + Environment.NewLine;
            if ((!String.IsNullOrEmpty(TextBox_nev.Text)) && !String.IsNullOrEmpty(Convert.ToString(RadioButton_ferfi.Checked)) && !String.IsNullOrEmpty(Convert.ToString(RadioButton_no.Checked)) && !String.IsNullOrEmpty(Convert.ToString(Combobox_hobbik.SelectedItem)))
            {
                string Radio_nem_String = "";
                if (RadioButton_ferfi.Checked == true)
                {
                    Radio_nem_String = RadioButton_ferfi.Text;
                }
                else if (RadioButton_no.Checked == true)
                {
                    Radio_nem_String = RadioButton_no.Text;
                }
                string tartalom = Kezdes +
                                    TextBox_nev.Text + ";" +
                                    DateTimePicker_szul_datum.Value.Year + "." + DateTimePicker_szul_datum.Value.Month + "." + DateTimePicker_szul_datum.Value.Day + ";" +
                                    Radio_nem_String + ";" +
                                    Combobox_hobbik.SelectedItem + ";";
                SaveFileDialog_mentes.FileName = "";
                var eredmeny = SaveFileDialog_mentes.ShowDialog(this);
                if (eredmeny == DialogResult.OK)
                {
                    string Fajl_nev = SaveFileDialog_mentes.FileName;
                    File.WriteAllText(Fajl_nev, tartalom);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Minden bemenetnek értéke kell lennie!");
            }
        }
        public void Megnyitas()
        {
            OpenFileDialog_megnyitas.FileName = "";
            string betolto = "";
            if (OpenFileDialog_megnyitas.ShowDialog(this) == DialogResult.OK)
            {
                betolto = File.ReadAllLines(OpenFileDialog_megnyitas.FileName)[1];
                string[] adatok = betolto.Split(';');
                TextBox_nev.Text = adatok[0];
                DateTimePicker_szul_datum.Value = Convert.ToDateTime(adatok[1]);
                if (adatok[2].Equals("Férfi"))
                {
                    RadioButton_ferfi.Checked = true;
                }
                else
                {
                    RadioButton_no.Checked = true;
                }
                if (Combobox_hobbik.Items.Contains(adatok[3]))
                {
                    Combobox_hobbik.SelectedItem = adatok[3];
                }
                else
                {
                    Combobox_hobbik.Items.Add(adatok[3]);
                    Combobox_hobbik.SelectedItem = adatok[3];
                }
            }

        }
        private void Button_hobbi_hozzaadas_Click(object sender, EventArgs e)
        {
            if (Combobox_hobbik.Items.Contains(TextBox_uj_hobbi.Text))
            {
                MessageBox.Show("A(z) \"" + TextBox_uj_hobbi.Text + "\" elem már létezik");
            }
            else
            {
                Combobox_hobbik.Items.Add(TextBox_uj_hobbi.Text);
                TextBox_uj_hobbi.Text = "";

            }
        }

        private void Button_save_Click(object sender, EventArgs e)
        {
            // Fajlkiiras.WriteLine("Név" + ";" + "SzületésiDátum" + ";" + "Neme" + ";" + "KedvencHobbi;", false);
            /*
            Fajlkiiras.Write(TextBox_nev.Text + ";" +
                                    DateTimePicker_szul_datum.Value.Year + "." +
                                    DateTimePicker_szul_datum.Value.Month + "." +
                                    DateTimePicker_szul_datum.Value.Day + ";"
                             );
            if (RadioButton_ferfi.Checked == true)
            {
                // Radio_ferfi_String += Radio_ferfi_String;
                Fajlkiiras.Write(RadioButton_ferfi.Text + ";");
            }
            else if (RadioButton_no.Checked == true)
            {
                // Radio_no_String += RadioButton_no.Text;
                Fajlkiiras.Write(RadioButton_no.Text + ";");
            }
            Fajlkiiras.Write(Combobox_hobbik.SelectedItem + ";");
            Fajlkiiras.WriteLine();
            Fajlkiiras.Close();*/
            Mentes();
        }

        private void Button_open_Click(object sender, EventArgs e)
        {
            Megnyitas();
        }
    }
}