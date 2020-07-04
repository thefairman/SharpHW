namespace Organizer
{
    partial class AddOrEditEventForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.comboBoxPriorVal = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDateEvent = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDurationEvent = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTimeEvent = new System.Windows.Forms.DateTimePicker();
            this.buttonAddEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя заметки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Описание заметки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Приоритет:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата и время:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Продолжительность:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(87, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(370, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(144, 33);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(313, 115);
            this.textBoxDescription.TabIndex = 6;
            // 
            // comboBoxPriorVal
            // 
            this.comboBoxPriorVal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPriorVal.FormattingEnabled = true;
            this.comboBoxPriorVal.Location = new System.Drawing.Point(6, 127);
            this.comboBoxPriorVal.Name = "comboBoxPriorVal";
            this.comboBoxPriorVal.Size = new System.Drawing.Size(132, 21);
            this.comboBoxPriorVal.TabIndex = 7;
            // 
            // dateTimePickerDateEvent
            // 
            this.dateTimePickerDateEvent.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateEvent.Location = new System.Drawing.Point(6, 173);
            this.dateTimePickerDateEvent.Name = "dateTimePickerDateEvent";
            this.dateTimePickerDateEvent.Size = new System.Drawing.Size(92, 20);
            this.dateTimePickerDateEvent.TabIndex = 8;
            // 
            // dateTimePickerDurationEvent
            // 
            this.dateTimePickerDurationEvent.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerDurationEvent.Location = new System.Drawing.Point(209, 173);
            this.dateTimePickerDurationEvent.Name = "dateTimePickerDurationEvent";
            this.dateTimePickerDurationEvent.ShowUpDown = true;
            this.dateTimePickerDurationEvent.Size = new System.Drawing.Size(72, 20);
            this.dateTimePickerDurationEvent.TabIndex = 9;
            this.dateTimePickerDurationEvent.Value = new System.DateTime(2020, 7, 3, 22, 42, 24, 0);
            // 
            // dateTimePickerTimeEvent
            // 
            this.dateTimePickerTimeEvent.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTimeEvent.Location = new System.Drawing.Point(104, 173);
            this.dateTimePickerTimeEvent.Name = "dateTimePickerTimeEvent";
            this.dateTimePickerTimeEvent.ShowUpDown = true;
            this.dateTimePickerTimeEvent.Size = new System.Drawing.Size(68, 20);
            this.dateTimePickerTimeEvent.TabIndex = 10;
            // 
            // buttonAddEvent
            // 
            this.buttonAddEvent.Location = new System.Drawing.Point(342, 156);
            this.buttonAddEvent.Name = "buttonAddEvent";
            this.buttonAddEvent.Size = new System.Drawing.Size(115, 37);
            this.buttonAddEvent.TabIndex = 11;
            this.buttonAddEvent.Text = "Готово";
            this.buttonAddEvent.UseVisualStyleBackColor = true;
            this.buttonAddEvent.Click += new System.EventHandler(this.buttonAddEvent_Click);
            // 
            // AddOrEditEventForm
            // 
            this.AcceptButton = this.buttonAddEvent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 203);
            this.Controls.Add(this.buttonAddEvent);
            this.Controls.Add(this.dateTimePickerTimeEvent);
            this.Controls.Add(this.dateTimePickerDurationEvent);
            this.Controls.Add(this.dateTimePickerDateEvent);
            this.Controls.Add(this.comboBoxPriorVal);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddOrEditEventForm";
            this.Text = "Add or Edit event";
            this.Load += new System.EventHandler(this.AddEventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.ComboBox comboBoxPriorVal;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateEvent;
        private System.Windows.Forms.DateTimePicker dateTimePickerDurationEvent;
        private System.Windows.Forms.DateTimePicker dateTimePickerTimeEvent;
        private System.Windows.Forms.Button buttonAddEvent;
    }
}