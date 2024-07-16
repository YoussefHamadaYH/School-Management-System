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
using EntityFrame_Lab1.Models;
namespace EntityFrame_Lab1;

public partial class LoginForm : Form
{
    ItiContext context1;
    public LoginForm()
    {
        context1 = new ItiContext();
        InitializeComponent();


    }

    private void btn_login_Click(object sender, EventArgs e)
    {
        string username = txt_userName.Text;
        int password = int.Parse(txt_password.Text);

        if (context1.Students.Where(s => s.StFname == username && s.StId == password).Any())
        {
            //Login successful, open the next form
            MessageBox.Show("Login successful!");
            var anotherForm = new Dashbord();
            anotherForm.Show();
            this.Hide();
        }
        else
        {
            MessageBox.Show("Please enter a valid password.");
        }
    }
    private void label4_Click(object sender, EventArgs e)
    {
        Close();
    }
}
