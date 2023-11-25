namespace App
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.RichTextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonUrgent = new System.Windows.Forms.RadioButton();
            this.radioButtonOrdinary = new System.Windows.Forms.RadioButton();
            this.RadioButton = new System.Windows.Forms.GroupBox();
            this.RadioButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cost";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(41, 57);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(673, 149);
            this.txtText.TabIndex = 2;
            this.txtText.Text = "";
            this.txtText.TextChanged += new System.EventHandler(this.txtText_TextChanged);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(101, 355);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(303, 26);
            this.txtCost.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(607, 341);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(131, 64);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 5;
            // 
            // radioButtonUrgent
            // 
            this.radioButtonUrgent.AutoSize = true;
            this.radioButtonUrgent.Location = new System.Drawing.Point(104, 44);
            this.radioButtonUrgent.Name = "radioButtonUrgent";
            this.radioButtonUrgent.Size = new System.Drawing.Size(96, 24);
            this.radioButtonUrgent.TabIndex = 8;
            this.radioButtonUrgent.TabStop = true;
            this.radioButtonUrgent.Text = "Urgente ";
            this.radioButtonUrgent.UseVisualStyleBackColor = true;
            // 
            // radioButtonOrdinary
            // 
            this.radioButtonOrdinary.AutoSize = true;
            this.radioButtonOrdinary.Location = new System.Drawing.Point(0, 44);
            this.radioButtonOrdinary.Name = "radioButtonOrdinary";
            this.radioButtonOrdinary.Size = new System.Drawing.Size(102, 24);
            this.radioButtonOrdinary.TabIndex = 7;
            this.radioButtonOrdinary.TabStop = true;
            this.radioButtonOrdinary.Text = "Ordinario ";
            this.radioButtonOrdinary.UseVisualStyleBackColor = true;
            // 
            // RadioButton
            // 
            this.RadioButton.Controls.Add(this.radioButtonOrdinary);
            this.RadioButton.Controls.Add(this.radioButtonUrgent);
            this.RadioButton.Location = new System.Drawing.Point(37, 249);
            this.RadioButton.Name = "RadioButton";
            this.RadioButton.Size = new System.Drawing.Size(200, 100);
            this.RadioButton.TabIndex = 9;
            this.RadioButton.TabStop = false;
            this.RadioButton.Text = "groupBox1";
            this.RadioButton.Enter += new System.EventHandler(this.RadioButton_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RadioButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.RadioButton.ResumeLayout(false);
            this.RadioButton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtText;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonUrgent;
        private System.Windows.Forms.RadioButton radioButtonOrdinary;
        private System.Windows.Forms.GroupBox RadioButton;
    }
}

