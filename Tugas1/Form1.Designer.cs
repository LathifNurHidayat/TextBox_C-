namespace Tugas1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnOk = new Button();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            labelOut = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 87);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 0;
            label1.Text = "Nama  ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 114);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 135);
            label3.Name = "label3";
            label3.Size = new Size(40, 25);
            label3.TabIndex = 2;
            label3.Text = "NIS";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(214, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(214, 132);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(230, 31);
            textBox2.TabIndex = 4;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(214, 240);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(112, 34);
            btnOk.TabIndex = 5;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "ddd-dd-mm-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.ImeMode = ImeMode.On;
            dateTimePicker1.Location = new Point(214, 183);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(230, 31);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.TabStop = false;
            dateTimePicker1.Value = new DateTime(2024, 6, 25, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(102, 188);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 8;
            label4.Text = "Tgl Lahir";
            // 
            // labelOut
            // 
            labelOut.AutoSize = true;
            labelOut.Location = new Point(264, 298);
            labelOut.Name = "labelOut";
            labelOut.Size = new Size(16, 25);
            labelOut.TabIndex = 9;
            labelOut.Text = ".";
            labelOut.Click += labelOut_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(332, 240);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 385);
            Controls.Add(btnClear);
            Controls.Add(labelOut);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnOk);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnOk;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label labelOut;
        private Button btnClear;
    }
}
