using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMastermind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bordMastermind();
            TeRadenCode();
            
        }
        Brush[,] kleurGroteRondje = new Brush[9, 4];
        Brush[,] kleurKleineRondje = new Brush[8, 4];
        bool knipperenAan = true;
        bool goedeCode = false;
        
        int rij = 0, kolom = 0 , tellerAantalGeklikt = 0;

        Brush[] arrayColor = new Brush[4];

        // Deze methode zet de kleur van alle grote en kleine rondjes op het bord in op licht grijs.
        private void bordMastermind()
        {
            for (int rij = 0; rij < 8; rij++)
            {
                for (int kolom = 0; kolom < 4; kolom++)
                {
                    kleurGroteRondje[rij, kolom] = Brushes.LightGray;
                    kleurKleineRondje[rij, kolom] = Brushes.LightGray;
                }
            }
        }
        private void pionVeranderKleur(object sender, EventArgs eventArgs)
        {
            Button button = (Button)sender;
            string kleurButton = button.Tag.ToString();
            
            switch (kleurButton)
            {
                case "geel":
                    kleurGroteRondje[rij, kolom] = Brushes.Yellow;
                    break;
                case "rood":
                    kleurGroteRondje[rij, kolom] = Brushes.Red;
                    break;
                case "groen":
                    kleurGroteRondje[rij, kolom] = Brushes.Green;
                    break;
                case "blauw":
                    kleurGroteRondje[rij, kolom] = Brushes.Blue;
                    break;
                case "oranje":
                    kleurGroteRondje[rij, kolom] = Brushes.Orange;
                    break;
                case "paars":
                    kleurGroteRondje[rij, kolom] = Brushes.Purple;
                    break;
            }
            kolom++;

            if (tellerAantalGeklikt == 8)
            {
                MessageBox.Show("Helaas, u heeft verloren. Probeer het opnieuw!");
            }

            if (kolom == 4)
            {
                btnGeel.Enabled = true;
                btnRood.Enabled = true;
                btnGroen.Enabled = true;
                btnBlauw.Enabled = true;
                btnOranje.Enabled = true;
                btnPaars.Enabled = true;

                CheckCode(kolom, rij);
                rij++;
                
                tellerAantalGeklikt++;
                kolom = 0;
                

            }
            picCanvas.Invalidate();
        }

        // Controleer de code en bepaal het aantal juiste kleuren en juiste plekken
        private void CheckCode(int kolom, int rij)
        {
            int[] goedeIndex = new int[4];
            int goedeTellen = 0;

            int aantalJuisteKleuren = 0;
            int aantalJuistePlekken = 0;


            for (int i = 0; i < 4; i++)
            {
                for( int j = 0; j < 4; j++)
                {
                    if (kleurGroteRondje[rij, i] == arrayColor[j] && i == j)
                    {
                        aantalJuistePlekken++;
                        goedeIndex[goedeTellen] = i;
                        goedeTellen++;
                    }
                    else if (kleurGroteRondje[rij, i] == arrayColor[j])
                    {
                        aantalJuisteKleuren++;
                    }
                }
                
            }

            UpdateKleurKleineRondjes(rij, aantalJuistePlekken, aantalJuisteKleuren);

            if (aantalJuistePlekken == 4)
            {
                lbWinnaar.Visible = true;
                knipperen.Start();
                btnGeel.Enabled = false;
                btnRood.Enabled = false;
                btnGroen.Enabled = false;
                btnBlauw.Enabled = false;
                btnOranje.Enabled = false;
                btnPaars.Enabled = false;
            }
            picCanvas.Invalidate();
        }
        // Update kleur van kleine rondjes
        private void UpdateKleurKleineRondjes(int rij, int juistePlekken, int juisteKleuren)
        {
            for (int i = 0; i < juistePlekken; i++)
            {
                kleurKleineRondje[rij, i] = Brushes.Red;
            }
            for (int i = juistePlekken; i < juistePlekken + juisteKleuren; i++)
            {
                kleurKleineRondje[rij, i] = Brushes.White;
            }
        }
        private void TeRadenCode()
        {
            Random r = new Random();
            Brush[] colorArray = { Brushes.Yellow, Brushes.Red, Brushes.Green, Brushes.Blue, Brushes.Orange };
            TextBox[] textboxes = { txtArray, txtArray2, txtArray3, txtArray4 };
            bool[] gebruikteKleuren = new bool[6];

            for (int i = 0; i < 4; i++)
            {
                int randomIndex;
                do
                {
                    randomIndex = r.Next(colorArray.Length);
                }
                while (gebruikteKleuren[randomIndex]);

                arrayColor[i] = colorArray[randomIndex];
                textboxes[i].BackColor = ((SolidBrush)arrayColor[i]).Color;
                gebruikteKleuren[randomIndex] = true;               
            }            
        }
        private void UpdateGraficsPicturebox(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            canvas.FillRectangle(Brushes.Gray, 10, 10, 600, 800);

            for (int rij = 0; rij < 8; rij++)
            {
                for (int kolom = 0; kolom < 4; kolom++)
                {
                    canvas.FillEllipse(kleurGroteRondje[rij, kolom], 20 + 40 * kolom, 20 + 40 * rij, 30, 30);
                    canvas.FillEllipse(kleurKleineRondje[rij, kolom], 200 + 30 * kolom, 25 + 40 * rij, 20, 20);
                }
            }
        }
        private void btnGeel_Click(object sender, EventArgs e)
        {
            btnGeel.Enabled = false;
            pionVeranderKleur(sender, e);
        }
        private void btnRood_Click(object sender, EventArgs e)
        {
            btnRood.Enabled = false;
            pionVeranderKleur(sender, e);
        }
        private void btnGroen_Click(object sender, EventArgs e)
        {
            btnGroen.Enabled = false;
            pionVeranderKleur(sender, e);
        }
        private void btnBlauw_Click(object sender, EventArgs e)
        {
            btnBlauw.Enabled = false;
            pionVeranderKleur(sender, e);
        }
        private void btnUndo_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }
        private void knipperen_Tick(object sender, EventArgs e)
        {
            if (knipperenAan)
            {
                for(int i = 0; i <4; i++)
                {
                    kleurGroteRondje[rij-1,i] = arrayColor[i];
                }
                knipperenAan = false;
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    kleurGroteRondje[rij-1, i] = Brushes.LightGray;
                }
                knipperenAan = true;
            }
            picCanvas.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (goedeCode)
            {
                picZichtbaar.Visible = true;               
            }
            else
            {
                picZichtbaar.Visible = false;
            }
            goedeCode = !goedeCode;
        }

        private void btnOranje_Click(object sender, EventArgs e)
        {
            btnOranje.Enabled = false;
            pionVeranderKleur(sender, e);
        }
        private void btnPaars_Click(object sender, EventArgs e)
        {
            btnPaars.Enabled = false;
            pionVeranderKleur(sender, e);
        }
    }
}
