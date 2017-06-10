namespace Weather
{
    partial class FormGrid
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.databaseDataSet = new Weather.DatabaseDataSet();
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pogodaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pogodaTableAdapter = new Weather.DatabaseDataSetTableAdapters.PogodaTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miastoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.krajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wojewodztwoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opadyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cisnienieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wiatrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pogodaDniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pogodaDniTableAdapter = new Weather.DatabaseDataSetTableAdapters.PogodaDniTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPogodaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dzienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperaturaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cisnienieDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogodaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogodaDniBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.miastoDataGridViewTextBoxColumn,
            this.krajDataGridViewTextBoxColumn,
            this.wojewodztwoDataGridViewTextBoxColumn,
            this.temperaturaDataGridViewTextBoxColumn,
            this.fotoDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.opadyDataGridViewTextBoxColumn,
            this.cisnienieDataGridViewTextBoxColumn,
            this.wiatrDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pogodaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1128, 143);
            this.dataGridView1.TabIndex = 0;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseDataSetBindingSource
            // 
            this.databaseDataSetBindingSource.DataSource = this.databaseDataSet;
            this.databaseDataSetBindingSource.Position = 0;
            // 
            // pogodaBindingSource
            // 
            this.pogodaBindingSource.DataMember = "Pogoda";
            this.pogodaBindingSource.DataSource = this.databaseDataSet;
            // 
            // pogodaTableAdapter
            // 
            this.pogodaTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // miastoDataGridViewTextBoxColumn
            // 
            this.miastoDataGridViewTextBoxColumn.DataPropertyName = "Miasto";
            this.miastoDataGridViewTextBoxColumn.HeaderText = "Miasto";
            this.miastoDataGridViewTextBoxColumn.Name = "miastoDataGridViewTextBoxColumn";
            // 
            // krajDataGridViewTextBoxColumn
            // 
            this.krajDataGridViewTextBoxColumn.DataPropertyName = "Kraj";
            this.krajDataGridViewTextBoxColumn.HeaderText = "Kraj";
            this.krajDataGridViewTextBoxColumn.Name = "krajDataGridViewTextBoxColumn";
            // 
            // wojewodztwoDataGridViewTextBoxColumn
            // 
            this.wojewodztwoDataGridViewTextBoxColumn.DataPropertyName = "Wojewodztwo";
            this.wojewodztwoDataGridViewTextBoxColumn.HeaderText = "Wojewodztwo";
            this.wojewodztwoDataGridViewTextBoxColumn.Name = "wojewodztwoDataGridViewTextBoxColumn";
            // 
            // temperaturaDataGridViewTextBoxColumn
            // 
            this.temperaturaDataGridViewTextBoxColumn.DataPropertyName = "Temperatura";
            this.temperaturaDataGridViewTextBoxColumn.HeaderText = "Temperatura";
            this.temperaturaDataGridViewTextBoxColumn.Name = "temperaturaDataGridViewTextBoxColumn";
            // 
            // fotoDataGridViewTextBoxColumn
            // 
            this.fotoDataGridViewTextBoxColumn.DataPropertyName = "Foto";
            this.fotoDataGridViewTextBoxColumn.HeaderText = "Foto";
            this.fotoDataGridViewTextBoxColumn.Name = "fotoDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // opadyDataGridViewTextBoxColumn
            // 
            this.opadyDataGridViewTextBoxColumn.DataPropertyName = "Opady";
            this.opadyDataGridViewTextBoxColumn.HeaderText = "Opady";
            this.opadyDataGridViewTextBoxColumn.Name = "opadyDataGridViewTextBoxColumn";
            // 
            // cisnienieDataGridViewTextBoxColumn
            // 
            this.cisnienieDataGridViewTextBoxColumn.DataPropertyName = "Cisnienie";
            this.cisnienieDataGridViewTextBoxColumn.HeaderText = "Cisnienie";
            this.cisnienieDataGridViewTextBoxColumn.Name = "cisnienieDataGridViewTextBoxColumn";
            // 
            // wiatrDataGridViewTextBoxColumn
            // 
            this.wiatrDataGridViewTextBoxColumn.DataPropertyName = "Wiatr";
            this.wiatrDataGridViewTextBoxColumn.HeaderText = "Wiatr";
            this.wiatrDataGridViewTextBoxColumn.Name = "wiatrDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.idPogodaDataGridViewTextBoxColumn,
            this.dzienDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn1,
            this.temperaturaDataGridViewTextBoxColumn1,
            this.fotoDataGridViewTextBoxColumn1,
            this.cisnienieDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.pogodaDniBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 221);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1128, 234);
            this.dataGridView2.TabIndex = 1;
            // 
            // pogodaDniBindingSource
            // 
            this.pogodaDniBindingSource.DataMember = "PogodaDni";
            this.pogodaDniBindingSource.DataSource = this.databaseDataSet;
            // 
            // pogodaDniTableAdapter
            // 
            this.pogodaDniTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // idPogodaDataGridViewTextBoxColumn
            // 
            this.idPogodaDataGridViewTextBoxColumn.DataPropertyName = "IdPogoda";
            this.idPogodaDataGridViewTextBoxColumn.HeaderText = "IdPogoda";
            this.idPogodaDataGridViewTextBoxColumn.Name = "idPogodaDataGridViewTextBoxColumn";
            // 
            // dzienDataGridViewTextBoxColumn
            // 
            this.dzienDataGridViewTextBoxColumn.DataPropertyName = "Dzien";
            this.dzienDataGridViewTextBoxColumn.HeaderText = "Dzien";
            this.dzienDataGridViewTextBoxColumn.Name = "dzienDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn1
            // 
            this.opisDataGridViewTextBoxColumn1.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn1.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn1.Name = "opisDataGridViewTextBoxColumn1";
            // 
            // temperaturaDataGridViewTextBoxColumn1
            // 
            this.temperaturaDataGridViewTextBoxColumn1.DataPropertyName = "Temperatura";
            this.temperaturaDataGridViewTextBoxColumn1.HeaderText = "Temperatura";
            this.temperaturaDataGridViewTextBoxColumn1.Name = "temperaturaDataGridViewTextBoxColumn1";
            // 
            // fotoDataGridViewTextBoxColumn1
            // 
            this.fotoDataGridViewTextBoxColumn1.DataPropertyName = "Foto";
            this.fotoDataGridViewTextBoxColumn1.HeaderText = "Foto";
            this.fotoDataGridViewTextBoxColumn1.Name = "fotoDataGridViewTextBoxColumn1";
            // 
            // cisnienieDataGridViewTextBoxColumn1
            // 
            this.cisnienieDataGridViewTextBoxColumn1.DataPropertyName = "Cisnienie";
            this.cisnienieDataGridViewTextBoxColumn1.HeaderText = "Cisnienie";
            this.cisnienieDataGridViewTextBoxColumn1.Name = "cisnienieDataGridViewTextBoxColumn1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Zapisz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 467);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormGrid";
            this.Text = "FormGrid";
            this.Load += new System.EventHandler(this.FormGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogodaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogodaDniBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource pogodaBindingSource;
        private DatabaseDataSetTableAdapters.PogodaTableAdapter pogodaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miastoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn krajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wojewodztwoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fotoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opadyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cisnienieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wiatrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource pogodaDniBindingSource;
        private DatabaseDataSetTableAdapters.PogodaDniTableAdapter pogodaDniTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPogodaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dzienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperaturaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fotoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cisnienieDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button2;
    }
}