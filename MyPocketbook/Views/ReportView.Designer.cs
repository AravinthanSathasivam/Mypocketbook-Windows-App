﻿
namespace MyPocketbook.Views
{
    partial class ReportView
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.expensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.test = new MyPocketbook.test();
            this.incomesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.incomesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incomesTableAdapter = new MyPocketbook.testTableAdapters.IncomesTableAdapter();
            this.tempData = new MyPocketbook.TempData();
            this.tempDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incomesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.expensesTableAdapter = new MyPocketbook.testTableAdapters.ExpensesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // expensesBindingSource
            // 
            this.expensesBindingSource.DataMember = "Expenses";
            this.expensesBindingSource.DataSource = this.test;
            // 
            // test
            // 
            this.test.DataSetName = "test";
            this.test.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incomesBindingSource2
            // 
            this.incomesBindingSource2.DataMember = "Incomes";
            this.incomesBindingSource2.DataSource = this.test;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.expensesBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.incomesBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MyPocketbook.Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(911, 607);
            this.reportViewer1.TabIndex = 0;
            // 
            // incomesBindingSource
            // 
            this.incomesBindingSource.DataMember = "Incomes";
            this.incomesBindingSource.DataSource = this.test;
            // 
            // incomesTableAdapter
            // 
            this.incomesTableAdapter.ClearBeforeFill = true;
            // 
            // tempData
            // 
            this.tempData.DataSetName = "TempData";
            this.tempData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tempDataBindingSource
            // 
            this.tempDataBindingSource.DataSource = this.tempData;
            this.tempDataBindingSource.Position = 0;
            // 
            // expenseBindingSource
            // 
            this.expenseBindingSource.DataMember = "Expense";
            this.expenseBindingSource.DataSource = this.tempDataBindingSource;
            // 
            // incomesBindingSource1
            // 
            this.incomesBindingSource1.DataMember = "Incomes";
            this.incomesBindingSource1.DataSource = this.test;
            // 
            // expensesTableAdapter
            // 
            this.expensesTableAdapter.ClearBeforeFill = true;
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(945, 631);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.ReportView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private test test;
        private System.Windows.Forms.BindingSource incomesBindingSource;
        private testTableAdapters.IncomesTableAdapter incomesTableAdapter;
        private System.Windows.Forms.BindingSource tempDataBindingSource;
        private TempData tempData;
        private System.Windows.Forms.BindingSource expenseBindingSource;
        private System.Windows.Forms.BindingSource incomesBindingSource1;
        private System.Windows.Forms.BindingSource expensesBindingSource;
        private testTableAdapters.ExpensesTableAdapter expensesTableAdapter;
        private System.Windows.Forms.BindingSource incomesBindingSource2;
    }
}