using System.Data;
using System.Data.OleDb;
using InventoryManager.Core.Interfaces;

namespace InventoryManager.Core.Services
{
    public class DataAccessService : IDataAccessService
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=data/Inventory.accdb";

        public void AddLinkedPart(int productId, int partId)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "INSERT INTO ProductPart(ProductId, PartId) VALUES(@productId, @partId)";

                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@productId", productId);
                    cmd.Parameters.AddWithValue("@partId", partId);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddPart(Part part)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "INSERT INTO Part(PartName, Inventory, Price, [Max], [Min], MachineId, CompanyName) VALUES(@partName, @inventory, @price, @max, @min, @machineId, @companyName)";

                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                {
                    int? machineId = null;
                    string? companyName = null;

                    if (part is InHousePart)
                    {
                        machineId = ((InHousePart)part).PartId;
                    }
                    else
                    {
                        companyName = ((OutsourcedPart)part).CompanyName;
                    }

                    cmd.Parameters.AddWithValue("@partName", part.Name);
                    cmd.Parameters.AddWithValue("@inventory", part.Inv);
                    cmd.Parameters.AddWithValue("@price", part.Price);
                    cmd.Parameters.AddWithValue("@max", part.Max);
                    cmd.Parameters.AddWithValue("@min", part.Min);
                    cmd.Parameters.AddWithValue("@machineId", machineId.HasValue ? machineId : DBNull.Value);
                    cmd.Parameters.AddWithValue("@companyName", companyName ?? "");

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Part successfully added!");
                }
            }
        }

        public void AddProduct(Product product)
        {
            string insertQuery = "INSERT INTO Product(ProductName, Inventory, Price, [Max], [Min]) VALUES(@productName, @inventory, @price, @max, @min)";

            using (OleDbCommand insertCommand = new OleDbCommand(insertQuery))
            {
                insertCommand.Parameters.AddWithValue("@productName", product.Name);
                insertCommand.Parameters.AddWithValue("@inventory", product.Inv);
                insertCommand.Parameters.AddWithValue("@price", product.Price);
                insertCommand.Parameters.AddWithValue("@max", product.Max);
                insertCommand.Parameters.AddWithValue("@min", product.Min);

                int generatedId = InsertAndGetGeneratedId(insertCommand, connectionString);

                if (generatedId != -1)
                {
                    foreach (var linkedPart in product.Parts)
                    {
                        AddLinkedPart(generatedId, (int)linkedPart.PartId);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to retrieve the inserted ID.", "Failed to save Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void DeleteLinkedPart(int id)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "DELETE FROM ProductPart WHERE ID = @id";

                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Part successfully deleted!");
                    }
                    else
                    {
                        MessageBox.Show("Unable to deleted part.");
                    }
                }
            }
        }

        public void DeletePart(int id)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "DELETE FROM Part WHERE ID = @id";

                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Part successfully deleted!");
                    }
                    else
                    {
                        MessageBox.Show("Unable to deleted part.");
                    }
                }
            }
        }

        public void DeleteProduct(int id)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "DELETE FROM Product WHERE Id = @id";

                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product successfully deleted!");
                    }
                    else
                    {
                        MessageBox.Show("Unable to deleted product.");
                    }
                }
            }
        }

        public DataTable GetDataFromTable(string tableName)
        {
            DataTable dataTable = new DataTable();

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter($"SELECT * FROM {tableName}", connection))
                {
                    connection.Open();
                    dataAdapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        public List<ProductPart> GetProductParts(int productId)
        {
            List<ProductPart> productParts = new List<ProductPart>();
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM ProductPart WHERE ProductId = @productId";

                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@productId", productId);
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        foreach (DataRow dataTableRow in dataTable.Rows)
                        {
                            ProductPart productPart = new ProductPart
                            {
                                Id = Convert.ToInt32(dataTableRow["Id"]),
                                ProductId = productId,
                                PartId = Convert.ToInt32(dataTableRow["PartId"]),
                            };
                            productParts.Add(productPart);
                        }
                    }
                }
            }
            return productParts;
        }

        public Part? GetPart(int partId)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Part WHERE Id = @partId";

                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@partId", partId);
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            DataRow dataTableRow = dataTable.Rows[0];
                            Part part = new InHousePart
                            {
                                Id = partId,
                                Name = Convert.ToString(dataTableRow["PartName"]),
                                Inv = Convert.ToInt32(dataTableRow["Inventory"]),
                                Price = Convert.ToDouble(dataTableRow["Price"]),
                                Min = Convert.ToInt32(dataTableRow["Min"]),
                                Max = Convert.ToInt32(dataTableRow["Max"])
                            };
                            return part;
                        }

                        return null;
                    }
                }
            }
        }

        public void UpdatePart(Part part)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "UPDATE Part SET PartName = @partName, Inventory = @inventory, Price = @price, [Max] = @max, [Min] = @min, MachineId = @machineId, CompanyName = @companyName WHERE ID = @id";

                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                {
                    int? machineId = null;
                    string? companyName = null;

                    if (part is InHousePart)
                    {
                        machineId = ((InHousePart)part).PartId;
                    }
                    else
                    {
                        companyName = ((OutsourcedPart)part).CompanyName;
                    }

                    cmd.Parameters.AddWithValue("@partName", part.Name);
                    cmd.Parameters.AddWithValue("@inventory", part.Inv);
                    cmd.Parameters.AddWithValue("@price", part.Price);
                    cmd.Parameters.AddWithValue("@max", part.Max);
                    cmd.Parameters.AddWithValue("@min", part.Min);
                    cmd.Parameters.AddWithValue("@machineId", machineId.HasValue ? machineId : DBNull.Value);
                    cmd.Parameters.AddWithValue("@companyName", companyName ?? "");
                    cmd.Parameters.AddWithValue("@id", (int)part.Id);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Part successfully updated!");
                }
            }
        }

        public void UpdateProduct(Product product)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "UPDATE Product SET ProductName = @productName, Inventory = @inventory, Price = @price, [Max] = @max, [Min] = @min WHERE ID = @id";

                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@productName", product.Name);
                    cmd.Parameters.AddWithValue("@inventory", product.Inv);
                    cmd.Parameters.AddWithValue("@price", product.Price);
                    cmd.Parameters.AddWithValue("@max", product.Max);
                    cmd.Parameters.AddWithValue("@min", product.Min);
                    cmd.Parameters.AddWithValue("@id", (int)product.Id);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    DeleteProductParts((int)product.Id);
                    foreach (ProductPart productPart in product.Parts)
                    {
                        AddLinkedPart(productPart.ProductId, productPart.PartId);
                    }
                }
            }
        }

        private void DeleteProductParts(int productId)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "DELETE FROM ProductPart WHERE ProductId = @id";

                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", productId);

                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                }
            }
        }

        private int InsertAndGetGeneratedId(OleDbCommand insertCommand, string connectionString)
        {
            int generatedId = -1;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                insertCommand.Connection = connection;
                insertCommand.ExecuteNonQuery();
                
                using (OleDbCommand identityCommand = new OleDbCommand("SELECT @@IDENTITY", connection))
                {
                    object result = identityCommand.ExecuteScalar();
                    
                    if (result != null && int.TryParse(result.ToString(), out generatedId))
                    {
                        return generatedId;
                    }
                }
            }

            return generatedId;
        }

    }
}
