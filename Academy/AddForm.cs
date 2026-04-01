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
	public partial class AddForm : Form
	{
		public AddForm(object sender)
		{
			InitializeComponent();
			if (sender.ToString().Split(' ')[sender.ToString().Split(' ').Length - 1] == "Students")
			{
				//Console.WriteLine("Добавить студента");
				checkBoxAddStudents.Checked = true;
				ShowGroupsFields(false);
			}
			else if (sender.ToString().Split(' ')[sender.ToString().Split(' ').Length - 1] == "Teacher")
			{
				//Console.WriteLine("Добавить учителя");
				checkBoxAddTeacher.Checked = true;
				ShowGroupsFields(false);
			}
			else if (sender.ToString().Split(' ')[sender.ToString().Split(' ').Length - 1] == "Group")
			{
				//Console.WriteLine("Добавить грппу");
				chekBoxAddGroup.Checked = true;
				ShowPeopleFields(false);
			}

		}
		private void ShowGroupsFields(bool flag)
		{
			TBADDDirection_name.Visible = flag;
			TBADDDirection_name_PlaceHolder.Visible = flag;
			TBADDGroup_name_PlaceHolder.Visible = flag;
			TBADDGroup_name.Visible = flag;
		}
		private void ShowPeopleFields(bool flag)
		{
			TBADDFirst_name.Visible = flag;
			TBADDFirst_name_PlaceHolder.Visible = flag;
			TBADDLast_name.Visible = flag;
			TBADDLast_name_PlaceHolder.Visible = flag;
			TBADDMiddle_name.Visible = flag;
			TBADDMiddle_name_PlaceHolder.Visible = flag;
			TBADDBirth_date.Visible = flag;
			TBADDBirth_date_PlaceHolder.Visible = flag;
		}
		private void checkBoxAddStudents_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxAddStudents.Checked == true)
				ShowGroupsFields(false);
			else
				ShowGroupsFields(true);
		}
		private void checkBoxAddTeacher_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxAddTeacher.Checked == true)
				ShowGroupsFields(false);
			else
				ShowGroupsFields(true);

		}

		private void chekBoxAddGroup_CheckedChanged(object sender, EventArgs e)
		{
			if (chekBoxAddGroup.Checked == true) ShowPeopleFields(false);
			else ShowPeopleFields(true);
		}
		private void AddStudent()
		{
			string last_name = TBADDLast_name.Text == "" ? string.Empty : TBADDLast_name.Text;
			string first_name = TBADDFirst_name.Text == "" ? string.Empty : TBADDFirst_name.Text;
			string middle_name = TBADDMiddle_name.Text == "" ? string.Empty : TBADDMiddle_name.Text;
			DateTime birth_date = TBADDBirth_date.Value;
			MainForm.AddToDB
				(
				"Students",
				"last_name,first_name,middle_name,birth_date",
				$"{last_name},{first_name},{middle_name},{birth_date:yyyy-MM-dd}"
				);
		}
		private void AddTeacher()
		{
			string last_name = TBADDLast_name.Text == "" ? string.Empty : TBADDLast_name.Text;
			string first_name = TBADDFirst_name.Text == "" ? string.Empty : TBADDFirst_name.Text;
			string middle_name = TBADDMiddle_name.Text == "" ? string.Empty : TBADDMiddle_name.Text;
			DateTime birth_date = TBADDBirth_date.Value;
			MainForm.AddToDB
				(
				"Teachers",
				"last_name,first_name,middle_name,birth_date",
				$"{last_name},{first_name},{middle_name},{birth_date:yyyy-MM-dd}"
				);
		}
		private void AddGroup()
		{
			string group_name = TBADDGroup_name.Text;
			string direction_name = TBADDDirection_name.Text;
			int direction_id = 0;
			if (MainForm.d_directions.ContainsKey(direction_name))
				direction_id = MainForm.d_directions[direction_name];
			MainForm.AddToDB
				(
					"Groups",
					"group_name,direction_id",
					$"{group_name},{direction_id}"
				);
		}
		private void buttonAddElement_Click(object sender, EventArgs e)
		{
			string group_name = TBADDGroup_name.Text == "" ? string.Empty : TBADDGroup_name.Text;
			string group_direction = TBADDDirection_name.Text == "" ? string.Empty : TBADDDirection_name.Text;


		}
	}
}
