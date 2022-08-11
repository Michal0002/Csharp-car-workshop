using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        //tablica kolumn tabelki
        string[] kolumny = { "Nr. rejestracyjny pojazdu", "Data wykonania naprawy", "Imię i nazwisko mechanika", "Koszt cześci zamiennych [zł]", "Czas pracy [h]", "Należność [zł]" };
        //deklaracja dat rozpoczęcia pracy dla mechaników
        DateTime d1 = new DateTime(2019, 5, 15);
        DateTime d2 = new DateTime(2019, 8, 11);
        DateTime d3 = new DateTime(2018, 10, 21);
        DateTime d4 = new DateTime(2017, 3, 18);
        public Form1()
        {
            InitializeComponent();

            //Przypisujemy mechaników (ImięNazwisko,Stawka,zatrudniony);
            Mechanik m1 = new Mechanik("Jan Kowalski", 50, d1);
            Mechanik.Mechanicy.Add(m1);
            Mechanik m2 = new Mechanik("Krzysztof Bąk", 50, d2);
            Mechanik.Mechanicy.Add(m2);
            Mechanik m3 = new Mechanik("Jacek Kulesza", 65, d3);
            Mechanik.Mechanicy.Add(m3);
            Mechanik m4 = new Mechanik("Paweł Groszek", 85, d4);
            Mechanik.Mechanicy.Add(m4);
        }
        private void Form1_Load(object sender, EventArgs e)
        {           
            //Dodajemy kolumny do tabelki 
            foreach (string kolumny in kolumny)
                dataGridView1.Columns.Add("col", kolumny);

            //deserializacja
            try
            {
                FileStream fs = new FileStream("Mechanik1.war", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();

                Naprawa.Naprawy = (List<Naprawa>)bf.Deserialize(fs);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Nie udało się wczytać danych z pliku Mechanik1.war");
            }
            wyświetl(); //wywołanie funkcji - wypelnianie tabelki wcześniejszymi danymi
        }
       private void Form1_FormClosing(object sender, FormClosingEventArgs e) //serializacja
        {
            FileStream fs = new FileStream("Mechanik1.war", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, Naprawa.Naprawy);


            fs.Close();

        }
        private void button_dodaj_Click(object sender, EventArgs e)  //Wywołujemy FormNaprawy i dodajemy wartości do tabelki
        {

            Naprawa naprawa = new Naprawa(); //tworzenie obiektu klasy
            FormNaprawy formularz_napraw = new FormNaprawy(naprawa);
            formularz_napraw.ShowDialog();

            if (formularz_napraw.DialogResult != DialogResult.OK)
                return;
                Naprawa.Naprawy.Add(naprawa);

            wyświetl(); // wyświetl funkcje wyświetl()
        }

        void wyświetl() //funkcja wyświetl
        {
            //czyścimy wiersze i dodajemy za pomocą funkcji foreach odpowiednie wartości do tabelki
            dataGridView1.Rows.Clear();
            foreach (Naprawa n in Naprawa.Naprawy)
                dataGridView1.Rows.Add(n.Nr_rejestracyjny,n.data_naprawy.ToShortDateString(), n.mechan.Imię_naziwsko, n.koszt_części, n.czas_pracy, n.należność);
    }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //edytowanie przy 2-krotnym kliknięciu.
        {
            Naprawa naprawa = new Naprawa();
            FormNaprawy form = new FormNaprawy(naprawa);

            DialogResult result = MessageBox.Show("Chcesz edytować dane dla nr. rejestracynego: " + dataGridView1.SelectedRows[0].Cells[0].Value + "? ", "Edytowanie", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes) // przypisujemy wartości z klasy do komórek tabelki
            {
                naprawa.Nr_rejestracyjny = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                naprawa.data_naprawy = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[1].Value);
                naprawa.koszt_części = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
                naprawa.czas_pracy = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
                naprawa.należność = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[5].Value);
                
                if (form.ShowDialog() != DialogResult.OK)
                    return;

                //dodajemy przypisane wartości do tabelki w wybrane miejsce
                dataGridView1.SelectedRows[0].Cells[0].Value = naprawa.Nr_rejestracyjny;
                dataGridView1.SelectedRows[0].Cells[1].Value = naprawa.data_naprawy.ToShortDateString();
                dataGridView1.SelectedRows[0].Cells[2].Value = naprawa.mechan.Imię_naziwsko;
                dataGridView1.SelectedRows[0].Cells[3].Value = Convert.ToInt32(naprawa.koszt_części);
                dataGridView1.SelectedRows[0].Cells[4].Value = Convert.ToInt32(naprawa.czas_pracy);
                dataGridView1.SelectedRows[0].Cells[5].Value = Convert.ToDecimal(naprawa.należność);
                int selectedIndex = dataGridView1.CurrentCell.RowIndex; //wybrany wiersz
                Naprawa.Naprawy.RemoveAt(selectedIndex); //usuwamy wybrany wiersz
                Naprawa.Naprawy.Add(naprawa); //dodajemy nowy wiersz w to samo miejsce w tabelce

            }
        }

        private void button_usuń_Click(object sender, EventArgs e)  //usuwanie
        {
            DialogResult result = MessageBox.Show("Chcesz usunąć dane dla nr. rejestracynego: " + dataGridView1.SelectedRows[0].Cells[0].Value + "? ", "Usuwanie", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) 
            {
                int index = dataGridView1.CurrentRow.Index; //przypisanie do zmiennej index obecnego wiersza po indeksie.
                dataGridView1.Rows.RemoveAt(index); //usuwanie wiersza z tabelki

                Naprawa.Naprawy.RemoveAt(index); //usuwanie wiersza z klasy Naprawa
            }
            if (result == DialogResult.No) // przypisujemy wartości
                return;
            }

        private void button_infos_Click(object sender, EventArgs e) //przycisk informacje o mechanikach wywołuje formatke FormInformacje
        {
            FormInformacje form_info = new FormInformacje();
            form_info.ShowDialog();
        }

        private void button_dane_Click(object sender, EventArgs e) //przycisk należności dla poszczególnych mechaników, wywołuje formatke FormKosztorys
        {
            FormKosztorys form_kosztorys = new FormKosztorys();
            form_kosztorys.ShowDialog();
        }

    }
}
