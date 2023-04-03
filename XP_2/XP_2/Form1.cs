using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XP_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string Specializace = "Berserker";
        public int XP = 20;
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public static string VratJmeno(string jmeno)
        {
            return jmeno;
        }
        public static string VratSpecializaci(string Specializace)
        {
            return Specializace;
        }
        public static int VratXP(int XP)
        {
            return XP;
        }
        public static int ZmenaPoziceX(int X)
        {
            return X;
        }
        public static int ZmenaPoziceY(int Y)
        {
            return Y;
        }
    }
}
