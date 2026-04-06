using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
	public partial class StudentForm : HumanForm
	{
		public StudentForm()
		{
			InitializeComponent();

			DataTable groups = DataBase.Connector.Select("SELECT * FROM Groups");
			cbGroups.DataSource = groups;
			cbGroups.DisplayMember = "group_name";
			cbGroups.ValueMember = "group_id";
		}
		public StudentForm(int studentID)
		{
			InitializeComponent();

			DataTable student = DataBase.Connector.Select($"SELECT * FROM Students WHERE stud_id = {studentID}");
			DataTable groups = DataBase.Connector.Select("SELECT * FROM Groups");

			if (student.Rows.Count == 0) return;


			TBLastName.Text = student.Rows[0]["last_name"].ToString();
			TBFirstName.Text = student.Rows[0]["first_name"].ToString();
			TBMiddleName.Text = student.Rows[0]["middle_name"].ToString();
			dtpBirthDate.Value = Convert.ToDateTime(student.Rows[0]["birth_date"]);
			tbEmail.Text = student.Rows[0]["email"].ToString();
			tbPhone.Text = student.Rows[0]["phone"].ToString();

			cbGroups.DataSource = groups;
			cbGroups.DisplayMember = "group_name";
			cbGroups.ValueMember = "group_id";

			cbGroups.SelectedValue = student.Rows[0]["group"];

		}
		protected override void buttonOk_Click(object sender, EventArgs e)
		{
			DataBase.Connector.Insert
				(
					"Students",
					"last_name,first_name,middle_name,birth_date,email,phone,[group]",
					$"{TBLastName.Text},{TBFirstName.Text},{TBMiddleName.Text},{dtpBirthDate.Value.ToString("yyyy-MM-dd")},{tbEmail.Text},{tbPhone.Text},{cbGroups.SelectedValue}"
				);
		}
	}
}
