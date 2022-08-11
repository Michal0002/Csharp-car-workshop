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
    public partial class FormInformacje : Form
    {
        //kolumny
        string[] kolumny = { "Imię i nazwisko mechanika", "Zatrudniony", "Stawka"};
        public FormInformacje()
        {
            InitializeComponent();
        }

        private void FormInformacje_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;

            //dodajemy kolumny
            foreach (string kolumny in kolumny)
                dataGridView1.Columns.Add("col", kolumny);

            foreach(Mechanik mechanik in Mechanik.Mechanicy) //funkcja dodająca mechaników do tabelki
            {
                dataGridView1.Rows.Add(mechanik.Imię_naziwsko, mechanik.data_rozpoczęcia.ToShortDateString(), mechanik.Stawka);
            }
        }
    }
}
