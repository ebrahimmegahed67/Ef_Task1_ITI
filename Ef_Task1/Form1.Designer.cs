namespace Ef_Task1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_instructor = new DataGridView();
            btn_add = new Button();
            button2 = new Button();
            button3 = new Button();
            cb_depart = new ComboBox();
            label1 = new Label();
            txt_name = new TextBox();
            txt_degree = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            nu_salary = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgv_instructor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nu_salary).BeginInit();
            SuspendLayout();
            // 
            // dgv_instructor
            // 
            dgv_instructor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_instructor.Location = new Point(67, 259);
            dgv_instructor.Name = "dgv_instructor";
            dgv_instructor.Size = new Size(550, 179);
            dgv_instructor.TabIndex = 0;
            dgv_instructor.RowHeaderMouseClick += dgv_instructor_RowHeaderMouseClick;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(477, 209);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 1;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // button2
            // 
            button2.Location = new Point(694, 209);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(585, 209);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // cb_depart
            // 
            cb_depart.FormattingEnabled = true;
            cb_depart.Location = new Point(648, 23);
            cb_depart.Name = "cb_depart";
            cb_depart.Size = new Size(121, 23);
            cb_depart.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(560, 31);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 5;
            label1.Text = "department";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(161, 23);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(100, 23);
            txt_name.TabIndex = 6;
            // 
            // txt_degree
            // 
            txt_degree.Location = new Point(161, 71);
            txt_degree.Name = "txt_degree";
            txt_degree.Size = new Size(100, 23);
            txt_degree.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 143);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 11;
            label3.Text = "Salary";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 74);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 12;
            label4.Text = "Degree";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 26);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 13;
            label5.Text = "Name";
            // 
            // nu_salary
            // 
            nu_salary.Location = new Point(161, 135);
            nu_salary.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nu_salary.Name = "nu_salary";
            nu_salary.Size = new Size(120, 23);
            nu_salary.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nu_salary);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txt_degree);
            Controls.Add(txt_name);
            Controls.Add(label1);
            Controls.Add(cb_depart);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btn_add);
            Controls.Add(dgv_instructor);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_instructor).EndInit();
            ((System.ComponentModel.ISupportInitialize)nu_salary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_instructor;
        private Button btn_add;
        private Button button2;
        private Button button3;
        private ComboBox cb_depart;
        private Label label1;
        private TextBox txt_name;
        private TextBox txt_degree;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown nu_salary;
    }
}
