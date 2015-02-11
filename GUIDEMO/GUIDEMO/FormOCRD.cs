using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIDEMO
{
    public partial class FormOCRD : DevExpress.XtraEditors.XtraForm
    {
        public FormOCRD()
        {
            InitializeComponent();
        }

        ServiceOCRD.ServiceOCRDClient wsOCRD = new ServiceOCRD.ServiceOCRDClient(); 
        private void FormOCRD_Load(object sender, EventArgs e)
        {
            gridControlOCRD.DataSource = wsOCRD.showOCRD();
        }

       
     
   
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            gridControlOCRD.DataSource = wsOCRD.searchOCRD(txtSearch.Text);
        }
        public string cardCode = string.Empty;
        public string cardName = string.Empty;
        // lay du lieu tren dgv  ra
        private void gridControlOCRD_DoubleClick(object sender, EventArgs e)
        {
            var obj = gridViewOCRD.GetRowCellValue(gridViewOCRD.FocusedRowHandle, gridViewOCRD.Columns["CardCode"]);
            cardCode = obj == null ? string.Empty : obj.ToString();
            var obj1 = gridViewOCRD.GetRowCellValue(gridViewOCRD.FocusedRowHandle, gridViewOCRD.Columns["CardName"]);
            cardName = obj1 == null ? string.Empty : obj1.ToString(); //
            // MessageBox.Show(obj.ToString());
            this.Close();
        }
    }
}
