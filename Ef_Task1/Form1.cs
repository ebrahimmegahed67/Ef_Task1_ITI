using System.Data;
using Ef_Task1.Models;
using System.Windows.Forms;
namespace Ef_Task1
{

    public partial class Form1 : Form
    {
        ItiContext iti;
        public Form1()
        {
            InitializeComponent();
            iti = new ItiContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            iti = new ItiContext();
            dgv_instructor.DataSource = iti.Instructors.Select(s => new { ins_id = s.InsId, Name = s.InsName, Degree = s.InsDegree, Salary = s.Salary, Depart_name = s.DeptId }).ToList();
            cb_depart.DataSource = iti.Departments.ToList();
            cb_depart.DisplayMember = "DeptName";
            cb_depart.ValueMember = "DeptId";
            cb_depart.SelectedIndex = -1;
        }

        private void dgv_instructor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int)dgv_instructor.SelectedRows[0].Cells[0].Value;
            Instructor instruct = iti.Instructors.Where(s => s.InsId == id).FirstOrDefault();
            txt_name.Text = instruct.InsName;
            txt_degree.Text = instruct.InsDegree;
            nu_salary.Value = (int)instruct.Salary;
            //if((int)cb_depart.SelectedValue>decimal.MaxValue)
            //{
            //    MessageBox.Show($"Salary= {cb_depart.SelectedValue.ToString}");
            //}
            cb_depart.SelectedValue = instruct.DeptId;
        }
        public void clear()
        {
            txt_degree.Text = txt_name.Text = string.Empty;
            nu_salary.Value = 0;
            cb_depart.SelectedValue = "";
        }
        //public bool flag(bool x)
        //{

        //}
        private void btn_add_Click(object sender, EventArgs e)
        {
            Instructor instruct = new Instructor()
            {
                InsName = txt_name.Text,
                InsDegree = txt_degree.Text,
                Salary = (int)nu_salary.Value,
                DeptId = (int)cb_depart.SelectedValue,
            };
            iti.Add(instruct);
            iti.SaveChanges();
            MessageBox.Show("data added");
            dgv_instructor.DataSource = iti.Instructors.Select(s => new { ins_id = s.InsId, Name = s.InsName, Degree = s.InsDegree, Salary = s.Salary, Depart_name = s.DeptId }).ToList();
            clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = (int)dgv_instructor.SelectedRows[0].Cells[0].Value;
            Instructor instruct = iti.Instructors.Where(s => s.InsId == id).FirstOrDefault();
            instruct.InsName = txt_name.Text;
            instruct.Salary = (int)nu_salary.Value;
            instruct.InsDegree = txt_degree.Text;
            instruct.DeptId = (int)cb_depart.SelectedValue;
            iti.SaveChanges();
            dgv_instructor.DataSource = iti.Instructors.Select(s => new { ins_id = s.InsId, Name = s.InsName, Degree = s.InsDegree, Salary = s.Salary, Depart_name = s.DeptId }).ToList();
            MessageBox.Show("updated");
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = (int)dgv_instructor.SelectedRows[0].Cells[0].Value;
            Instructor instruct = iti.Instructors.Where(s => s.InsId == id).SingleOrDefault();
            iti.Remove(instruct);
            iti.SaveChanges();
            MessageBox.Show("deleted");
            dgv_instructor.DataSource = iti.Instructors.Select(s => new { ins_id = s.InsId, Name = s.InsName, Degree = s.InsDegree, Salary = s.Salary, Depart_name = s.DeptId }).ToList();
            clear();
        }
    }
}
