namespace Project2
{
    partial class formRemove
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
            this.label2 = new System.Windows.Forms.Label();
            this.brnRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CBoxName = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Remove plane";
            // 
            // brnRemove
            // 
            this.brnRemove.BackColor = System.Drawing.Color.Red;
            this.brnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.brnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.brnRemove.Location = new System.Drawing.Point(257, 125);
            this.brnRemove.Name = "brnRemove";
            this.brnRemove.Size = new System.Drawing.Size(89, 44);
            this.brnRemove.TabIndex = 3;
            this.brnRemove.Text = "Remove";
            this.brnRemove.UseVisualStyleBackColor = false;
            this.brnRemove.Click += new System.EventHandler(this.brnRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Plane Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CBoxName
            // 
            this.CBoxName.FormattingEnabled = true;
            this.CBoxName.Location = new System.Drawing.Point(106, 74);
            this.CBoxName.Name = "CBoxName";
            this.CBoxName.Size = new System.Drawing.Size(240, 21);
            this.CBoxName.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(162, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(446, 192);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brnRemove);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Bell MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "formRemove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove form";
            this.Load += new System.EventHandler(this.formRemove_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button brnRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBoxName;
        private System.Windows.Forms.Button button1;
    }
}