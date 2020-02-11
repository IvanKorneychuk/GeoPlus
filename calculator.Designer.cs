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
            this.usluga2label = new System.Windows.Forms.Label();
            this.usluga3comboBox = new System.Windows.Forms.ComboBox();
            this.usluga1StoimostLabel = new System.Windows.Forms.Label();
            this.usluga3label = new System.Windows.Forms.Label();
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
            this.spravkaTextBox = new System.Windows.Forms.TextBox();
            this.ItogS = new System.Windows.Forms.Label();
            this.ItogB = new System.Windows.Forms.Button();
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
            this.usluga1comboBox.Location = new System.Drawing.Point(400, 64);
            this.usluga1comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usluga1comboBox.Name = "usluga1comboBox";
            this.usluga1comboBox.Size = new System.Drawing.Size(140, 24);
            this.usluga1comboBox.TabIndex = 4;
            this.usluga1comboBox.SelectedIndexChanged += new System.EventHandler(this.button1_Click);
            // 
            // usluga1label
            // 
            this.usluga1label.AutoSize = true;
            this.usluga1label.Location = new System.Drawing.Point(51, 64);
            this.usluga1label.Name = "usluga1label";
            this.usluga1label.Size = new System.Drawing.Size(305, 17);
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
            this.usluga2comboBox.Location = new System.Drawing.Point(400, 130);
            this.usluga2comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usluga2comboBox.Name = "usluga2comboBox";
            this.usluga2comboBox.Size = new System.Drawing.Size(140, 24);
            this.usluga2comboBox.TabIndex = 6;
            this.usluga2comboBox.SelectedIndexChanged += new System.EventHandler(this.button2_Click);
            // 
            // usluga2label
            // 
            this.usluga2label.AutoSize = true;
            this.usluga2label.Location = new System.Drawing.Point(51, 138);
            this.usluga2label.Name = "usluga2label";
            this.usluga2label.Size = new System.Drawing.Size(194, 17);
            this.usluga2label.TabIndex = 7;
            this.usluga2label.Text = "Подготовка межевого плана";
            this.usluga2label.Click += new System.EventHandler(this.label2_Click);
            // 
            // usluga3comboBox
            // 
            this.usluga3comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usluga3comboBox.FormattingEnabled = true;
            this.usluga3comboBox.Items.AddRange(new object[] {
            "ИЖС",
            "Помещение",
            "Часть в здании/ддоме"});
            this.usluga3comboBox.Location = new System.Drawing.Point(400, 217);
            this.usluga3comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usluga3comboBox.Name = "usluga3comboBox";
            this.usluga3comboBox.Size = new System.Drawing.Size(140, 24);
            this.usluga3comboBox.TabIndex = 8;
            this.usluga3comboBox.SelectedIndexChanged += new System.EventHandler(this.button3_Click);
            // 
            // usluga1StoimostLabel
            // 
            this.usluga1StoimostLabel.AutoSize = true;
            this.usluga1StoimostLabel.Location = new System.Drawing.Point(605, 71);
            this.usluga1StoimostLabel.Name = "usluga1StoimostLabel";
            this.usluga1StoimostLabel.Size = new System.Drawing.Size(71, 17);
            this.usluga1StoimostLabel.TabIndex = 12;
            this.usluga1StoimostLabel.Text = " 0 рублей";
            // 
            // usluga3label
            // 
            this.usluga3label.AutoSize = true;
            this.usluga3label.Location = new System.Drawing.Point(51, 224);
            this.usluga3label.Name = "usluga3label";
            this.usluga3label.Size = new System.Drawing.Size(370, 17);
            this.usluga3label.TabIndex = 13;
            this.usluga3label.Text = "Подготовка технического плана (без инвентаризации)";
            this.usluga3label.Click += new System.EventHandler(this.label6_Click);
            // 
            // usluga2StoimostLabel
            // 
            this.usluga2StoimostLabel.AutoSize = true;
            this.usluga2StoimostLabel.Location = new System.Drawing.Point(605, 138);
            this.usluga2StoimostLabel.Name = "usluga2StoimostLabel";
            this.usluga2StoimostLabel.Size = new System.Drawing.Size(67, 17);
            this.usluga2StoimostLabel.TabIndex = 14;
            this.usluga2StoimostLabel.Text = "0 рублей";
            this.usluga2StoimostLabel.Click += new System.EventHandler(this.usluga2StoimostLabel_Click);
            // 
            // usluga3StoimostLabel
            // 
            this.usluga3StoimostLabel.AutoSize = true;
            this.usluga3StoimostLabel.Location = new System.Drawing.Point(605, 217);
            this.usluga3StoimostLabel.Name = "usluga3StoimostLabel";
            this.usluga3StoimostLabel.Size = new System.Drawing.Size(67, 17);
            this.usluga3StoimostLabel.TabIndex = 15;
            this.usluga3StoimostLabel.Text = "0 рублей";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(635, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Подытог";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(803, 71);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "тыкни";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // usluga1
            // 
            this.usluga1.AutoSize = true;
            this.usluga1.Location = new System.Drawing.Point(12, 64);
            this.usluga1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usluga1.Name = "usluga1";
            this.usluga1.Size = new System.Drawing.Size(18, 17);
            this.usluga1.TabIndex = 18;
            this.usluga1.UseVisualStyleBackColor = true;
            this.usluga1.CheckedChanged += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "выбор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "вид работы";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(803, 138);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "тыкни";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(803, 217);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "тыкни";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // usluga2
            // 
            this.usluga2.AutoSize = true;
            this.usluga2.Location = new System.Drawing.Point(12, 144);
            this.usluga2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usluga2.Name = "usluga2";
            this.usluga2.Size = new System.Drawing.Size(18, 17);
            this.usluga2.TabIndex = 23;
            this.usluga2.UseVisualStyleBackColor = true;
            this.usluga2.CheckedChanged += new System.EventHandler(this.button2_Click);
            // 
            // usluga3
            // 
            this.usluga3.AutoSize = true;
            this.usluga3.Location = new System.Drawing.Point(12, 223);
            this.usluga3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usluga3.Name = "usluga3";
            this.usluga3.Size = new System.Drawing.Size(18, 17);
            this.usluga3.TabIndex = 24;
            this.usluga3.UseVisualStyleBackColor = true;
            this.usluga3.CheckedChanged += new System.EventHandler(this.button3_Click);
            // 
            // spravkaTextBox
            // 
            this.spravkaTextBox.Location = new System.Drawing.Point(22, 350);
            this.spravkaTextBox.Multiline = true;
            this.spravkaTextBox.Name = "spravkaTextBox";
            this.spravkaTextBox.ReadOnly = true;
            this.spravkaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.spravkaTextBox.Size = new System.Drawing.Size(856, 134);
            this.spravkaTextBox.TabIndex = 25;
            // 
            // ItogS
            // 
            this.ItogS.AutoSize = true;
            this.ItogS.Location = new System.Drawing.Point(789, 294);
            this.ItogS.Name = "ItogS";
            this.ItogS.Size = new System.Drawing.Size(67, 17);
            this.ItogS.TabIndex = 26;
            this.ItogS.Text = "0 рублей";
            this.ItogS.Click += new System.EventHandler(this.ItogS_Click);
            // 
            // ItogB
            // 
            this.ItogB.Location = new System.Drawing.Point(638, 291);
            this.ItogB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ItogB.Name = "ItogB";
            this.ItogB.Size = new System.Drawing.Size(75, 23);
            this.ItogB.TabIndex = 27;
            this.ItogB.Text = "тыкни";
            this.ItogB.UseVisualStyleBackColor = true;
            this.ItogB.Click += new System.EventHandler(this.ItogB_Click);
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 496);
            this.Controls.Add(this.ItogB);
            this.Controls.Add(this.ItogS);
            this.Controls.Add(this.spravkaTextBox);
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
            this.Controls.Add(this.usluga3label);
            this.Controls.Add(this.usluga1StoimostLabel);
            this.Controls.Add(this.usluga3comboBox);
            this.Controls.Add(this.usluga2label);
            this.Controls.Add(this.usluga2comboBox);
            this.Controls.Add(this.usluga1label);
            this.Controls.Add(this.usluga1comboBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "calculator";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox usluga1comboBox;
        private System.Windows.Forms.Label usluga1label;
        private System.Windows.Forms.ComboBox usluga2comboBox;
        private System.Windows.Forms.Label usluga2label;
        private System.Windows.Forms.ComboBox usluga3comboBox;
        private System.Windows.Forms.Label usluga1StoimostLabel;
        private System.Windows.Forms.Label usluga3label;
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
        private System.Windows.Forms.TextBox spravkaTextBox;
        private System.Windows.Forms.Label ItogS;
        private System.Windows.Forms.Button ItogB;
    }
}