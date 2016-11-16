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
    public partial class Form_КарточкаКлиента : Form
    {
        public Form_КарточкаКлиента()
        {
            InitializeComponent();
        }

        private void клиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Эу_436_ДмитриеваDataSet);

        }

        private void Form_КарточкаКлиента_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Эу_436_ДмитриеваDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this._Эу_436_ДмитриеваDataSet.Клиенты);

        }

        

        private void клиентыBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView dRow = (DataRowView)this.клиентыBindingSource.Current;
            int id_client = Convert.ToInt32(dRow[("id_клиента")]);
            this.выводВыполненныхРаботКлиентаTableAdapter.Fill(_Эу_436_ДмитриеваDataSet.ВыводВыполненныхРаботКлиента, id_client);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.выводВыполненныхРаботКлиентаBindingSource.EndEdit();
            
        }
    }
}
