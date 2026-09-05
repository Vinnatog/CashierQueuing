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
            label3.Location = new Point(93, 185);
            label3.Name = "label3";
            label3.Size = new Size(125, 13);
            label3.TabIndex = 6;
            label3.Text = "*Click To Get A Number";
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.BorderStyle = BorderStyle.FixedSingle;
            lblQueue.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQueue.Location = new Point(346, 68);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(67, 27);
            lblQueue.TabIndex = 5;
            lblQueue.Text = "label2";
            // 
            // btnCashier
            // 
            btnCashier.FlatStyle = FlatStyle.Flat;
            btnCashier.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCashier.Location = new Point(81, 39);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(149, 133);
            btnCashier.TabIndex = 4;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = true;
            btnCashier.Click += btnCashier_Click;
            // 
            // QueuingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(lblQueue);
            Controls.Add(btnCashier);
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
