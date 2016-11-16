using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_4к
{
    public partial class FormNewClient : Form
    {
        public FormNewClient()
        {
            InitializeComponent();
        }
        
        public string clientName
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string autoMark
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string autoNumber
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public string phoneNumber
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }
        public int releaseYear
        {
            get { return Convert.ToInt32(textBox5.Text); }
            set { textBox5.Text = Convert.ToString(value); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Эу_436_ДмитриеваDataSet.
        }
    }
}
