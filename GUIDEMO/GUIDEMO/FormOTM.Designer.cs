namespace GUIDEMO
{
    partial class FormOTM
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
            this.gridControlOITM = new DevExpress.XtraGrid.GridControl();
            this.gridViewOTM = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PrchseItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SellItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InvntItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TreeType = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOITM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOTM)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlOITM
            // 
            this.gridControlOITM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOITM.Location = new System.Drawing.Point(0, 0);
            this.gridControlOITM.MainView = this.gridViewOTM;
            this.gridControlOITM.Name = "gridControlOITM";
            this.gridControlOITM.Size = new System.Drawing.Size(695, 376);
            this.gridControlOITM.TabIndex = 0;
            this.gridControlOITM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOTM});
            this.gridControlOITM.DoubleClick += new System.EventHandler(this.gridControlOITM_DoubleClick);
            // 
            // gridViewOTM
            // 
            this.gridViewOTM.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ItemCode,
            this.ItemName,
            this.PrchseItem,
            this.SellItem,
            this.InvntItem,
            this.TreeType});
            this.gridViewOTM.GridControl = this.gridControlOITM;
            this.gridViewOTM.Name = "gridViewOTM";
            this.gridViewOTM.OptionsView.ShowGroupPanel = false;
            this.gridViewOTM.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // ItemCode
            // 
            this.ItemCode.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.ItemCode.AppearanceCell.Options.UseForeColor = true;
            this.ItemCode.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCode.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.ItemCode.AppearanceHeader.Options.UseFont = true;
            this.ItemCode.AppearanceHeader.Options.UseForeColor = true;
            this.ItemCode.Caption = "Item Code";
            this.ItemCode.FieldName = "ItemCode";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.Visible = true;
            this.ItemCode.VisibleIndex = 0;
            // 
            // ItemName
            // 
            this.ItemName.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.ItemName.AppearanceCell.Options.UseForeColor = true;
            this.ItemName.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.ItemName.AppearanceHeader.Options.UseFont = true;
            this.ItemName.AppearanceHeader.Options.UseForeColor = true;
            this.ItemName.Caption = "Item Name";
            this.ItemName.FieldName = "ItemName";
            this.ItemName.Name = "ItemName";
            this.ItemName.Visible = true;
            this.ItemName.VisibleIndex = 1;
            // 
            // PrchseItem
            // 
            this.PrchseItem.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.PrchseItem.AppearanceCell.Options.UseForeColor = true;
            this.PrchseItem.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrchseItem.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.PrchseItem.AppearanceHeader.Options.UseFont = true;
            this.PrchseItem.AppearanceHeader.Options.UseForeColor = true;
            this.PrchseItem.Caption = "PrchseItem";
            this.PrchseItem.FieldName = "PrchseItem";
            this.PrchseItem.Name = "PrchseItem";
            this.PrchseItem.Visible = true;
            this.PrchseItem.VisibleIndex = 2;
            // 
            // SellItem
            // 
            this.SellItem.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.SellItem.AppearanceCell.Options.UseForeColor = true;
            this.SellItem.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellItem.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.SellItem.AppearanceHeader.Options.UseFont = true;
            this.SellItem.AppearanceHeader.Options.UseForeColor = true;
            this.SellItem.Caption = "SellItem";
            this.SellItem.FieldName = "SellItem";
            this.SellItem.Name = "SellItem";
            this.SellItem.Visible = true;
            this.SellItem.VisibleIndex = 3;
            // 
            // InvntItem
            // 
            this.InvntItem.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.InvntItem.AppearanceCell.Options.UseForeColor = true;
            this.InvntItem.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvntItem.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.InvntItem.AppearanceHeader.Options.UseFont = true;
            this.InvntItem.AppearanceHeader.Options.UseForeColor = true;
            this.InvntItem.Caption = "InvntItem";
            this.InvntItem.Name = "InvntItem";
            this.InvntItem.Visible = true;
            this.InvntItem.VisibleIndex = 4;
            // 
            // TreeType
            // 
            this.TreeType.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.TreeType.AppearanceCell.Options.UseForeColor = true;
            this.TreeType.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeType.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.TreeType.AppearanceHeader.Options.UseFont = true;
            this.TreeType.AppearanceHeader.Options.UseForeColor = true;
            this.TreeType.Caption = "Tree Type";
            this.TreeType.FieldName = "TreeType";
            this.TreeType.Name = "TreeType";
            this.TreeType.Visible = true;
            this.TreeType.VisibleIndex = 5;
            // 
            // FormOTM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 376);
            this.Controls.Add(this.gridControlOITM);
            this.Name = "FormOTM";
            this.Text = "FormOTM";
            this.Load += new System.EventHandler(this.FormOTM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOITM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOTM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlOITM;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOTM;
        private DevExpress.XtraGrid.Columns.GridColumn ItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn ItemName;
        private DevExpress.XtraGrid.Columns.GridColumn PrchseItem;
        private DevExpress.XtraGrid.Columns.GridColumn SellItem;
        private DevExpress.XtraGrid.Columns.GridColumn InvntItem;
        private DevExpress.XtraGrid.Columns.GridColumn TreeType;
    }
}