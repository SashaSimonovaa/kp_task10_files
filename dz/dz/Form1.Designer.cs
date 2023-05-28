namespace dz
{
    partial class Form1
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
            this.Text_Input = new System.Windows.Forms.TextBox();
            this.Path_Input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Output_Button = new System.Windows.Forms.Button();
            this.Input_button = new System.Windows.Forms.Button();
            this.Name_Input = new System.Windows.Forms.TextBox();
            this.Text_Output = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Lines_Amount = new System.Windows.Forms.Button();
            this.Lines_Amount2 = new System.Windows.Forms.Button();
            this.Chars_Amount = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.Answer1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Requirement = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Answer2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Requirement2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Answer3 = new System.Windows.Forms.Label();
            this.Before_Change = new System.Windows.Forms.TextBox();
            this.After_Change = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.Word = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Text_Input
            // 
            this.Text_Input.Location = new System.Drawing.Point(12, 93);
            this.Text_Input.Multiline = true;
            this.Text_Input.Name = "Text_Input";
            this.Text_Input.Size = new System.Drawing.Size(355, 219);
            this.Text_Input.TabIndex = 0;
            // 
            // Path_Input
            // 
            this.Path_Input.Location = new System.Drawing.Point(12, 39);
            this.Path_Input.Name = "Path_Input";
            this.Path_Input.Size = new System.Drawing.Size(529, 22);
            this.Path_Input.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Путь";
            // 
            // Output_Button
            // 
            this.Output_Button.Location = new System.Drawing.Point(430, 67);
            this.Output_Button.Name = "Output_Button";
            this.Output_Button.Size = new System.Drawing.Size(99, 23);
            this.Output_Button.TabIndex = 6;
            this.Output_Button.Text = "Вывод";
            this.Output_Button.UseVisualStyleBackColor = true;
            this.Output_Button.Click += new System.EventHandler(this.Output_Button_Click);
            // 
            // Input_button
            // 
            this.Input_button.Location = new System.Drawing.Point(12, 67);
            this.Input_button.Name = "Input_button";
            this.Input_button.Size = new System.Drawing.Size(99, 23);
            this.Input_button.TabIndex = 7;
            this.Input_button.Text = "Ввод";
            this.Input_button.UseVisualStyleBackColor = true;
            this.Input_button.Click += new System.EventHandler(this.Input_button_Click);
            // 
            // Name_Input
            // 
            this.Name_Input.Location = new System.Drawing.Point(547, 39);
            this.Name_Input.Name = "Name_Input";
            this.Name_Input.Size = new System.Drawing.Size(133, 22);
            this.Name_Input.TabIndex = 8;
            // 
            // Text_Output
            // 
            this.Text_Output.Location = new System.Drawing.Point(430, 93);
            this.Text_Output.Multiline = true;
            this.Text_Output.Name = "Text_Output";
            this.Text_Output.Size = new System.Drawing.Size(355, 219);
            this.Text_Output.TabIndex = 1;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(686, 39);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(99, 23);
            this.Create.TabIndex = 9;
            this.Create.Text = "Создать";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Имя";
            // 
            // Lines_Amount
            // 
            this.Lines_Amount.Location = new System.Drawing.Point(12, 318);
            this.Lines_Amount.Name = "Lines_Amount";
            this.Lines_Amount.Size = new System.Drawing.Size(152, 49);
            this.Lines_Amount.TabIndex = 11;
            this.Lines_Amount.Text = "Количество строк";
            this.Lines_Amount.UseVisualStyleBackColor = true;
            this.Lines_Amount.Click += new System.EventHandler(this.Lines_Amount_Click);
            // 
            // Lines_Amount2
            // 
            this.Lines_Amount2.Location = new System.Drawing.Point(12, 373);
            this.Lines_Amount2.Name = "Lines_Amount2";
            this.Lines_Amount2.Size = new System.Drawing.Size(152, 49);
            this.Lines_Amount2.TabIndex = 12;
            this.Lines_Amount2.Text = "Количество строк с условием";
            this.Lines_Amount2.UseVisualStyleBackColor = true;
            this.Lines_Amount2.Click += new System.EventHandler(this.Lines_Amount2_Click);
            // 
            // Chars_Amount
            // 
            this.Chars_Amount.Location = new System.Drawing.Point(12, 428);
            this.Chars_Amount.Name = "Chars_Amount";
            this.Chars_Amount.Size = new System.Drawing.Size(152, 50);
            this.Chars_Amount.TabIndex = 13;
            this.Chars_Amount.Text = "Кол-во заданных символов";
            this.Chars_Amount.UseVisualStyleBackColor = true;
            this.Chars_Amount.Click += new System.EventHandler(this.Chars_Amount_Click);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(12, 484);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(152, 50);
            this.Change.TabIndex = 14;
            this.Change.Text = "Замена слов/символов";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(12, 540);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(152, 50);
            this.Register.TabIndex = 15;
            this.Register.Text = "Смена регистра";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Answer1
            // 
            this.Answer1.AutoSize = true;
            this.Answer1.Location = new System.Drawing.Point(170, 334);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(10, 16);
            this.Answer1.TabIndex = 16;
            this.Answer1.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "В строке встречается слово/символ:";
            // 
            // Requirement
            // 
            this.Requirement.Location = new System.Drawing.Point(173, 392);
            this.Requirement.Name = "Requirement";
            this.Requirement.Size = new System.Drawing.Size(244, 22);
            this.Requirement.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ответ:";
            // 
            // Answer2
            // 
            this.Answer2.AutoSize = true;
            this.Answer2.Location = new System.Drawing.Point(438, 395);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(13, 16);
            this.Answer2.TabIndex = 20;
            this.Answer2.Text = "  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Символ:";
            // 
            // Requirement2
            // 
            this.Requirement2.Location = new System.Drawing.Point(170, 447);
            this.Requirement2.Name = "Requirement2";
            this.Requirement2.Size = new System.Drawing.Size(244, 22);
            this.Requirement2.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ответ:";
            // 
            // Answer3
            // 
            this.Answer3.AutoSize = true;
            this.Answer3.Location = new System.Drawing.Point(438, 450);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(13, 16);
            this.Answer3.TabIndex = 24;
            this.Answer3.Text = "  ";
            // 
            // Before_Change
            // 
            this.Before_Change.Location = new System.Drawing.Point(170, 503);
            this.Before_Change.Name = "Before_Change";
            this.Before_Change.Size = new System.Drawing.Size(244, 22);
            this.Before_Change.TabIndex = 25;
            // 
            // After_Change
            // 
            this.After_Change.Location = new System.Drawing.Point(420, 503);
            this.After_Change.Name = "After_Change";
            this.After_Change.Size = new System.Drawing.Size(244, 22);
            this.After_Change.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 484);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Символ/слово:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 484);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Заменить на:";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Верхний",
            "Нижний"});
            this.comboBox.Location = new System.Drawing.Point(173, 559);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(151, 24);
            this.comboBox.TabIndex = 29;
            this.comboBox.Text = "Выберете регистр";
            // 
            // Word
            // 
            this.Word.Location = new System.Drawing.Point(330, 559);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(244, 22);
            this.Word.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(327, 540);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "Слово (Ввести 1 если весь текст)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 605);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Word);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.After_Change);
            this.Controls.Add(this.Before_Change);
            this.Controls.Add(this.Answer3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Requirement2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Answer2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Requirement);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Answer1);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Chars_Amount);
            this.Controls.Add(this.Lines_Amount2);
            this.Controls.Add(this.Lines_Amount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Name_Input);
            this.Controls.Add(this.Input_button);
            this.Controls.Add(this.Output_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Path_Input);
            this.Controls.Add(this.Text_Output);
            this.Controls.Add(this.Text_Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text_Input;
        private System.Windows.Forms.TextBox Path_Input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Output_Button;
        private System.Windows.Forms.Button Input_button;
        private System.Windows.Forms.TextBox Name_Input;
        private System.Windows.Forms.TextBox Text_Output;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Lines_Amount;
        private System.Windows.Forms.Button Lines_Amount2;
        private System.Windows.Forms.Button Chars_Amount;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Label Answer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Requirement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Answer2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Requirement2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Answer3;
        private System.Windows.Forms.TextBox Before_Change;
        private System.Windows.Forms.TextBox After_Change;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox Word;
        private System.Windows.Forms.Label label9;
    }
}

