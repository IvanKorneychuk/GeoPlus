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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
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
            this.usluga1comboBox.Name = "usluga1comboBox";
            this.usluga1comboBox.Size = new System.Drawing.Size(140, 24);
            this.usluga1comboBox.TabIndex = 4;
            this.usluga1comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // usluga1label
            // 
            this.usluga1label.AutoSize = true;
            this.usluga1label.Location = new System.Drawing.Point(50, 64);
            this.usluga1label.Name = "usluga1label";
            this.usluga1label.Size = new System.Drawing.Size(305, 17);
            this.usluga1label.TabIndex = 5;
            this.usluga1label.Text = "Горизонтальная съемка земельного участка";
            this.usluga1label.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Образование з/у",
            "Уточнение гр-ц з/у",
            "Раздел з/у",
            "Объединение з/у"});
            this.comboBox2.Location = new System.Drawing.Point(400, 131);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 24);
            this.comboBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Подготовка межевого плана";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "ИЖС",
            "Помещение",
            "Часть в здании/ддоме"});
            this.comboBox3.Location = new System.Drawing.Point(400, 216);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(140, 24);
            this.comboBox3.TabIndex = 8;
            // 
            // usluga1StoimostLabel
            // 
            this.usluga1StoimostLabel.AutoSize = true;
            this.usluga1StoimostLabel.Location = new System.Drawing.Point(606, 71);
            this.usluga1StoimostLabel.Name = "usluga1StoimostLabel";
            this.usluga1StoimostLabel.Size = new System.Drawing.Size(71, 17);
            this.usluga1StoimostLabel.TabIndex = 12;
            this.usluga1StoimostLabel.Text = " 0 рублей";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 34);
            this.label6.TabIndex = 13;
            this.label6.Text = "Подготовка технического плана\r\n(без инвентаризации)";
            // 
            // usluga2StoimostLabel
            // 
            this.usluga2StoimostLabel.AutoSize = true;
            this.usluga2StoimostLabel.Location = new System.Drawing.Point(606, 138);
            this.usluga2StoimostLabel.Name = "usluga2StoimostLabel";
            this.usluga2StoimostLabel.Size = new System.Drawing.Size(67, 17);
            this.usluga2StoimostLabel.TabIndex = 14;
            this.usluga2StoimostLabel.Text = "0 рублей";
            // 
            // usluga3StoimostLabel
            // 
            this.usluga3StoimostLabel.AutoSize = true;
            this.usluga3StoimostLabel.Location = new System.Drawing.Point(606, 216);
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
            this.usluga1.Name = "usluga1";
            this.usluga1.Size = new System.Drawing.Size(18, 17);
            this.usluga1.TabIndex = 18;
            this.usluga1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 9);
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
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "тыкни";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(803, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "тыкни";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 144);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 223);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(18, 17);
            this.checkBox2.TabIndex = 24;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 496);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
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
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.usluga1label);
            this.Controls.Add(this.usluga1comboBox);
            this.Name = "calculator";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox usluga1comboBox;
        private System.Windows.Forms.Label usluga1label;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}