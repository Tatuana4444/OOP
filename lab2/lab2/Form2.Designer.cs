namespace lab2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.EnterX = new System.Windows.Forms.TextBox();
            this.EnterY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Create = new System.Windows.Forms.Button();
            this.IsShowInf = new System.Windows.Forms.CheckBox();
            this.isWorkButt = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(162, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберети объект";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(65, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите местоположение";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(384, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 35);
            this.comboBox1.TabIndex = 3;
            // 
            // EnterX
            // 
            this.EnterX.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterX.Location = new System.Drawing.Point(397, 195);
            this.EnterX.Name = "EnterX";
            this.EnterX.Size = new System.Drawing.Size(100, 33);
            this.EnterX.TabIndex = 4;
            this.EnterX.TextChanged += new System.EventHandler(this.EnterX_TextChanged);
            // 
            // EnterY
            // 
            this.EnterY.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterY.Location = new System.Drawing.Point(586, 197);
            this.EnterY.Name = "EnterY";
            this.EnterY.Size = new System.Drawing.Size(100, 33);
            this.EnterY.TabIndex = 5;
            this.EnterY.TextChanged += new System.EventHandler(this.EnterX_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(366, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(555, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Y";
            // 
            // Create
            // 
            this.Create.Enabled = false;
            this.Create.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Create.Location = new System.Drawing.Point(293, 394);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(180, 44);
            this.Create.TabIndex = 9;
            this.Create.Text = "Создать";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.button1_Click);
            // 
            // IsShowInf
            // 
            this.IsShowInf.AutoSize = true;
            this.IsShowInf.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic);
            this.IsShowInf.Location = new System.Drawing.Point(220, 286);
            this.IsShowInf.Name = "IsShowInf";
            this.IsShowInf.Size = new System.Drawing.Size(360, 32);
            this.IsShowInf.TabIndex = 11;
            this.IsShowInf.Text = "Выводить информации об объекте?";
            this.IsShowInf.UseVisualStyleBackColor = true;
            // 
            // isWorkButt
            // 
            this.isWorkButt.AutoSize = true;
            this.isWorkButt.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic);
            this.isWorkButt.Location = new System.Drawing.Point(323, 338);
            this.isWorkButt.Name = "isWorkButt";
            this.isWorkButt.Size = new System.Drawing.Size(134, 32);
            this.isWorkButt.TabIndex = 12;
            this.isWorkButt.Text = "Работает?";
            this.isWorkButt.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 493);
            this.Controls.Add(this.isWorkButt);
            this.Controls.Add(this.IsShowInf);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EnterY);
            this.Controls.Add(this.EnterX);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Введите данные объекта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox EnterX;
        private System.Windows.Forms.TextBox EnterY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.CheckBox IsShowInf;
        private System.Windows.Forms.CheckBox isWorkButt;
    }
}