using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Configuration;
using DBTools;
using Microsoft.Win32;
using System.Data;

namespace AcademyWPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		Query[] queries =
		{
			new Query
				(
				"stud_id,last_name,first_name,middle_name,group_name,direction_name",
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
			new Query("*", "Teachers"),
		};
		string[] status_messages =
		{
			"Количество студентов",
			"Количество групп",
			"Количество направлений",
			"Количество дисциплин",
			"Количество преподавателей"
		};
		Connector connector;
		DataGrid[] tables;
		private Dictionary<string, int> d_directions;
		private Dictionary<string, int> d_groups;
		public MainWindow()
		{
			InitializeComponent();
			connector = new Connector(ConfigurationManager.ConnectionStrings["PV_521_Import"].ConnectionString);
			tables = new DataGrid[] { dgvStudents, dgvGroups, dgvDirections, dgvDisciplines, dgvTeachers };

			d_groups = connector.GetDictionary("Groups");
			d_directions = connector.GetDictionary("Directions");

			List<string> l_direction = new List<string> { "" };
			l_direction.AddRange(d_directions.Keys);
			cbDirections_dgvStudents.ItemsSource = l_direction;

			List<string> l_groups = new List<string> { "" };
			l_groups.AddRange(d_groups.Keys);
			cbGroups_dgvStudents.ItemsSource = l_groups;

			tabCotrol.SelectedIndex = 0;
		}

		private void tabCotrol_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			int i = (sender as TabControl).SelectedIndex;
			tables[i].ItemsSource = connector.
				Select($"SELECT * FROM {((sender as TabControl).Items[i] as TabItem).Header.ToString()}").DefaultView;
			statusBarCount.Text = $"Количество записей: {tables[i].Items.Count - 1}";
		}
		private void cbDirections_dgvStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			
        }
		private void cbGroups_dgvStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			//dgvGroups.ItemsSource = connector.Select
			//	(
			//		queries[1].ToString() +
			//		$" AND Direction={d_directions[cbDirections_dgvStudents.SelectedItem.ToString()]}"
			//	);
        }
		private void btnClearFilters_dgvStudents_Click(object sender, RoutedEventArgs e)
		{
			cbGroups_dgvStudents.SelectedItem= null;
			cbDirections_dgvStudents.SelectedItem = null;
        }

    }
}
