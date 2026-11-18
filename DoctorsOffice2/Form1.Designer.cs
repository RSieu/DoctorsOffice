namespace DoctorsOffice
//namesapce is a container for classes and other types. It helps organize code and prevent naming conflicts. In this case, DoctorsOffice is the namespace that contains the Form1 class.
//like a specific labelled drawer in a tool box where you can store and organize your tools (classes, methods, etc.) related to the DoctorsOffice application.
// class is a specific kind of tool like a hammer. You add methods define the behavior or actions like swinging the hammer? 
// public class Hammer <- can be accessed from anywhere in the program or even from other programs that reference this code. It is a blueprint for creating objects (instances) of the Hammer class.
// {
// public string material <- property of the hammera varoable that has the description of the hammer's material
// {
// get; set; <- let your program get and read program data and set and write program data
// }
// public void Swing (int Strength) <- public means method can be called from anywhere, and void means that the method can be called or triggered without changing its. parenthis hold any extra information that the method might need to perform its action. In this case, the Swing method doesn't require any additional information to swing the hammer.
// {
// Console.Writeline ($swinging the hammer with strength 'Strength')
// }
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
            groupBox1 = new GroupBox();
            radNone = new RadioButton();
            radPPO = new RadioButton();
            radHMO = new RadioButton();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(10, 10);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(270, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Doctor's Office Copay Calculator";
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPatientName.Location = new Point(22, 68);
            lblPatientName.Margin = new Padding(2, 0, 2, 0);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(97, 17);
            lblPatientName.TabIndex = 1;
            lblPatientName.Text = "Patient Name:";
            // 
            // lblVisitCost
            // 
            lblVisitCost.AutoSize = true;
            lblVisitCost.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVisitCost.Location = new Point(22, 109);
            lblVisitCost.Margin = new Padding(2, 0, 2, 0);
            lblVisitCost.Name = "lblVisitCost";
            lblVisitCost.Size = new Size(92, 17);
            lblVisitCost.TabIndex = 3;
            lblVisitCost.Text = "Visit Cost ($):";
            // 
            // txtVisitCost
            // 
            txtVisitCost.Location = new Point(217, 108);
            txtVisitCost.Margin = new Padding(2, 2, 2, 2);
            txtVisitCost.Name = "txtVisitCost";
            txtVisitCost.Size = new Size(191, 23);
            txtVisitCost.TabIndex = 4;
            // 
            // txtPatientName
            // 
            txtPatientName.Location = new Point(217, 68);
            txtPatientName.Margin = new Padding(2, 2, 2, 2);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(191, 23);
            txtPatientName.TabIndex = 2;
            txtPatientName.Enter += txtPatientName_Enter;
            txtPatientName.Leave += txtPatientName_Leave;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(37, 183);
            btnCalculate.Margin = new Padding(2, 2, 2, 2);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(76, 35);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(180, 183);
            btnClear.Margin = new Padding(2, 2, 2, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(81, 35);
            btnClear.TabIndex = 8;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(313, 183);
            btnExit.Margin = new Padding(2, 2, 2, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(93, 35);
            btnExit.TabIndex = 9;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lstOutput
            // 
            lstOutput.FormattingEnabled = true;
            lstOutput.Location = new Point(26, 303);
            lstOutput.Margin = new Padding(2, 2, 2, 2);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(380, 154);
            lstOutput.TabIndex = 0;
            lstOutput.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radNone);
            groupBox1.Controls.Add(radPPO);
            groupBox1.Controls.Add(radHMO);
            groupBox1.Location = new Point(523, 68);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(182, 91);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insurance Type";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radNone
            // 
            radNone.AutoSize = true;
            radNone.Location = new Point(24, 71);
            radNone.Margin = new Padding(3, 2, 3, 2);
            radNone.Name = "radNone";
            radNone.Size = new Size(54, 19);
            radNone.TabIndex = 2;
            radNone.Text = "None";
            radNone.UseVisualStyleBackColor = true;
            radNone.CheckedChanged += radNone_CheckedChanged;
            // 
            // radPPO
            // 
            radPPO.AutoSize = true;
            radPPO.Location = new Point(24, 49);
            radPPO.Margin = new Padding(3, 2, 3, 2);
            radPPO.Name = "radPPO";
            radPPO.Size = new Size(48, 19);
            radPPO.TabIndex = 1;
            radPPO.Text = "PPO";
            radPPO.UseVisualStyleBackColor = true;
            radPPO.CheckedChanged += radPPO_CheckedChanged;
            // 
            // radHMO
            // 
            radHMO.AutoSize = true;
            radHMO.Location = new Point(24, 26);
            radHMO.Margin = new Padding(3, 2, 3, 2);
            radHMO.Name = "radHMO";
            radHMO.Size = new Size(54, 19);
            radHMO.TabIndex = 0;
            radHMO.Text = "HMO";
            radHMO.UseVisualStyleBackColor = true;
            radHMO.CheckedChanged += radHMO_CheckedChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 488);
            Controls.Add(groupBox1);
            Controls.Add(lstOutput);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtPatientName);
            Controls.Add(txtVisitCost);
            Controls.Add(lblVisitCost);
            Controls.Add(lblPatientName);
            Controls.Add(lblTitle);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
        private RadioButton radNone;
        private RadioButton radPPO;
        private RadioButton radHMO;
        private OpenFileDialog openFileDialog1;
    }
}

