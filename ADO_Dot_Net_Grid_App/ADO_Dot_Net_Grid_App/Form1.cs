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

namespace ADO_Dot_Net_Grid_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString =  "Data Source=192.168.1.230;Initial Catalog=Freshers_Training2022;Persist Security Info=True;User ID=trainee2022;Password=trainee@2022";
            SqlConnection myConnection = new SqlConnection(ConnectionString);
           

            myConnection.Open();
            string queryString = "select * from student1";
            SqlDataAdapter myDataAdaptor = new SqlDataAdapter(queryString, myConnection);

            //DataTable dt = new DataTable();
            ////--DataSet dataSet = new DataSet("student1");
            ////--myDataAdaptor.Fill(dataSet, "student1");
            //myDataAdaptor.Fill(dt);



            DataSet ds= new DataSet("student1");


            dataGridView1.DataSource = ds;
            //--dataGridView1.DataSource = dataSet.DefaultViewManager;

            myDataAdaptor.Fill(ds, "student1");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

            myConnection.Close();
            




        }
    }
}
