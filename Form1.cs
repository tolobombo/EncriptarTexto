using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncriptarTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
        }

        //almaceno el texto en una variable para separar cada caracter
        //y por medio de un For envio letra por letra para sustituirla por otra
        private void btn1_Click(object sender, EventArgs e)
        {
            output = "";

            string input = txt1.Text;

            for (int i = 0; i < input.Length; i++)
            {
                encriptar(input[i].ToString());
            }

            txt2.Text = output;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            output = "";

            string input = txt1.Text;

            for (int i = 0; i < input.Length; i++)
            {
                desencriptar(input[i].ToString());
            }

            txt2.Text = output;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            output = "";
        }

        public string output = "";
        public void encriptar(string letra)
        {
            //por cada letra que va recibiendo la compara y la intercambia por la letra asignada
            //concatenando cada letra en un string para devolver el texto junto.

            if (letra == " ")
            {
                output = output + "Æ";
            }
            if (letra == "A")
            {
                output = output + "K";
            }
            if (letra == "B")
            {
                output = output + "D";
            }
            if (letra == "C")
            {
                output = output + "F";
            }
            if (letra == "D")
            {
                output = output + "J";
            }
            if (letra == "E")
            {
                output = output + "N";
            }
            if (letra == "F")
            {
                output = output + "R";
            }
            if (letra == "G")
            {
                output = output + "B";
            }
            if (letra == "H")
            {
                output = output + "C";
            }
            if (letra == "I")
            {
                output = output + "G";
            }
            if (letra == "J")
            {
                output = output + "L";
            }
            if (letra == "K")
            {
                output = output + "X";
            }
            if (letra == "L")
            {
                output = output + "Z";
            }
            if (letra == "M")
            {
                output = output + "Y";
            }
            if (letra == "N")
            {
                output = output + "A";
            }
            if (letra == "Ñ")
            {
                output = output + "V";
            }
            if (letra == "O")
            {
                output = output + "Q";
            }
            if (letra == "P")
            {
                output = output + "I";
            }
            if (letra == "Q")
            {
                output = output + "E";
            }
            if (letra == "R")
            {
                output = output + "M";
            }
            if (letra == "S")
            {
                output = output + "O";
            }
            if (letra == "T")
            {
                output = output + "P";
            }
            if (letra == "U")
            {
                output = output + "T";
            }
            if (letra == "V")
            {
                output = output + "W";
            }
            if (letra == "W")
            {
                output = output + "U";
            }
            if (letra == "X")
            {
                output = output + "Ñ";
            }
            if (letra == "Y")
            {
                output = output + "H";
            }
            if (letra == "Z")
            {
                output = output + "S";
            }
        }
        public void desencriptar(string letra)
        {
            if (letra == "Æ")
            {
                output = output + " ";
            }
            if (letra == "K")
            {
                output = output + "A";
            }
            if (letra == "D")
            {
                output = output + "B";
            }
            if (letra == "F")
            {
                output = output + "C";
            }
            if (letra == "J")
            {
                output = output + "D";
            }
            if (letra == "N")
            {
                output = output + "E";
            }
            if (letra == "R")
            {
                output = output + "F";
            }
            if (letra == "B")
            {
                output = output + "G";
            }
            if (letra == "C")
            {
                output = output + "H";
            }
            if (letra == "G")
            {
                output = output + "I";
            }
            if (letra == "L")
            {
                output = output + "J";
            }
            if (letra == "X")
            {
                output = output + "K";
            }
            if (letra == "Z")
            {
                output = output + "L";
            }
            if (letra == "Y")
            {
                output = output + "M";
            }
            if (letra == "A")
            {
                output = output + "N";
            }
            if (letra == "V")
            {
                output = output + "Ñ";
            }
            if (letra == "Q")
            {
                output = output + "O";
            }
            if (letra == "I")
            {
                output = output + "P";
            }
            if (letra == "E")
            {
                output = output + "Q";
            }
            if (letra == "M")
            {
                output = output + "R";
            }
            if (letra == "O")
            {
                output = output + "S";
            }
            if (letra == "P")
            {
                output = output + "T";
            }
            if (letra == "T")
            {
                output = output + "U";
            }
            if (letra == "W")
            {
                output = output + "V";
            }
            if (letra == "U")
            {
                output = output + "W";
            }
            if (letra == "Ñ")
            {
                output = output + "X";
            }
            if (letra == "H")
            {
                output = output + "Y";
            }
            if (letra == "S")
            {
                output = output + "Z";
            }
        }

        
    }
}
