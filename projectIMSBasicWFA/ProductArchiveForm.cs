using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectIMSBasicWFA
{
    public partial class ProductArchiveForm : Form
    {
        public ProductArchiveForm()
        {
            InitializeComponent();
        }

        public void setGridColumns()
        {
            // Reset all grid columns to fit all data
            prodActiveDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            prodInactiveDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void removeActiveColumns()
        {
            prodActiveDataGridView.Columns.Remove("CategoryID");
            prodActiveDataGridView.Columns.Remove("QuantityPerUnit");
            prodActiveDataGridView.Columns.Remove("UnitPrice");
            prodActiveDataGridView.Columns.Remove("UnitsInStock");
            prodActiveDataGridView.Columns.Remove("UnitsOnOrder");
            prodActiveDataGridView.Columns.Remove("ReorderLevel");
        }

        public void removeInactiveColumns()
        {
            prodInactiveDataGridView.Columns.Remove("CategoryID");
            prodInactiveDataGridView.Columns.Remove("QuantityPerUnit");
            prodInactiveDataGridView.Columns.Remove("UnitPrice");
            prodInactiveDataGridView.Columns.Remove("UnitsInStock");
            prodInactiveDataGridView.Columns.Remove("UnitsOnOrder");
            prodInactiveDataGridView.Columns.Remove("ReorderLevel");
        }

        public void loadActive()
        {
            try
            {
                String tableName = "Products";
                String queryWHERE = "Discontinued = '" + 0 + "'";
                DBConnect dbAct = new DBConnect(tableName, queryWHERE);
                DataSet dsAct = new DataSet();
                dbAct.DA.Fill(dsAct, "Products");
                DataTable dtAct = dsAct.Tables["Products"];

                prodActiveDataGridView.DataSource = dtAct;
                removeActiveColumns();
                setGridColumns();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        public void loadInactive()
        {
            try
            {
                String tableName = "Products";
                String queryWHERE = "Discontinued = '" + 1 + "'";
                DBConnect dbInact = new DBConnect(tableName, queryWHERE);
                DataSet dsInact = new DataSet();
                dbInact.DA.Fill(dsInact, "Products");
                DataTable dtInact = dsInact.Tables["Products"];

                prodInactiveDataGridView.DataSource = dtInact;
                removeInactiveColumns();
                setGridColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private void ProductArchiveForm_Load(object sender, EventArgs e)
        {
            loadActive();
            loadInactive();
        }

        private void applyActiveButton_Click(object sender, EventArgs e)
        {
            int current_row_index = 0;
            int current_selected_product_ID = 0; 
            // Get selected index and ID 
            try
            {
                current_row_index = prodActiveDataGridView.CurrentCell.RowIndex;
                current_selected_product_ID = Convert.ToInt32(prodActiveDataGridView.Rows[current_row_index].Cells[0].Value.ToString()); ;
            }
            catch (Exception)
            {
                MessageBox.Show("Make sure a row is selected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Make inactive 
            DialogResult result = MessageBox.Show("Do you want to deactivated the Product?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string selection = "ProductID = '" + current_selected_product_ID + "'";
                    DBConnect mydb = new DBConnect("Products", selection);
                    DataSet myds = new DataSet();
                    mydb.DA.Fill(myds, "Products");
                    mydb.DA.UpdateCommand = new SqlCommandBuilder(mydb.DA).GetUpdateCommand();
                    DataTable mydt = myds.Tables["Products"];

                    mydt.Rows[0][9] = 1;

                    mydb.DA.Update(mydt);
                    MessageBox.Show("Product successfully deactivated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadActive();
                    loadInactive();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void applyInactiveButton_Click(object sender, EventArgs e)
        {
            // Make active
            int current_row_index = 0;
            int current_selected_product_ID = 0;
            // Get selected index and ID 
            try
            {
                current_row_index = prodInactiveDataGridView.CurrentCell.RowIndex;
                current_selected_product_ID = Convert.ToInt32(prodInactiveDataGridView.Rows[current_row_index].Cells[0].Value.ToString()); ;
            }
            catch (Exception)
            {
                MessageBox.Show("Make sure a row is selected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Make inactive 
            DialogResult result = MessageBox.Show("Do you want to activated the Product?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string selection = "ProductID = '" + current_selected_product_ID + "'";
                    DBConnect mydb = new DBConnect("Products", selection);
                    DataSet myds = new DataSet();
                    mydb.DA.Fill(myds, "Products");
                    mydb.DA.UpdateCommand = new SqlCommandBuilder(mydb.DA).GetUpdateCommand();
                    DataTable mydt = myds.Tables["Products"];

                    mydt.Rows[0][9] = 0;

                    mydb.DA.Update(mydt);
                    MessageBox.Show("Product successfully deactivated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadActive();
                    loadInactive();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabControl.TabPages["tabPage1"])
            {
                loadActive();
                
            }
            if (tabControl.SelectedTab == tabControl.TabPages["tabPage2"])
            {
                loadInactive();
            }
        }

        private void prodActiveDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in prodActiveDataGridView.Rows)
            {        
                    Myrow.DefaultCellStyle.BackColor = Color.LightGreen;     
            }
        }

        private void prodInactiveDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in prodInactiveDataGridView.Rows)
            {
                Myrow.DefaultCellStyle.BackColor = Color.IndianRed;
            }
        }

    }
}
