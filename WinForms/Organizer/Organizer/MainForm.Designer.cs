namespace Organizer
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.myEventsListControl1 = new EventsControl.MyEventsListControl();
            this.analogClock1 = new MyControlLibrary.AnalogClock();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonEventsManager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(503, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ближайшие события:";
            // 
            // myEventsListControl1
            // 
            this.myEventsListControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myEventsListControl1.AutoScroll = true;
            this.myEventsListControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.myEventsListControl1.Location = new System.Drawing.Point(302, 47);
            this.myEventsListControl1.Name = "myEventsListControl1";
            this.myEventsListControl1.Size = new System.Drawing.Size(484, 233);
            this.myEventsListControl1.TabIndex = 2;
            // 
            // analogClock1
            // 
            this.analogClock1.Location = new System.Drawing.Point(12, 12);
            this.analogClock1.Name = "analogClock1";
            this.analogClock1.Size = new System.Drawing.Size(277, 280);
            this.analogClock1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonEventsManager
            // 
            this.buttonEventsManager.Location = new System.Drawing.Point(302, 18);
            this.buttonEventsManager.Name = "buttonEventsManager";
            this.buttonEventsManager.Size = new System.Drawing.Size(141, 23);
            this.buttonEventsManager.TabIndex = 3;
            this.buttonEventsManager.Text = "Менеджер событий";
            this.buttonEventsManager.UseVisualStyleBackColor = true;
            this.buttonEventsManager.Click += new System.EventHandler(this.buttonEventsManager_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 292);
            this.Controls.Add(this.buttonEventsManager);
            this.Controls.Add(this.myEventsListControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.analogClock1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControlLibrary.AnalogClock analogClock1;
        private System.Windows.Forms.Label label1;
        private EventsControl.MyEventsListControl myEventsListControl1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonEventsManager;
    }
}

