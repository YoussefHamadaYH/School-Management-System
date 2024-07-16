using EntityFrame_Lab1.Models;

namespace EntityFrame_Lab1
{
    public partial class Form1 : Form
    {

        ItiContext context2;
        public Form1()
        {
            context2 = new ItiContext();
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_student.DataSource = context2.Students.Select(s => new { s.StId, s.StFname, s.StLname, s.StAge, DeptName = s.Dept.DeptName }).ToList();
            cb_dept.DataSource = context2.Departments.ToList();
            cb_dept.DisplayMember = "DeptName";
            cb_dept.ValueMember = "DeptId";


        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Get the highest existing StId. If there are no students, default to 0.
            var maxStId = context2.Students.OrderBy(s => s.StId).Select(s => s.StId).LastOrDefault();
            var newStId = maxStId + 1;

            Student student = new Student()
            {
                StId = newStId,
                StFname = txt_fname.Text,
                StLname = txt_lname.Text,
                StAddress = txt_address.Text,
                StAge = int.Parse(nud_age.Text),
                DeptId = (int)cb_dept.SelectedValue
            };

            context2.Students.Add(student);
            context2.SaveChanges();
            MessageBox.Show("Added");
            dgv_student.DataSource = context2.Students.Select(s => new { s.StId, s.StFname, s.StLname, s.StAge, DeptName = s.Dept.DeptName }).ToList();
        }
        int id;
        private void btn_update_Click(object sender, EventArgs e)
        {
            Student s = context2.Students.Where(s => s.StId == id).FirstOrDefault();
            s.StFname = txt_fname.Text;
            s.StLname = txt_lname.Text;
            s.StAddress = txt_address.Text;
            s.StAge = (int)nud_age.Value;
            s.DeptId = (int)cb_dept.SelectedValue;

            txt_fname.Text = "";
            txt_lname.Text = "";
            txt_address.Text = "";
            nud_age.Value = 0;

            context2.SaveChanges();
            MessageBox.Show("Updated");
            dgv_student.DataSource = context2.Students.Select(s => new { s.StId, s.StFname, s.StLname, s.StAge, s.StAddress, DeptName = s.Dept.DeptName }).ToList();

        }



        private void dgv_student_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_student.SelectedRows[0].Cells[0].Value;

            Student s = context2.Students.Where(s => s.StId == id).FirstOrDefault();

            txt_fname.Text = s.StFname;
            txt_lname.Text = s.StLname;
            txt_address.Text = s.StAddress;
            nud_age.Value = (int)(s.StAge ?? 0);
            cb_dept.SelectedValue = (int)(s.DeptId ?? 0);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Student s = context2.Students.Where(s => s.StId == id).FirstOrDefault();
            context2.Students.Remove(s);
            context2.SaveChanges();
            MessageBox.Show("Deleted");
            dgv_student.DataSource = context2.Students.Select(s =>
            new { s.StId, s.StFname, s.StLname, s.StAge, DeptName = s.Dept.DeptName }).ToList();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            var students = context2.Students.Where(s => s.StFname == txt_fname.Text).
                Select(s => new { s.StId, s.StFname, s.StLname, s.StAddress, DeptName = s.Dept.DeptName }).ToList();

            dgv_student.DataSource = students;

            if (students.Count > 0)
            {
                dgv_student.CurrentCell = dgv_student.Rows[0].Cells[0];
            }
            else
            {
                MessageBox.Show("No students found with the specified first name.");
            }

        }


        private void label7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var anotherForm = new LoginForm();
            anotherForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var anotherForm = new Inst();
            anotherForm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var anotherForm = new Form1();
            anotherForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var anotherForm = new Dashbord();
            anotherForm.Show();
            this.Hide();
        }
    }
}
