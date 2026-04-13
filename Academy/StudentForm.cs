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
	internal partial class StudentForm : HumanForm
	{
		internal Models.Student student;
		public StudentForm()
		{
			InitializeComponent();

			DataTable groups = DataBase.Connector.Select("SELECT * FROM Groups");
			cbGroups.DataSource = groups;
			cbGroups.DisplayMember = "group_name";
			cbGroups.ValueMember = "group_id";
		}
		public StudentForm(int id) : this()
		{
			DataTable data = DataBase.Connector.Select("*", "Students", $"stud_id={id}");
			//object[] arr = data.Rows[0].ItemArray;
			student = new Models.Student(data.Rows[0].ItemArray);
			human = student;
			Extract();
			cbGroups.SelectedValue = student.group;
			pbPhoto.Image = DataBase.Connector.DownloadPhoto("Students", "photo", student.id);
		}
		protected override void buttonOk_Click(object sender, EventArgs e)
		{
			base.buttonOk_Click(sender, e);

			student = new Models.Student(human, Convert.ToInt32(cbGroups.SelectedValue));
			//object id = DataBase.Connector.Scalar($"SELECT stud_id FROM Students WHERE {student.GetCondition()}");
			if (student.id == 0) DataBase.Connector.Insert("Students", $"{student.GetNames()}", $"{student.GetValues()}");
			else DataBase.Connector.Update($"UPDATE Students SET {student.GetUpdateString()} WHERE stud_id={student.id}");
			if(student.photo != null)
				DataBase.Connector.UploadPhoto(student.SerializePhoto(), student.id, "photo", "Students");
			//DataBase.Connector.Insert
			//	(
			//		"Students",
			//		"last_name,first_name,middle_name,birth_date,email,phone,[group]",
			//		$"{TBLastName.Text},{TBFirstName.Text},{TBMiddleName.Text},{dtpBirthDate.Value.ToString("yyyy-MM-dd")},{tbEmail.Text},{tbPhone.Text},{cbGroups.SelectedValue}"
			//	);

		}
	}
}
