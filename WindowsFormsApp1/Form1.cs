using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{


    


    
    public partial class Form1 : Form
    {

        byte[,] tab = new byte[2, 2];
        byte btCourentPlayer = 0; 
        public Form1()
        {
            InitializeComponent();
        }

        private static byte nextPayer(byte courentPlayer)
        {
            return (byte)(courentPlayer % 2);
        }

        ///////////////////////////////////////////////////
        /// methode pricipale de jeux 
        ///////////////////////////////////////////////////
        private void game()
        {

        }


        /// <summary>
        /// tout mes methodes des boutons 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_00_Click(object sender, EventArgs e)
        {
            //changer les valeur dans le tableau 
            //changer le contenue du button 
            //changer de player 
        }

        private void button_01_Click(object sender, EventArgs e)
        {

        }

        private void button_02_Click(object sender, EventArgs e)
        {

        }

        private void button_10_Click(object sender, EventArgs e)
        {

        }

        private void button_11_Click(object sender, EventArgs e)
        {

        }

        private void button_12_Click(object sender, EventArgs e)
        {

        }

        private void button_20_Click(object sender, EventArgs e)
        {

        }

        private void button_21_Click(object sender, EventArgs e)
        {

        }

        private void button_22_Click(object sender, EventArgs e)
        {

        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {

        }
    }
}
