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
    public partial class FormOTM : DevExpress.XtraEditors.XtraForm
    {
        public FormOTM()
        {
            InitializeComponent();
        }
        ServiceOITM.ServiceOITMClient wsOITM = new ServiceOITM.ServiceOITMClient();
        private void FormOTM_Load(object sender, EventArgs e)
        {
            gridControlOITM.DataSource = wsOITM.showOITM();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }
        public string itemCode = null;
        public string itemName = null;
        private void gridControlOITM_DoubleClick(object sender, EventArgs e)
        {
            var obj = gridViewOTM.GetRowCellValue(gridViewOTM.FocusedRowHandle, gridViewOTM.Columns["ItemCode"]);
            itemCode  = obj == null ? string.Empty : obj.ToString(); //

            var obj1 = gridViewOTM.GetRowCellValue(gridViewOTM.FocusedRowHandle, gridViewOTM.Columns["ItemName"]);
            itemName = obj1 == null ? string.Empty : obj1.ToString();
          //  MessageBox.Show(obj.ToString());
            this.Close();
        }
    }
}
