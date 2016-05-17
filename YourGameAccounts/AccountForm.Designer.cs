namespace YourGameAccounts
{
    partial class AccountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.wowDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameAccountsDataSet = new YourGameAccounts.GameAccountsDataSet();
            this.proDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diabloDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diabloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.troveDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.troveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bSave = new System.Windows.Forms.Button();
            this.proTableAdapter = new YourGameAccounts.GameAccountsDataSetTableAdapters.proTableAdapter();
            this.diabloTableAdapter = new YourGameAccounts.GameAccountsDataSetTableAdapters.diabloTableAdapter();
            this.troveTableAdapter = new YourGameAccounts.GameAccountsDataSetTableAdapters.troveTableAdapter();
            this.wowTableAdapter = new YourGameAccounts.GameAccountsDataSetTableAdapters.wowTableAdapter();
            this.tableAdapterManager = new YourGameAccounts.GameAccountsDataSetTableAdapters.TableAdapterManager();
            this.bRemovePro = new System.Windows.Forms.Button();
            this.bRemoveD2 = new System.Windows.Forms.Button();
            this.bRemoveTrove = new System.Windows.Forms.Button();
            this.bRemoveWow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wowDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameAccountsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diabloDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diabloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.troveDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.troveBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1095, 974);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pokemon Revolution Online";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(783, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Diablo 2 Lord of Destruction";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Trove";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(819, 509);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "World of Warcraft";
            // 
            // wowDataGridView
            // 
            this.wowDataGridView.AutoGenerateColumns = false;
            this.wowDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wowDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.wowDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wowDataGridView.DataSource = this.wowBindingSource;
            this.wowDataGridView.Location = new System.Drawing.Point(627, 536);
            this.wowDataGridView.Name = "wowDataGridView";
            this.wowDataGridView.RowTemplate.Height = 24;
            this.wowDataGridView.Size = new System.Drawing.Size(591, 420);
            this.wowDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn2.HeaderText = "Username";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn3.HeaderText = "Password";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // wowBindingSource
            // 
            this.wowBindingSource.DataMember = "wow";
            this.wowBindingSource.DataSource = this.gameAccountsDataSet;
            // 
            // gameAccountsDataSet
            // 
            this.gameAccountsDataSet.DataSetName = "GameAccountsDataSet";
            this.gameAccountsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proDataGridView
            // 
            this.proDataGridView.AutoGenerateColumns = false;
            this.proDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.proDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proDataGridView.DataSource = this.proBindingSource;
            this.proDataGridView.Location = new System.Drawing.Point(24, 56);
            this.proDataGridView.Name = "proDataGridView";
            this.proDataGridView.RowTemplate.Height = 24;
            this.proDataGridView.Size = new System.Drawing.Size(591, 420);
            this.proDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn5.HeaderText = "Id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn6.HeaderText = "Username";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn7.HeaderText = "Password";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn8.HeaderText = "Email";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // proBindingSource
            // 
            this.proBindingSource.DataMember = "pro";
            this.proBindingSource.DataSource = this.gameAccountsDataSet;
            // 
            // diabloDataGridView
            // 
            this.diabloDataGridView.AutoGenerateColumns = false;
            this.diabloDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.diabloDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.diabloDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.diabloDataGridView.DataSource = this.diabloBindingSource;
            this.diabloDataGridView.Location = new System.Drawing.Point(627, 56);
            this.diabloDataGridView.Name = "diabloDataGridView";
            this.diabloDataGridView.RowTemplate.Height = 24;
            this.diabloDataGridView.Size = new System.Drawing.Size(591, 420);
            this.diabloDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn9.HeaderText = "Id";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn10.HeaderText = "Username";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn11.HeaderText = "Password";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn12.HeaderText = "Email";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // diabloBindingSource
            // 
            this.diabloBindingSource.DataMember = "diablo";
            this.diabloBindingSource.DataSource = this.gameAccountsDataSet;
            // 
            // troveDataGridView
            // 
            this.troveDataGridView.AutoGenerateColumns = false;
            this.troveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.troveDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.troveDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.troveDataGridView.DataSource = this.troveBindingSource;
            this.troveDataGridView.Location = new System.Drawing.Point(24, 536);
            this.troveDataGridView.Name = "troveDataGridView";
            this.troveDataGridView.RowTemplate.Height = 24;
            this.troveDataGridView.Size = new System.Drawing.Size(591, 420);
            this.troveDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn13.HeaderText = "Id";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn14.HeaderText = "Username";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn15.HeaderText = "Password";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn16.HeaderText = "Email";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // troveBindingSource
            // 
            this.troveBindingSource.DataMember = "trove";
            this.troveBindingSource.DataSource = this.gameAccountsDataSet;
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.Color.Gainsboro;
            this.bSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSave.Location = new System.Drawing.Point(972, 974);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(117, 40);
            this.bSave.TabIndex = 17;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = false;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // proTableAdapter
            // 
            this.proTableAdapter.ClearBeforeFill = true;
            // 
            // diabloTableAdapter
            // 
            this.diabloTableAdapter.ClearBeforeFill = true;
            // 
            // troveTableAdapter
            // 
            this.troveTableAdapter.ClearBeforeFill = true;
            // 
            // wowTableAdapter
            // 
            this.wowTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.diabloTableAdapter = this.diabloTableAdapter;
            this.tableAdapterManager.proTableAdapter = this.proTableAdapter;
            this.tableAdapterManager.troveTableAdapter = this.troveTableAdapter;
            this.tableAdapterManager.UpdateOrder = YourGameAccounts.GameAccountsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.wowTableAdapter = this.wowTableAdapter;
            // 
            // bRemovePro
            // 
            this.bRemovePro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bRemovePro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRemovePro.Location = new System.Drawing.Point(24, 482);
            this.bRemovePro.Name = "bRemovePro";
            this.bRemovePro.Size = new System.Drawing.Size(117, 40);
            this.bRemovePro.TabIndex = 19;
            this.bRemovePro.Text = "Remove";
            this.bRemovePro.UseVisualStyleBackColor = true;
            this.bRemovePro.Click += new System.EventHandler(this.bRemove_Click);
            // 
            // bRemoveD2
            // 
            this.bRemoveD2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bRemoveD2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRemoveD2.Location = new System.Drawing.Point(627, 482);
            this.bRemoveD2.Name = "bRemoveD2";
            this.bRemoveD2.Size = new System.Drawing.Size(117, 40);
            this.bRemoveD2.TabIndex = 20;
            this.bRemoveD2.Text = "Remove";
            this.bRemoveD2.UseVisualStyleBackColor = true;
            this.bRemoveD2.Click += new System.EventHandler(this.bRemoveD2_Click);
            // 
            // bRemoveTrove
            // 
            this.bRemoveTrove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bRemoveTrove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRemoveTrove.Location = new System.Drawing.Point(24, 962);
            this.bRemoveTrove.Name = "bRemoveTrove";
            this.bRemoveTrove.Size = new System.Drawing.Size(117, 40);
            this.bRemoveTrove.TabIndex = 21;
            this.bRemoveTrove.Text = "Remove";
            this.bRemoveTrove.UseVisualStyleBackColor = true;
            this.bRemoveTrove.Click += new System.EventHandler(this.bRemoveTrove_Click);
            // 
            // bRemoveWow
            // 
            this.bRemoveWow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bRemoveWow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRemoveWow.Location = new System.Drawing.Point(627, 962);
            this.bRemoveWow.Name = "bRemoveWow";
            this.bRemoveWow.Size = new System.Drawing.Size(117, 40);
            this.bRemoveWow.TabIndex = 22;
            this.bRemoveWow.Text = "Remove";
            this.bRemoveWow.UseVisualStyleBackColor = true;
            this.bRemoveWow.Click += new System.EventHandler(this.bRemoveWow_Click);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1230, 1034);
            this.Controls.Add(this.bRemoveWow);
            this.Controls.Add(this.bRemoveTrove);
            this.Controls.Add(this.bRemoveD2);
            this.Controls.Add(this.bRemovePro);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.troveDataGridView);
            this.Controls.Add(this.diabloDataGridView);
            this.Controls.Add(this.proDataGridView);
            this.Controls.Add(this.wowDataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AccountForm";
            this.Text = "Game Accounts";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wowDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameAccountsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diabloDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diabloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.troveDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.troveBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private GameAccountsDataSet gameAccountsDataSet;
        private System.Windows.Forms.BindingSource proBindingSource;
        private GameAccountsDataSetTableAdapters.proTableAdapter proTableAdapter;
        private System.Windows.Forms.BindingSource diabloBindingSource;
        private GameAccountsDataSetTableAdapters.diabloTableAdapter diabloTableAdapter;
        private System.Windows.Forms.BindingSource troveBindingSource;
        private GameAccountsDataSetTableAdapters.troveTableAdapter troveTableAdapter;
        private System.Windows.Forms.BindingSource wowBindingSource;
        private GameAccountsDataSetTableAdapters.wowTableAdapter wowTableAdapter;
        private GameAccountsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView wowDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView proDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView diabloDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridView troveDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bRemovePro;
        private System.Windows.Forms.Button bRemoveD2;
        private System.Windows.Forms.Button bRemoveTrove;
        private System.Windows.Forms.Button bRemoveWow;
    }
}

