using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace LINQ_First
{
    [Table(Name = "Person.Person")]//SalesLT.Customer
    public class Contact
    {
        [Column]
        public string Title;
        [Column]
        public string FirstName;
        [Column]
        public string LastName;

    }
    public partial class LINQSQL : Form
    {
        public LINQSQL()
        {
            InitializeComponent();
        }

        private void LINQSQL_Load(object sender, EventArgs e)
        {
            //Connection string
            string conString = "Data Source=192.168.1.230;Initial Catalog=AdventureWorks2017;Persist Security Info=True;User ID=trainee2022;Password=trainee@2022";
            try
            {
                //creating data context
                DataContext db = new DataContext(conString);
                Table<Contact> contacts = db.GetTable<Contact>();//Returns the table of similar type

                //QueryDb
                //var contactDetails = from c in contacts
                //                     where c.Title == "Mr."
                //                     select c;
                var contactDetails = from c in contacts select c;
                //Display Contact Details

                foreach (var item in contactDetails)
                {
                    textBox1.AppendText("Title : " + item.Title);
                    textBox1.AppendText("\t");
                    textBox1.AppendText("First Name : " + item.FirstName);
                    textBox1.AppendText("\t");
                    textBox1.AppendText("Last Name : " + item.LastName);
                    textBox1.AppendText("\t");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
