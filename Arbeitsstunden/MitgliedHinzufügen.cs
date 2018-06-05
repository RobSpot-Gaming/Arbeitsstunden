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
    public partial class MitgliedHinzufügen : Form
    {
        Datenbank dieDatenbank;
        public MitgliedHinzufügen(Datenbank pDatenbank)
        {
            InitializeComponent();
            dieDatenbank = pDatenbank;
        }


        private void btn_addClose_Click(object sender, EventArgs e)
        {
            insertData();
            this.Close();
        }

        private void insertData()
        {
            dieDatenbank.insert("mitglied", "nummer,vName,name,arbeitsstunden", txt_nummer.Text + ",'" + txt_vorname.Text + "','" + txt_nachname.Text + "'," + txt_arbeitsstunden.Text);
        }

        private void btn_addNext_Click(object sender, EventArgs e)
        {
            insertData();
            txt_nummer.Text = "";
            txt_vorname.Text = "";
            txt_nachname.Text = "";
            txt_arbeitsstunden.Text = "";
        }
    }
}
