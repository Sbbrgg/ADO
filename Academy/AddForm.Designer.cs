namespace Academy
{
	partial class AddForm
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
			this.TBADDLast_name = new System.Windows.Forms.TextBox();
			this.TBADDFirst_name = new System.Windows.Forms.TextBox();
			this.TBADDMiddle_name = new System.Windows.Forms.TextBox();
			this.TBADDLast_name_PlaceHolder = new System.Windows.Forms.TextBox();
			this.TBADDFirst_name_PlaceHolder = new System.Windows.Forms.TextBox();
			this.TBADDMiddle_name_PlaceHolder = new System.Windows.Forms.TextBox();
			this.TBADDBirth_date_PlaceHolder = new System.Windows.Forms.TextBox();
			this.chekBoxAddGroup = new System.Windows.Forms.CheckBox();
			this.checkBoxAddStudents = new System.Windows.Forms.CheckBox();
			this.checkBoxAddTeacher = new System.Windows.Forms.CheckBox();
			this.TBADDGroup_name_PlaceHolder = new System.Windows.Forms.TextBox();
			this.TBADDDirection_name_PlaceHolder = new System.Windows.Forms.TextBox();
			this.TBADDGroup_name = new System.Windows.Forms.TextBox();
			this.TBADDDirection_name = new System.Windows.Forms.TextBox();
			this.buttonAddElement = new System.Windows.Forms.Button();
			this.TBADDBirth_date = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// TBADDLast_name
			// 
			this.TBADDLast_name.Location = new System.Drawing.Point(170, 100);
			this.TBADDLast_name.Name = "TBADDLast_name";
			this.TBADDLast_name.Size = new System.Drawing.Size(242, 20);
			this.TBADDLast_name.TabIndex = 0;
			// 
			// TBADDFirst_name
			// 
			this.TBADDFirst_name.Location = new System.Drawing.Point(170, 126);
			this.TBADDFirst_name.Name = "TBADDFirst_name";
			this.TBADDFirst_name.Size = new System.Drawing.Size(242, 20);
			this.TBADDFirst_name.TabIndex = 1;
			// 
			// TBADDMiddle_name
			// 
			this.TBADDMiddle_name.Location = new System.Drawing.Point(170, 152);
			this.TBADDMiddle_name.Name = "TBADDMiddle_name";
			this.TBADDMiddle_name.Size = new System.Drawing.Size(242, 20);
			this.TBADDMiddle_name.TabIndex = 2;
			// 
			// TBADDLast_name_PlaceHolder
			// 
			this.TBADDLast_name_PlaceHolder.Enabled = false;
			this.TBADDLast_name_PlaceHolder.Location = new System.Drawing.Point(13, 100);
			this.TBADDLast_name_PlaceHolder.Name = "TBADDLast_name_PlaceHolder";
			this.TBADDLast_name_PlaceHolder.Size = new System.Drawing.Size(131, 20);
			this.TBADDLast_name_PlaceHolder.TabIndex = 5;
			this.TBADDLast_name_PlaceHolder.Text = "Фамилия";
			// 
			// TBADDFirst_name_PlaceHolder
			// 
			this.TBADDFirst_name_PlaceHolder.Enabled = false;
			this.TBADDFirst_name_PlaceHolder.Location = new System.Drawing.Point(13, 126);
			this.TBADDFirst_name_PlaceHolder.Name = "TBADDFirst_name_PlaceHolder";
			this.TBADDFirst_name_PlaceHolder.Size = new System.Drawing.Size(131, 20);
			this.TBADDFirst_name_PlaceHolder.TabIndex = 6;
			this.TBADDFirst_name_PlaceHolder.Text = "Имя";
			// 
			// TBADDMiddle_name_PlaceHolder
			// 
			this.TBADDMiddle_name_PlaceHolder.Enabled = false;
			this.TBADDMiddle_name_PlaceHolder.Location = new System.Drawing.Point(13, 152);
			this.TBADDMiddle_name_PlaceHolder.Name = "TBADDMiddle_name_PlaceHolder";
			this.TBADDMiddle_name_PlaceHolder.Size = new System.Drawing.Size(131, 20);
			this.TBADDMiddle_name_PlaceHolder.TabIndex = 7;
			this.TBADDMiddle_name_PlaceHolder.Text = "Отчество";
			// 
			// TBADDBirth_date_PlaceHolder
			// 
			this.TBADDBirth_date_PlaceHolder.Enabled = false;
			this.TBADDBirth_date_PlaceHolder.Location = new System.Drawing.Point(13, 178);
			this.TBADDBirth_date_PlaceHolder.Name = "TBADDBirth_date_PlaceHolder";
			this.TBADDBirth_date_PlaceHolder.Size = new System.Drawing.Size(131, 20);
			this.TBADDBirth_date_PlaceHolder.TabIndex = 8;
			this.TBADDBirth_date_PlaceHolder.Text = "Дата Рождения";
			// 
			// chekBoxAddGroup
			// 
			this.chekBoxAddGroup.AutoSize = true;
			this.chekBoxAddGroup.Location = new System.Drawing.Point(12, 12);
			this.chekBoxAddGroup.Name = "chekBoxAddGroup";
			this.chekBoxAddGroup.Size = new System.Drawing.Size(113, 17);
			this.chekBoxAddGroup.TabIndex = 10;
			this.chekBoxAddGroup.Text = "Добавить Группу";
			this.chekBoxAddGroup.UseVisualStyleBackColor = true;
			this.chekBoxAddGroup.CheckedChanged += new System.EventHandler(this.chekBoxAddGroup_CheckedChanged);
			// 
			// checkBoxAddStudents
			// 
			this.checkBoxAddStudents.AutoSize = true;
			this.checkBoxAddStudents.Location = new System.Drawing.Point(131, 12);
			this.checkBoxAddStudents.Name = "checkBoxAddStudents";
			this.checkBoxAddStudents.Size = new System.Drawing.Size(125, 17);
			this.checkBoxAddStudents.TabIndex = 11;
			this.checkBoxAddStudents.Text = "Добавить Студента";
			this.checkBoxAddStudents.UseVisualStyleBackColor = true;
			this.checkBoxAddStudents.CheckedChanged += new System.EventHandler(this.checkBoxAddStudents_CheckedChanged);
			// 
			// checkBoxAddTeacher
			// 
			this.checkBoxAddTeacher.AutoSize = true;
			this.checkBoxAddTeacher.Location = new System.Drawing.Point(262, 12);
			this.checkBoxAddTeacher.Name = "checkBoxAddTeacher";
			this.checkBoxAddTeacher.Size = new System.Drawing.Size(121, 17);
			this.checkBoxAddTeacher.TabIndex = 12;
			this.checkBoxAddTeacher.Text = "Добавить Учителя";
			this.checkBoxAddTeacher.UseVisualStyleBackColor = true;
			this.checkBoxAddTeacher.CheckedChanged += new System.EventHandler(this.checkBoxAddTeacher_CheckedChanged);
			// 
			// TBADDGroup_name_PlaceHolder
			// 
			this.TBADDGroup_name_PlaceHolder.Enabled = false;
			this.TBADDGroup_name_PlaceHolder.Location = new System.Drawing.Point(13, 48);
			this.TBADDGroup_name_PlaceHolder.Name = "TBADDGroup_name_PlaceHolder";
			this.TBADDGroup_name_PlaceHolder.Size = new System.Drawing.Size(131, 20);
			this.TBADDGroup_name_PlaceHolder.TabIndex = 13;
			this.TBADDGroup_name_PlaceHolder.Text = "Название группы";
			// 
			// TBADDDirection_name_PlaceHolder
			// 
			this.TBADDDirection_name_PlaceHolder.Enabled = false;
			this.TBADDDirection_name_PlaceHolder.Location = new System.Drawing.Point(13, 74);
			this.TBADDDirection_name_PlaceHolder.Name = "TBADDDirection_name_PlaceHolder";
			this.TBADDDirection_name_PlaceHolder.Size = new System.Drawing.Size(131, 20);
			this.TBADDDirection_name_PlaceHolder.TabIndex = 14;
			this.TBADDDirection_name_PlaceHolder.Text = "Направление обучения";
			// 
			// TBADDGroup_name
			// 
			this.TBADDGroup_name.Location = new System.Drawing.Point(170, 48);
			this.TBADDGroup_name.Name = "TBADDGroup_name";
			this.TBADDGroup_name.Size = new System.Drawing.Size(242, 20);
			this.TBADDGroup_name.TabIndex = 15;
			// 
			// TBADDDirection_name
			// 
			this.TBADDDirection_name.Location = new System.Drawing.Point(170, 74);
			this.TBADDDirection_name.Name = "TBADDDirection_name";
			this.TBADDDirection_name.Size = new System.Drawing.Size(242, 20);
			this.TBADDDirection_name.TabIndex = 16;
			// 
			// buttonAddElement
			// 
			this.buttonAddElement.Location = new System.Drawing.Point(155, 255);
			this.buttonAddElement.Name = "buttonAddElement";
			this.buttonAddElement.Size = new System.Drawing.Size(75, 23);
			this.buttonAddElement.TabIndex = 17;
			this.buttonAddElement.Text = "Добавить";
			this.buttonAddElement.UseVisualStyleBackColor = true;
			this.buttonAddElement.Click += new System.EventHandler(this.buttonAddElement_Click);
			// 
			// TBADDBirth_date
			// 
			this.TBADDBirth_date.Location = new System.Drawing.Point(170, 178);
			this.TBADDBirth_date.Name = "TBADDBirth_date";
			this.TBADDBirth_date.Size = new System.Drawing.Size(242, 20);
			this.TBADDBirth_date.TabIndex = 18;
			// 
			// AddForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(424, 319);
			this.Controls.Add(this.TBADDBirth_date);
			this.Controls.Add(this.buttonAddElement);
			this.Controls.Add(this.TBADDDirection_name);
			this.Controls.Add(this.TBADDGroup_name);
			this.Controls.Add(this.TBADDDirection_name_PlaceHolder);
			this.Controls.Add(this.TBADDGroup_name_PlaceHolder);
			this.Controls.Add(this.checkBoxAddTeacher);
			this.Controls.Add(this.checkBoxAddStudents);
			this.Controls.Add(this.chekBoxAddGroup);
			this.Controls.Add(this.TBADDBirth_date_PlaceHolder);
			this.Controls.Add(this.TBADDMiddle_name_PlaceHolder);
			this.Controls.Add(this.TBADDFirst_name_PlaceHolder);
			this.Controls.Add(this.TBADDLast_name_PlaceHolder);
			this.Controls.Add(this.TBADDMiddle_name);
			this.Controls.Add(this.TBADDFirst_name);
			this.Controls.Add(this.TBADDLast_name);
			this.Name = "AddForm";
			this.Text = "AddForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TBADDLast_name;
		private System.Windows.Forms.TextBox TBADDFirst_name;
		private System.Windows.Forms.TextBox TBADDMiddle_name;
		private System.Windows.Forms.TextBox TBADDLast_name_PlaceHolder;
		private System.Windows.Forms.TextBox TBADDFirst_name_PlaceHolder;
		private System.Windows.Forms.TextBox TBADDMiddle_name_PlaceHolder;
		private System.Windows.Forms.TextBox TBADDBirth_date_PlaceHolder;
		private System.Windows.Forms.CheckBox chekBoxAddGroup;
		private System.Windows.Forms.CheckBox checkBoxAddStudents;
		private System.Windows.Forms.CheckBox checkBoxAddTeacher;
		private System.Windows.Forms.TextBox TBADDGroup_name_PlaceHolder;
		private System.Windows.Forms.TextBox TBADDDirection_name_PlaceHolder;
		private System.Windows.Forms.TextBox TBADDGroup_name;
		private System.Windows.Forms.TextBox TBADDDirection_name;
		private System.Windows.Forms.Button buttonAddElement;
		private System.Windows.Forms.DateTimePicker TBADDBirth_date;
	}
}