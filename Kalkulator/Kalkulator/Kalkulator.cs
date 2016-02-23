using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kalkulator;
using System.Media;


namespace Kalkulator
{
    
    public partial class Form1 : Form
    {
        kalkulatorMetode m = new kalkulatorMetode();
        public Form1()
        {
            InitializeComponent();
            this.Text = "Kalkulator";
            
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            m.postotak(textBox2);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            
            m.upisBroja(textBox2,textBox1, "1",m.jednakoPritisnuto);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            m.upisBroja(textBox2, textBox1, "2", m.jednakoPritisnuto);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            m.upisBroja(textBox2, textBox1, "3", m.jednakoPritisnuto);
        }
        private void button16_Click(object sender, EventArgs e)
        {
            m.upisBroja(textBox2, textBox1, "4", m.jednakoPritisnuto);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            m.upisBroja(textBox2, textBox1, "5", m.jednakoPritisnuto);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            m.upisBroja(textBox2, textBox1, "6", m.jednakoPritisnuto);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            m.upisBroja(textBox2, textBox1, "7", m.jednakoPritisnuto);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            m.upisBroja(textBox2, textBox1, "8", m.jednakoPritisnuto);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            m.upisBroja(textBox2, textBox1, "9", m.jednakoPritisnuto);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if(textBox2.Text=="" || m.jednakoPritisnuto==true)
            {
                
            }
            else
            {
                m.upisBroja(textBox2, textBox1, "0", m.jednakoPritisnuto);
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {          
            if (m.decZarez==false)
            { 
                if (textBox2.Text == "")
                {
                    m.upisBroja(textBox2, textBox1, "0,", m.jednakoPritisnuto);
                     m.decZarez= true;
                }
                else
                {
                    m.upisBroja(textBox2, textBox1, ",", m.jednakoPritisnuto);
                     m.decZarez= true;
                }
            }
            else
            {
                SystemSounds.Hand.Play();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
           if (textBox2.Text=="")
           {
                SystemSounds.Hand.Play();
            }
            else
            {
            string txt = textBox2.Text.Remove(textBox2.Text.Count() - 1);
            textBox2.Text = txt;
            }   
        }

        private void button29_Click(object sender, EventArgs e)
        {
            m.zbr(textBox2, textBox1);
        }

        private void izracunaj_button_Click(object sender, EventArgs e)
        {
            try
            {
               m.izracunaj(textBox1, textBox2, m.broj1);
            }
            catch (Exception)
            {
                
            }
            
            
        }

        private void oduzimanje_button_Click(object sender, EventArgs e)
        {
            m.oduz(textBox2, textBox1);
        }

        private void mnozenje_button_Click(object sender, EventArgs e)
        {
            m.mnoz(textBox2, textBox1);
        }

        private void dijeljenje_button_Click(object sender, EventArgs e)
        {
            m.dij(textBox2, textBox1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            m.jednakoPritisnuto = false;
            m.decZarez = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            m.jednakoPritisnuto = false;
            m.decZarez = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            m.promjenaPredznaka(textBox2);

        }

        private void button20_Click(object sender, EventArgs e)
        {
            m.jedanKrozBroj(textBox2);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            m.korijen(textBox2);
        }
    }
}
