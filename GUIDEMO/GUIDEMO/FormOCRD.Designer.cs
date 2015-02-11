namespace GUIDEMO
{
    partial class FormOCRD
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControlOCRD = new DevExpress.XtraGrid.GridControl();
            this.gridViewOCRD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CardCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CardName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.E_Mail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BankName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOCRD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOCRD)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.txtSearch);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(911, 61);
            this.panelControl1.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(369, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(228, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.panelControl2.Controls.Add(this.gridControlOCRD);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 61);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(911, 373);
            this.panelControl2.TabIndex = 2;
            // 
            // gridControlOCRD
            // 
            this.gridControlOCRD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOCRD.Location = new System.Drawing.Point(2, 2);
            this.gridControlOCRD.MainView = this.gridViewOCRD;
            this.gridControlOCRD.Name = "gridControlOCRD";
            this.gridControlOCRD.Size = new System.Drawing.Size(907, 369);
            this.gridControlOCRD.TabIndex = 1;
            this.gridControlOCRD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOCRD});
            this.gridControlOCRD.DoubleClick += new System.EventHandler(this.gridControlOCRD_DoubleClick);
            // 
            // gridViewOCRD
            // 
            this.gridViewOCRD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CardCode1,
            this.CardName,
            this.Fax,
            this.E_Mail,
            this.BankName});
            this.gridViewOCRD.GridControl = this.gridControlOCRD;
            this.gridViewOCRD.Name = "gridViewOCRD";
            this.gridViewOCRD.OptionsBehavior.Editable = false;
            this.gridViewOCRD.OptionsView.ShowGroupPanel = false;
            // 
            // CardCode1
            // 
            this.CardCode1.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardCode1.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.CardCode1.AppearanceCell.Options.UseFont = true;
            this.CardCode1.AppearanceCell.Options.UseForeColor = true;
            this.CardCode1.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardCode1.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.CardCode1.AppearanceHeader.Options.UseFont = true;
            this.CardCode1.AppearanceHeader.Options.UseForeColor = true;
            this.CardCode1.Caption = "Card Code";
            this.CardCode1.FieldName = "CardCode";
            this.CardCode1.Name = "CardCode1";
            this.CardCode1.OptionsColumn.AllowEdit = false;
            this.CardCode1.Visible = true;
            this.CardCode1.VisibleIndex = 0;
            this.CardCode1.Width = 60;
            // 
            // CardName
            // 
            this.CardName.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardName.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.CardName.AppearanceCell.Options.UseFont = true;
            this.CardName.AppearanceCell.Options.UseForeColor = true;
            this.CardName.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardName.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.CardName.AppearanceHeader.Options.UseFont = true;
            this.CardName.AppearanceHeader.Options.UseForeColor = true;
            this.CardName.Caption = "Card Name";
            this.CardName.FieldName = "CardName";
            this.CardName.Name = "CardName";
            this.CardName.Visible = true;
            this.CardName.VisibleIndex = 1;
            // 
            // Fax
            // 
            this.Fax.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fax.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.Fax.AppearanceCell.Options.UseFont = true;
            this.Fax.AppearanceCell.Options.UseForeColor = true;
            this.Fax.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fax.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.Fax.AppearanceHeader.Options.UseFont = true;
            this.Fax.AppearanceHeader.Options.UseForeColor = true;
            this.Fax.Caption = "Fax";
            this.Fax.FieldName = "Fax";
            this.Fax.Name = "Fax";
            this.Fax.Visible = true;
            this.Fax.VisibleIndex = 2;
            // 
            // E_Mail
            // 
            this.E_Mail.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E_Mail.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.E_Mail.AppearanceCell.Options.UseFont = true;
            this.E_Mail.AppearanceCell.Options.UseForeColor = true;
            this.E_Mail.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E_Mail.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.E_Mail.AppearanceHeader.Options.UseFont = true;
            this.E_Mail.AppearanceHeader.Options.UseForeColor = true;
            this.E_Mail.Caption = "EMail";
            this.E_Mail.FieldName = "E_Mail";
            this.E_Mail.Name = "E_Mail";
            this.E_Mail.Visible = true;
            this.E_Mail.VisibleIndex = 3;
            // 
            // BankName
            // 
            this.BankName.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankName.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.BankName.AppearanceCell.Options.UseFont = true;
            this.BankName.AppearanceCell.Options.UseForeColor = true;
            this.BankName.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankName.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.BankName.AppearanceHeader.Options.UseFont = true;
            this.BankName.AppearanceHeader.Options.UseForeColor = true;
            this.BankName.Caption = "Bank Name";
            this.BankName.FieldName = "BankName";
            this.BankName.Name = "BankName";
            this.BankName.Visible = true;
            this.BankName.VisibleIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(293, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // FormOCRD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 434);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormOCRD";
            this.Text = "FormOCRD";
            this.Load += new System.EventHandler(this.FormOCRD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOCRD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOCRD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControlOCRD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOCRD;
        private DevExpress.XtraGrid.Columns.GridColumn CardName;
        private DevExpress.XtraGrid.Columns.GridColumn Fax;
        private DevExpress.XtraGrid.Columns.GridColumn E_Mail;
        private DevExpress.XtraGrid.Columns.GridColumn BankName;
        private DevExpress.XtraGrid.Columns.GridColumn CardCode1;
        private System.Windows.Forms.Label label1;

    }
}