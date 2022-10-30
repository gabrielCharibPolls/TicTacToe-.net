using System;
using System.Reflection;
using System.Windows.Forms;

namespace WindowsFormsApp1
{    public partial class Form1 : Form
    {

        byte[] tab = new byte[9];
        byte btCourentPlayer = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void nextPayer()
        {

            btCourentPlayer = (byte)((btCourentPlayer % 2)+1);

        }

        ///////////////////////////////////////////////////
        /// methode pricipale de jeux 
        ///////////////////////////////////////////////////
        private void game(Button ActualeButton,byte indice)
        {
            updateTab(indice);
            updateButtonWhenIsClick((Button)ActualeButton);
           
            if (checkLine() || checkColone() || checkDiagonal())
            {
                MessageBox.Show("fin de la partie");
            }
           
        }
        ////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// update the table where the positions of the players are stored
        /// </summary>
        /// It is the position of the table which corresponds to each button
        /// <param name="position"></param>
        /// ///////////////////////////////////////////////////////////////////////
        private void updateTab(byte position)
        {
            if(btCourentPlayer == 1)
            {
                tab[position] = 0;
            }
            else
            {
                tab[position] = 1;
            }
           
        }
        ///////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// check one line at a time
        /// </summary>
        /// <returns>returns true if we have found 3 equal values in a row </returns>
        /// ////////////////////////////////////////////////////////////////////////////
        private bool checkLine()
        {
            bool answer = false;
            if (tab[0] == tab[1] && tab[1] == tab[2] && tab[1] !=0)
            {
                answer = true;
            }
            if (tab[3] == tab[4] && tab[4] == tab[5] && tab[4] !=0)
            {
                answer = true;
            }
            if (tab[6] == tab[7] && tab[7] == tab[8] && tab[7] !=0)
            {
                answer = true;
            }
            return answer;
        }

        private bool checkColone()
        {
            bool answer = false;
            if (tab[0] == tab[3] && tab[3] == tab[6] && tab[3]!=0)
            {
                answer = true;
            }
            if (tab[1] == tab[4] && tab[4] == tab[7] && tab[4]!=0)
            {
                answer = true;
            }
            if (tab[2] == tab[5] && tab[5] == tab[8] && tab[5] != 0)
            {
                answer = true;
            }
            return answer;
        }

        private bool checkDiagonal()
        {
            bool answer = false;
            if(tab[0] == tab[4] && tab[4] == tab[8] && tab[4] != 0)
            {
                answer = true;
            }
            if (tab[2] == tab[4]&& tab[4] == tab[6] && tab[4] != 0)
            {
                answer = true;
            }
            return answer;
        }  

        //////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// tout mes methodes des boutons 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// ///////////////////////////////////////////////////////////////////////////
        private void updateButtonWhenIsClick(Button ActualeButton)
        {
            if (btCourentPlayer == 1)
            {
                ActualeButton.Text = "X";
            }
            else
            {
                ActualeButton.Text = "O";
            }
            nextPayer();

        }
        //methode qui verifier si tout les case sont jouer 

        private void button_00_Click(object sender, EventArgs e)
        {
            byte index = 0;
            //changer les valeur dans le tableau 
            //changer le contenue du button 
            //changer de player 
            //button_00.Text = "X";
            game((Button)sender,index);
        }

        private void button_01_Click(object sender, EventArgs e)
        {
            byte index = 1;
            game((Button)sender, index);

        }

        private void button_02_Click(object sender, EventArgs e)
        {
            byte index = 2;
            game((Button)sender, index);

        }

        private void button_10_Click(object sender, EventArgs e)
        {
            byte index = 3;
            game((Button)sender, index);

        }

        private void button_11_Click(object sender, EventArgs e)
        {
            byte index = 4;
            game((Button)sender, index);

        }

        private void button_12_Click(object sender, EventArgs e)
        {
            byte index = 5;
            game((Button)sender, index);

        }

        private void button_20_Click(object sender, EventArgs e)
        {
            byte index = 6;
            game((Button)sender, index);

        }

        private void button_21_Click(object sender, EventArgs e)
        {
            byte index = 7;
            game((Button)sender, index);
        }

        private void button_22_Click(object sender, EventArgs e)
        {
            byte index = 8;
            game((Button)sender, index);
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {

        }
    }
}
