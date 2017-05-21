using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication25
{
    public partial class Form2 : Form
    {
        public Form2(String s)
        {
            InitializeComponent();
            label4.Text = s;

        }
        public Label Data
        {
            get
            {
                return label4;
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Airlane airlane = Return.Airlane;
            int index1 = Return.index1[Return.index1.Count() - 1];
            if (textBox2.Text.Length != 0 && textBox3.Text.Length != 0 && textBox4.Text.Length != 0 && textBox1.Text.Length != 0)
            {
                int res;
                bool isInt = Int32.TryParse(textBox4.Text, out res);
                if (isInt == true)
                {
                    _20_65T sp1 = new _20_65T();
                    _65_120T sp2 = new _65_120T();
                    Boing sp3 = new Boing();
                    Airbus sp4 = new Airbus();
                    Bomber sp5 = new Bomber();
                    Intelligence sp6 = new Intelligence();
                    if (airlane.Allplane[index1].GetType() == sp1.GetType())
                    {
                        _20_65T b = (_20_65T)(airlane.Allplane[index1]);
                        b.Name = textBox1.Text;
                        b.Country = textBox2.Text;
                        b.Color = textBox3.Text;
                        b.Lifting = int.Parse(textBox4.Text);
                        b.Nameclass = "";
                        airlane.Allplane.RemoveAt(index1);
                        airlane.Allplane.Add(b);
                        Return.Airlane = airlane;
                        this.Close();
                    }
                    if (airlane.Allplane[index1].GetType() == sp2.GetType())
                    {
                        _65_120T b = (_65_120T)(airlane.Allplane[index1]);
                        b.Name = textBox1.Text;
                        b.Country = textBox2.Text;
                        b.Color = textBox3.Text;
                        b.Lifting = int.Parse(textBox4.Text);
                        b.Nameclass = "";
                        airlane.Allplane.RemoveAt(index1);
                        airlane.Allplane.Add(b);
                        Return.Airlane = airlane;
                        this.Close();
                    }
                    if (airlane.Allplane[index1].GetType() == sp3.GetType())
                    {
                        Boing b = (Boing)(airlane.Allplane[index1]);
                        b.Name = textBox1.Text;
                        b.Country = textBox2.Text;
                        b.Color = textBox3.Text;
                        b.Nameclass = "";
                        airlane.Capacity = -b.Capacity;
                        b.Capacity = int.Parse(textBox4.Text);
                        airlane.Capacity = b.Capacity;
                        airlane.Allplane.RemoveAt(index1);
                        airlane.Allplane.Add(b);
                        Return.Airlane = airlane;
                        this.Close();
                    }
                    if (airlane.Allplane[index1].GetType() == sp4.GetType())
                    {
                        Airbus b = (Airbus)(airlane.Allplane[index1]);
                        b.Name = textBox1.Text;
                        b.Country = textBox2.Text;
                        b.Color = textBox3.Text;
                        b.Nameclass = "";
                        airlane.Capacity = -b.Capacity;
                        b.Capacity = int.Parse(textBox4.Text);
                        airlane.Capacity = b.Capacity;
                        airlane.Allplane.RemoveAt(index1);
                        airlane.Allplane.Add(b);
                        Return.Airlane = airlane;
                        this.Close();
                    }
                    if (airlane.Allplane[index1].GetType() == sp5.GetType())
                    {
                        Bomber b = (Bomber)(airlane.Allplane[index1]);
                        b.Name = textBox1.Text;
                        b.Country = textBox2.Text;
                        b.Color = textBox3.Text;
                        b.Thickness = int.Parse(textBox4.Text);
                        b.Nameclass = "";
                        airlane.Allplane.RemoveAt(index1);
                        airlane.Allplane.Add(b);
                        Return.Airlane = airlane;
                        this.Close();
                    }
                    if (airlane.Allplane[index1].GetType() == sp6.GetType())
                    {
                        Intelligence b = (Intelligence)(airlane.Allplane[index1]);
                        b.Name = textBox1.Text;
                        b.Country = textBox2.Text;
                        b.Color = textBox3.Text;
                        b.Thickness = int.Parse(textBox4.Text);
                        b.Nameclass = "";
                        airlane.Allplane.RemoveAt(index1);
                        airlane.Allplane.Add(b);
                        Return.Airlane = airlane;
                        this.Close();

                    }
                }
            }

        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            Airlane airlane = Return.Airlane;
            int index1 = Return.index1[Return.index1.Count() - 1];
                    _20_65T sp1 = new _20_65T();
                    _65_120T sp2 = new _65_120T();
                    Boing sp3 = new Boing();
                    Airbus sp4 = new Airbus();
                    Bomber sp5 = new Bomber();
                    Intelligence sp6 = new Intelligence();
                    if (airlane.Allplane[index1].GetType() == sp1.GetType())
                    {
                        _20_65T b = (_20_65T)(airlane.Allplane[index1]);
                        textBox1.Text = b.Name;
                        textBox2.Text = b.Country;
                        textBox3.Text = b.Color;
                        textBox4.Text = b.Lifting.ToString();
                    }
                    if (airlane.Allplane[index1].GetType() == sp2.GetType())
                    {
                        _65_120T b = (_65_120T)(airlane.Allplane[index1]);
                        textBox1.Text = b.Name;
                        textBox2.Text = b.Country;
                        textBox3.Text = b.Color;
                        textBox4.Text = b.Lifting.ToString();
                    }
                    if (airlane.Allplane[index1].GetType() == sp3.GetType())
                    {
                        Boing b = (Boing)(airlane.Allplane[index1]);
                        textBox1.Text = b.Name;
                        textBox2.Text = b.Country;
                        textBox3.Text = b.Color;
                        textBox4.Text = b.Capacity.ToString();
                    }
                    if (airlane.Allplane[index1].GetType() == sp4.GetType())
                    {
                        Airbus b = (Airbus)(airlane.Allplane[index1]);
                        textBox1.Text = b.Name;
                        textBox2.Text = b.Country;
                        textBox3.Text = b.Color;
                        textBox4.Text = b.Capacity.ToString();

                    }
                    if (airlane.Allplane[index1].GetType() == sp5.GetType())
                    {
                        Bomber b = (Bomber)(airlane.Allplane[index1]);
                        textBox1.Text = b.Name;
                        textBox2.Text = b.Country;
                        textBox3.Text = b.Color;
                        textBox4.Text = b.Thickness.ToString();

                    }
                    if (airlane.Allplane[index1].GetType() == sp6.GetType())
                    {
                        Intelligence b = (Intelligence)(airlane.Allplane[index1]);
                        textBox1.Text = b.Name;
                        textBox2.Text = b.Country;
                        textBox3.Text = b.Color;
                        textBox4.Text = b.Thickness.ToString();


                    }
                }
            }
        }

