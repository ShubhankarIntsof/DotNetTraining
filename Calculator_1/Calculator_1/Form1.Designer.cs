
namespace Calculator_1
{
    partial class FormCalculator
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
            this.CalcDisplay = new System.Windows.Forms.TextBox();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_decimal = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_Divide = new System.Windows.Forms.Button();
            this.button_multiply = new System.Windows.Forms.Button();
            this.button_subtract = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_equals = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CalcDisplay
            // 
            this.CalcDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcDisplay.Location = new System.Drawing.Point(13, 13);
            this.CalcDisplay.Name = "CalcDisplay";
            this.CalcDisplay.Size = new System.Drawing.Size(224, 40);
            this.CalcDisplay.TabIndex = 0;
            this.CalcDisplay.TextChanged += new System.EventHandler(this.CalcDisplay_TextChanged);
            // 
            // button_0
            // 
            this.button_0.Location = new System.Drawing.Point(13, 274);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(43, 38);
            this.button_0.TabIndex = 1;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            // 
            // button_decimal
            // 
            this.button_decimal.Location = new System.Drawing.Point(73, 274);
            this.button_decimal.Name = "button_decimal";
            this.button_decimal.Size = new System.Drawing.Size(43, 38);
            this.button_decimal.TabIndex = 2;
            this.button_decimal.Text = ".";
            this.button_decimal.UseVisualStyleBackColor = true;
            this.button_decimal.Click += new System.EventHandler(this.button_decimal_Click);
            // 
            // button_7
            // 
            this.button_7.Location = new System.Drawing.Point(12, 97);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(43, 38);
            this.button_7.TabIndex = 4;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // button_8
            // 
            this.button_8.Location = new System.Drawing.Point(73, 97);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(43, 38);
            this.button_8.TabIndex = 5;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.button_8_Click);
            // 
            // button_9
            // 
            this.button_9.Location = new System.Drawing.Point(137, 97);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(43, 38);
            this.button_9.TabIndex = 6;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.button_9_Click);
            // 
            // button_4
            // 
            this.button_4.Location = new System.Drawing.Point(13, 161);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(43, 38);
            this.button_4.TabIndex = 7;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_5
            // 
            this.button_5.Location = new System.Drawing.Point(73, 161);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(43, 38);
            this.button_5.TabIndex = 8;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_6
            // 
            this.button_6.Location = new System.Drawing.Point(137, 161);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(43, 38);
            this.button_6.TabIndex = 9;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // button_1
            // 
            this.button_1.Location = new System.Drawing.Point(12, 217);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(43, 38);
            this.button_1.TabIndex = 10;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_2
            // 
            this.button_2.Location = new System.Drawing.Point(73, 217);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(43, 38);
            this.button_2.TabIndex = 11;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_3
            // 
            this.button_3.Location = new System.Drawing.Point(137, 217);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(43, 38);
            this.button_3.TabIndex = 12;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_Divide
            // 
            this.button_Divide.Location = new System.Drawing.Point(137, 274);
            this.button_Divide.Name = "button_Divide";
            this.button_Divide.Size = new System.Drawing.Size(43, 38);
            this.button_Divide.TabIndex = 13;
            this.button_Divide.Text = "/";
            this.button_Divide.UseVisualStyleBackColor = true;
            this.button_Divide.Click += new System.EventHandler(this.button_Divide_Click);
            // 
            // button_multiply
            // 
            this.button_multiply.Location = new System.Drawing.Point(199, 161);
            this.button_multiply.Name = "button_multiply";
            this.button_multiply.Size = new System.Drawing.Size(43, 38);
            this.button_multiply.TabIndex = 14;
            this.button_multiply.Text = "*";
            this.button_multiply.UseVisualStyleBackColor = true;
            this.button_multiply.Click += new System.EventHandler(this.button_multiply_Click);
            // 
            // button_subtract
            // 
            this.button_subtract.Location = new System.Drawing.Point(199, 217);
            this.button_subtract.Name = "button_subtract";
            this.button_subtract.Size = new System.Drawing.Size(43, 38);
            this.button_subtract.TabIndex = 15;
            this.button_subtract.Text = "-";
            this.button_subtract.UseVisualStyleBackColor = true;
            this.button_subtract.Click += new System.EventHandler(this.button_subtract_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(199, 274);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(43, 38);
            this.button_Add.TabIndex = 16;
            this.button_Add.Text = "+";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_equals
            // 
            this.button_equals.Location = new System.Drawing.Point(73, 325);
            this.button_equals.Name = "button_equals";
            this.button_equals.Size = new System.Drawing.Size(169, 38);
            this.button_equals.TabIndex = 17;
            this.button_equals.Text = "=";
            this.button_equals.UseVisualStyleBackColor = true;
            this.button_equals.Click += new System.EventHandler(this.button_equals_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(199, 97);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(43, 38);
            this.button_Cancel.TabIndex = 19;
            this.button_Cancel.Text = "C";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 375);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_equals);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_subtract);
            this.Controls.Add(this.button_multiply);
            this.Controls.Add(this.button_Divide);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_decimal);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.CalcDisplay);
            this.Name = "FormCalculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.FormCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CalcDisplay;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_decimal;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_Divide;
        private System.Windows.Forms.Button button_multiply;
        private System.Windows.Forms.Button button_subtract;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_equals;
        private System.Windows.Forms.Button button_Cancel;
    }
}

