using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FormNaprawy : Form
    {
        Naprawa naprawy; //odwołanie do klasy
        internal FormNaprawy(Naprawa naprawy)
        {
            InitializeComponent();
            this.naprawy = naprawy; //odwołanie do klasy
        }

        private void FormNaprawy_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = new DateTime(2000, 1, 1); //przypisanie wartości początkowej dla kalendarza
            foreach ( Mechanik mech in Mechanik.Mechanicy) //Dodajemy mechaników z combobox. Przypisani mechanicy -> Form1
            {
                comboBox_mechanik.Items.Add(mech); //dodawanie mechaników do cb
            }
        }
        private void button_dodajnaprawe_Click(object sender, EventArgs e) //dodawanie i przypisywanie wartości 
        {
            if ( textBox_nr_rejestracyjny.Text.Length <=0 || comboBox_mechanik.SelectedIndex <= -1) // jeśli wartość pola nr. rejestracyjnego jest pusta albo nie wybrano mechanika  
            {
                MessageBox.Show("Nie wprowadzono numeru rejestracyjnego / Nie wybrano mechanika", "Uzupełnij");
            }
            else 
            {
                //przypisujemy do klasy
                naprawy.Nr_rejestracyjny = textBox_nr_rejestracyjny.Text;
                naprawy.data_naprawy = dateTimePicker1.Value;
                naprawy.mechan = Mechanik.Mechanicy[comboBox_mechanik.SelectedIndex];
                naprawy.koszt_części = numericUpDown_koszt_części.Value;
                naprawy.czas_pracy = numericUpDown_czas_pracy.Value;
                naprawy.należność = numericUpDown_koszt_części.Value + numericUpDown_czas_pracy.Value* Convert.ToDecimal(naprawy.mechan.Stawka);
                button_dodajnaprawe.DialogResult = DialogResult.OK;
            }

        }

        private void button_wyczyść_Click(object sender, EventArgs e) //czyszczenie wierszy
        {
            DateTime value = new DateTime(2000, 1, 1); //przypisanie wartości

            textBox_nr_rejestracyjny.Text = "";
            dateTimePicker1.Value = value;
            comboBox_mechanik.SelectedIndex = -1;
            numericUpDown_koszt_części.Value = 1;
            numericUpDown_czas_pracy.Value = 1;
        }
    }
}
