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
    public partial class FormNameOfWorks : Form
    {
        public FormNameOfWorks()
        {
            InitializeComponent();
        }

        private void наименования_работBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.наименования_работBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Эу_436_ДмитриеваDataSet);

        }

        private void FormNameOfWorks_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Эу_436_ДмитриеваDataSet.Наименования_работ". При необходимости она может быть перемещена или удалена.
            this.наименования_работTableAdapter.Fill(this._Эу_436_ДмитриеваDataSet.Наименования_работ);

        }
    }
}
