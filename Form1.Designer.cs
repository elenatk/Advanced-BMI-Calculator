
namespace BMI_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.btnCalculateBMI = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHeight.Location = new System.Drawing.Point(373, 59);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(180, 53);
            this.txtHeight.TabIndex = 0;
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWeight.Location = new System.Drawing.Point(373, 158);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(179, 53);
            this.txtWeight.TabIndex = 1;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeight.Location = new System.Drawing.Point(21, 60);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(323, 46);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Enter your height";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWeight.Location = new System.Drawing.Point(25, 155);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(330, 46);
            this.lblWeight.TabIndex = 3;
            this.lblWeight.Text = "Enter your weight";
            // 
            // btnCalculateBMI
            // 
            this.btnCalculateBMI.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCalculateBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalculateBMI.Location = new System.Drawing.Point(212, 259);
            this.btnCalculateBMI.Name = "btnCalculateBMI";
            this.btnCalculateBMI.Size = new System.Drawing.Size(392, 82);
            this.btnCalculateBMI.TabIndex = 4;
            this.btnCalculateBMI.Text = "Calculate your BMI";
            this.btnCalculateBMI.UseVisualStyleBackColor = false;
            this.btnCalculateBMI.Click += new System.EventHandler(this.btnCalculateBMI_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(42, 368);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(2, 43);
            this.lblResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 481);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculateBMI);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Button btnCalculateBMI;
        private System.Windows.Forms.Label lblResult;
    }
}

