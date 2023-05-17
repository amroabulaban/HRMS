namespace HRMS
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.employees = new System.Windows.Forms.Button();
            this.departments = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 146);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(73, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 94);
            this.label1.TabIndex = 0;
            this.label1.Text = "HRMS";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(1019, 43);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // employees
            // 
            this.employees.BackColor = System.Drawing.Color.Red;
            this.employees.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employees.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.employees.Location = new System.Drawing.Point(280, 270);
            this.employees.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.employees.Name = "employees";
            this.employees.Size = new System.Drawing.Size(213, 138);
            this.employees.TabIndex = 1;
            this.employees.Text = "Employees";
            this.employees.UseVisualStyleBackColor = false;
            // 
            // departments
            // 
            this.departments.BackColor = System.Drawing.Color.Red;
            this.departments.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.departments.Location = new System.Drawing.Point(685, 270);
            this.departments.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.departments.Name = "departments";
            this.departments.Size = new System.Drawing.Size(213, 138);
            this.departments.TabIndex = 3;
            this.departments.Text = "Departments";
            this.departments.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.Image = global::HRMS.Properties.Resources.download2;
            this.button5.Location = new System.Drawing.Point(1142, 491);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 70);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 585);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.departments);
            this.Controls.Add(this.employees);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form2";
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button employees;
        private System.Windows.Forms.Button departments;
        private System.Windows.Forms.Button button5;
    }
}