namespace Project2
{
    partial class AddPlane
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHealth2 = new System.Windows.Forms.NumericUpDown();
            this.txtSpeed = new System.Windows.Forms.NumericUpDown();
            this.txtWeight = new System.Windows.Forms.NumericUpDown();
            this.txtDamage = new System.Windows.Forms.NumericUpDown();
            this.txtFuel = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtHealth2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plane Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Health Points:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Speed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Weight:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Damage:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(91, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Inventory:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(242, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(265, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtInventory
            // 
            this.txtInventory.Location = new System.Drawing.Point(242, 243);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.ReadOnly = true;
            this.txtInventory.Size = new System.Drawing.Size(46, 20);
            this.txtInventory.TabIndex = 11;
            this.txtInventory.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(90, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fuel level:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(242, 345);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 33);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add plane";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Firebrick;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(125, 345);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 33);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Plane Select";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bell MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(131, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 42);
            this.label8.TabIndex = 16;
            this.label8.Text = "Add a Plane";
            // 
            // txtHealth2
            // 
            this.txtHealth2.Location = new System.Drawing.Point(242, 101);
            this.txtHealth2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtHealth2.Name = "txtHealth2";
            this.txtHealth2.Size = new System.Drawing.Size(46, 20);
            this.txtHealth2.TabIndex = 17;
            this.txtHealth2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(242, 139);
            this.txtSpeed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(46, 20);
            this.txtSpeed.TabIndex = 18;
            this.txtSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(242, 174);
            this.txtWeight.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(46, 20);
            this.txtWeight.TabIndex = 19;
            this.txtWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtDamage
            // 
            this.txtDamage.Location = new System.Drawing.Point(242, 207);
            this.txtDamage.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.txtDamage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDamage.Name = "txtDamage";
            this.txtDamage.Size = new System.Drawing.Size(46, 20);
            this.txtDamage.TabIndex = 20;
            this.txtDamage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtFuel
            // 
            this.txtFuel.Location = new System.Drawing.Point(242, 282);
            this.txtFuel.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.txtFuel.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtFuel.Name = "txtFuel";
            this.txtFuel.Size = new System.Drawing.Size(46, 20);
            this.txtFuel.TabIndex = 21;
            this.txtFuel.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // AddPlane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(551, 401);
            this.Controls.Add(this.txtFuel);
            this.Controls.Add(this.txtDamage);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.txtHealth2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtInventory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPlane";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPlane";
            this.Load += new System.EventHandler(this.AddPlane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtHealth2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtHealth2;
        private System.Windows.Forms.NumericUpDown txtSpeed;
        private System.Windows.Forms.NumericUpDown txtWeight;
        private System.Windows.Forms.NumericUpDown txtDamage;
        private System.Windows.Forms.NumericUpDown txtFuel;
    }
}