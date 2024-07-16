using EntityFrame_Lab1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrame_Lab1
{
    public partial class Dashbord : Form
    {
        ItiContext _tiContext;
        public Dashbord()
        {
            InitializeComponent();
            _tiContext = new ItiContext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var anotherForm = new LoginForm();
            anotherForm.Show();
            this.Hide();
        }

        private void Dashbord_Load(object sender, EventArgs e)
        {
            dgv_dachbord.DataSource = _tiContext.Students.Select(s => new { s.StId, s.StFname, s.StLname, s.StAge, DeptName = s.Dept.DeptName }).ToList();
            // Count the number of students
            int studentCount = _tiContext.Students.Count();
            int insCount = _tiContext.Instructors.Count();

            // Display the count in label3
            lbl_stud.Text += studentCount.ToString();
            lbl_ins.Text += insCount.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var anotherForm = new Form1();
            anotherForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var anotherForm = new Inst();
            anotherForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var anotherForm = new Dashbord();
            anotherForm.Show();
            this.Hide();
        }
    }
}
