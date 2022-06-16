
namespace ExercisePABD
{
    partial class Form1
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
            this.statusKaryawanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exeDatabase1DataSet = new ExercisePABD.ExeDatabase1DataSet();
            this.karyawanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.periodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.status_KaryawanTableAdapter = new ExercisePABD.ExeDatabase1DataSetTableAdapters.Status_KaryawanTableAdapter();
            this.karyawanTableAdapter = new ExercisePABD.ExeDatabase1DataSetTableAdapters.KaryawanTableAdapter();
            this.periodeTableAdapter = new ExercisePABD.ExeDatabase1DataSetTableAdapters.PeriodeTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.statusKaryawanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exeDatabase1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // statusKaryawanBindingSource
            // 
            this.statusKaryawanBindingSource.DataMember = "Status_Karyawan";
            this.statusKaryawanBindingSource.DataSource = this.exeDatabase1DataSet;
            // 
            // exeDatabase1DataSet
            // 
            this.exeDatabase1DataSet.DataSetName = "ExeDatabase1DataSet";
            this.exeDatabase1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // karyawanBindingSource
            // 
            this.karyawanBindingSource.DataMember = "Karyawan";
            this.karyawanBindingSource.DataSource = this.exeDatabase1DataSet;
            // 
            // periodeBindingSource
            // 
            this.periodeBindingSource.DataMember = "Periode";
            this.periodeBindingSource.DataSource = this.exeDatabase1DataSet;
            // 
            // status_KaryawanTableAdapter
            // 
            this.status_KaryawanTableAdapter.ClearBeforeFill = true;
            // 
            // karyawanTableAdapter
            // 
            this.karyawanTableAdapter.ClearBeforeFill = true;
            // 
            // periodeTableAdapter
            // 
            this.periodeTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(260, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 124);
            this.button1.TabIndex = 0;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusKaryawanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exeDatabase1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ExeDatabase1DataSet exeDatabase1DataSet;
        private System.Windows.Forms.BindingSource statusKaryawanBindingSource;
        private ExeDatabase1DataSetTableAdapters.Status_KaryawanTableAdapter status_KaryawanTableAdapter;
        private System.Windows.Forms.BindingSource karyawanBindingSource;
        private ExeDatabase1DataSetTableAdapters.KaryawanTableAdapter karyawanTableAdapter;
        private System.Windows.Forms.BindingSource periodeBindingSource;
        private ExeDatabase1DataSetTableAdapters.PeriodeTableAdapter periodeTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}

