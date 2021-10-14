namespace Lab3_FractionGUI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textNumerator1 = new System.Windows.Forms.TextBox();
            this.textDenominator1 = new System.Windows.Forms.TextBox();
            this.cmbOperation = new System.Windows.Forms.ComboBox();
            this.textNumerator2 = new System.Windows.Forms.TextBox();
            this.textDenominator2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textNumerator1
            // 
            this.textNumerator1.Location = new System.Drawing.Point(14, 50);
            this.textNumerator1.Name = "textNumerator1";
            this.textNumerator1.Size = new System.Drawing.Size(47, 22);
            this.textNumerator1.TabIndex = 0;
            this.textNumerator1.TextChanged += new System.EventHandler(this.onValueChanged);
            // 
            // textDenominator1
            // 
            this.textDenominator1.Location = new System.Drawing.Point(14, 78);
            this.textDenominator1.Name = "textDenominator1";
            this.textDenominator1.Size = new System.Drawing.Size(47, 22);
            this.textDenominator1.TabIndex = 1;
            this.textDenominator1.TextChanged += new System.EventHandler(this.onValueChanged);
            // 
            // cmbOperation
            // 
            this.cmbOperation.FormattingEnabled = true;
            this.cmbOperation.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "<>"});
            this.cmbOperation.Location = new System.Drawing.Point(67, 64);
            this.cmbOperation.Name = "cmbOperation";
            this.cmbOperation.Size = new System.Drawing.Size(46, 24);
            this.cmbOperation.TabIndex = 2;
            this.cmbOperation.Text = "+";
            this.cmbOperation.SelectedIndexChanged += new System.EventHandler(this.onValueChanged);
            // 
            // textNumerator2
            // 
            this.textNumerator2.Location = new System.Drawing.Point(119, 50);
            this.textNumerator2.Name = "textNumerator2";
            this.textNumerator2.Size = new System.Drawing.Size(47, 22);
            this.textNumerator2.TabIndex = 4;
            this.textNumerator2.TextChanged += new System.EventHandler(this.onValueChanged);
            // 
            // textDenominator2
            // 
            this.textDenominator2.Location = new System.Drawing.Point(119, 78);
            this.textDenominator2.Name = "textDenominator2";
            this.textDenominator2.Size = new System.Drawing.Size(47, 22);
            this.textDenominator2.TabIndex = 3;
            this.textDenominator2.TextChanged += new System.EventHandler(this.onValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "=";
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(194, 50);
            this.textResult.Multiline = true;
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(167, 50);
            this.textResult.TabIndex = 6;
            this.textResult.Text = "\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Задание";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 153);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNumerator2);
            this.Controls.Add(this.textDenominator2);
            this.Controls.Add(this.cmbOperation);
            this.Controls.Add(this.textDenominator1);
            this.Controls.Add(this.textNumerator1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculate_Fraction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNumerator1;
        private System.Windows.Forms.TextBox textDenominator1;
        private System.Windows.Forms.ComboBox cmbOperation;
        private System.Windows.Forms.TextBox textNumerator2;
        private System.Windows.Forms.TextBox textDenominator2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

