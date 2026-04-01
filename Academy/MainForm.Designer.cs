namespace Academy
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageStudents = new System.Windows.Forms.TabPage();
			this.cbStudentsDirection = new System.Windows.Forms.ComboBox();
			this.cbStudentsGroups = new System.Windows.Forms.ComboBox();
			this.dgvStudents = new System.Windows.Forms.DataGridView();
			this.tabPageGroups = new System.Windows.Forms.TabPage();
			this.cbGroupDirection = new System.Windows.Forms.ComboBox();
			this.dgvGroups = new System.Windows.Forms.DataGridView();
			this.tabPageDirections = new System.Windows.Forms.TabPage();
			this.cbDirections = new System.Windows.Forms.ComboBox();
			this.dgvDirections = new System.Windows.Forms.DataGridView();
			this.tabPageDisciplines = new System.Windows.Forms.TabPage();
			this.cbDisciplines = new System.Windows.Forms.ComboBox();
			this.dgvDisciplines = new System.Windows.Forms.DataGridView();
			this.tabPageTeachers = new System.Windows.Forms.TabPage();
			this.cbTerachers = new System.Windows.Forms.ComboBox();
			this.dgvTeachers = new System.Windows.Forms.DataGridView();
			this.buttonAddStudents = new System.Windows.Forms.Button();
			this.buttonAddGroups = new System.Windows.Forms.Button();
			this.buttonAddTeacher = new System.Windows.Forms.Button();
			this.statusStrip.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabPageStudents.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
			this.tabPageGroups.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
			this.tabPageDirections.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDirections)).BeginInit();
			this.tabPageDisciplines.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDisciplines)).BeginInit();
			this.tabPageTeachers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 428);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(800, 22);
			this.statusStrip.TabIndex = 0;
			this.statusStrip.Text = "statusStrip1";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(118, 17);
			this.toolStripStatusLabel.Text = "toolStripStatusLabel1";
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageStudents);
			this.tabControl.Controls.Add(this.tabPageGroups);
			this.tabControl.Controls.Add(this.tabPageDirections);
			this.tabControl.Controls.Add(this.tabPageDisciplines);
			this.tabControl.Controls.Add(this.tabPageTeachers);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Multiline = true;
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(800, 428);
			this.tabControl.TabIndex = 1;
			this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
			// 
			// tabPageStudents
			// 
			this.tabPageStudents.Controls.Add(this.buttonAddStudents);
			this.tabPageStudents.Controls.Add(this.cbStudentsDirection);
			this.tabPageStudents.Controls.Add(this.cbStudentsGroups);
			this.tabPageStudents.Controls.Add(this.dgvStudents);
			this.tabPageStudents.Location = new System.Drawing.Point(4, 22);
			this.tabPageStudents.Name = "tabPageStudents";
			this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageStudents.Size = new System.Drawing.Size(792, 402);
			this.tabPageStudents.TabIndex = 0;
			this.tabPageStudents.Text = "Students";
			this.tabPageStudents.UseVisualStyleBackColor = true;
			// 
			// cbStudentsDirection
			// 
			this.cbStudentsDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbStudentsDirection.FormattingEnabled = true;
			this.cbStudentsDirection.Location = new System.Drawing.Point(209, 6);
			this.cbStudentsDirection.Name = "cbStudentsDirection";
			this.cbStudentsDirection.Size = new System.Drawing.Size(344, 21);
			this.cbStudentsDirection.TabIndex = 3;
			this.cbStudentsDirection.SelectedIndexChanged += new System.EventHandler(this.cbStudentsDirection_SelectedIndexChanged);
			// 
			// cbStudentsGroups
			// 
			this.cbStudentsGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbStudentsGroups.FormattingEnabled = true;
			this.cbStudentsGroups.Location = new System.Drawing.Point(29, 6);
			this.cbStudentsGroups.Name = "cbStudentsGroups";
			this.cbStudentsGroups.Size = new System.Drawing.Size(119, 21);
			this.cbStudentsGroups.TabIndex = 2;
			// 
			// dgvStudents
			// 
			this.dgvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStudents.Location = new System.Drawing.Point(8, 30);
			this.dgvStudents.Name = "dgvStudents";
			this.dgvStudents.Size = new System.Drawing.Size(776, 366);
			this.dgvStudents.TabIndex = 1;
			// 
			// tabPageGroups
			// 
			this.tabPageGroups.Controls.Add(this.buttonAddGroups);
			this.tabPageGroups.Controls.Add(this.cbGroupDirection);
			this.tabPageGroups.Controls.Add(this.dgvGroups);
			this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
			this.tabPageGroups.Name = "tabPageGroups";
			this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGroups.Size = new System.Drawing.Size(792, 402);
			this.tabPageGroups.TabIndex = 1;
			this.tabPageGroups.Text = "Groups";
			this.tabPageGroups.UseVisualStyleBackColor = true;
			// 
			// cbGroupDirection
			// 
			this.cbGroupDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbGroupDirection.FormattingEnabled = true;
			this.cbGroupDirection.Location = new System.Drawing.Point(8, 6);
			this.cbGroupDirection.Name = "cbGroupDirection";
			this.cbGroupDirection.Size = new System.Drawing.Size(396, 21);
			this.cbGroupDirection.TabIndex = 2;
			this.cbGroupDirection.SelectedIndexChanged += new System.EventHandler(this.cbGroupDirection_SelectedIndexChanged);
			// 
			// dgvGroups
			// 
			this.dgvGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvGroups.Location = new System.Drawing.Point(8, 30);
			this.dgvGroups.Name = "dgvGroups";
			this.dgvGroups.Size = new System.Drawing.Size(776, 366);
			this.dgvGroups.TabIndex = 1;
			// 
			// tabPageDirections
			// 
			this.tabPageDirections.Controls.Add(this.cbDirections);
			this.tabPageDirections.Controls.Add(this.dgvDirections);
			this.tabPageDirections.Location = new System.Drawing.Point(4, 22);
			this.tabPageDirections.Name = "tabPageDirections";
			this.tabPageDirections.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDirections.Size = new System.Drawing.Size(792, 402);
			this.tabPageDirections.TabIndex = 2;
			this.tabPageDirections.Text = "Directions";
			this.tabPageDirections.UseVisualStyleBackColor = true;
			// 
			// cbDirections
			// 
			this.cbDirections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDirections.FormattingEnabled = true;
			this.cbDirections.Location = new System.Drawing.Point(73, 6);
			this.cbDirections.Name = "cbDirections";
			this.cbDirections.Size = new System.Drawing.Size(390, 21);
			this.cbDirections.TabIndex = 1;
			this.cbDirections.SelectedIndexChanged += new System.EventHandler(this.cbDirections_SelectedIndexChanged);
			// 
			// dgvDirections
			// 
			this.dgvDirections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvDirections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvDirections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDirections.Location = new System.Drawing.Point(8, 30);
			this.dgvDirections.Name = "dgvDirections";
			this.dgvDirections.Size = new System.Drawing.Size(776, 366);
			this.dgvDirections.TabIndex = 0;
			// 
			// tabPageDisciplines
			// 
			this.tabPageDisciplines.Controls.Add(this.cbDisciplines);
			this.tabPageDisciplines.Controls.Add(this.dgvDisciplines);
			this.tabPageDisciplines.Location = new System.Drawing.Point(4, 22);
			this.tabPageDisciplines.Name = "tabPageDisciplines";
			this.tabPageDisciplines.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDisciplines.Size = new System.Drawing.Size(792, 402);
			this.tabPageDisciplines.TabIndex = 3;
			this.tabPageDisciplines.Text = "Disciplines";
			this.tabPageDisciplines.UseVisualStyleBackColor = true;
			// 
			// cbDisciplines
			// 
			this.cbDisciplines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDisciplines.FormattingEnabled = true;
			this.cbDisciplines.Location = new System.Drawing.Point(114, 3);
			this.cbDisciplines.Name = "cbDisciplines";
			this.cbDisciplines.Size = new System.Drawing.Size(424, 21);
			this.cbDisciplines.TabIndex = 2;
			this.cbDisciplines.SelectedIndexChanged += new System.EventHandler(this.cbDisciplines_SelectedIndexChanged);
			// 
			// dgvDisciplines
			// 
			this.dgvDisciplines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvDisciplines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvDisciplines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDisciplines.Location = new System.Drawing.Point(6, 30);
			this.dgvDisciplines.Name = "dgvDisciplines";
			this.dgvDisciplines.Size = new System.Drawing.Size(776, 366);
			this.dgvDisciplines.TabIndex = 1;
			// 
			// tabPageTeachers
			// 
			this.tabPageTeachers.Controls.Add(this.buttonAddTeacher);
			this.tabPageTeachers.Controls.Add(this.cbTerachers);
			this.tabPageTeachers.Controls.Add(this.dgvTeachers);
			this.tabPageTeachers.Location = new System.Drawing.Point(4, 22);
			this.tabPageTeachers.Name = "tabPageTeachers";
			this.tabPageTeachers.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageTeachers.Size = new System.Drawing.Size(792, 402);
			this.tabPageTeachers.TabIndex = 4;
			this.tabPageTeachers.Text = "Teachers";
			this.tabPageTeachers.UseVisualStyleBackColor = true;
			// 
			// cbTerachers
			// 
			this.cbTerachers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTerachers.FormattingEnabled = true;
			this.cbTerachers.Location = new System.Drawing.Point(21, 6);
			this.cbTerachers.Name = "cbTerachers";
			this.cbTerachers.Size = new System.Drawing.Size(394, 21);
			this.cbTerachers.TabIndex = 2;
			this.cbTerachers.SelectedIndexChanged += new System.EventHandler(this.cbTerachers_SelectedIndexChanged);
			// 
			// dgvTeachers
			// 
			this.dgvTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTeachers.Location = new System.Drawing.Point(6, 33);
			this.dgvTeachers.Name = "dgvTeachers";
			this.dgvTeachers.Size = new System.Drawing.Size(776, 366);
			this.dgvTeachers.TabIndex = 1;
			// 
			// buttonAddStudents
			// 
			this.buttonAddStudents.Location = new System.Drawing.Point(657, 6);
			this.buttonAddStudents.Name = "buttonAddStudents";
			this.buttonAddStudents.Size = new System.Drawing.Size(127, 23);
			this.buttonAddStudents.TabIndex = 4;
			this.buttonAddStudents.Text = "Add Students";
			this.buttonAddStudents.UseVisualStyleBackColor = true;
			this.buttonAddStudents.Click += new System.EventHandler(this.buttonAddStudents_Click);
			// 
			// buttonAddGroups
			// 
			this.buttonAddGroups.Location = new System.Drawing.Point(659, 6);
			this.buttonAddGroups.Name = "buttonAddGroups";
			this.buttonAddGroups.Size = new System.Drawing.Size(125, 23);
			this.buttonAddGroups.TabIndex = 5;
			this.buttonAddGroups.Text = "Add Group";
			this.buttonAddGroups.UseVisualStyleBackColor = true;
			this.buttonAddGroups.Click += new System.EventHandler(this.buttonAddGroups_Click);
			// 
			// buttonAddTeacher
			// 
			this.buttonAddTeacher.Location = new System.Drawing.Point(655, 6);
			this.buttonAddTeacher.Name = "buttonAddTeacher";
			this.buttonAddTeacher.Size = new System.Drawing.Size(127, 23);
			this.buttonAddTeacher.TabIndex = 5;
			this.buttonAddTeacher.Text = "Add Teacher";
			this.buttonAddTeacher.UseVisualStyleBackColor = true;
			this.buttonAddTeacher.Click += new System.EventHandler(this.buttonAddTeacher_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.statusStrip);
			this.Name = "MainForm";
			this.Text = "Academy PV_521";
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.tabPageStudents.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
			this.tabPageGroups.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
			this.tabPageDirections.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDirections)).EndInit();
			this.tabPageDisciplines.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDisciplines)).EndInit();
			this.tabPageTeachers.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageStudents;
		private System.Windows.Forms.TabPage tabPageGroups;
		private System.Windows.Forms.TabPage tabPageDirections;
		private System.Windows.Forms.DataGridView dgvDirections;
		private System.Windows.Forms.TabPage tabPageDisciplines;
		private System.Windows.Forms.TabPage tabPageTeachers;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.DataGridView dgvStudents;
		private System.Windows.Forms.DataGridView dgvGroups;
		private System.Windows.Forms.DataGridView dgvDisciplines;
		private System.Windows.Forms.DataGridView dgvTeachers;
		private System.Windows.Forms.ComboBox cbGroupDirection;
		private System.Windows.Forms.ComboBox cbStudentsDirection;
		private System.Windows.Forms.ComboBox cbStudentsGroups;
		private System.Windows.Forms.ComboBox cbDirections;
		private System.Windows.Forms.ComboBox cbDisciplines;
		private System.Windows.Forms.ComboBox cbTerachers;
		private System.Windows.Forms.Button buttonAddStudents;
		private System.Windows.Forms.Button buttonAddGroups;
		private System.Windows.Forms.Button buttonAddTeacher;
	}
}

