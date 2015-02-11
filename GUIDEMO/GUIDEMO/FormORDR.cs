using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinesObject ;
using BusinesEntity;
using DevExpress.XtraEditors;
namespace GUIDEMO
{
    public partial class FormORDR : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt;
        private int docEntry;
        private int lineNum;
        private int rowSelect;
        public FormORDR()
        {
            InitializeComponent();
        }
        ServiceORDR.ServiceORDRClient wsOrdr = new ServiceORDR.ServiceORDRClient();
        ServiceRDR1.ServiceRDR1Client wsRdr1 = new ServiceRDR1.ServiceRDR1Client();
        ServiceLogistic.ServiceLogisticClient wsLogistic = new ServiceLogistic.ServiceLogisticClient();
        ServiceOCRD.ServiceOCRDClient wsOCRD = new ServiceOCRD.ServiceOCRDClient();
        ServiceOWHS.ServiceOWHSClient wsOWHS = new ServiceOWHS.ServiceOWHSClient();
        ServiceOVTG.ServiceOVTGClient wsOVTG = new ServiceOVTG.ServiceOVTGClient();
        ServiceOCPR.ServiceOCPRClient wsOCPR = new ServiceOCPR.ServiceOCPRClient();
        public void loadDataRDR1()
        {
            DataTable dt = new DataTable();
        }
        public void loadData()
        {
            DataTable dt = new DataTable();
            grdViewORDR.DataSource = wsOrdr.ShowORDR();
            gridControlRDR1.DataSource = wsRdr1.showRDR1();
            gridViewLogistic.DataSource = wsLogistic.showLogistic();
          
        }
        public void loadComb()
        {
            //load CBBussinessP
            //cbBussinessP.DataSource = wsOCRD.showOCRD();
            //cbBussinessP.SelectedIndex = 0;
            //cbBussinessP.DisplayMember = "CardName";
            //cbBussinessP.ValueMember = "CardName";
            //loadCbStatus            
            //    // Add Item vao cbTK 
            //    cbStatus.Items.Add("Open");
            //    cbStatus.Items.Add("Close");
            //    cbStatus.Items.Add("Cancel");
            //    // chi cho chon 
            //    cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            //cbStatus.SelectedIndex = 0;
           

            comboBoxEdit1.Properties.Items.Add("Open");
            comboBoxEdit1.Properties.Items.Add("Close");
            comboBoxEdit1.Properties.Items.Add("Cancel");
            //chi cho chon
            comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            comboBoxEdit1.SelectedIndex = 0;

            // load cbWHS
            repositoryItemGridLookUpEdit_Kho.DataSource = wsOWHS.ShowOWHS ();
            repositoryItemGridLookUpEdit_Kho.DisplayMember = "WhsCode";
            repositoryItemGridLookUpEdit_Kho.ValueMember  = "WhsCode";

            //load CbTaxCode
            repositoryItemGridLookUpEdit_OVGT.DataSource = wsOVTG.ShowOVTG();
            repositoryItemGridLookUpEdit_OVGT.DisplayMember = "Code";
            repositoryItemGridLookUpEdit_OVGT.ValueMember = "Code";
            
            //load CbContactPerson
            repositoryItemGridLookUpEdit_ContactPerson.DataSource = wsOCPR.ShowContactPerson();
            repositoryItemGridLookUpEdit_ContactPerson.DisplayMember = "Name"; 
            repositoryItemGridLookUpEdit_ContactPerson.ValueMember = "CntctCode";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            loadComb();
            dgvORDR.Appearance.HideSelectionRow.BackColor = Color.Pink; // load backgroud when select row
            dgvORDR.Appearance.FocusedRow.BackColor  = Color.Pink;

            dgvRDR1 .Appearance.HideSelectionRow.BackColor = Color.Pink; // load backgroud when select row
            dgvRDR1 .Appearance.FocusedRow.BackColor = Color.Pink;

            dgvLogistic.Appearance.HideSelectionRow.BackColor = Color.Pink; // load backgroud when select row  
            dgvLogistic.Appearance.FocusedRow.BackColor = Color.Pink;

            loadData();
        }

