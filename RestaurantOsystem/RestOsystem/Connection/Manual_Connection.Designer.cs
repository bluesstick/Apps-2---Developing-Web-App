namespace RestaurantOsystem.Connection
{
    partial class Manual_Connection
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
            this.txtCnString = new System.Windows.Forms.TextBox();
            this.btn_GeCoSt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter LOCAL connection string";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(552, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "When you ready click \"Generate connection string\", it will create a File that wil" +
    "l content your encrypted connection. \r\nNow your connection is more secure agains" +
    "t possible hackers.";
            // 
            // txtCnString
            // 
            this.txtCnString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCnString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnString.Location = new System.Drawing.Point(15, 103);
            this.txtCnString.Multiline = true;
            this.txtCnString.Name = "txtCnString";
            this.txtCnString.Size = new System.Drawing.Size(544, 80);
            this.txtCnString.TabIndex = 2;
            // 
            // btn_GeCoSt
            // 
            this.btn_GeCoSt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_GeCoSt.FlatAppearance.BorderSize = 0;
            this.btn_GeCoSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GeCoSt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_GeCoSt.Location = new System.Drawing.Point(15, 189);
            this.btn_GeCoSt.Name = "btn_GeCoSt";
            this.btn_GeCoSt.Size = new System.Drawing.Size(290, 47);
            this.btn_GeCoSt.TabIndex = 3;
            this.btn_GeCoSt.Text = "Generate connection string";
            this.btn_GeCoSt.UseVisualStyleBackColor = false;
            this.btn_GeCoSt.Click += new System.EventHandler(this.btn_GeCoSt_Click);
            // 
            // Manual_Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 263);
            this.Controls.Add(this.btn_GeCoSt);
            this.Controls.Add(this.txtCnString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Manual_Connection";
            this.Text = "Manual Connection";
            this.Load += new System.EventHandler(this.Manual_Connection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCnString;
        private System.Windows.Forms.Button btn_GeCoSt;
    }
}