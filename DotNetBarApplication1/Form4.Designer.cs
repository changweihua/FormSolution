namespace DotNetBarApplication1
{
    partial class Form4
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
            this.calendarView1 = new DevComponents.DotNetBar.Schedule.CalendarView();
            this.SuspendLayout();
            // 
            // calendarView1
            // 
            // 
            // 
            // 
            this.calendarView1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calendarView1.ContainerControlProcessDialogKey = true;
            this.calendarView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarView1.Location = new System.Drawing.Point(0, 0);
            this.calendarView1.MultiUserTabHeight = 20;
            this.calendarView1.Name = "calendarView1";
            this.calendarView1.Size = new System.Drawing.Size(899, 337);
            this.calendarView1.TabIndex = 0;
            this.calendarView1.Text = "calendarView1";
            this.calendarView1.TimeIndicator.BorderColor = System.Drawing.Color.Empty;
            this.calendarView1.TimeIndicator.Tag = null;
            this.calendarView1.TimeSlotDuration = 30;
            // 
            // Form4
            // 
            this.ClientSize = new System.Drawing.Size(899, 337);
            this.Controls.Add(this.calendarView1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Schedule.CalendarView calendarView1;
    }
}