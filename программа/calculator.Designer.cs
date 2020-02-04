namespace программа
{
    partial class calculator
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
            this.usluga1comboBox = new System.Windows.Forms.ComboBox();
            this.usluga1label = new System.Windows.Forms.Label();
            this.usluga2comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usluga3comboBox = new System.Windows.Forms.ComboBox();
            this.usluga1StoimostLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.usluga2StoimostLabel = new System.Windows.Forms.Label();
            this.usluga3StoimostLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.usluga1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.usluga2 = new System.Windows.Forms.CheckBox();
            this.usluga3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // usluga1comboBox
            // 
            this.usluga1comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usluga1comboBox.FormattingEnabled = true;
            this.usluga1comboBox.Items.AddRange(new object[] {
            "До 1000М²",
            "До 10000М²",
            "Свыше 1га"});
            this.usluga1comboBox.Location = new System.Drawing.Point(300, 52);
            this.usluga1comboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usluga1comboBox.Name = "usluga1comboBox";
            this.usluga1comboBox.Size = new System.Drawing.Size(106, 21);
            this.usluga1comboBox.TabIndex = 4;
            this.usluga1comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // usluga1label
            // 
            this.usluga1label.AutoSize = true;
            this.usluga1label.Location = new System.Drawing.Point(38, 52);
            this.usluga1label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usluga1label.Name = "usluga1label";
            this.usluga1label.Size = new System.Drawing.Size(238, 13);
            this.usluga1label.TabIndex = 5;
            this.usluga1label.Text = "Горизонтальная съемка земельного участка";
            this.usluga1label.Click += new System.EventHandler(this.label1_Click);
            // 
            // usluga2comboBox
            // 
            this.usluga2comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usluga2comboBox.FormattingEnabled = true;
            this.usluga2comboBox.Items.AddRange(new object[] {
            "Образование з/у",
            "Уточнение гр-ц з/у",
            "Раздел з/у",
            "Объединение з/у"});
            this.usluga2comboBox.Location = new System.Drawing.Point(300, 106);
            this.usluga2comboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usluga2comboBox.Name = "usluga2comboBox";
            this.usluga2comboBox.Size = new System.Drawing.Size(106, 21);
            this.usluga2comboBox.TabIndex = 6;
            this.usluga2comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Подготовка межевого плана";
            // 
            // usluga3comboBox
            // 
            this.usluga3comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usluga3comboBox.FormattingEnabled = true;
            this.usluga3comboBox.Items.AddRange(new object[] {
            "ИЖС",
            "Помещение",
            "Часть в здании/ддоме"});
            this.usluga3comboBox.Location = new System.Drawing.Point(300, 176);
            this.usluga3comboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usluga3comboBox.Name = "usluga3comboBox";
            this.usluga3comboBox.Size = new System.Drawing.Size(106, 21);
            this.usluga3comboBox.TabIndex = 8;
            // 
            // usluga1StoimostLabel
            // 
            this.usluga1StoimostLabel.AutoSize = true;
            this.usluga1StoimostLabel.Location = new System.Drawing.Point(454, 58);
            this.usluga1StoimostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usluga1StoimostLabel.Name = "usluga1StoimostLabel";
            this.usluga1StoimostLabel.Size = new System.Drawing.Size(54, 13);
            this.usluga1StoimostLabel.TabIndex = 12;
            this.usluga1StoimostLabel.Text = " 0 рублей";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Подготовка технического плана\r\n(без инвентаризации)";
            // 
            // usluga2StoimostLabel
            // 
            this.usluga2StoimostLabel.AutoSize = true;
            this.usluga2StoimostLabel.Location = new System.Drawing.Point(454, 112);
            this.usluga2StoimostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usluga2StoimostLabel.Name = "usluga2StoimostLabel";
            this.usluga2StoimostLabel.Size = new System.Drawing.Size(51, 13);
            this.usluga2StoimostLabel.TabIndex = 14;
            this.usluga2StoimostLabel.Text = "0 рублей";
            this.usluga2StoimostLabel.Click += new System.EventHandler(this.usluga2StoimostLabel_Click);
            // 
            // usluga3StoimostLabel
            // 
            this.usluga3StoimostLabel.AutoSize = true;
            this.usluga3StoimostLabel.Location = new System.Drawing.Point(454, 176);
            this.usluga3StoimostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usluga3StoimostLabel.Name = "usluga3StoimostLabel";
            this.usluga3StoimostLabel.Size = new System.Drawing.Size(51, 13);
            this.usluga3StoimostLabel.TabIndex = 15;
            this.usluga3StoimostLabel.Text = "0 рублей";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(476, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Подытог";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(602, 58);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 17;
            this.button1.Text = "тыкни";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // usluga1
            // 
            this.usluga1.AutoSize = true;
            this.usluga1.Location = new System.Drawing.Point(9, 52);
            this.usluga1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usluga1.Name = "usluga1";
            this.usluga1.Size = new System.Drawing.Size(15, 14);
            this.usluga1.TabIndex = 18;
            this.usluga1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "выбор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "вид работы";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(602, 112);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 21;
            this.button2.Text = "тыкни";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(602, 176);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 22;
            this.button3.Text = "тыкни";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // usluga2
            // 
            this.usluga2.AutoSize = true;
            this.usluga2.Location = new System.Drawing.Point(9, 117);
            this.usluga2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usluga2.Name = "usluga2";
            this.usluga2.Size = new System.Drawing.Size(15, 14);
            this.usluga2.TabIndex = 23;
            this.usluga2.UseVisualStyleBackColor = true;
            // 
            // usluga3
            // 
            this.usluga3.AutoSize = true;
            this.usluga3.Location = new System.Drawing.Point(9, 181);
            this.usluga3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usluga3.Name = "usluga3";
            this.usluga3.Size = new System.Drawing.Size(15, 14);
            this.usluga3.TabIndex = 24;
            this.usluga3.UseVisualStyleBackColor = true;
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 403);
            this.Controls.Add(this.usluga3);
            this.Controls.Add(this.usluga2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usluga1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.usluga3StoimostLabel);
            this.Controls.Add(this.usluga2StoimostLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.usluga1StoimostLabel);
            this.Controls.Add(this.usluga3comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usluga2comboBox);
            this.Controls.Add(this.usluga1label);
            this.Controls.Add(this.usluga1comboBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "calculator";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox usluga1comboBox;
        private System.Windows.Forms.Label usluga1label;
        private System.Windows.Forms.ComboBox usluga2comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox usluga3comboBox;
        private System.Windows.Forms.Label usluga1StoimostLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label usluga2StoimostLabel;
        private System.Windows.Forms.Label usluga3StoimostLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox usluga1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox usluga2;
        private System.Windows.Forms.CheckBox usluga3;
    }
}