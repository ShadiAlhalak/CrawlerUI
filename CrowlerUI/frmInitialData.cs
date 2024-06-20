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
using LibGeneralUtilities;
using LibStructure;
using LogManagment;
using MaterialSkin2DotNet;
namespace CrawlerUI
{
    public partial class frmInitialData : MaterialSkin2DotNet.Controls.MaterialForm
    {
        public List<clsHtmlElem> elements { get; set; } = new List<clsHtmlElem>();
        public clsFields fields { get; set; } = new clsFields();
        public List<clsHtmlElem> RequestedElements = new List<clsHtmlElem>();
        public frmInitialData(List<clsHtmlElem> elements, clsFields Filds)
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
                    DataGridViewComboBoxCell GroupCell = new DataGridViewComboBoxCell();
                    GroupCell.DataSource = Enum.GetNames(typeof(ModEnum.Orders));
                    dgvinitData.Rows[rowIndex].Cells[6] = GroupCell;

                    DataGridViewComboBoxCell ParentGroup = new DataGridViewComboBoxCell();
                    ParentGroup.DataSource = Enum.GetNames(typeof(ModEnum.Orders));
                    dgvinitData.Rows[rowIndex].Cells[11] = ParentGroup;

                    DataGridViewComboBoxCell OrderCell = new DataGridViewComboBoxCell();
                    OrderCell.DataSource = Enum.GetNames(typeof(ModEnum.Orders));
                    dgvinitData.Rows[rowIndex].Cells[9] = OrderCell;

                    DataGridViewComboBoxCell FieldsCell = new DataGridViewComboBoxCell();
                    DataGridViewComboBoxCell FieldsIds = new DataGridViewComboBoxCell();
                    foreach (clsField fld in fields.LstFields)
                    {
                        FieldsCell.Items.Add(fld.Name);
                        FieldsIds.Items.Add(fld.Id);
                    }
                    dgvinitData.Rows[rowIndex].Cells[7] = FieldsCell;
                    dgvinitData.Rows[rowIndex].Cells[10] = FieldsIds;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                RequestedElements.Clear();
                foreach (DataGridViewRow row in dgvinitData.Rows)
                {
                    clsHtmlElem elem = new clsHtmlElem();
                    elem.tagName = row.Cells[0].Value.ToString();
                    elem.ClassName = row.Cells[1].Value.ToString();
                    elem.Id = row.Cells[2].Value.ToString();
                    elem.Value = row.Cells[3].Value.ToString();
                    elem.href = row.Cells[4].Value.ToString();
                    elem.src = row.Cells[5].Value.ToString();
                    //elem.FildId = row.Cells[10].Value.ToString();
                    if (row.Cells[7].Value != null)
                    {
                        elem.FieldName = row.Cells[7].Value.ToString();
                    }
                    if (row.Cells[8].Value != null)
                    {
                        elem.IsPage = bool.Parse(row.Cells[8].Value?.ToString());
                    }
                    if (row.Cells[6].Value != null)
                    {
                        Enum.TryParse(row.Cells[6].Value.ToString(), out ModEnum.Orders Group);
                        elem.group = (int)Group;
                    }
                    if (row.Cells[9].Value != null)
                    {
                        Enum.TryParse(row.Cells[9].Value.ToString(), out ModEnum.Orders order);
                        elem.order = (int)order;
                    }
                    if (row.Cells[11].Value != null)
                    {
                        Enum.TryParse(row.Cells[11].Value.ToString(), out ModEnum.Orders order);
                        elem.groupParent = (int)order;
                    }
                    RequestedElements.Add(elem);
                }
                string ErrorMessage = string.Empty;
                string TrainingFolder = ModPathes.GetSessionTrainingFolder(ref ErrorMessage);
                string ResultFilePath = Path.Combine(TrainingFolder, ModConstant.cnst_ValuesFileName + ModConstant.cnst_json_Extention);
                //clsHtmlElem.SerializeHtmlElementsToFile(RequestedElements, ResultFilePath, ref ErrorMessage);
                clsHtmlElems _elems = new clsHtmlElems();
                _elems.Elements = RequestedElements;
                clsHtmlElems.SerializeHtmlElementsToFile(_elems, ResultFilePath, ref ErrorMessage);
            }
            catch (Exception ex)
            {
                //ModLog.
            }
        }
    }
}
