﻿namespace программа
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
            this.ItogS = new System.Windows.Forms.Label();
            this.ItogB = new System.Windows.Forms.Button();
            this.usluga4 = new System.Windows.Forms.CheckBox();
            this.usluga4label = new System.Windows.Forms.Label();
            this.usluga4comboBox = new System.Windows.Forms.ComboBox();
            this.usluga4StoimostLabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.usluga5 = new System.Windows.Forms.CheckBox();
            this.usluga5label = new System.Windows.Forms.Label();
            this.usluga5comboBox = new System.Windows.Forms.ComboBox();
            this.usluga5StoimostLabel = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
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
            this.usluga1comboBox.Location = new System.Drawing.Point(298, 65);
            this.usluga1comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.usluga1comboBox.Name = "usluga1comboBox";
            this.usluga1comboBox.Size = new System.Drawing.Size(106, 21);
            this.usluga1comboBox.TabIndex = 4;
            this.usluga1comboBox.SelectedIndexChanged += new System.EventHandler(this.button1_Click);
            // 
            // usluga1label
            // 
            this.usluga1label.AutoSize = true;
            this.usluga1label.Location = new System.Drawing.Point(36, 72);
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
            this.usluga2comboBox.Location = new System.Drawing.Point(298, 114);
            this.usluga2comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.usluga2comboBox.Name = "usluga2comboBox";
            this.usluga2comboBox.Size = new System.Drawing.Size(106, 21);
            this.usluga2comboBox.TabIndex = 6;
            this.usluga2comboBox.SelectedIndexChanged += new System.EventHandler(this.button2_Click);
            // 
            // usluga2label
            // 
            this.usluga2label.AutoSize = true;
            this.usluga2label.Location = new System.Drawing.Point(36, 117);
            this.usluga2label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usluga2label.Name = "usluga2label";
            this.usluga2label.Size = new System.Drawing.Size(154, 13);
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
            "Часть в здании/доме"});
            this.usluga3comboBox.Location = new System.Drawing.Point(298, 159);
            this.usluga3comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.usluga3comboBox.Name = "usluga3comboBox";
            this.usluga3comboBox.Size = new System.Drawing.Size(106, 21);
            this.usluga3comboBox.TabIndex = 8;
            this.usluga3comboBox.SelectedIndexChanged += new System.EventHandler(this.button3_Click);
            // 
            // usluga1StoimostLabel
            // 
            this.usluga1StoimostLabel.AutoSize = true;
            this.usluga1StoimostLabel.Location = new System.Drawing.Point(452, 72);
            this.usluga1StoimostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usluga1StoimostLabel.Name = "usluga1StoimostLabel";
            this.usluga1StoimostLabel.Size = new System.Drawing.Size(54, 13);
            this.usluga1StoimostLabel.TabIndex = 12;
            this.usluga1StoimostLabel.Text = " 0 рублей";
            this.usluga1StoimostLabel.Click += new System.EventHandler(this.usluga1StoimostLabel_Click);
            // 
            // usluga3label
            // 
            this.usluga3label.AutoSize = true;
            this.usluga3label.Location = new System.Drawing.Point(36, 161);
            this.usluga3label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usluga3label.Name = "usluga3label";
            this.usluga3label.Size = new System.Drawing.Size(174, 13);
            this.usluga3label.TabIndex = 13;
            this.usluga3label.Text = "Подготовка технического плана ";
            this.usluga3label.Click += new System.EventHandler(this.label6_Click);
            // 
            // usluga2StoimostLabel
            // 
            this.usluga2StoimostLabel.AutoSize = true;
            this.usluga2StoimostLabel.Location = new System.Drawing.Point(452, 117);
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
            this.usluga3StoimostLabel.Location = new System.Drawing.Point(452, 161);
            this.usluga3StoimostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usluga3StoimostLabel.Name = "usluga3StoimostLabel";
            this.usluga3StoimostLabel.Size = new System.Drawing.Size(51, 13);
            this.usluga3StoimostLabel.TabIndex = 15;
            this.usluga3StoimostLabel.Text = "0 рублей";
            this.usluga3StoimostLabel.Click += new System.EventHandler(this.usluga3StoimostLabel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(467, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Подытог";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(600, 72);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
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
            this.usluga1.Location = new System.Drawing.Point(18, 73);
            this.usluga1.Margin = new System.Windows.Forms.Padding(2);
            this.usluga1.Name = "usluga1";
            this.usluga1.Size = new System.Drawing.Size(15, 14);
            this.usluga1.TabIndex = 18;
            this.usluga1.UseVisualStyleBackColor = true;
            this.usluga1.CheckedChanged += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "выбор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "вид работы";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(600, 114);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 21;
            this.button2.Text = "тыкни";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(600, 159);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
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
            this.usluga2.Location = new System.Drawing.Point(18, 121);
            this.usluga2.Margin = new System.Windows.Forms.Padding(2);
            this.usluga2.Name = "usluga2";
            this.usluga2.Size = new System.Drawing.Size(15, 14);
            this.usluga2.TabIndex = 23;
            this.usluga2.UseVisualStyleBackColor = true;
            this.usluga2.CheckedChanged += new System.EventHandler(this.button2_Click);
            // 
            // usluga3
            // 
            this.usluga3.AutoSize = true;
            this.usluga3.Location = new System.Drawing.Point(18, 163);
            this.usluga3.Margin = new System.Windows.Forms.Padding(2);
            this.usluga3.Name = "usluga3";
            this.usluga3.Size = new System.Drawing.Size(15, 14);
            this.usluga3.TabIndex = 24;
            this.usluga3.UseVisualStyleBackColor = true;
            this.usluga3.CheckedChanged += new System.EventHandler(this.button3_Click);
            // 
            // ItogS
            // 
            this.ItogS.AutoSize = true;
            this.ItogS.Location = new System.Drawing.Point(609, 551);
            this.ItogS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ItogS.Name = "ItogS";
            this.ItogS.Size = new System.Drawing.Size(51, 13);
            this.ItogS.TabIndex = 26;
            this.ItogS.Text = "0 рублей";
            this.ItogS.Click += new System.EventHandler(this.ItogS_Click);
            // 
            // ItogB
            // 
            this.ItogB.Location = new System.Drawing.Point(502, 549);
            this.ItogB.Margin = new System.Windows.Forms.Padding(2);
            this.ItogB.Name = "ItogB";
            this.ItogB.Size = new System.Drawing.Size(56, 19);
            this.ItogB.TabIndex = 27;
            this.ItogB.Text = "тыкни";
            this.ItogB.UseVisualStyleBackColor = true;
            this.ItogB.Click += new System.EventHandler(this.ItogB_Click);
            // 
            // usluga4
            // 
            this.usluga4.AutoSize = true;
            this.usluga4.Location = new System.Drawing.Point(18, 205);
            this.usluga4.Margin = new System.Windows.Forms.Padding(2);
            this.usluga4.Name = "usluga4";
            this.usluga4.Size = new System.Drawing.Size(15, 14);
            this.usluga4.TabIndex = 28;
            this.usluga4.UseVisualStyleBackColor = true;
            this.usluga4.CheckedChanged += new System.EventHandler(this.usluga4_CheckedChanged);
            // 
            // usluga4label
            // 
            this.usluga4label.AutoSize = true;
            this.usluga4label.Location = new System.Drawing.Point(36, 203);
            this.usluga4label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usluga4label.Name = "usluga4label";
            this.usluga4label.Size = new System.Drawing.Size(83, 13);
            this.usluga4label.TabIndex = 29;
            this.usluga4label.Text = "Строительство";
            this.usluga4label.Click += new System.EventHandler(this.usluga4label_Click);
            // 
            // usluga4comboBox
            // 
            this.usluga4comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usluga4comboBox.FormattingEnabled = true;
            this.usluga4comboBox.Items.AddRange(new object[] {
            "ИЖС",
            "Коммерческая недвижимость",
            "Инженерные коммуникации"});
            this.usluga4comboBox.Location = new System.Drawing.Point(298, 201);
            this.usluga4comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.usluga4comboBox.Name = "usluga4comboBox";
            this.usluga4comboBox.Size = new System.Drawing.Size(106, 21);
            this.usluga4comboBox.TabIndex = 30;
            this.usluga4comboBox.SelectedIndexChanged += new System.EventHandler(this.button4_Click);
            // 
            // usluga4StoimostLabel
            // 
            this.usluga4StoimostLabel.AutoSize = true;
            this.usluga4StoimostLabel.Location = new System.Drawing.Point(450, 203);
            this.usluga4StoimostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usluga4StoimostLabel.Name = "usluga4StoimostLabel";
            this.usluga4StoimostLabel.Size = new System.Drawing.Size(51, 13);
            this.usluga4StoimostLabel.TabIndex = 31;
            this.usluga4StoimostLabel.Text = "0 рублей";
            this.usluga4StoimostLabel.Click += new System.EventHandler(this.usluga4StoimostLabel_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(600, 202);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 19);
            this.button4.TabIndex = 32;
            this.button4.Text = "тыкни";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(39, 545);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 19);
            this.button5.TabIndex = 33;
            this.button5.Text = "korzina";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // usluga5
            // 
            this.usluga5.AutoSize = true;
            this.usluga5.Location = new System.Drawing.Point(18, 245);
            this.usluga5.Margin = new System.Windows.Forms.Padding(2);
            this.usluga5.Name = "usluga5";
            this.usluga5.Size = new System.Drawing.Size(15, 14);
            this.usluga5.TabIndex = 34;
            this.usluga5.UseVisualStyleBackColor = true;
            this.usluga5.CheckedChanged += new System.EventHandler(this.usluga5_CheckedChanged);
            // 
            // usluga5label
            // 
            this.usluga5label.AutoSize = true;
            this.usluga5label.Location = new System.Drawing.Point(39, 246);
            this.usluga5label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usluga5label.Name = "usluga5label";
            this.usluga5label.Size = new System.Drawing.Size(168, 13);
            this.usluga5label.TabIndex = 35;
            this.usluga5label.Text = "Подготовка акта обследования";
            this.usluga5label.Click += new System.EventHandler(this.usluga5label_Click);
            // 
            // usluga5comboBox
            // 
            this.usluga5comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usluga5comboBox.FormattingEnabled = true;
            this.usluga5comboBox.Items.AddRange(new object[] {
            "1 шт.",
            "2 шт."});
            this.usluga5comboBox.Location = new System.Drawing.Point(298, 238);
            this.usluga5comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.usluga5comboBox.Name = "usluga5comboBox";
            this.usluga5comboBox.Size = new System.Drawing.Size(106, 21);
            this.usluga5comboBox.TabIndex = 36;
            this.usluga5comboBox.SelectedIndexChanged += new System.EventHandler(this.button6_Click);
            // 
            // usluga5StoimostLabel
            // 
            this.usluga5StoimostLabel.AutoSize = true;
            this.usluga5StoimostLabel.Location = new System.Drawing.Point(450, 246);
            this.usluga5StoimostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usluga5StoimostLabel.Name = "usluga5StoimostLabel";
            this.usluga5StoimostLabel.Size = new System.Drawing.Size(51, 13);
            this.usluga5StoimostLabel.TabIndex = 37;
            this.usluga5StoimostLabel.Text = "0 рублей";
            this.usluga5StoimostLabel.Click += new System.EventHandler(this.usluga5StoimostLabel_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(600, 246);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 19);
            this.button6.TabIndex = 38;
            this.button6.Text = "тыкни";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(324, 540);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(74, 24);
            this.button7.TabIndex = 39;
            this.button7.Text = "услуга+";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(186, 540);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 41;
            this.button9.Text = "заказ";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 583);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.usluga5StoimostLabel);
            this.Controls.Add(this.usluga5comboBox);
            this.Controls.Add(this.usluga5label);
            this.Controls.Add(this.usluga5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.usluga4StoimostLabel);
            this.Controls.Add(this.usluga4comboBox);
            this.Controls.Add(this.usluga4label);
            this.Controls.Add(this.usluga4);
            this.Controls.Add(this.ItogB);
            this.Controls.Add(this.ItogS);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "calculator";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.calculator_Load);
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
        private System.Windows.Forms.Label ItogS;
        private System.Windows.Forms.Button ItogB;
        private System.Windows.Forms.CheckBox usluga4;
        private System.Windows.Forms.Label usluga4label;
        private System.Windows.Forms.ComboBox usluga4comboBox;
        private System.Windows.Forms.Label usluga4StoimostLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox usluga5;
        private System.Windows.Forms.Label usluga5label;
        private System.Windows.Forms.ComboBox usluga5comboBox;
        private System.Windows.Forms.Label usluga5StoimostLabel;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
    }
}