using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourGameAccounts
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameAccountsDataSet.wow' table. You can move, or remove it, as needed.
            this.wowTableAdapter.Fill(this.gameAccountsDataSet.wow);
            // TODO: This line of code loads data into the 'gameAccountsDataSet.trove' table. You can move, or remove it, as needed.
            this.troveTableAdapter.Fill(this.gameAccountsDataSet.trove);
            // TODO: This line of code loads data into the 'gameAccountsDataSet.diablo' table. You can move, or remove it, as needed.
            this.diabloTableAdapter.Fill(this.gameAccountsDataSet.diablo);
            // TODO: This line of code loads data into the 'gameAccountsDataSet.pro' table. You can move, or remove it, as needed.
            this.proTableAdapter.Fill(this.gameAccountsDataSet.pro);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proBindingSource.EndEdit();
            this.wowBindingSource.EndEdit();
            this.troveBindingSource.EndEdit();
            this.diabloBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gameAccountsDataSet);
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            this.proBindingSource.RemoveCurrent();
        }

        private void bRemoveD2_Click(object sender, EventArgs e)
        {
            this.diabloBindingSource.RemoveCurrent();
        }

        private void bRemoveTrove_Click(object sender, EventArgs e)
        {
            this.troveBindingSource.RemoveCurrent();
        }

        private void bRemoveWow_Click(object sender, EventArgs e)
        {
            this.wowBindingSource.RemoveCurrent();
        }
    }
}
