using System.Data;
using InventoryManager.Core;
using InventoryManager.Core.Interfaces;
using InventoryManager.Core.Services;

namespace InventoryManager
{
    public partial class frmMain : Form
    {
        #region Properties

        private IDataAccessService _dataAccessService;
        private BindingSource _partsBindingSource;
        private BindingSource _productsBindingSource;

        #endregion

        #region Constructors

        public frmMain()
        {
            InitializeComponent();
            _dataAccessService = new DataAccessService();
            InitializeDataBinding();
            LoadAllData();
        }

        #endregion

        #region Form Methods

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadAllData()
        {
            LoadPartData();
            LoadProductData();
        }

        private void LoadPartData()
        {
            DataTable dt = _dataAccessService.GetDataFromTable("Part");
            _partsBindingSource.DataSource = dt;
            _partsBindingSource.ResetBindings(false);
        }

        private void LoadProductData()
        {
            DataTable dt = _dataAccessService.GetDataFromTable("Product");
            _productsBindingSource.DataSource = dt;
            _productsBindingSource.ResetBindings(false);
        }

        private void InitializeDataBinding()
        {
            _partsBindingSource = new BindingSource();
            _partsBindingSource.DataSource = dgvParts.DataSource;
            dgvParts.DataSource = _partsBindingSource;

            _productsBindingSource = new BindingSource();
            _productsBindingSource.DataSource = dgvProducts.DataSource;
            dgvProducts.DataSource = _productsBindingSource;
        }

        private DialogResult ShowDeleteConfirmation()
        {
            string message = "Are you sure you want to delete this item?";
            string caption = "Delete Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            DialogResult result = MessageBox.Show(message, caption, buttons, icon);

            return result;
        }

        #endregion

        #region Part Methods

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            frmAddPart frmAddPart = new frmAddPart(_dataAccessService);
            frmAddPart.FormClosed += AddPartForm_FormClosed;
            frmAddPart.ShowDialog();
        }

        private void btnModifyPart_Click(object sender, EventArgs e)
        {
            if (dgvParts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvParts.SelectedRows[0];

                var id = (int)selectedRow.Cells["ID"].Value;
                var partName = selectedRow.Cells["PartName"].Value.ToString();
                var inventory = (int)selectedRow.Cells["Inventory"].Value;
                var price = Convert.ToDouble(selectedRow.Cells["Price"].Value);
                var max = (int)selectedRow.Cells["Max"].Value;
                var min = (int)selectedRow.Cells["Min"].Value;
                var companyName = selectedRow.Cells["CompanyName"].Value.ToString();
                Part part;

                if (!string.IsNullOrEmpty(companyName))
                {
                    part = new OutsourcedPart(partName, price, inventory, min, max, companyName);
                    part.Id = id;
                }
                else
                {
                    var machineId = (int)selectedRow.Cells["MachineId"].Value;
                    part = new InHousePart(partName, price, inventory, min, max, machineId);
                    part.Id = id;
                }

                frmModifyPart frmModifyPart = new frmModifyPart(part, _dataAccessService);
                frmModifyPart.FormClosed += ModifyPartForm_FormClosed;
                frmModifyPart.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select Part.", "Part not selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            if (dgvParts.SelectedRows.Count > 0)
            {
                if (ShowDeleteConfirmation() == DialogResult.OK)
                {
                    DataGridViewRow selectedRow = dgvParts.SelectedRows[0];

                    var id = (int)selectedRow.Cells["ID"].Value;
                    _dataAccessService.DeletePart(id);
                    LoadPartData();
                }
            }
            else
            {
                MessageBox.Show("Please select Part.", "Part not selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearchParts_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchParts.Text))
            {
                _partsBindingSource.RemoveFilter();
            }
            else
            {
                int.TryParse(txtSearchParts.Text, out int searchValue);
                string filterExpression = $"ID = {searchValue} OR PartName LIKE '%{txtSearchParts.Text}%'";
                _partsBindingSource.Filter = filterExpression;
            }

            dgvParts.Refresh();
            if (dgvParts.RowCount == 0)
            {
                MessageBox.Show("No Parts found.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddPartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadPartData();
        }

        private void ModifyPartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadPartData();
        }

        #endregion

        #region Product Methods

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddProduct frmAddProduct = new frmAddProduct(_dataAccessService);
            frmAddProduct.FormClosed += AddProduct_FormClosed;
            frmAddProduct.ShowDialog();
        }

        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvProducts.SelectedRows[0];

                var id = (int)selectedRow.Cells["ID"].Value;
                var productName = selectedRow.Cells["ProductName"].Value.ToString();
                var inventory = (int)selectedRow.Cells["Inventory"].Value;
                var price = Convert.ToDouble(selectedRow.Cells["Price"].Value);
                var max = (int)selectedRow.Cells["Max"].Value;
                var min = (int)selectedRow.Cells["Min"].Value;

                Product product = new Product(id, productName, price, inventory, min, max);
                product.Parts = _dataAccessService.GetProductParts(id);
                frmModifyProduct frmModifyProduct = new frmModifyProduct(product, _dataAccessService);
                frmModifyProduct.FormClosed += ModifyProduct_FormClosed;
                frmModifyProduct.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select Product.", "Product not selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvProducts.SelectedRows[0];

                var id = (int)selectedRow.Cells["ID"].Value;
                List<ProductPart> productParts = _dataAccessService.GetProductParts(id);

                if (productParts.Count > 0)
                {
                    MessageBox.Show("All assigned Parts must be deleted before Product can be deleted.", "Part assigned", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (ShowDeleteConfirmation() == DialogResult.OK)
                    {
                        _dataAccessService.DeleteProduct(id);
                        LoadProductData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select Product.", "Product not selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearchProducts_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchProducts.Text))
            {
                _productsBindingSource.RemoveFilter();
            }
            else
            {
                int.TryParse(txtSearchProducts.Text, out int searchValue);
                string filterExpression = $"ID = {searchValue} OR ProductName LIKE '%{txtSearchProducts.Text}%'";
                _productsBindingSource.Filter = filterExpression;
            }

            dgvProducts.Refresh();
            if (dgvProducts.RowCount == 0)
            {
                MessageBox.Show("No Products found.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadProductData();
        }

        private void ModifyProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadProductData();
        }

        #endregion
    }
}