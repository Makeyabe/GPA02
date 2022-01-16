namespace GPA
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
            this.textBoxName_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxGPAx = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMaxName = new System.Windows.Forms.TextBox();
            this.textBoxMinName = new System.Windows.Forms.TextBox();
            this.textBoxMaxGPA = new System.Windows.Forms.TextBox();
            this.textBoxMinGPA = new System.Windows.Forms.TextBox();
            this.textBoxAllData = new System.Windows.Forms.TextBox();
            this.textBoxNameGPA_input = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxName_input
            // 
            this.textBoxName_input.Location = new System.Drawing.Point(100, 67);
            this.textBoxName_input.Name = "textBoxName_input";
            this.textBoxName_input.Size = new System.Drawing.Size(125, 27);
            this.textBoxName_input.TabIndex = 0;
            this.textBoxName_input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "GPA INPUT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxGPAx
            // 
            this.textBoxGPAx.Location = new System.Drawing.Point(78, 30);
            this.textBoxGPAx.Name = "textBoxGPAx";
            this.textBoxGPAx.Size = new System.Drawing.Size(125, 27);
            this.textBoxGPAx.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxMinGPA);
            this.groupBox1.Controls.Add(this.textBoxMaxGPA);
            this.groupBox1.Controls.Add(this.textBoxMinName);
            this.groupBox1.Controls.Add(this.textBoxMaxName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxGPAx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(22, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 205);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OUT PUT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "GPA X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(401, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 93);
            this.button2.TabIndex = 6;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Max GPA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Min GPA";
            // 
            // textBoxMaxName
            // 
            this.textBoxMaxName.Location = new System.Drawing.Point(78, 84);
            this.textBoxMaxName.Name = "textBoxMaxName";
            this.textBoxMaxName.Size = new System.Drawing.Size(125, 27);
            this.textBoxMaxName.TabIndex = 7;
            // 
            // textBoxMinName
            // 
            this.textBoxMinName.Location = new System.Drawing.Point(78, 132);
            this.textBoxMinName.Name = "textBoxMinName";
            this.textBoxMinName.Size = new System.Drawing.Size(125, 27);
            this.textBoxMinName.TabIndex = 8;
            // 
            // textBoxMaxGPA
            // 
            this.textBoxMaxGPA.Location = new System.Drawing.Point(222, 84);
            this.textBoxMaxGPA.Name = "textBoxMaxGPA";
            this.textBoxMaxGPA.Size = new System.Drawing.Size(125, 27);
            this.textBoxMaxGPA.TabIndex = 9;
            this.textBoxMaxGPA.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxMinGPA
            // 
            this.textBoxMinGPA.Location = new System.Drawing.Point(222, 132);
            this.textBoxMinGPA.Name = "textBoxMinGPA";
            this.textBoxMinGPA.Size = new System.Drawing.Size(125, 27);
            this.textBoxMinGPA.TabIndex = 10;
            // 
            // textBoxAllData
            // 
            this.textBoxAllData.Location = new System.Drawing.Point(25, 347);
            this.textBoxAllData.Multiline = true;
            this.textBoxAllData.Name = "textBoxAllData";
            this.textBoxAllData.Size = new System.Drawing.Size(381, 101);
            this.textBoxAllData.TabIndex = 7;
            // 
            // textBoxNameGPA_input
            // 
            this.textBoxNameGPA_input.Location = new System.Drawing.Point(244, 67);
            this.textBoxNameGPA_input.Name = "textBoxNameGPA_input";
            this.textBoxNameGPA_input.Size = new System.Drawing.Size(125, 27);
            this.textBoxNameGPA_input.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 479);
            this.Controls.Add(this.textBoxNameGPA_input);
            this.Controls.Add(this.textBoxAllData);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxName_input;
        private Label label1;
        private Button button1;
        private TextBox textBoxGPAx;
        private GroupBox groupBox1;
        private Label label2;
        private Button button2;
        private TextBox textBoxMinGPA;
        private TextBox textBoxMaxGPA;
        private TextBox textBoxMinName;
        private TextBox textBoxMaxName;
        private Label label4;
        private Label label3;
        private TextBox textBoxAllData;
        private TextBox textBoxNameGPA_input;
    }
}