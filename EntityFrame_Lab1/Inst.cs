using EntityFrame_Lab1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrame_Lab1
{
    public partial class Inst : Form
    {
        ItiContext Tcontext;
        public Inst()
        {
            InitializeComponent();
            Tcontext = new ItiContext();
        }

        private void Inst_Load(object sender, EventArgs e)
        {
            dgv_ins.DataSource = Tcontext.Instructors.Select(ins => new { ins.InsId, ins.InsName, ins.InsDegree, DeptName = ins.Dept.DeptName }).ToList();
            cb_dept.DataSource = Tcontext.Departments.ToList();
            cb_dept.DisplayMember = "DeptName";
            cb_dept.ValueMember = "DeptId";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Get the highest existing StId. If there are no students, default to 0.
            var maxStId = Tcontext.Instructors.OrderBy(ins => ins.InsId).Select(ins => ins.InsId).LastOrDefault();
            var newStId = maxStId + 1;

            Instructor instructor = new Instructor()
            {
                InsId = newStId,
                InsName = txt_name.Text,
                InsDegree = txt_degree.Text,
                DeptId = (int)cb_dept.SelectedValue
            };
            Tcontext.Instructors.Add(instructor);
            Tcontext.SaveChanges();
            MessageBox.Show("Added");
            dgv_ins.DataSource = Tcontext.Instructors.Select(ins => new { ins.InsId, ins.InsName, ins.InsDegree, DeptName = ins.Dept.DeptName }).ToList();

        }
        int id;
        private void btn_delete_Click(object sender, EventArgs e)
        {
            Instructor inss = Tcontext.Instructors.Where(ins => ins.InsId == id).FirstOrDefault();
            Tcontext.Instructors.Remove(inss);
            Tcontext.SaveChanges();
            MessageBox.Show("Deleted");
            dgv_ins.DataSource = Tcontext.Students.Select(s =>
            new { s.StId, s.StFname, s.StLname, s.StAge, DeptName = s.Dept.DeptName }).ToList();
        }

        private void dgv_ins_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_ins.SelectedRows[0].Cells[0].Value;

            Instructor ins = Tcontext.Instructors.Where(ins => ins.InsId == id).FirstOrDefault();

            txt_name.Text = ins.InsName;
            txt_degree.Text = ins.InsDegree;
            cb_dept.SelectedValue = (int)(ins.DeptId ?? 0);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Instructor inss = Tcontext.Instructors.Where(ins => ins.InsId == id).FirstOrDefault();
            inss.InsName = txt_name.Text;
            inss.InsDegree = txt_degree.Text;
            inss.DeptId = (int)cb_dept.SelectedValue;

            txt_name.Text = "";
            txt_degree.Text = "";

            Tcontext.SaveChanges();
            MessageBox.Show("Updated");
            dgv_ins.DataSource = Tcontext.Instructors.Select(ins => new { ins.InsId, ins.InsName, ins.InsDegree, ins.Dept, DeptName = ins.Dept.DeptName }).ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var anotherForm = new Dashbord();
            anotherForm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var anotherForm = new Form1();
            anotherForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var anotherForm = new Inst();
            anotherForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var anotherForm = new LoginForm();
            anotherForm.Show();
            this.Hide();
        }
    }
}
