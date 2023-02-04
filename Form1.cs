using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formiranje_JMBG
{
    public partial class formJmbg : Form
    {
        public formJmbg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void formJmbg_Load(object sender, EventArgs e)
        {
            tbJmbg.Enabled = false;
            tbJmbg.Visible = false;
            labJmbg.Visible = false;
            cbRegion.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbCentSrb_CheckedChanged(object sender, EventArgs e)
        {
            cbRegion.Enabled = true;
            cbRegion.Items.Add("Beograd");
            cbRegion.Items.Add("Šumadija");
            cbRegion.Items.Add("Niš");
            cbRegion.Items.Add("Južna Morava");
            cbRegion.Items.Add("Zaječar");
            cbRegion.Items.Add("Podunavlje");
            cbRegion.Items.Add("Podrinje i Kolubara");
            cbRegion.Items.Add("Kraljevo");
            cbRegion.Items.Add("Užice");
        }

        private void rbVojvodina_CheckedChanged(object sender, EventArgs e)
        {
            cbRegion.Enabled = true;
            cbRegion.Items.Clear();
            cbRegion.Items.Add("Novi Sad");
            cbRegion.Items.Add("Sombor");
            cbRegion.Items.Add("Subotica");
            cbRegion.Items.Add("Zrenjanin");
            cbRegion.Items.Add("Pančevo");
            cbRegion.Items.Add("Kikinda");
            cbRegion.Items.Add("Ruma");
            cbRegion.Items.Add("Sremska Mitrovica");
        }

        private void rbKiM_CheckedChanged(object sender, EventArgs e)
        {
            cbRegion.Enabled = true;
            cbRegion.Items.Clear();
            cbRegion.Items.Add("Priština");
            cbRegion.Items.Add("Kosovska Mitrovica");
            cbRegion.Items.Add("Peć");
            cbRegion.Items.Add("Đakovica");
            cbRegion.Items.Add("Prizren");
            cbRegion.Items.Add("Kosovsko-pomoravski okrug");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbRegion.Enabled = false;
            tbDan.Text = "";
            tbMesec.Text = "";
            tbGodina.Text = "";
            rbM.Checked = false;
            rbZ.Checked = false;
            rbCentSrb.Checked = false;
            rbVojvodina.Checked = false;
            rbKiM.Checked = false;
            cbRegion.Text = "";
            cbRegion.Items.Clear();
            labJmbg.Visible = false;
            tbJmbg.Text = "";
            tbJmbg.Visible = false;
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            int dan, mesec, godina, regija = 0, pol, kont, brojac = 0;

            dan = int.Parse(tbDan.Text);
            mesec = int.Parse(tbMesec.Text);
            godina = int.Parse(tbGodina.Text);

            labJmbg.Visible = true;
            tbJmbg.Visible = true;

            if (rbCentSrb.Checked == true)
            {
                if (cbRegion.SelectedItem.ToString() == "Beograd")
                {
                    regija = 71;
                }
                if (cbRegion.SelectedItem.ToString() == "Šumadija")
                {
                    regija = 72;
                }
                if (cbRegion.SelectedItem.ToString() == "Niš")
                {
                    regija = 73;
                }
                if (cbRegion.SelectedItem.ToString() == "Južna Morava")
                {
                    regija = 74;
                }
                if (cbRegion.SelectedItem.ToString() == "Zaječar")
                {
                    regija = 75;
                }
                if (cbRegion.SelectedItem.ToString() == "Podunavlje")
                {
                    regija = 76;
                }
                if (cbRegion.SelectedItem.ToString() == "Podrinje i Kolubara")
                {
                    regija = 77;
                }
                if (cbRegion.SelectedItem.ToString() == "Kraljevo")
                {
                    regija = 78;
                }
                if (cbRegion.SelectedItem.ToString() == "Užice")
                {
                    regija = 79;
                }
            }

            if (rbVojvodina.Checked == true)
            {
                if (cbRegion.SelectedItem.ToString() == "Novi Sad")
                {
                    regija = 80;
                }
                if (cbRegion.SelectedItem.ToString() == "Sombor")
                {
                    regija = 81;
                }
                if (cbRegion.SelectedItem.ToString() == "Subotica")
                {
                    regija = 82;
                }
                if (cbRegion.SelectedItem.ToString() == "Zrenjanin")
                {
                    regija = 85;
                }
                if (cbRegion.SelectedItem.ToString() == "Pančevo")
                {
                    regija = 86;
                }
                if (cbRegion.SelectedItem.ToString() == "Kikinda")
                {
                    regija = 87;
                }
                if (cbRegion.SelectedItem.ToString() == "Ruma")
                {
                    regija = 88;
                }
                if (cbRegion.SelectedItem.ToString() == "Sremska Mitrovica")
                {
                    regija = 89;
                }
            }

            if (rbKiM.Checked == true)
            {
                if (cbRegion.SelectedItem.ToString() == "Priština")
                {
                    regija = 91;
                }
                if (cbRegion.SelectedItem.ToString() == "Kosovska Mitrovica")
                {
                    regija = 92;
                }
                if (cbRegion.SelectedItem.ToString() == "Peć")
                {
                    regija = 93;
                }
                if (cbRegion.SelectedItem.ToString() == "Đakovica")
                {
                    regija = 94;
                }
                if (cbRegion.SelectedItem.ToString() == "Prizren")
                {
                    regija = 95;
                }
                if (cbRegion.SelectedItem.ToString() == "Kosovsko-pomoravski okrug")
                {
                    regija = 96;
                }
            }

            if (rbM.Checked == true)
            {
                pol = 783;
            }
            else
            {
                pol = 500;

            }

            kont = 11 - ((7 * (dan + godina) + 6 * (dan + pol) + 5 * (mesec + pol) + 4 * (mesec + pol) + 3 * (godina + pol) + 2 * (godina + pol)) % 11);

            tbJmbg.Text = dan.ToString() + mesec.ToString() + (tbGodina.Text).Substring(1) + regija.ToString() + pol.ToString() + kont.ToString();
        }
    }
}
