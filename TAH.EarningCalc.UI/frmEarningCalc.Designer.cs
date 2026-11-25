namespace TAH.EarningCalc.UI
{
    partial class frmEarningCalc
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
            lblDaysWorked = new Label();
            txtDaysWorked = new TextBox();
            lstOutput = new ListBox();
            lblPayEarned = new Label();
            lblTotal = new Label();
            btnCalc = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblDaysWorked
            // 
            lblDaysWorked.AutoSize = true;
            lblDaysWorked.Font = new Font("Segoe UI", 12F);
            lblDaysWorked.Location = new Point(44, 44);
            lblDaysWorked.Name = "lblDaysWorked";
            lblDaysWorked.Size = new Size(185, 21);
            lblDaysWorked.TabIndex = 0;
            lblDaysWorked.Text = "Number of Days Worked:";
            // 
            // txtDaysWorked
            // 
            txtDaysWorked.Font = new Font("Segoe UI", 12F);
            txtDaysWorked.Location = new Point(235, 41);
            txtDaysWorked.Name = "txtDaysWorked";
            txtDaysWorked.Size = new Size(100, 29);
            txtDaysWorked.TabIndex = 0;
            txtDaysWorked.TextAlign = HorizontalAlignment.Right;
            txtDaysWorked.TextChanged += txtDaysWorked_TextChanged;
            // 
            // lstOutput
            // 
            lstOutput.Font = new Font("Segoe UI", 12F);
            lstOutput.FormattingEnabled = true;
            lstOutput.Location = new Point(44, 105);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(482, 193);
            lstOutput.TabIndex = 2;
            // 
            // lblPayEarned
            // 
            lblPayEarned.AutoSize = true;
            lblPayEarned.Font = new Font("Segoe UI", 12F);
            lblPayEarned.Location = new Point(101, 331);
            lblPayEarned.Name = "lblPayEarned";
            lblPayEarned.Size = new Size(125, 21);
            lblPayEarned.TabIndex = 3;
            lblPayEarned.Text = "Total Pay Earned:";
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.White;
            lblTotal.BorderStyle = BorderStyle.Fixed3D;
            lblTotal.FlatStyle = FlatStyle.Popup;
            lblTotal.Font = new Font("Segoe UI", 12F);
            lblTotal.Location = new Point(232, 331);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(294, 23);
            lblTotal.TabIndex = 4;
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnCalc
            // 
            btnCalc.Font = new Font("Segoe UI", 12F);
            btnCalc.Location = new Point(44, 375);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(125, 45);
            btnCalc.TabIndex = 5;
            btnCalc.Text = "&Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F);
            btnClear.Location = new Point(221, 375);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(125, 45);
            btnClear.TabIndex = 6;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F);
            btnExit.Location = new Point(401, 375);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(125, 45);
            btnExit.TabIndex = 7;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmEarningCalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 450);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalc);
            Controls.Add(lblTotal);
            Controls.Add(lblPayEarned);
            Controls.Add(lstOutput);
            Controls.Add(txtDaysWorked);
            Controls.Add(lblDaysWorked);
            Name = "frmEarningCalc";
            Text = "Earnings Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDaysWorked;
        private TextBox txtDaysWorked;
        private ListBox lstOutput;
        private Label lblPayEarned;
        private Label lblTotal;
        private Button btnCalc;
        private Button btnClear;
        private Button btnExit;
    }
}
