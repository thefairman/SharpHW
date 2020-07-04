namespace Organizer
{
    partial class EventsViewForm
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
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.buttonAddEvent = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxDesc = new System.Windows.Forms.CheckBox();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.radioButtonPriority = new System.Windows.Forms.RadioButton();
            this.radioButtonDate = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxSearchInRes = new System.Windows.Forms.CheckBox();
            this.buttonClearSearch = new System.Windows.Forms.Button();
            this.comboBoxSeacrhPriorVal = new System.Windows.Forms.ComboBox();
            this.textBoxSearchVal = new System.Windows.Forms.TextBox();
            this.comboBoxSearchType = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonEditEvent = new System.Windows.Forms.Button();
            this.buttonDelEvent = new System.Windows.Forms.Button();
            this.radioButtonNoneSort = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(12, 12);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(220, 407);
            this.listBoxEvents.TabIndex = 0;
            // 
            // buttonAddEvent
            // 
            this.buttonAddEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddEvent.Location = new System.Drawing.Point(238, 264);
            this.buttonAddEvent.Name = "buttonAddEvent";
            this.buttonAddEvent.Size = new System.Drawing.Size(75, 23);
            this.buttonAddEvent.TabIndex = 1;
            this.buttonAddEvent.Text = "Добавить";
            this.buttonAddEvent.UseVisualStyleBackColor = true;
            this.buttonAddEvent.Click += new System.EventHandler(this.buttonAddEvent_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioButtonNoneSort);
            this.groupBox1.Controls.Add(this.checkBoxDesc);
            this.groupBox1.Controls.Add(this.radioButtonName);
            this.groupBox1.Controls.Add(this.radioButtonPriority);
            this.groupBox1.Controls.Add(this.radioButtonDate);
            this.groupBox1.Location = new System.Drawing.Point(238, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 90);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // checkBoxDesc
            // 
            this.checkBoxDesc.AutoSize = true;
            this.checkBoxDesc.Location = new System.Drawing.Point(7, 19);
            this.checkBoxDesc.Name = "checkBoxDesc";
            this.checkBoxDesc.Size = new System.Drawing.Size(51, 17);
            this.checkBoxDesc.TabIndex = 3;
            this.checkBoxDesc.Text = "Desc";
            this.checkBoxDesc.UseVisualStyleBackColor = true;
            this.checkBoxDesc.CheckedChanged += new System.EventHandler(this.SortOptionsChanged_CheckedChanged);
            // 
            // radioButtonName
            // 
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.Location = new System.Drawing.Point(6, 66);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(74, 17);
            this.radioButtonName.TabIndex = 2;
            this.radioButtonName.Text = "По имени";
            this.radioButtonName.UseVisualStyleBackColor = true;
            this.radioButtonName.CheckedChanged += new System.EventHandler(this.SortOptionsChanged_CheckedChanged);
            // 
            // radioButtonPriority
            // 
            this.radioButtonPriority.AutoSize = true;
            this.radioButtonPriority.Location = new System.Drawing.Point(86, 66);
            this.radioButtonPriority.Name = "radioButtonPriority";
            this.radioButtonPriority.Size = new System.Drawing.Size(99, 17);
            this.radioButtonPriority.TabIndex = 1;
            this.radioButtonPriority.Text = "По приоритету";
            this.radioButtonPriority.UseVisualStyleBackColor = true;
            this.radioButtonPriority.CheckedChanged += new System.EventHandler(this.SortOptionsChanged_CheckedChanged);
            // 
            // radioButtonDate
            // 
            this.radioButtonDate.AutoSize = true;
            this.radioButtonDate.Location = new System.Drawing.Point(86, 43);
            this.radioButtonDate.Name = "radioButtonDate";
            this.radioButtonDate.Size = new System.Drawing.Size(65, 17);
            this.radioButtonDate.TabIndex = 0;
            this.radioButtonDate.Text = "По дате";
            this.radioButtonDate.UseVisualStyleBackColor = true;
            this.radioButtonDate.CheckedChanged += new System.EventHandler(this.SortOptionsChanged_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.checkBoxSearchInRes);
            this.groupBox2.Controls.Add(this.buttonClearSearch);
            this.groupBox2.Controls.Add(this.comboBoxSeacrhPriorVal);
            this.groupBox2.Controls.Add(this.textBoxSearchVal);
            this.groupBox2.Controls.Add(this.comboBoxSearchType);
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Location = new System.Drawing.Point(238, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 131);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск";
            // 
            // checkBoxSearchInRes
            // 
            this.checkBoxSearchInRes.AutoSize = true;
            this.checkBoxSearchInRes.Location = new System.Drawing.Point(111, 19);
            this.checkBoxSearchInRes.Name = "checkBoxSearchInRes";
            this.checkBoxSearchInRes.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSearchInRes.TabIndex = 6;
            this.checkBoxSearchInRes.UseVisualStyleBackColor = true;
            // 
            // buttonClearSearch
            // 
            this.buttonClearSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearSearch.Location = new System.Drawing.Point(122, 103);
            this.buttonClearSearch.Name = "buttonClearSearch";
            this.buttonClearSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonClearSearch.TabIndex = 5;
            this.buttonClearSearch.Text = "Сбросить";
            this.buttonClearSearch.UseVisualStyleBackColor = true;
            this.buttonClearSearch.Click += new System.EventHandler(this.buttonClearSearch_Click);
            // 
            // comboBoxSeacrhPriorVal
            // 
            this.comboBoxSeacrhPriorVal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSeacrhPriorVal.FormattingEnabled = true;
            this.comboBoxSeacrhPriorVal.Location = new System.Drawing.Point(7, 56);
            this.comboBoxSeacrhPriorVal.Name = "comboBoxSeacrhPriorVal";
            this.comboBoxSeacrhPriorVal.Size = new System.Drawing.Size(187, 21);
            this.comboBoxSeacrhPriorVal.TabIndex = 4;
            // 
            // textBoxSearchVal
            // 
            this.textBoxSearchVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchVal.Location = new System.Drawing.Point(5, 56);
            this.textBoxSearchVal.Name = "textBoxSearchVal";
            this.textBoxSearchVal.Size = new System.Drawing.Size(192, 20);
            this.textBoxSearchVal.TabIndex = 3;
            // 
            // comboBoxSearchType
            // 
            this.comboBoxSearchType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchType.FormattingEnabled = true;
            this.comboBoxSearchType.Items.AddRange(new object[] {
            "По имени",
            "По приоритету",
            "По дате",
            "По описанию"});
            this.comboBoxSearchType.Location = new System.Drawing.Point(5, 19);
            this.comboBoxSearchType.Name = "comboBoxSearchType";
            this.comboBoxSearchType.Size = new System.Drawing.Size(100, 21);
            this.comboBoxSearchType.TabIndex = 2;
            this.comboBoxSearchType.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchType_SelectedIndexChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSearch.Location = new System.Drawing.Point(6, 103);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(167, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // buttonEditEvent
            // 
            this.buttonEditEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditEvent.Location = new System.Drawing.Point(341, 264);
            this.buttonEditEvent.Name = "buttonEditEvent";
            this.buttonEditEvent.Size = new System.Drawing.Size(100, 23);
            this.buttonEditEvent.TabIndex = 4;
            this.buttonEditEvent.Text = "Редактировать";
            this.buttonEditEvent.UseVisualStyleBackColor = true;
            this.buttonEditEvent.Click += new System.EventHandler(this.buttonEditEvent_Click);
            // 
            // buttonDelEvent
            // 
            this.buttonDelEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelEvent.Location = new System.Drawing.Point(366, 313);
            this.buttonDelEvent.Name = "buttonDelEvent";
            this.buttonDelEvent.Size = new System.Drawing.Size(75, 23);
            this.buttonDelEvent.TabIndex = 5;
            this.buttonDelEvent.Text = "Удалить";
            this.buttonDelEvent.UseVisualStyleBackColor = true;
            this.buttonDelEvent.Click += new System.EventHandler(this.buttonDelEvent_Click);
            // 
            // radioButtonNoneSort
            // 
            this.radioButtonNoneSort.AutoSize = true;
            this.radioButtonNoneSort.Checked = true;
            this.radioButtonNoneSort.Location = new System.Drawing.Point(7, 43);
            this.radioButtonNoneSort.Name = "radioButtonNoneSort";
            this.radioButtonNoneSort.Size = new System.Drawing.Size(44, 17);
            this.radioButtonNoneSort.TabIndex = 4;
            this.radioButtonNoneSort.TabStop = true;
            this.radioButtonNoneSort.Text = "Без";
            this.radioButtonNoneSort.UseVisualStyleBackColor = true;
            // 
            // EventsViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 438);
            this.Controls.Add(this.buttonDelEvent);
            this.Controls.Add(this.buttonEditEvent);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAddEvent);
            this.Controls.Add(this.listBoxEvents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EventsViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EventsViewForm";
            this.Load += new System.EventHandler(this.EventsViewForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Button buttonAddEvent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonDate;
        private System.Windows.Forms.RadioButton radioButtonName;
        private System.Windows.Forms.RadioButton radioButtonPriority;
        private System.Windows.Forms.CheckBox checkBoxDesc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxSearchType;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxSeacrhPriorVal;
        private System.Windows.Forms.TextBox textBoxSearchVal;
        private System.Windows.Forms.Button buttonClearSearch;
        private System.Windows.Forms.Button buttonEditEvent;
        private System.Windows.Forms.Button buttonDelEvent;
        private System.Windows.Forms.CheckBox checkBoxSearchInRes;
        private System.Windows.Forms.RadioButton radioButtonNoneSort;
    }
}