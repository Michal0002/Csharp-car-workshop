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
    public partial class FormKosztorys : Form
    {
        string[] kolumny = { "Nr. rejestracyjny pojazdu", "Data wykonania naprawy", "Imię i nazwisko mechanika", "Koszt cześci zamiennych", "Czas pracy [h]" };
        public FormKosztorys()
        {
            InitializeComponent();
        }

        private void FormKosztorys_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;

            //dodajemy kolumny
            foreach (string kolumny in kolumny)
                dataGridView1.Columns.Add("col", kolumny);

            foreach(Mechanik mechanik in Mechanik.Mechanicy)
            {
                comboBox1.Items.Add(mechanik);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_szukaj_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Mechanik mechanik = (Mechanik)comboBox1.SelectedItem; //przypisujemy wartość comboboxa do zmiennej mechanik
            decimal należność = 0; //wartość początkowa dla należności
            for (int i = 0; i < Naprawa.Naprawy.Count; i++) 
            {
                if (Naprawa.Naprawy[i].mechan.ToString() == mechanik.ToString())
                {
                    int dgv = dataGridView1.Rows.Add();
                    dataGridView1.Rows[dgv].Cells[0].Value = Naprawa.Naprawy[i].Nr_rejestracyjny;
                    dataGridView1.Rows[dgv].Cells[1].Value = Naprawa.Naprawy[i].data_naprawy.ToShortDateString();
                    dataGridView1.Rows[dgv].Cells[2].Value = Naprawa.Naprawy[i].mechan.Imię_naziwsko;
                    dataGridView1.Rows[dgv].Cells[3].Value = Naprawa.Naprawy[i].koszt_części;
                    dataGridView1.Rows[dgv].Cells[4].Value = Naprawa.Naprawy[i].czas_pracy;
                    należność += Naprawa.Naprawy[i].koszt_części + Naprawa.Naprawy[i].czas_pracy * Naprawa.Naprawy[i].mechan.Stawka;
                }
                label_należność.Text = należność.ToString(); 
                label_ilnapraw.Text = dataGridView1.Rows.Count.ToString();

                //suma z kosztów części
                int suma_części = 0; //wartość początkowa
                int wiersze = dataGridView1.Rows.Count; //liczba wierszy
                for (int s = 0; s < wiersze; s++) 
                {
                    suma_części += Convert.ToInt32(dataGridView1.Rows[s].Cells[3].Value);
                }
                label_części.Text = suma_części.ToString();
            }
        }
    }
}
