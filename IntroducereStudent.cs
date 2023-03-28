using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class IntroducereStudent : Form
    {
        List <Candidati> CandList = new List <Candidati> ();
        public IntroducereStudent()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Ai reusit sa faci click!");
            if (tbNume.Text == "")
                errorProvider1.SetError(tbNume, "Introduceti numele!");
            else
                if (tbVarsta.Text == "")
                errorProvider1.SetError(tbVarsta, "Introduceti varsta!");
            else
                if (tbCNP.Text == "" && tbCNP.Text.Length != 13)
                errorProvider1.SetError(tbCNP, "Introduceti CNP-ul corect!");
            else
                if (cboxSex.Text == "")
                errorProvider1.SetError(cboxSex, "Selectati sexul!");
            else
                if (cboxProfil.Text == "")
                errorProvider1.SetError(cboxProfil, "Selectati profilul!");
            else
                if (tbMedieLiceu.Text == "")
                errorProvider1.SetError(tbMedieLiceu, "Introduceti media din liceu!");
            else
            {
                errorProvider1.Clear();
                try
                {
                    //int nume = Convert.ToInt32(tbNume.Text);
                    //char sex = Convert.ToChar(cbSex.Text);
                    //int varsta = Convert.ToInt32(tbVarsta.Text);
                    //string nume = tbNume.Text;
                    //string[] noteS = tbNote.Text.Trim().Split(',');
                    //int[] note = new int[noteS.Length];
                    //for (int i = 0; i < noteS.Length; i++)
                    //    note[i] = Convert.ToInt32(noteS[i]);

                    Candidati c = new Candidati();
                    //MessageBox.Show(s.ToString());
                    CandList.Add(c);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbCod.Clear();
                    cbSex.Text = "";
                    tbVarsta.Clear();
                    tbNume.Clear();
                    tbNote.Clear();
                }
            }
        }
    }
}
