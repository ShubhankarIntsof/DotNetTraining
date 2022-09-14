using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_First
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //defining a String Array
            string[] names = {"Wings of fire",
                "Rich Dad Poor Die", 
                "Deep Work",
                "Think Rich Grow More",
                "Everyone you hate is going to die"};

            //LINQ Query
            IEnumerable<string> AlltimeFavBooks = from name in names
                                                  where name.Length >= 5
                                                  select name;
            //For Each to display objects
            foreach (var book in AlltimeFavBooks)
            {
                Console.WriteLine(book);
                richTextBox1.AppendText(book + "\n");

            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
