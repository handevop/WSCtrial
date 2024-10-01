namespace WorldSkills
{
    partial class Natjecatelj
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
            this.wSCDataSet3 = new WorldSkills.WSCDataSet3();
            this.wSCDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.natjecateljBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.natjecateljTableAdapter = new WorldSkills.WSCDataSet3TableAdapters.NatjecateljTableAdapter();
            this.wSCDataSet = new WorldSkills.WSCDataSet();
            this.natjecateljBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.natjecateljTableAdapter1 = new WorldSkills.WSCDataSetTableAdapters.NatjecateljTableAdapter();
            this.tableAdapterManager = new WorldSkills.WSCDataSetTableAdapters.TableAdapterManager();
            this.natjecateljDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.wSCDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wSCDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.natjecateljBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wSCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.natjecateljBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.natjecateljDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // wSCDataSet3
            // 
            this.wSCDataSet3.DataSetName = "WSCDataSet3";
            this.wSCDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wSCDataSet3BindingSource
            // 
            this.wSCDataSet3BindingSource.DataSource = this.wSCDataSet3;
            this.wSCDataSet3BindingSource.Position = 0;
            // 
            // natjecateljBindingSource
            // 
            this.natjecateljBindingSource.DataMember = "Natjecatelj";
            this.natjecateljBindingSource.DataSource = this.wSCDataSet3BindingSource;
            // 
            // natjecateljTableAdapter
            // 
            this.natjecateljTableAdapter.ClearBeforeFill = true;
            // 
            // wSCDataSet
            // 
            this.wSCDataSet.DataSetName = "WSCDataSet";
            this.wSCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // natjecateljBindingSource1
            // 
            this.natjecateljBindingSource1.DataMember = "Natjecatelj";
            this.natjecateljBindingSource1.DataSource = this.wSCDataSet;
            // 
            // natjecateljTableAdapter1
            // 
            this.natjecateljTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.NatjecanjeTableAdapter = null;
            this.tableAdapterManager.NatjecateljTableAdapter = this.natjecateljTableAdapter1;
            this.tableAdapterManager.OcjenaTableAdapter = null;
            this.tableAdapterManager.RadKategorijaTableAdapter = null;
            this.tableAdapterManager.RadTableAdapter = null;
            this.tableAdapterManager.Sudac2RadKategorijaTableAdapter = null;
            this.tableAdapterManager.SudacTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WorldSkills.WSCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UstanovaTableAdapter = null;
            this.tableAdapterManager.VoditeljNatjecanjaTableAdapter = null;
            // 
            // natjecateljDataGridView
            // 
            this.natjecateljDataGridView.AutoGenerateColumns = false;
            this.natjecateljDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.natjecateljDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.natjecateljDataGridView.DataSource = this.natjecateljBindingSource1;
            this.natjecateljDataGridView.Location = new System.Drawing.Point(69, 104);
            this.natjecateljDataGridView.Name = "natjecateljDataGridView";
            this.natjecateljDataGridView.Size = new System.Drawing.Size(642, 220);
            this.natjecateljDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ime";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prezime";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prezime";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Lozinka";
            this.dataGridViewTextBoxColumn5.HeaderText = "Lozinka";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "UstanovaId";
            this.dataGridViewTextBoxColumn6.HeaderText = "UstanovaId";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Natjecatelj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.natjecateljDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Natjecatelj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Natjecatelj";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Natjecatelj_FormClosed);
            this.Load += new System.EventHandler(this.Natjecatelj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wSCDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wSCDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.natjecateljBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wSCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.natjecateljBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.natjecateljDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource wSCDataSet3BindingSource;
        private WSCDataSet3 wSCDataSet3;
        private System.Windows.Forms.BindingSource natjecateljBindingSource;
        private WSCDataSet3TableAdapters.NatjecateljTableAdapter natjecateljTableAdapter;
        private WSCDataSet wSCDataSet;
        private System.Windows.Forms.BindingSource natjecateljBindingSource1;
        private WSCDataSetTableAdapters.NatjecateljTableAdapter natjecateljTableAdapter1;
        private WSCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView natjecateljDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}