        private void Refresh()
        {
            txtNoOfTrans.Text = null;
            fdate.Text = null;
            tdate.Text = null;
            fdate.Focus();
            comboBoxEdit1.ResetText();
            bteCardCode.ResetText();
            //flagAddNew = false;
            //fladAddNewRDR1 = false;
            loadData();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string status = string.Empty;
            if (comboBoxEdit1.SelectedItem.ToString() == "Open")
            {
                status = "O";
            }
            else if (comboBoxEdit1.SelectedItem.ToString() == "Close")
            {
                status = "C";
            }
            else if (comboBoxEdit1.SelectedItem.ToString() == "Cancel")
            {
                status = "c";
            }
            DataTable dt = wsOrdr.SearchDocumentAll(status, bteCardCode.Text, txtNoOfTrans.Text, fdate.DateTime, tdate.DateTime);
            grdViewORDR.DataSource = dt;

            DataTable dtRDR1 = wsRdr1.SearchRDR1ByDocEntryAll(bteCardCode.Text , status,txtNoOfTrans.Text ,fdate.DateTime ,tdate.DateTime);
            gridControlRDR1.DataSource = dtRDR1;
        }


        private void txtNoOfTrans_TextChanged(object sender, EventArgs e)
        {
            if (txtNoOfTrans.Text == "")
            {
                loadData();
            }
            else
            {
                string status = string.Empty;
                if (comboBoxEdit1.SelectedItem.ToString() == "Open")
                {
                    status = "O";
                }
                else if (comboBoxEdit1.SelectedItem.ToString() == "Close")
                {
                    status = "C";
                }
                else if (comboBoxEdit1.SelectedItem.ToString() == "Cancel")
                {
                    status = "c";
                }
                DataTable dt = wsOrdr.searchByNoOfTrans(txtNoOfTrans.Text);
                grdViewORDR.DataSource = dt;

                DataTable dtRDR1 = wsRdr1.SearchRDR1ByDocEntryAll(bteCardCode.Text, status, txtNoOfTrans.Text, fdate.DateTime, tdate.DateTime);
                gridControlRDR1.DataSource = dtRDR1;
            }
        }

