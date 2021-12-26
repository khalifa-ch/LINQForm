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
    public partial class Form2 : Form
    {
        NorthwindEntities db= NorthwindEntities.Mydb;
        Product prod;
        public Form2(Product p=null)
        {
            InitializeComponent();

            this.prod = p;
        }

        private void btok_Click(object sender, EventArgs e)
        {
            // Product p = new Product();
            // p.ProductName = txttext.Text;
            //  p.CategoryID = 1;
            /* Product p = new Product
             {
                 ProductName = txttext.Text,
                 CategoryID = 1

             };

             db.Products.Add(p);*/
            prod.ProductName = txttext.Text;
            prod.CategoryID = (int)lsttest.SelectedValue;
            db.SaveChanges();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Filllist();
            FillForm(prod);
        }

        private void Filllist()
        {
            var query = from c in db.Categories
                        orderby c.CategoryName
                        select c;
             lsttest.DataSource = query.ToList();
             lsttest.DisplayMember="CategoryName";
             lsttest.ValueMember = "CategoryID";
        }

        private void FillForm(Product prod)
        {
            txttext.Text = prod.ProductName;
            lsttest.Text = prod.Category.CategoryName;



        }
    }
}
