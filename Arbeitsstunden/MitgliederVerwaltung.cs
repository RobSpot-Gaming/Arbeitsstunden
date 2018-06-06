using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbeitsstunden
{
    public partial class MitgliederVerwaltung : Form
    {
        Datenbank dieDatenbank;

        public MitgliederVerwaltung(Datenbank pDatenbank)
        {
            InitializeComponent();
            dieDatenbank = pDatenbank;
            reloade_table();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            reloade_table();
        }

        public void reloade_table()
        {
            dataGridView1.DataSource = dieDatenbank.DataAdapter("SELECT nummer AS Mitgliedsnummer, vNAme AS Vorname, Name AS Nachnahme, arbeitsstunden AS Arbeitsstunden FROM mitglied ORDER BY nummer").Tables[0];
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            MitgliedHinzufügen dasMitgliedHinzufügen = new MitgliedHinzufügen(dieDatenbank);
            dasMitgliedHinzufügen.ShowDialog();
        }

        private void btn_bearbeiten_Click(object sender, EventArgs e)
        {
            string nummer = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            btn_bearbeiten.Text = nummer;

            //MitgiledBearbeiten dasMitgliedBearbeiten = new MitgliedBearbeiten(dieDatenbank,nummer);
            //dasMitgliedBearbeiten.ShowDialog();
        }
    }
}
