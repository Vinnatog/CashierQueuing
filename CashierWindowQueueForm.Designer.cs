namespace CashierQueuing
{
    partial class CashierWindowQueueForm
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
            components = new System.ComponentModel.Container();
            listCashierQueue = new ListView();
            btnNext = new Button();
            btnRefresh = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // listCashierQueue
            // 
            listCashierQueue.Location = new Point(348, 12);
            listCashierQueue.Name = "listCashierQueue";
            listCashierQueue.Size = new Size(336, 426);
            listCashierQueue.TabIndex = 6;
            listCashierQueue.UseCompatibleStateImageBehavior = false;
            listCashierQueue.View = View.List;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Lime;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Location = new Point(173, 87);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(136, 42);
            btnNext.TabIndex = 5;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(255, 255, 128);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Location = new Point(173, 18);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(136, 42);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // CashierWindowQueueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listCashierQueue);
            Controls.Add(btnNext);
            Controls.Add(btnRefresh);
            Name = "CashierWindowQueueForm";
            Text = "CashierWindowQueueForm";
            ResumeLayout(false);
        }

        #endregion
        private ListView listCashierQueue;
        private Button btnNext;
        private Button btnRefresh;
        private System.Windows.Forms.Timer timer1;
    }
}