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
    public partial class FormClientCard : Form
    {
        public FormClientCard()
        {
            InitializeComponent();
        }
        public int id_client//в textbox1 передаётся id клиента
        {
            get { return Convert.ToInt32(textBox1.Text); }
            set { textBox1.Text = Convert.ToString(value); }
        }
        public string clientName
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string autoMark
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public string autoNumber
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }
        public string phoneNumber
        {
            get { return textBox5.Text; }
            set { textBox5.Text = value; }
        }
        public int releaseYear
        {
            get { return Convert.ToInt32(textBox6.Text); }
            set { textBox6.Text = Convert.ToString(value); }
        }
        private void клиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Эу_436_ДмитриеваDataSet);

        }

        private void FormClientCard_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Эу_436_ДмитриеваDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this._Эу_436_ДмитриеваDataSet.Клиенты);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";
            FormClients f = new FormClients();
            f.ShowDialog();
        }
    }
}
