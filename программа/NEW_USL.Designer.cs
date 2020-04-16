namespace программа
{
    partial class NEW_USL
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
            this.button1 = new System.Windows.Forms.Button();
            this.nameUSL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.price1 = new System.Windows.Forms.TextBox();
            this.uslov1 = new System.Windows.Forms.TextBox();
            this.uslov2 = new System.Windows.Forms.TextBox();
            this.price2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 84);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameUSL
            // 
            this.nameUSL.Location = new System.Drawing.Point(335, 24);
            this.nameUSL.Multiline = true;
            this.nameUSL.Name = "nameUSL";
            this.nameUSL.Size = new System.Drawing.Size(203, 20);
            this.nameUSL.TabIndex = 1;
            this.nameUSL.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "название услуги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "условие услуги";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "цены услуги";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "цены услуги";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "условие услуги";
            // 
            // price1
            // 
            this.price1.Location = new System.Drawing.Point(273, 124);
            this.price1.Multiline = true;
            this.price1.Name = "price1";
            this.price1.Size = new System.Drawing.Size(203, 20);
            this.price1.TabIndex = 11;
            // 
            // uslov1
            // 
            this.uslov1.Location = new System.Drawing.Point(29, 124);
            this.uslov1.Multiline = true;
            this.uslov1.Name = "uslov1";
            this.uslov1.Size = new System.Drawing.Size(203, 20);
            this.uslov1.TabIndex = 11;
            // 
            // uslov2
            // 
            this.uslov2.Location = new System.Drawing.Point(29, 197);
            this.uslov2.Multiline = true;
            this.uslov2.Name = "uslov2";
            this.uslov2.Size = new System.Drawing.Size(203, 20);
            this.uslov2.TabIndex = 12;
            // 
            // price2
            // 
            this.price2.Location = new System.Drawing.Point(273, 197);
            this.price2.Multiline = true;
            this.price2.Name = "price2";
            this.price2.Size = new System.Drawing.Size(203, 20);
            this.price2.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(489, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(17, 19);
            this.button2.TabIndex = 14;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // NEW_USL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 434);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.price2);
            this.Controls.Add(this.uslov2);
            this.Controls.Add(this.uslov1);
            this.Controls.Add(this.price1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameUSL);
            this.Controls.Add(this.button1);
            this.Name = "NEW_USL";
            this.Text = "NEW_USL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nameUSL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox price1;
        private System.Windows.Forms.TextBox uslov1;
        private System.Windows.Forms.TextBox uslov2;
        private System.Windows.Forms.TextBox price2;
        private System.Windows.Forms.Button button2;
    }
}