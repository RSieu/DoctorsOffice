namespace DoctorsOffice2
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
            lblTitle = new Label();
            lblPatientName = new Label();
            lblVisitCost = new Label();
            txtVisitCost = new TextBox();
            txtPatientName = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lstOutput = new ListBox();
            label1 = new Label();
            txtInsurancePlan = new TextBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(14, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(390, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Doctor's Office Copay Calculator";
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPatientName.Location = new Point(31, 114);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(135, 25);
            lblPatientName.TabIndex = 1;
            lblPatientName.Text = "Patient Name:";
            // 
            // lblVisitCost
            // 
            lblVisitCost.AutoSize = true;
            lblVisitCost.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVisitCost.Location = new Point(31, 181);
            lblVisitCost.Name = "lblVisitCost";
            lblVisitCost.Size = new Size(131, 25);
            lblVisitCost.TabIndex = 2;
            lblVisitCost.Text = "Visit Cost ($):";
            // 
            // txtVisitCost
            // 
            txtVisitCost.Location = new Point(310, 180);
            txtVisitCost.Margin = new Padding(3, 4, 3, 4);
            txtVisitCost.Name = "txtVisitCost";
            txtVisitCost.Size = new Size(271, 31);
            txtVisitCost.TabIndex = 5;
            // 
            // txtPatientName
            // 
            txtPatientName.Location = new Point(310, 114);
            txtPatientName.Margin = new Padding(3, 4, 3, 4);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(271, 31);
            txtPatientName.TabIndex = 6;
            txtPatientName.Enter += txtPatientName_Enter;
            txtPatientName.Leave += txtPatientName_Leave;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(72, 365);
            btnCalculate.Margin = new Padding(3, 4, 3, 4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(109, 59);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(263, 365);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(116, 59);
            btnClear.TabIndex = 8;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(448, 365);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(133, 59);
            btnExit.TabIndex = 9;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lstOutput
            // 
            lstOutput.FormattingEnabled = true;
            lstOutput.Location = new Point(38, 505);
            lstOutput.Margin = new Padding(3, 4, 3, 4);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(542, 254);
            lstOutput.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 259);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 11;
            label1.Text = "Insurance Plan:";
            label1.Click += label1_Click;
            // 
            // txtInsurancePlan
            // 
            txtInsurancePlan.Location = new Point(313, 259);
            txtInsurancePlan.Name = "txtInsurancePlan";
            txtInsurancePlan.Size = new Size(267, 31);
            txtInsurancePlan.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 812);
            Controls.Add(txtInsurancePlan);
            Controls.Add(label1);
            Controls.Add(lstOutput);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtPatientName);
            Controls.Add(txtVisitCost);
            Controls.Add(lblVisitCost);
            Controls.Add(lblPatientName);
            Controls.Add(lblTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doctor's Office Billing";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblVisitCost;
        private System.Windows.Forms.TextBox txtVisitCost;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstOutput;
        private Label label1;
        private TextBox txtInsurancePlan;
    }
}

