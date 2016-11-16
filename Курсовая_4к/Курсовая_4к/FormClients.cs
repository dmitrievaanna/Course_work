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
    public partial class FormClients : Form
    {
        public FormClients()
        {
            InitializeComponent();
        }

        private void клиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Эу_436_ДмитриеваDataSet);

        }

        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Эу_436_ДмитриеваDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this._Эу_436_ДмитриеваDataSet.Клиенты);

        }

        private void клиентыDataGridView_DoubleClick(object sender, EventArgs e)
        {
            Int32 _id_client = Convert.ToInt32(клиентыDataGridView.CurrentRow.Cells[0].Value);
            String _name = клиентыDataGridView.CurrentRow.Cells[1].Value as String;
            String _autoMark = клиентыDataGridView.CurrentRow.Cells[2].Value as String;
            String _autoNumber = клиентыDataGridView.CurrentRow.Cells[3].Value as String;
            String _phoneNumber = клиентыDataGridView.CurrentRow.Cells[4].Value as String;
            Int32 _releaseYear = Convert.ToInt32(клиентыDataGridView.CurrentRow.Cells[5].Value);
            FormClientCard fCC = (FormClientCard)Application.OpenForms["FormClientCard"];

            fCC.id_client = _id_client;
            fCC.clientName = _name;
            fCC.autoMark = _autoMark;
            fCC.autoNumber = _autoNumber;
            fCC.phoneNumber = _phoneNumber;
            fCC.releaseYear = _releaseYear;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNewClient f = new FormNewClient();
            f.ShowDialog();
        }
    }
}
