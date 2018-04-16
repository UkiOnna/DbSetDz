using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSetDz
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet dbShop = new DataSet();

            DataTable orders = new DataTable("Orders");
            DataTable customers = new DataTable("Customers");
            DataTable employees = new DataTable("Employees");
            DataTable orderDetails = new DataTable("OrderDetails");
            DataTable products = new DataTable("Products");

            DataColumn customersIdCol = new DataColumn();


            customersIdCol.ColumnName = "Id";
            customersIdCol.DataType = typeof(int);
            customersIdCol.AllowDBNull = false;
            customersIdCol.AutoIncrement = true;
            customersIdCol.AutoIncrementSeed = 0;
            customersIdCol.AutoIncrementStep = 1;
            customersIdCol.Unique = true;

            DataColumn columnName = new DataColumn("Name", Type.GetType("System.String"));
            DataColumn clumnSurname = new DataColumn("Surname", Type.GetType("System.String"));
            customers.Columns.Add(customersIdCol);
            customers.Columns.Add(columnName);
            customers.Columns.Add(clumnSurname);
            customers.PrimaryKey = new DataColumn[] { customers.Columns["Id"] };

            DataColumn product_idColumn = new DataColumn();
            product_idColumn.ColumnName = "Id";
            product_idColumn.DataType = typeof(int);
            product_idColumn.AllowDBNull = false;
            product_idColumn.AutoIncrement = true;
            product_idColumn.AutoIncrementSeed = 0;
            product_idColumn.AutoIncrementStep = 1;
            product_idColumn.Unique = true;

            DataColumn empIdCol = new DataColumn();
            empIdCol.ColumnName = "Id";
            empIdCol.DataType = typeof(int);
            empIdCol.AllowDBNull = false;
            empIdCol.AutoIncrement = true;
            empIdCol.AutoIncrementSeed = 0;
            empIdCol.AutoIncrementStep = 1;
            empIdCol.Unique = true;
            DataColumn eNameCol = new DataColumn("Name", Type.GetType("System.String"));
            DataColumn eSurnameCol = new DataColumn("Surname", Type.GetType("System.String"));
            employees.Columns.Add(empIdCol);
            employees.Columns.Add(eNameCol);
            employees.Columns.Add(eSurnameCol);
            employees.PrimaryKey = new DataColumn[] { employees.Columns["Id"] };


            DataColumn prodPriceCol = new DataColumn("Price", Type.GetType("System.Decimal"));
            DataColumn prodNameColumn = new DataColumn("Name", Type.GetType("System.String"));
            products.Columns.Add(product_idColumn);
            products.Columns.Add(prodNameColumn);
            products.Columns.Add(prodPriceCol);
            products.PrimaryKey = new DataColumn[] { products.Columns["Id"] };

            DataColumn ordIdCol = new DataColumn();
            ordIdCol.ColumnName = "Id";
            ordIdCol.DataType = typeof(int);
            ordIdCol.AllowDBNull = false;
            ordIdCol.AutoIncrement = true;
            ordIdCol.AutoIncrementSeed = 0;
            ordIdCol.AutoIncrementStep = 1;
            ordIdCol.Unique = true;

            DataColumn custoIdCol = new DataColumn();
            custoIdCol.ColumnName = "Customers_id";
            custoIdCol.DataType = typeof(int);
            DataColumn employIdCol = new DataColumn();
            employIdCol.ColumnName = "Employees_id";
            employIdCol.DataType = typeof(int);


            DataColumn prodIdCol = new DataColumn();
            prodIdCol.ColumnName = "Product_id";
            prodIdCol.DataType = typeof(int);

            DataColumn ordPriceCol = new DataColumn("Price", Type.GetType("System.Decimal"));
            ordPriceCol.ColumnName = "Price";
            ordPriceCol.DataType = typeof(int);
            orders.Columns.Add(ordIdCol);
            orders.Columns.Add(custoIdCol);
            orders.Columns.Add(employIdCol);
            orders.Columns.Add(prodIdCol);
            orders.Columns.Add(ordPriceCol);
            orders.PrimaryKey = new DataColumn[] { orders.Columns["Id"] };

            ForeignKeyConstraint ordEmployeesFK = new ForeignKeyConstraint(orders.Columns["Employees_id"], employees.Columns["Id"]);
            ForeignKeyConstraint ordCustomersFK = new ForeignKeyConstraint(orders.Columns["Customers_id"], customers.Columns["Id"]);
            ForeignKeyConstraint ordProductsFK = new ForeignKeyConstraint(orders.Columns["Product_id"], customers.Columns["Id"]);

            dbShop.Tables.Add(orders);
            dbShop.Tables.Add(customers);
            dbShop.Tables.Add(employees);
            dbShop.Tables.Add(products);
           



            dbShop.AcceptChanges();
        }
    }
}
