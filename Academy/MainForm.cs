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
				"last_name,first_name,middle_name,group_name,direction_name",
				"Students,Groups,Directions",
				"[group]=group_id AND direction=direction_id"
				),
			new Query
				(
				"*",
				"Groups,Directions",
				"direction=direction_id"
				),
			new Query("*", "Directions"),
			new Query("*", "Disciplines"),
			new Query("*", "Teachers")
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
		public static Dictionary<string, int> d_directions;
		Dictionary<string, int> d_groups;
		Dictionary<string, int> d_disciplines;
		Dictionary<string, int> d_teachers;
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
			d_disciplines = connector.GetDictionary("Disciplines");
			d_teachers = connector.GetDictionary("Teachers");

			cbStudentsGroups.Items.AddRange(d_groups.Keys.ToArray());
			cbGroupDirection.Items.AddRange(d_directions.Keys.ToArray());
			cbStudentsDirection.Items.AddRange(d_directions.Keys.ToArray());
			cbDirections.Items.AddRange(d_directions.Keys.ToArray());
			cbDisciplines.Items.AddRange(d_disciplines.Keys.ToArray());
			cbTerachers.Items.AddRange(d_teachers.Keys.ToArray());
		}

		private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			int i = tabControl.SelectedIndex;
			tables[i].DataSource = connector.Select(queries[i].ToString());
			toolStripStatusLabel.Text = $"{status_message[i]}: {tables[i].RowCount - 1}";
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
					queries[0].ToString() +
					$" AND direction={d_directions[cbStudentsDirection.SelectedItem.ToString()]}"
				);
			toolStripStatusLabel.Text = $"{status_message[0]}: {dgvStudents.RowCount - 1}";
		}

		private void cbDirections_SelectedIndexChanged(object sender, EventArgs e)
		{
			dgvDirections.DataSource = connector.Select
				(
					queries[2].ToString() +
					$" WHERE direction_id={d_directions[cbDirections.SelectedItem.ToString()]}"
				);

			toolStripStatusLabel.Text = $"{status_message[2]}: {dgvDirections.RowCount - 1}";
		}

		private void cbDisciplines_SelectedIndexChanged(object sender, EventArgs e)
		{
			dgvDisciplines.DataSource = connector.Select
				(
					queries[3].ToString() +
					$" WHERE discipline_id={d_disciplines[cbDisciplines.SelectedItem.ToString()]}"
				);
			toolStripStatusLabel.Text = $"{status_message[3]}: {dgvDisciplines.RowCount - 1}";
		}

		private void cbTerachers_SelectedIndexChanged(object sender, EventArgs e)
		{
			dgvTeachers.DataSource = connector.Select
				(
					queries[4].ToString() +
					$" WHERE teacher_id={d_teachers[cbTerachers.SelectedItem.ToString()]}"
				);
			toolStripStatusLabel.Text = $"{status_message[4]}: {dgvTeachers.RowCount - 1}";
		}

		private void buttonAddStudents_Click(object sender, EventArgs e)
		{
			AddForm addForm = new AddForm(sender);
			addForm.ShowDialog();
		}

		private void buttonAddTeacher_Click(object sender, EventArgs e)
		{
			AddForm addForm = new AddForm(sender);
			addForm.ShowDialog();
		}

		private void buttonAddGroups_Click(object sender, EventArgs e)
		{
			AddForm addForm = new AddForm(sender);
			addForm.ShowDialog();
		}
		public static void AddToDB(string tables, string fields, string values)
		{

		}
	}
}