namespace MatrixCalculator
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
            this.MatrixEditControl_1 = new MatrixCalculator.MatrixEditControl();
            this.MatrixEditControl_2 = new MatrixCalculator.MatrixEditControl();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Substract = new System.Windows.Forms.Button();
            this.Button_Multiply = new System.Windows.Forms.Button();
            this.MatrixEditControl_3 = new MatrixCalculator.MatrixEditControl();
            this.SuspendLayout();
            // 
            // MatrixEditControl_1
            // 
            this.MatrixEditControl_1.AutoScroll = true;
            this.MatrixEditControl_1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MatrixEditControl_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MatrixEditControl_1.CanEditMatrix = true;
            this.MatrixEditControl_1.Location = new System.Drawing.Point(12, 12);
            this.MatrixEditControl_1.Matrix = null;
            this.MatrixEditControl_1.Name = "MatrixEditControl_1";
            this.MatrixEditControl_1.Size = new System.Drawing.Size(216, 176);
            this.MatrixEditControl_1.TabIndex = 8;
            // 
            // MatrixEditControl_2
            // 
            this.MatrixEditControl_2.AutoScroll = true;
            this.MatrixEditControl_2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MatrixEditControl_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MatrixEditControl_2.CanEditMatrix = true;
            this.MatrixEditControl_2.Location = new System.Drawing.Point(234, 12);
            this.MatrixEditControl_2.Matrix = null;
            this.MatrixEditControl_2.Name = "MatrixEditControl_2";
            this.MatrixEditControl_2.Size = new System.Drawing.Size(214, 176);
            this.MatrixEditControl_2.TabIndex = 9;
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(141, 194);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(25, 25);
            this.Button_Add.TabIndex = 10;
            this.Button_Add.Text = "+";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_Substract
            // 
            this.Button_Substract.Location = new System.Drawing.Point(172, 194);
            this.Button_Substract.Name = "Button_Substract";
            this.Button_Substract.Size = new System.Drawing.Size(25, 25);
            this.Button_Substract.TabIndex = 11;
            this.Button_Substract.Text = "-";
            this.Button_Substract.UseVisualStyleBackColor = true;
            this.Button_Substract.Click += new System.EventHandler(this.Button_Substract_Click);
            // 
            // Button_Multiply
            // 
            this.Button_Multiply.Location = new System.Drawing.Point(203, 194);
            this.Button_Multiply.Name = "Button_Multiply";
            this.Button_Multiply.Size = new System.Drawing.Size(25, 25);
            this.Button_Multiply.TabIndex = 12;
            this.Button_Multiply.Text = "*";
            this.Button_Multiply.UseVisualStyleBackColor = true;
            this.Button_Multiply.Click += new System.EventHandler(this.Button_Multiply_Click);
            // 
            // MatrixEditControl_3
            // 
            this.MatrixEditControl_3.AutoScroll = true;
            this.MatrixEditControl_3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MatrixEditControl_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MatrixEditControl_3.CanEditMatrix = true;
            this.MatrixEditControl_3.Location = new System.Drawing.Point(12, 225);
            this.MatrixEditControl_3.Matrix = null;
            this.MatrixEditControl_3.Name = "MatrixEditControl_3";
            this.MatrixEditControl_3.Size = new System.Drawing.Size(436, 223);
            this.MatrixEditControl_3.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 460);
            this.Controls.Add(this.MatrixEditControl_3);
            this.Controls.Add(this.Button_Multiply);
            this.Controls.Add(this.Button_Substract);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.MatrixEditControl_2);
            this.Controls.Add(this.MatrixEditControl_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private MatrixEditControl MatrixEditControl_1;
        private MatrixEditControl MatrixEditControl_2;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_Substract;
        private System.Windows.Forms.Button Button_Multiply;
        private MatrixEditControl MatrixEditControl_3;
    }
}

