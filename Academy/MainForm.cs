using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
	public partial class MainForm : Form
	{
		Query[] queries =
		{
			new Query
				(
				"stud_id,last_name,first_name,middle_name,group_name,direction_name",
				"Students,Groups,Directions",
				"[group]=group_id AND direction=direction_id"
				),//0
			new Query
				(
				"*",
				"Groups,Directions",
				"direction=direction_id"
				),//1
			new Query("*", "Directions"),//2
			new Query("*", "Disciplines"),//3
			new Query("*", "Teachers")//4
		};
		string[] status_message =
		{
			"Количество студентов",
			"Количество групп",
			"Количество направлений",
			"Количество дисциплин",
			"Количество преподавателей"
		};
		DataGridView[] tables;
		DBTools.Connector connector;
		Dictionary<string, int> d_directions;
		Dictionary<string, int> d_groups;
		StudentForm studentForm;
		public MainForm()
		{
			AllocConsole();
			InitializeComponent();
			tables = new DataGridView[] { dgvStudents, dgvGroups, dgvDirections, dgvDisciplines, dgvTeachers };
			connector = new DBTools.Connector(ConfigurationManager.ConnectionStrings["PV_521_Import"].ConnectionString);

			//dgvDirections.DataSource = connector.Select("*", "Directions");
			//toolStripStatusLabel.Text = $"Количество направлений обучения: {dgvDirections.Rows.Count-1}";
			//toolStripStatusLabel.Text = $"Количество направлений обучения: {connector.Scalar("SELECT COUNT(*) FROM Directions")}";
			tabControl_SelectedIndexChanged(tabControl, null);

			d_directions = connector.GetDictionary("Directions");
			d_groups = connector.GetDictionary("Groups");

			cbStudentsGroups.Items.AddRange(d_groups.Keys.ToArray());
			cbGroupDirection.Items.AddRange(d_directions.Keys.ToArray());
			cbStudentsDirection.Items.AddRange(d_directions.Keys.ToArray());
		}

		private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			int i = tabControl.SelectedIndex;
			tables[i].DataSource = connector.Select(queries[i].ToString());
			toolStripStatusLabel.Text = $"{status_message[i]}: {tables[i].RowCount - 1}";
			if(i == 0) dgvStudents.Columns["stud_id"].Visible = false;
		}
		[DllImport("kernel32.dll")]
		public static extern void AllocConsole();
		[DllImport("kernel32.dll")]
		public static extern bool FreeConsole();

		private void cbGroupDirection_SelectedIndexChanged(object sender, EventArgs e)
		{
			dgvGroups.DataSource = connector.Select
				(
					queries[1].ToString() +
					$" AND direction={d_directions[cbGroupDirection.SelectedItem.ToString()]}"
				);
			toolStripStatusLabel.Text = $"{status_message[1]}: {dgvGroups.RowCount - 1}";
		}

		private void cbStudentsDirection_SelectedIndexChanged(object sender, EventArgs e)
		{
			d_groups = connector.GetDictionary
				(
					"Groups", $"direction={d_directions[cbStudentsDirection.SelectedItem.ToString()]}"
				);
			cbStudentsGroups.Items.Clear();
			cbStudentsGroups.Items.AddRange(d_groups.Keys.ToArray());
			dgvStudents.DataSource = connector.Select
				(
					queries[0].ToString()+
					$" AND direction={d_directions[cbStudentsDirection.SelectedItem.ToString()]}"
				);
			toolStripStatusLabel.Text = $"{status_message[0]}: {dgvStudents.RowCount - 1}";
		}

		private void buttonAddStudent_Click(object sender, EventArgs e)
		{
			studentForm = new StudentForm();
			studentForm.ShowDialog();

			dgvStudents.DataSource = connector.Select(queries[0].ToString());
			toolStripStatusLabel.Text = $"{status_message[0]}: {dgvStudents.Rows.Count - 1}";
		}

		private void dgvStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			int choosenStudentId = Convert.ToInt32(dgvStudents.Rows[e.RowIndex].Cells["stud_id"].Value);

			StudentForm studentForm = new StudentForm(choosenStudentId);
			studentForm.ShowDialog();
			dgvStudents.DataSource = connector.Select(queries[0].ToString());
		}
	}
}