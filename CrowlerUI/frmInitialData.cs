using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibStructure;
using MaterialSkin2DotNet;
namespace CrawlerUI
{
    public partial class frmInitialData : MaterialSkin2DotNet.Controls.MaterialForm
    {
        public List<clsHtmlElem> elements { get; set; } = new List<clsHtmlElem>();
        public clsFields fields { get; set; } = new clsFields();
        public frmInitialData(List<clsHtmlElem> elements,clsFields Filds)
        {
            InitializeComponent();
            this.elements = elements;
            fields = Filds;
            FillGrid();
        }

        #region Methods
        private void FillGrid()
        {
            try
            {
                //DataGridViewRow row = new DataGridViewRow();
                //int rowIndex = dgvinitData.Rows.Add();

                foreach (clsHtmlElem elem in elements)
                {
                    int rowIndex = dgvinitData.Rows.Add();
                    dgvinitData.Rows[rowIndex].Cells[0].Value = elem.tagName;
                    dgvinitData.Rows[rowIndex].Cells[1].Value = elem.ClassName;
                    dgvinitData.Rows[rowIndex].Cells[2].Value = elem.Id;
                    dgvinitData.Rows[rowIndex].Cells[3].Value = elem.Value;
                    dgvinitData.Rows[rowIndex].Cells[4].Value = elem.href;
                    dgvinitData.Rows[rowIndex].Cells[5].Value = elem.src;

                    // Add enum cells
                    DataGridViewComboBoxCell ParentCell = new DataGridViewComboBoxCell();
                    ParentCell.DataSource = Enum.GetNames(typeof(ModEnum.Orders));
                    dgvinitData.Rows[rowIndex].Cells[6] = ParentCell;

                    DataGridViewComboBoxCell OrderCell = new DataGridViewComboBoxCell();
                    OrderCell.DataSource = Enum.GetNames(typeof(ModEnum.Orders));
                    dgvinitData.Rows[rowIndex].Cells[9] = OrderCell;

                    DataGridViewComboBoxCell FieldsCell = new DataGridViewComboBoxCell();
                    foreach (clsField fld in fields.LstFields)
                    {
                        FieldsCell.Items.Add(fld.Name);
                    }
                    dgvinitData.Rows[rowIndex].Cells[7] = FieldsCell;

                }
            }
            catch (Exception)
            {
                //modLog
            }
        }
        #endregion

        #region events
        private void dgvinitData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion


    }
}
