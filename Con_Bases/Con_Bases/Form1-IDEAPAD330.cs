using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Con_Bases
{
    public partial class Conversor : Form
    {
        public Conversor()
        {
            InitializeComponent();
        }
        int d, b, o, rd, he, s = 0, ex = 0;
        string rb, rh, ro, h;
        private void button1_Click(object sender, EventArgs e)
        {
            if(rbbi.Checked)
            {
                b = Convert.ToInt32(txtn.Text);
               
                txtbi.Text = b.ToString();
                do
                {
                    s = b % 10;
                    b /= 10;
                    rd += (int)(s * Math.Pow(2, ex));
                    ex++;
                } while (b > 0);
                if (cbde.Checked)
                {
                    txtde.Text = rd.ToString();
                }
                if (cbhe.Checked)
                {
                    d = rd;
                    while (d > 0)
                    {
                        switch (d % 16)
                        {
                            case 0: rh = ("0" + rh); break;
                            case 1: rh = ("1" + rh); break;
                            case 2: rh = ("2" + rh); break;
                            case 3: rh = ("3" + rh); break;
                            case 4: rh = ("4" + rh); break;
                            case 5: rh = ("5" + rh); break;
                            case 6: rh = ("6" + rh); break;
                            case 7: rh = ("7" + rh); break;
                            case 8: rh = ("8" + rh); break;
                            case 9: rh = ("9" + rh); break;
                            case 10: rh = ("A" + rh); break;
                            case 11: rh = ("B" + rh); break;
                            case 12: rh = ("C" + rh); break;
                            case 13: rh = ("D" + rh); break;
                            case 14: rh = ("E" + rh); break;
                            case 15: rh = ("F" + rh); break;
                        }
                        d = (d / 16);
                    }
                    txthe.Text = rh.ToString();
                }
                if (cboc.Checked)
                {
                    d = rd;
                    while (d > 0)
                    {
                        switch (d % 8)
                        {
                            case 0: ro = ("0" + ro); break;
                            case 1: ro = ("1" + ro); break;
                            case 2: ro = ("2" + ro); break;
                            case 3: ro = ("3" + ro); break;
                            case 4: ro = ("4" + ro); break;
                            case 5: ro = ("5" + ro); break;
                            case 6: ro = ("6" + ro); break;
                            case 7: ro = ("7" + ro); break;
                        }
                        d = (d / 8);
                    }
                    txtoc.Text = ro.ToString();
                }
            }
            else
            {
                if (rbde.Checked)
                {
                    d = Convert.ToInt32(txtn.Text);
                    txtde.Text = d.ToString();
                    if (cbbi.Checked)
                    {
                        d = Convert.ToInt32(txtn.Text);
                        while (d > 0)
                        {
                            switch (d % 2)
                            {
                                case 0: rb = ("0" + rb); break;
                                case 1: rb = ("1" + rb); break;
                            }
                            d = (d / 2);
                        }
                        txtbi.Text = rb.ToString();
                    }
                    if(cbhe.Checked)
                    {
                        d = Convert.ToInt32(txtn.Text);
                        while (d > 0)
                        {
                            switch (d % 16)
                            {
                                case 0: rh = ("0" + rh); break;
                                case 1: rh = ("1" + rh); break;
                                case 2: rh = ("2" + rh); break;
                                case 3: rh = ("3" + rh); break;
                                case 4: rh = ("4" + rh); break;
                                case 5: rh = ("5" + rh); break;
                                case 6: rh = ("6" + rh); break;
                                case 7: rh = ("7" + rh); break;
                                case 8: rh = ("8" + rh); break;
                                case 9: rh = ("9" + rh); break;
                                case 10: rh = ("A" + rh); break;
                                case 11: rh = ("B" + rh); break;
                                case 12: rh = ("C" + rh); break;
                                case 13: rh = ("D" + rh); break;
                                case 14: rh = ("E" + rh); break;
                                case 15: rh = ("F" + rh); break;
                            }
                            d = (d / 16);
                        }
                        txthe.Text = rh.ToString();
                    }
                    if (cboc.Checked)
                    {
                        d = Convert.ToInt32(txtn.Text);
                        while (d > 0)
                        {
                            switch (d % 8)
                            {
                                case 0: ro = ("0" + ro); break;
                                case 1: ro = ("1" + ro); break;
                                case 2: ro = ("2" + ro); break;
                                case 3: ro = ("3" + ro); break;
                                case 4: ro = ("4" + ro); break;
                                case 5: ro = ("5" + ro); break;
                                case 6: ro = ("6" + ro); break;
                                case 7: ro = ("7" + ro); break;
                            }
                            d = (d / 8);
                        }
                        txtoc.Text = ro.ToString();
                    }
                }
                else
                {
                    if (rbhe.Checked)
                    {
                        h = (txtn.Text);

                        switch (h)
                        {
                            case "0": he = (0 + he); break;
                            case "1": he = (1 + he); break;
                            case "2": he = (2 + he); break;
                            case "3": he = (3 + he); break;
                            case "4": he = (4 + he); break;
                            case "5": he = (5 + he); break;
                            case "6": he = (6 + he); break;
                            case "7": he = (7 + he); break;
                            case "8": he = (8 + he); break;
                            case "9": he = (9 + he); break;
                            case "A": he = (10 + he); break;
                            case "B": he = (11 + he); break;
                            case "C": he = (12 + he); break;
                            case "D": he = (13 + he); break;
                            case "E": he = (14 + he); break;
                            case "F": he = (15 + he); break;
                        }
                        do
                        {
                            s = he % 10;
                            he /= 10;
                            rd += (int)(s * Math.Pow(16, ex));
                            ex++;
                        } while (he > 0);
                        txtde.Text = rd.ToString();
                    }
                    else
                    {
                        if (rboc.Checked)
                        {
                            o = Convert.ToInt32(txtn.Text);
                            txtoc.Text = o.ToString();
                            do
                            {
                                s = o % 10;
                                o /= 10;
                                rd += (int)(s * Math.Pow(8, ex));
                                ex++;
                            } while (o > 0);

                            if (cbde.Checked)
                            {
                                txtde.Text = rd.ToString();
                            }
                            if (cbbi.Checked)
                            {
                                if (cbbi.Checked)
                                {
                                    d = rd;
                                    while (d > 0)
                                    {
                                        switch (d % 2)
                                        {
                                            case 0: rb = ("0" + rb); break;
                                            case 1: rb = ("1" + rb); break;
                                        }
                                        d = (d / 2);
                                    }
                                    txtbi.Text = rb.ToString();
                                }
                                if (cbhe.Checked)
                                {
                                    d = rd;
                                    while (d > 0)
                                    {
                                        switch (d % 16)
                                        {
                                            case 0: rh = ("0" + rh); break;
                                            case 1: rh = ("1" + rh); break;
                                            case 2: rh = ("2" + rh); break;
                                            case 3: rh = ("3" + rh); break;
                                            case 4: rh = ("4" + rh); break;
                                            case 5: rh = ("5" + rh); break;
                                            case 6: rh = ("6" + rh); break;
                                            case 7: rh = ("7" + rh); break;
                                            case 8: rh = ("8" + rh); break;
                                            case 9: rh = ("9" + rh); break;
                                            case 10: rh = ("A" + rh); break;
                                            case 11: rh = ("B" + rh); break;
                                            case 12: rh = ("C" + rh); break;
                                            case 13: rh = ("D" + rh); break;
                                            case 14: rh = ("E" + rh); break;
                                            case 15: rh = ("F" + rh); break;
                                        }
                                        d = (d / 16);
                                    }
                                    txthe.Text = rh.ToString();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Selecione uma Base");
                        }

                    }
                }
            } 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtbi.Text = "";
            txtde.Text = "";
            txthe.Text = "";
            txtoc.Text = "";
            txtn.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        
    }
}
