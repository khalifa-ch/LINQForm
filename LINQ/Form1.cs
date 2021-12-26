using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class Form1 : Form
    {
        NorthwindEntities db = NorthwindEntities.Mydb;// = new NorthwindEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filList();
        }

        private void filList()
        {
            var query = from c in db.Categories
                        orderby c.CategoryName
                        select c.CategoryName;
            //  lstTest.DataSource = query.ToList();
            //   lstTest.DisplayMember = "CategoryName";
            ////////version manuel
            lstTest.Items.Add("All");

            foreach (var item in query)
            {
                lstTest.Items.Add(item);
            }
        }

        private void btTest_Click(object sender, EventArgs e)
        {
            var query = from p in db.Products
                        where p.ProductName.Contains(txtTest.Text)
                        where p.UnitsInStock > 0
                        orderby p.ProductName
                        select new
                        {
                            id = p.ProductID,
                            p.ProductName,
                            p.Category.CategoryName,
                            total = p.UnitPrice * p.UnitsInStock
                        };

            dataTest.DataSource = query.ToList();
            dataTest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private bool productFliter(Product p)
        {
            return p.ProductName.Contains(txtTest.Text);
        }

        private void txtTest_TextChanged(object sender, EventArgs e)
        {
            //methode linq
            dataTest.DataSource = db.Products
                // .Where(productFliter)
                // .Where(delegate (Product p) { return p.ProductName.Contains(txtTest.Text); })
                .Where((Product p) => p.ProductName.Contains(txtTest.Text))
                .Where(p => p.UnitsInStock > 0)
                .OrderBy(p => p.ProductName)
                .Select(p => new 
                {
                    p.ProductName,
                    p.UnitsInStock,
                    p.Category.CategoryName,
                    total= p.UnitsInStock * p.UnitPrice
                })
                .ToList();
            /*  var query = from p in db.Products
                           where p.ProductName.Contains(txtTest.Text)
                           where p.UnitsInStock > 0
                           orderby p.ProductName
                           select new
                           {
                               id = p.ProductID,
                               p.ProductName,
                               p.Category.CategoryName,
                               total = p.UnitPrice * p.UnitsInStock
                           };

               dataTest.DataSource = query.ToList();
               dataTest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;*/

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstTest_SelectedIndexChanged(object sender, EventArgs e)
        {

            var query = from p in db.Products
                        orderby p.ProductName
                        where lstTest.SelectedIndex == 0 || p.Category.CategoryName.Equals(lstTest.Text)
                        select p;
            dataTest.DataSource = query.ToList();
        }

        private void dataTest_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            txtTEST2.Text = dataTest.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int id = (int)dataTest.SelectedRows[0].Cells[0].Value;
            Product p = db.Products.Find(id);
            db.Products.Remove(p);
            try
            {
                db.SaveChanges();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void btModify_Click(object sender, EventArgs e)
        {

            int id = (int)dataTest.SelectedRows[0].Cells[0].Value;
            Product p = db.Products.Find(id);
            Form2 frm = new Form2(p);
            frm.ShowDialog();
        }
    }
}
