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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Visible = false;
            label2.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            groupBox1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length ==0)
            {

            }
            else
            {
                Airlane airlane = new Airlane();
                airlane.name = textBox1.Text;
                Return.Airlane = airlane;
                label2.Visible = true;
                label2.Text = "Самолеты в аэропорту: "+airlane.name.ToString();
                textBox1.Visible = false;
                label1.Visible = false;
                button1.Visible = false;
                listBox1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                groupBox1.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;

                label7.Text = "Общая вместимость: "+ airlane.Capacity.ToString();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && textBox2.Text.Length != 0 && textBox3.Text.Length != 0 && textBox4.Text.Length != 0 && textBox5.Text.Length != 0)
            {
                int res;
                bool isInt = Int32.TryParse(textBox5.Text, out res);
                if (isInt == true)
                {
                    Airlane airlane = Return.Airlane;
                    _20_65T samolet = new _20_65T();
                    samolet.Color = textBox4.Text;
                    samolet.Country = textBox3.Text;
                    samolet.Name = textBox2.Text;
                    samolet.Lifting = int.Parse(textBox5.Text);
                    samolet.Nameclass = "";
                    airlane.Allplane.Add(samolet);
                    listBox1.Items.Clear();
                    for (int i = 0; i < airlane.Allplane.Count(); i++)
                    {
                        listBox1.Items.Add(airlane.Allplane[i].Name.ToString());
                    }
                    Return.Airlane = airlane;
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                }

            }
            if (radioButton2.Checked && textBox2.Text.Length != 0 && textBox3.Text.Length != 0 && textBox4.Text.Length != 0 && textBox5.Text.Length != 0)
            {
                int res;
                bool isInt = Int32.TryParse(textBox5.Text, out res);
                if(isInt==true)
                {
                    Airlane airlane = Return.Airlane;
                    _65_120T samolet = new _65_120T();
                    samolet.Color = textBox4.Text;
                    samolet.Country = textBox3.Text;
                    samolet.Name = textBox2.Text;
                    samolet.Lifting = int.Parse(textBox5.Text);
                    samolet.Nameclass = "";
                    airlane.Allplane.Add(samolet);
                    listBox1.Items.Clear();
                    for (int i = 0; i < airlane.Allplane.Count(); i++)
                    {
                        listBox1.Items.Add(airlane.Allplane[i].Name.ToString());
                    }
                    Return.Airlane = airlane;
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                }

            }
            if (radioButton3.Checked && textBox2.Text.Length != 0 && textBox3.Text.Length != 0 && textBox4.Text.Length != 0 && textBox5.Text.Length != 0)
            {
                int res;
                bool isInt = Int32.TryParse(textBox5.Text, out res);
                if (isInt == true)
                {
                    Airlane airlane = Return.Airlane;
                    Boing samolet = new Boing();
                    samolet.Color = textBox4.Text;
                    samolet.Country = textBox3.Text;
                    samolet.Name = textBox2.Text;
                    samolet.Capacity = int.Parse(textBox5.Text);
                    samolet.Nameclass = "";
                    airlane.Allplane.Add(samolet);
                    listBox1.Items.Clear();
                    airlane.Capacity = samolet.Capacity;
                    label7.Text = "Общая вместимость: " + airlane.Capacity.ToString();
                    for (int i = 0; i < airlane.Allplane.Count(); i++)
                    {
                        listBox1.Items.Add(airlane.Allplane[i].Name.ToString());
                    }
                    Return.Airlane = airlane;
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                }


            }
            if (radioButton4.Checked && textBox2.Text.Length != 0 && textBox3.Text.Length != 0 && textBox4.Text.Length != 0 && textBox5.Text.Length != 0)
            {
                int res;
                bool isInt = Int32.TryParse(textBox5.Text, out res);
                if (isInt == true)
                {
                    Airlane airlane = Return.Airlane;
                    Airbus samolet = new Airbus();
                    samolet.Color = textBox4.Text;
                    samolet.Country = textBox3.Text;
                    samolet.Name = textBox2.Text;
                    samolet.Capacity = int.Parse(textBox5.Text);
                    samolet.Nameclass = "";
                    airlane.Allplane.Add(samolet);
                    listBox1.Items.Clear();
                    airlane.Capacity = samolet.Capacity;
                    label7.Text = "Общая вместимость: " + airlane.Capacity.ToString();
                    for (int i = 0; i < airlane.Allplane.Count(); i++)
                    {
                        listBox1.Items.Add(airlane.Allplane[i].Name.ToString());
                    }
                    Return.Airlane = airlane;
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                }


            }
            if (radioButton5.Checked && textBox2.Text.Length != 0 && textBox3.Text.Length != 0 && textBox4.Text.Length != 0 && textBox5.Text.Length != 0)
            {
                int res;
                bool isInt = Int32.TryParse(textBox5.Text, out res);
                if (isInt == true)
                {
                    Airlane airlane = Return.Airlane;
                    Bomber samolet = new Bomber();
                    samolet.Color = textBox4.Text;
                    samolet.Country = textBox3.Text;
                    samolet.Name = textBox2.Text;
                    samolet.Thickness = int.Parse(textBox5.Text);
                    samolet.Nameclass = "";
                    airlane.Allplane.Add(samolet);
                    listBox1.Items.Clear();
                    for (int i = 0; i < airlane.Allplane.Count(); i++)
                    {
                        listBox1.Items.Add(airlane.Allplane[i].Name.ToString());
                    }
                    Return.Airlane = airlane;
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                }
            }
            if (radioButton6.Checked && textBox2.Text.Length != 0 && textBox3.Text.Length != 0 && textBox4.Text.Length != 0 && textBox5.Text.Length != 0)
            {
                int res;
                bool isInt = Int32.TryParse(textBox5.Text, out res);
                if (isInt == true)
                {
                    Airlane airlane = Return.Airlane;
                    Intelligence samolet = new Intelligence();
                    samolet.Color = textBox4.Text;
                    samolet.Country = textBox3.Text;
                    samolet.Name = textBox2.Text;
                    samolet.Thickness = int.Parse(textBox5.Text);
                    samolet.Nameclass = "";
                    airlane.Allplane.Add(samolet);
                    listBox1.Items.Clear();
                    for (int i = 0; i < airlane.Allplane.Count(); i++)
                    {
                        listBox1.Items.Add(airlane.Allplane[i].Name.ToString());
                    }
                    Return.Airlane = airlane;
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                }
            }

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Броня (мм):";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Грузоподъемность:";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Грузоподъемность:";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Вместительность:";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Вместительность:";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Броня (мм):";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Airlane airlane = Return.Airlane;
            _65_120T samolet = new _65_120T();
            if (listBox1.Items.Count!=0)
            {
                int n = listBox1.SelectedIndex;
                Boing sp1 = new Boing();
                Airbus sp2 = new Airbus();
                //if (airlane.Allplane[listBox1.SelectedIndex].GetType() == sp1.GetType())
                //{
                //    Boing b = (Boing)(airlane.Allplane[listBox1.SelectedIndex]);
                //    airlane.Capacity = -b.Capacity;
                //}
                //if (airlane.Allplane[listBox1.SelectedIndex].GetType() == sp2.GetType())
                //{
                //    Airbus b = (Airbus)(airlane.Allplane[listBox1.SelectedIndex]);
                //    airlane.Capacity = -b.Capacity;
                //}
                airlane.Allplane.RemoveAt(n);
                label7.Text = "Общая вместимость: " + airlane.Capacity.ToString();
                listBox1.Items.Clear();
                for (int i = 0; i < airlane.Allplane.Count(); i++)
                {
                    listBox1.Items.Add(airlane.Allplane[i].Name.ToString());
                }
                Return.Airlane = airlane;

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                Airlane airlane = Return.Airlane;
                String cl = "";
                _20_65T sp1 = new _20_65T();
                _65_120T sp2 = new _65_120T();
                Boing sp3 = new Boing();
                Airbus sp4 = new Airbus();
                Bomber sp5 = new Bomber();
                Intelligence sp6 = new Intelligence();
                if (airlane.Allplane[listBox1.SelectedIndex].GetType() == sp1.GetType() || airlane.Allplane[listBox1.SelectedIndex].GetType() == sp2.GetType())
                {
                    cl = "Грузоподъемность";
                }
                if (airlane.Allplane[listBox1.SelectedIndex].GetType() == sp3.GetType() || airlane.Allplane[listBox1.SelectedIndex].GetType() == sp4.GetType())
                {
                    cl = "Вместимость";
                }
                if (airlane.Allplane[listBox1.SelectedIndex].GetType() == sp5.GetType() || airlane.Allplane[listBox1.SelectedIndex].GetType() == sp6.GetType())
                {
                    cl = "Броня (мм)";
                }
                if (Return.index1.Count != 0)
                {
                    Return.index1.RemoveAt(0);
                }
                Return.index1.Add(listBox1.SelectedIndex);
                Form2 f = new Form2(cl);
                f.Show();

            }

        }
        public int Date
        {
            get
            {
               return  listBox1.SelectedIndex;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Airlane airlane = Return.Airlane;
            listBox1.Items.Clear();
            for (int i = 0; i < airlane.Allplane.Count(); i++)
            {
                listBox1.Items.Add(airlane.Allplane[i].Name.ToString());
            }
            label7.Text = "Общая вместимость: " + airlane.Capacity.ToString();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Airlane airlane = Return.Airlane;
            listBox1.Items.Clear();
            for (int i = 0; i < airlane.Allplane.Count(); i++)
            {
                listBox1.Items.Add(airlane.Allplane[i].Name.ToString());
            }
            label7.Text = "Общая вместимость: " + airlane.Capacity.ToString();
        }

    }
}