        private void SetRowSelect()
        {
            dgvORDR.FocusedRowHandle = rowSelect;
           RowClick();

        }
        private void btSave_Click(object sender, EventArgs e)
        {
            addORDRClick();
            Refresh();
            SetRowSelect();
        }
        public string addRDR1(int docEntry)
        {
            //
            try
            {
                dt = (DataTable)gridControlRDR1.DataSource;
                DataTable dtChange = dt.GetChanges();
               // BE_RDR1 beRDR1 = new BE_RDR1();
                for (int i = 0; i < dtChange.Rows.Count; i++)
                {
                    BO_RDR1 obj = new BO_RDR1();
                    obj.ItemCode = dtChange.Rows[i]["ItemCode"] == DBNull.Value ? "0" : Convert.ToString(dtChange.Rows[i]["ItemCode"].ToString());
                    obj.Dscription = dtChange.Rows[i]["Dscription"] == DBNull.Value ? "0" : Convert.ToString(dtChange.Rows[i]["Dscription"].ToString());
                    obj.Quantity = dtChange.Rows[i]["Quantity"] == DBNull.Value ? 0 : Convert.ToDouble(dtChange.Rows[i]["Quantity"].ToString());
                    obj.Price = dtChange.Rows[i]["Price"] == DBNull.Value ? 0 : Convert.ToDouble(dtChange.Rows[i]["Price"].ToString());
                    obj.DiscPrcnt = dtChange.Rows[i]["DiscPrcnt"] == DBNull.Value ? 0 : Convert.ToDouble(dtChange.Rows[i]["DiscPrcnt"].ToString());
                    obj.TaxCode = dtChange.Rows[i]["TaxCode"] == DBNull.Value ? "0" : Convert.ToString(dtChange.Rows[i]["TaxCode"].ToString());
                    obj.LineTotal = dtChange.Rows[i]["LineTotal"] == DBNull.Value ? 0 : Convert.ToDouble(dtChange.Rows[i]["LineTotal"].ToString());
                    obj.WhsCode = dtChange.Rows[i]["WhsCode"] == DBNull.Value ? "0" : Convert.ToString(dtChange.Rows[i]["WhsCode"].ToString());                
                     // convert date nếu là null
                    obj.ShipDate = dtChange.Rows[i]["ShipDate"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime((dtChange.Rows[i]["ShipDate"].ToString()));

                    obj.FreeTxt = dtChange.Rows[i]["FreeTxt"].ToString();
                    obj.OpenQty = dtChange.Rows[i]["OpenQty"] == DBNull.Value ? 0 : Convert.ToDouble(dtChange.Rows[i]["OpenQty"].ToString());
                    obj.Currency = dtChange.Rows[i]["Currency"].ToString();
                    obj.Rate = dtChange.Rows[i]["Rate"] == DBNull.Value ? 0 : Convert.ToDouble(dtChange.Rows[i]["Rate"].ToString());

                    obj.LineNum = dtChange.Rows[i]["LineNum"] == DBNull.Value ? 0 : Convert.ToInt32(dtChange.Rows[i]["LineNum"].ToString());
                    obj.BaseType = dtChange.Rows[i]["BaseType"] == DBNull.Value ? 0 : Convert.ToInt32(dtChange.Rows[i]["BaseType"].ToString());
                    obj.BaseEntry = dtChange.Rows[i]["BaseEntry"] == DBNull.Value ? 0 : Convert.ToInt32(dtChange.Rows[i]["BaseEntry"].ToString());
                    obj.BaseLine = dtChange.Rows[i]["BaseLine"] == DBNull.Value ? 0 : Convert.ToInt32(dtChange.Rows[i]["BaseLine"].ToString());
                    obj.AcctCode = dtChange.Rows[i]["AcctCode"] == DBNull.Value ? "0" : Convert.ToString(dtChange.Rows[i]["AcctCode"].ToString());

                    obj.DocEntry = docEntry;

                    bool exists = wsRdr1.CheckExistsDocEntryAndLineNum(docEntry, obj.LineNum);
                    if (!exists)
                    {
                        string result = wsRdr1.addRDR1(obj);
                        if (!string.IsNullOrEmpty(result))
                        {
                            MessageBox.Show(result);
                           
                           // return result;
                        }
                        //wsRdr1.addRDR1(obj);
                    }
                    else
                    {
                        if (MessageBox.Show(" Do you want to update this information tblRDR1 ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {  //thuc hien update
                            wsRdr1.updateRDR1(obj);
                            
                            // loadData();
                            // return "";
                        }
                        else
                        {
                            return null;
                        }

                    }
                }
               
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return string.Empty;
        }

        public void addORDRClick()
        {
            try
            {
                dt = (DataTable)grdViewORDR.DataSource;
                DataTable dtChange = dt.GetChanges();
                DataTable dt2 = (DataTable)gridControlRDR1.DataSource;
                DataTable dt2Change = dt2.GetChanges();
                BE_ORDR beODRD = new BE_ORDR();
                if (dtChange!=null)
                {
                    for (int i = 0; i < dtChange.Rows.Count; i++)
                    {

                        BO_ORDR obj = new BO_ORDR();
                        obj.DocStatus = dtChange.Rows[i]["DocStatus"].ToString();
                        if (obj.DocStatus == "Close")
                        {
                            obj.DocStatus = "C";
                        }
                        else if (obj.DocStatus == "Open")
                        {
                            obj.DocStatus = "O";
                        }
                        else if (obj.DocStatus == "Cancel")
                        {
                            obj.DocStatus = "c";
                        }
                        if (obj.DocStatus.Length > 1 || obj.DocStatus == "")
                        {
                            MessageBox.Show("DocStatus not null and only allowed to enter 1 character");

                            return;

                        }

                        else
                        {

                            obj.DocEntry = int.Parse(dtChange.Rows[i]["DocNum"].ToString());
                            obj.CardCode = dtChange.Rows[i]["CardCode"].ToString();
                            obj.CardName = dtChange.Rows[i]["CardName"].ToString();
                            obj.CntctCode = dtChange.Rows[i]["CntctCode"] == DBNull.Value ? 0 : Convert.ToInt32(dtChange.Rows[i]["CntctCode"].ToString ());
                            //obj.DocStatus = dtChange.Rows[i]["DocStatus"].ToString();
                            obj.TaxDate = Convert.ToDateTime(dtChange.Rows[i]["TaxDate"].ToString());
                            obj.DocDueDate = Convert.ToDateTime(dtChange.Rows[i]["DocDueDate"].ToString());
                            obj.DocDate = Convert.ToDateTime(dtChange.Rows[i]["DocDate"].ToString());
                            obj.Comments = dtChange.Rows[i]["Comments"].ToString();

                            //double totalBefore =Convert.ToDouble(wsOrdr.SumLineTotalBeforDis(docEntry));
                           obj.TotalBefore  = dtChange.Rows[i]["TotalBefore"] == DBNull.Value ? 0 : Convert.ToDouble(dtChange.Rows[i]["TotalBefore"].ToString());

                            obj.DiscPrcnt = dtChange.Rows[i]["DiscPrcnt"] == DBNull.Value ? 0 : Convert.ToDouble(dtChange.Rows[i]["DiscPrcnt"].ToString());
                            obj.VatSum = dtChange.Rows[i]["VatSum"] == DBNull.Value ? 0 : Convert.ToDouble(dtChange.Rows[i]["VatSum"].ToString()); ;
                            obj.DocTotal = dtChange.Rows[i]["DocTotal"] == DBNull.Value ? 0 : Convert.ToDouble(dtChange.Rows[i]["DocTotal"].ToString()); ;
                            obj.DocCur =Convert.ToString(dtChange.Rows[i]["DocCur"].ToString()); ;
                            obj.DocRate = dtChange.Rows[i]["DocRate"] == DBNull.Value ? 0 : Convert.ToDouble(dtChange.Rows[i]["DocRate"].ToString());

                            obj.DocNum = dtChange.Rows[i]["DocNum"] == DBNull.Value ? 0 : Convert.ToInt32(dtChange.Rows[i]["DocNum"].ToString());
                            obj.CANCELED = dtChange.Rows[i]["CANCELED"] == DBNull.Value ? "0" : Convert.ToString(dtChange.Rows[i]["CANCELED"]);
                            obj.NumAtCard = dtChange.Rows[i]["NumAtCard"] == DBNull.Value ? "0" : Convert.ToString(dtChange.Rows[i]["NumAtCard"]);
                            obj.Series = dtChange.Rows[i]["Series"] == DBNull.Value ? 0 : Convert.ToInt32(dtChange.Rows[i]["Series"]);

                            bool exists = wsOrdr.CheckDoc(obj.DocEntry);
                            if (!exists)
                            {
                                // insert   
                                string result = wsOrdr.addORDR(obj);
                                if (!string.IsNullOrEmpty(result))
                                {
                                    MessageBox.Show(result);
                                }
                            }
                            else
                            {
                                if (MessageBox.Show(" Do you want to update this information ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {  //thuc hien update
                                    string result= wsOrdr.updateORDR(obj);
                                    if (!string.IsNullOrEmpty(result))
                                    {
                                        MessageBox.Show(result);
                                    }
                                  
                                }
                            }
                            // insert detail
                            if (dtChange != null && dt2Change != null)
                            {
                                //string result = addRDR1(obj.DocEntry);
                                //if (result != null)
                                //{
                                //    XtraMessageBox.Show(result);
                                //    XtraMessageBox.Show(" Insert success RDR1 !");
                                //}
                                addRDR1(obj.DocEntry);
                                return;
                            }

                        }
                    }
                    
                }
                // insert detail
                if (dtChange == null && dt2Change != null)
                {
                    //string result = addRDR1(docEntry);
                    //if (result != null)
                    //{
                    //  //  XtraMessageBox.Show(" Insert success addRDR1 !");
                    //    XtraMessageBox.Show(result);
                    //}
                     addRDR1(docEntry);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
      
        // hien thi gia tri len cot gridview
        private void gridView3_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "DocStatus")
            {
                // string value = e.Value;
                if (e.Value != null && e.Value.ToString() == "O")
                {
                    e.DisplayText = "Open";
                }
                else if (e.Value != null && e.Value.ToString() == "C")
                {
                    e.DisplayText = "Close";
                }
                else if (e.Value != null && e.Value.ToString() == "c")
                {
                    e.DisplayText = "Cancle";
                }
            }

        }

        //lay du lieu do len txtCardCode gan vao cot CardCode
        private void txtCardCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FormOCRD frmOCRD = new FormOCRD();
            frmOCRD.ShowDialog();
            string carCode = frmOCRD.cardCode;
            bteCardCode.EditValue = carCode;
            frmOCRD.Close();
        }

        // lay du lieu tu bang FormOCRD gán vao colCardCode
        private void repositoryItemButtonEdit_CarCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FormOCRD frm = new FormOCRD();
            frm.FormClosing += (s, ev) =>
            {
              string  cardCode = frm.cardCode;
              string cardName = frm.cardName;
                if (!string.IsNullOrEmpty(cardCode))
                {
                    if (!string.IsNullOrEmpty(cardName))
                    {
                        dgvORDR.SetFocusedRowCellValue(colCardName, cardName);
                    }
                    dgvORDR.SetFocusedRowCellValue(colCardCode, cardCode);                
                }                
               
            };
            frm.ShowDialog();
            frm.Close();
        }
      
        // kiem tra cot cuoi cung neu thay doi an tap ( Enter) them dong moi
        private void dgvORDR_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            int lastRow = dgvORDR.RowCount - 1;

            if ((dgvORDR.FocusedColumn.FieldName == "DocRate") && (e.RowHandle==lastRow || e.RowHandle==int.MinValue))
            {
                dgvORDR.AddNewRow();
               // dgvRDR1.AddNewRow();

            }

            if (e.Column.FieldName == "TotalBefore" || e.Column.FieldName == "DiscPrcnt" || e.Column.FieldName == "VatSum")
            {
              
                //double totalBefor = 0;
                double totaBefor = dgvORDR.GetRowCellValue(e.RowHandle, "TotalBefore") == null || string.IsNullOrEmpty(dgvORDR.GetRowCellValue(e.RowHandle, "TotalBefore").ToString()) ? 0 : Convert.ToDouble(dgvORDR.GetRowCellValue(e.RowHandle, TotalBefore ));                              
                double discpr = 0;
                discpr = dgvORDR.GetRowCellValue(e.RowHandle, "DiscPrcnt") == null || string.IsNullOrEmpty(dgvORDR.GetRowCellValue(e.RowHandle, "DiscPrcnt").ToString()) ? 0 : Convert.ToDouble(dgvORDR.GetRowCellValue(e.RowHandle, DiscPrcnt));
                double vatSum = 0;
                vatSum = dgvORDR.GetRowCellValue(e.RowHandle, "VatSum") == null || string.IsNullOrEmpty(dgvORDR.GetRowCellValue(e.RowHandle, "VatSum").ToString()) ? 0 : Convert.ToDouble(dgvORDR.GetRowCellValue(e.RowHandle, VatSum));

                double docTotal = 0;
                docTotal = totaBefor  * vatSum  - discpr  * totaBefor  ;
                dgvORDR.SetRowCellValue(dgvORDR.FocusedRowHandle, DocTotal, docTotal);
            }
        }
   
        private string dscription = string.Empty;
        // lay du lieu gan vao colum ItemCode 
        private void repositoryItemButtonEdit_ItemCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FormOTM frm = new FormOTM();
            frm.FormClosing += (s, ev) =>
            {
              string  itemCode = frm.itemCode;
              string dscription = frm.itemName;
              //if (dgvRDR1.FocusedRowHandle <0)
              //{
              //    DataTable dt = (DataTable)gridControlRDR1.DataSource;
              //    DataRow row = dt.NewRow();
              //    row["ShipDate"] = DateTime.Now;
              //    dt.Rows.Add(row);
              //    gridControlRDR1.DataSource = dt;
              //}
                if (string.IsNullOrEmpty (itemCode ) || !string.IsNullOrEmpty(itemCode))
                {
                    if (!string.IsNullOrEmpty(dscription))
                    {
                        dgvRDR1.SetFocusedRowCellValue(colDscription,dscription);  
                    }
                    dgvRDR1.SetFocusedRowCellValue(colItemCode, itemCode);
                }
            };
            frm.ShowDialog();
            frm.Close();
        }

        private void addNewRDR1_Click(object sender, EventArgs e)
        {
            dgvRDR1.AddNewRow();
        }
    
        private void dgvRDR1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
      {     
          contextMenuRDR1.Show(gridControlRDR1, e.Point); 
        }

        // show button delete , add on Gridview
        private void dgvORDR_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            //GridView view = (GridView)sender;
            //GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            //if (hitInfo.InRow)
            //{
            //    view.FocusedRowHandle = hitInfo.RowHandle;
            //    contextMenuORDR.Show(view.GridControl, e.Point);
            //}
            contextMenuORDR.Show(grdViewORDR,e.Point );
        }

       
        private void addNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddNewRowRDR1();
               
        }

        private bool fladAddNewRDR1 = false;
       
        private void AddNewRowRDR1()
        {
            //if (!fladAddNewRDR1)
            //{
            DataTable dt = (DataTable)gridControlRDR1.DataSource;
            if (dt == null)
            {
                lineNum = wsRdr1.GetMaxLineNumByDocEntry(docEntry);
                docEntry = wsOrdr.GetMaxidDocNum(); 
            }
            else if (dt.Rows.Count > 0)
            {
                lineNum = dt.Rows[dt.Rows.Count - 1]["LineNum"] == DBNull.Value ? 0 : Convert.ToInt32(dt.Rows[dt.Rows.Count - 1]["LineNum"]);
            }
            else lineNum = 0;

                
            //dt.Clear();  // xoa row 
            //    gridControlRDR1.DataSource = dt;
            //    fladAddNewRDR1 = true;
            //}
            dgvRDR1.AddNewRow();
           
        }
        private bool flagAddNew = false;
        //click buton addnew init new Row ORDR
        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {                          
            //if (!flagAddNew)
            //{
            //    DataTable dt = (DataTable)grdViewORDR.DataSource;
            //    dt.Clear();
            //    grdViewORDR.DataSource = dt;
            //    flagAddNew = true;
            //}
           
            dgvORDR.AddNewRow();
         
            //AddNewRowRDR1();

        }

        // khoi tao colum moi gan tri hien thi len new row
        private void dgvORDR_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["TaxDate"], DateTime.Today);
            view.SetRowCellValue(e.RowHandle, view.Columns["DocDate"], DateTime.Today);
            view.SetRowCellValue(e.RowHandle, view.Columns["DocDueDate"], DateTime.Today);
            double totalBefor = 0;
            view.SetRowCellValue(e.RowHandle, view.Columns["TotalBefore"], totalBefor);

            string item = repositoryItemComboBox_DocStatus.Items[0].ToString();
            view.SetRowCellValue(e.RowHandle, view.Columns["DocStatus"], item);

            view.SetRowCellValue(e.RowHandle, view.Columns["DocNum"], 0);
            int maxDocNum = wsOrdr.GetMaxidDocNum();
            docEntry = maxDocNum;
            int a = Convert.ToInt32(view.GetRowCellValue(dgvORDR.RowCount-2 , view.Columns["DocNum"]));
            bool exists = wsOrdr.CheckDoc(a);
            if (exists )
            {
                view.SetRowCellValue(e.RowHandle, view.Columns["DocNum"], maxDocNum + 1);
            }
            else if (!exists && 0 == a)
            {
                view.SetRowCellValue(e.RowHandle, view.Columns["DocNum"], maxDocNum + 1);
            }
            else
            {
                view.SetRowCellValue(e.RowHandle, view.Columns["DocNum"], a + 1); /// ??
            }


            // lay ra hang row cuoi cung tren dgv
            //int lastRow   = dgvORDR.RowCount-2;
            //int docNum = Convert.ToInt32(view.GetRowCellValue(lastRow, DocNum));
            //view.SetRowCellValue(e.RowHandle, view.Columns["DocNum"], docNum+1);
        }

        private void gridViewRDR1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["ShipDate"], DateTime.Today);             
           if (dgvORDR.FocusedRowHandle >=0)
           {
               int docE =int.Parse ( dgvORDR.GetFocusedRowCellValue("DocNum").ToString());                  
               view.SetRowCellValue(e.RowHandle, view.Columns["DocEntry"], docE );
               view.SetRowCellValue(e.RowHandle, view.Columns["LineNum"], lineNum +1);          
           }        
        }

        private void deleteToolStripMenuRDR1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int DocEntry = Convert.ToInt32(dgvRDR1.GetRowCellValue(dgvRDR1.FocusedRowHandle,"DocEntry")    );
                    int LineNum = Convert.ToInt32(dgvRDR1.GetRowCellValue(dgvRDR1.FocusedRowHandle, "LineNum"));
                  string result =  wsRdr1.deleteRDR1(DocEntry ,LineNum );
                  if (!string.IsNullOrEmpty(result))
                  {
                      MessageBox.Show(result);
                      loadData();
                      return;
                  }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(" lỗi " + ex); 
            }
        }

        private void deleteToolStripMenuItem_ORDR(object sender, EventArgs e)
        {     
            try
            {
                if (MessageBox.Show(" Do you want to delete ?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    int DocEntry = Convert.ToInt32(dgvORDR.GetRowCellValue(dgvORDR.FocusedRowHandle, "DocNum"));      // lay ra nameFiled can thuc hien               
                    wsOrdr.deleteORDR(DocEntry);
                  //  dgvORDR.DeleteRow(dgvORDR.FocusedRowHandle); // del row 
                    loadData();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro" + ex);
            }                 
        }
        // search RDR1 on GridView ORDR
        private void RowClick()
        {
            try
            {
               // fladAddNewRDR1 = false;
                BO_RDR1 obj = new BO_RDR1();
                obj.DocEntry = Convert.ToInt32(dgvORDR.GetFocusedRowCellValue("DocNum") ==DBNull.Value ? 0 : dgvORDR.GetFocusedRowCellValue("DocNum")); // lay ra ten cot 
               // rowSelect = dgvORDR.FocusedRowHandle;                           
                DataTable dt = wsRdr1.showRDR1ByDocEntry(obj.DocEntry);
                docEntry = obj.DocEntry;                                     // lay docEntry
                //lineNum = wsRdr1.GetMaxLineNumByDocEntry(obj.DocEntry);
                //if (dt != null && dt.Rows.Count == 0)
                //{
                //    DataRow row = dt.NewRow();
                //    row["ShipDate"] = DateTime.Now;
                //    dt.Rows.Add(row);
                //}
                gridControlRDR1.DataSource = dt;
                gridControlRDR1.RefreshDataSource();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void dgvORDR_RowClick(object sender, RowClickEventArgs e)
        {
            RowClick();          
        }

        private void dgvRDR1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                //if (e.Column.FieldName == "Price" || e.Column.FieldName == "Quantity" || e.Column.FieldName == "DiscPrcnt" || e.Column.FieldName == "LineTotal")
                //{
                //    double prc = dgvRDR1.GetRowCellValue(e.RowHandle, "Price") == null || string.IsNullOrEmpty(dgvRDR1.GetRowCellValue(e.RowHandle, "Price").ToString()) ? 0 : Convert.ToDouble(dgvRDR1.GetRowCellValue(e.RowHandle, Price));
                //    double quantity = dgvRDR1.GetRowCellValue(e.RowHandle, "Quantity") == null || string.IsNullOrEmpty(dgvRDR1.GetRowCellValue(e.RowHandle, "Quantity").ToString()) ? 0 : Convert.ToDouble(dgvRDR1.GetRowCellValue(e.RowHandle, Quantity));
                //    double discpr = dgvRDR1.GetRowCellValue(e.RowHandle, "DiscPrcnt") == null || string.IsNullOrEmpty(dgvRDR1.GetRowCellValue(e.RowHandle, "DiscPrcnt").ToString()) ? 0 : Convert.ToDouble(dgvRDR1.GetRowCellValue(e.RowHandle, DiscPrcnt));
                //    double lineTotal = dgvRDR1.GetRowCellValue(e.RowHandle, "LineTotal") == null || string.IsNullOrEmpty(dgvRDR1.GetRowCellValue(e.RowHandle, "LineTotal").ToString()) ? 0 : Convert.ToDouble(dgvRDR1.GetRowCellValue(e.RowHandle, LineTotal));
                //    int lineNum = dgvRDR1.GetRowCellValue(e.RowHandle, "LineNum") == null || string.IsNullOrEmpty(dgvRDR1.GetRowCellValue(e.RowHandle, "LineNum").ToString()) ? 0 : Convert.ToInt32(dgvRDR1.GetRowCellValue(e.RowHandle, LineNum));
                //    double sumLineTotalBeforDis = wsOrdr.SumLineTotalBeforDis(docEntry);
                //    if (!wsRdr1.CheckExistsDocEntryAndLineNum(docEntry, lineNum))
                //    {
                //        sumLineTotalBeforDis = sumLineTotalBeforDis + quantity * prc - quantity * prc * discpr / 100;
                //        dgvORDR.SetRowCellValue(dgvORDR.FocusedRowHandle, TotalBefore, sumLineTotalBeforDis);
                //    }
                //    else
                //    {
                //        sumLineTotalBeforDis = sumLineTotalBeforDis - lineTotal;
                //        sumLineTotalBeforDis = sumLineTotalBeforDis + quantity * prc - quantity * prc * discpr / 100;
                //        dgvORDR.SetRowCellValue(dgvORDR.FocusedRowHandle, TotalBefore, sumLineTotalBeforDis);

                //    }

                //} 
                if (e.Column.FieldName == "Price" || e.Column.FieldName == "Quantity" || e.Column.FieldName == "DiscPrcnt")
                {
                    double prc = 0;
                     prc = dgvRDR1.GetRowCellValue(e.RowHandle, "Price") == null || string.IsNullOrEmpty(dgvRDR1.GetRowCellValue(e.RowHandle, "Price").ToString()) ? 0 : Convert.ToDouble(dgvRDR1.GetRowCellValue(e.RowHandle, Price ));
                     double quantity = 0;
                    quantity = dgvRDR1.GetRowCellValue(e.RowHandle, "Quantity") == null || string.IsNullOrEmpty(dgvRDR1.GetRowCellValue(e.RowHandle, "Quantity").ToString()) ? 0 : Convert.ToDouble(dgvRDR1.GetRowCellValue(e.RowHandle, Quantity));
                    double discpr = 0;
                    discpr = dgvRDR1.GetRowCellValue(e.RowHandle, "DiscPrcnt") == null || string.IsNullOrEmpty(dgvRDR1.GetRowCellValue(e.RowHandle, "DiscPrcnt").ToString ()) ? 0 : Convert.ToDouble(dgvRDR1.GetRowCellValue(e.RowHandle, DiscPrcnt));
                    double total = 0;
                    total = quantity * prc - quantity * prc * discpr ;
                        dgvRDR1.SetRowCellValue(dgvRDR1.FocusedRowHandle,LineTotal,total);

                }

                if (e.Column == LineTotal)
                {
                    try
                    {
                        DataTable dt = (DataTable)gridControlRDR1.DataSource;
                        DataTable dtChange = dt.GetChanges();
                        double totalBefor = 0;
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            totalBefor += dt.Rows[i]["LineTotal"] == DBNull.Value ? 0 : Convert.ToDouble(dt.Rows[i]["LineTotal"].ToString());
                            dgvORDR.SetRowCellValue(dgvORDR.FocusedRowHandle, TotalBefore, totalBefor); 
                        }

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            
            }
        }

        private void bteCardCode_EditValueChanged(object sender, EventArgs e)
        {
            DataTable dt = wsOrdr.searchByCardCode(bteCardCode.Text);
            grdViewORDR.DataSource = dt;

            DataTable dt1 = wsRdr1.SearchRDR1ByDocEntry(bteCardCode.Text);
            gridControlRDR1.DataSource = dt1;
        }

                       
    }
}