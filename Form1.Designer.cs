namespace CashierQueuing
{
    partial class QueuingForm
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
            label3 = new Label();
            lblQueue = new Label();
            btnCashier = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(106, 247);
            label3.Name = "label3";
            label3.Size = new Size(154, 19);
            label3.TabIndex = 6;
            label3.Text = "*Click To Get A Number";
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.BorderStyle = BorderStyle.FixedSingle;
            lblQueue.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQueue.Location = new Point(395, 91);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(135, 34);
            lblQueue.TabIndex = 5;
            lblQueue.Text = "P - XXXXX";
            // 
            // btnCashier
            // 
            btnCashier.FlatStyle = FlatStyle.Flat;
            btnCashier.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCashier.Location = new Point(93, 52);
            btnCashier.Margin = new Padding(3, 4, 3, 4);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(170, 177);
            btnCashier.TabIndex = 4;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = true;
            btnCashier.Click += btnCashier_Click;
            // 
            // QueuingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label3);
            Controls.Add(lblQueue);
            Controls.Add(btnCashier);
            Margin = new Padding(3, 4, 3, 4);
            Name = "QueuingForm";
            Text = "QueuingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label lblQueue;
        private Button btnCashier;
    }
}
