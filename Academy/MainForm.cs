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
			if (studentForm.ShowDialog() == DialogResult.OK)
				tabControl_SelectedIndexChanged(tabControl, null);
		}
	}
}