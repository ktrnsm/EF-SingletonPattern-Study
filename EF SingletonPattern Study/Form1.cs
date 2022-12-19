using EF_SingletonPattern_Study.DesignPatterns.SingletonPattern;
using EF_SingletonPattern_Study.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_SingletonPattern_Study
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _db = DBTool.DBInstance;
        }
        NorthwindEntities _db;

        void ListEmployees()
        {
            listBox1.DataSource = _db.Employees.ToList();
            listBox1.DisplayMember = "FirstName";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListEmployees();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.FirstName = textBox1.Text;
            emp.LastName = textBox2.Text;
            _db.Employees.Add(emp);
            _db.SaveChanges();
            ListEmployees();
          
        }
       
private void listBox1_Format(object sender, ListControlConvertEventArgs e)
        {
            string fullName = $"{(e.ListItem as Employee).FirstName}{(e.ListItem as Employee).LastName}";

            e.Value = fullName;
        }
    }
}
