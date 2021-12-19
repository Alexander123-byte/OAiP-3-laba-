using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OAiP__3_laba_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            public partial class Form2 : Form
        {
            public Form2()
            {
                InitializeComponent();
            }

            public Form2(Form1 f)
            {
                InitializeComponent();
                f.BackColor = Color.Yellow;
            }
            private void button1_Click(object sender, EventArgs e)
            {
                Form1 newForm1 = new Form1();
                newForm1.Show();

                Form2 newForm2 = new Form2(newForm1);
                newForm2.Show();
            }
        }
    }