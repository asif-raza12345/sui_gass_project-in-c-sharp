namespace Siu_Gass_DataBaseSystem
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
            this.btninsertbill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.texes = new System.Windows.Forms.TextBox();
            this.totalBill = new System.Windows.Forms.TextBox();
            this.billMonth = new System.Windows.Forms.TextBox();
            this.serviceCharge = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.customerID = new System.Windows.Forms.TextBox();
            this.customerName = new System.Windows.Forms.TextBox();
            this.meterID = new System.Windows.Forms.TextBox();
            this.billingPeriod = new System.Windows.Forms.TextBox();
            this.billlingDate = new System.Windows.Forms.TextBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.Browsbtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btninsertbill
            // 
            this.btninsertbill.BackColor = System.Drawing.Color.MediumOrchid;
            this.btninsertbill.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertbill.ForeColor = System.Drawing.SystemColors.Control;
            this.btninsertbill.Location = new System.Drawing.Point(19, 280);
            this.btninsertbill.Name = "btninsertbill";
            this.btninsertbill.Size = new System.Drawing.Size(111, 46);
            this.btninsertbill.TabIndex = 11;
            this.btninsertbill.Text = "Insert Bill";
            this.btninsertbill.UseVisualStyleBackColor = false;
            this.btninsertbill.Click += new System.EventHandler(this.btninsertbill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Texes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Bill";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(344, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bill Month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(344, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Service Charges";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(344, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Status";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // texes
            // 
            this.texes.Location = new System.Drawing.Point(469, 30);
            this.texes.Name = "texes";
            this.texes.Size = new System.Drawing.Size(176, 20);
            this.texes.TabIndex = 6;
            // 
            // totalBill
            // 
            this.totalBill.Location = new System.Drawing.Point(469, 80);
            this.totalBill.Name = "totalBill";
            this.totalBill.ShortcutsEnabled = false;
            this.totalBill.Size = new System.Drawing.Size(176, 20);
            this.totalBill.TabIndex = 7;
            // 
            // billMonth
            // 
            this.billMonth.Location = new System.Drawing.Point(469, 131);
            this.billMonth.Name = "billMonth";
            this.billMonth.Size = new System.Drawing.Size(176, 20);
            this.billMonth.TabIndex = 8;
            // 
            // serviceCharge
            // 
            this.serviceCharge.Location = new System.Drawing.Point(469, 186);
            this.serviceCharge.Name = "serviceCharge";
            this.serviceCharge.Size = new System.Drawing.Size(176, 20);
            this.serviceCharge.TabIndex = 9;
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(469, 237);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(176, 20);
            this.status.TabIndex = 10;
            this.status.TextChanged += new System.EventHandler(this.status_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Meter ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Customer ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "Customer Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "Meter ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 19);
            this.label11.TabIndex = 1;
            this.label11.Text = "Billing Period";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 19);
            this.label12.TabIndex = 1;
            this.label12.Text = "Billing Date";
            // 
            // customerID
            // 
            this.customerID.Location = new System.Drawing.Point(153, 30);
            this.customerID.Name = "customerID";
            this.customerID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.customerID.Size = new System.Drawing.Size(176, 20);
            this.customerID.TabIndex = 1;
            this.customerID.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(153, 82);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(176, 20);
            this.customerName.TabIndex = 2;
            this.customerName.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // meterID
            // 
            this.meterID.Location = new System.Drawing.Point(153, 133);
            this.meterID.Name = "meterID";
            this.meterID.Size = new System.Drawing.Size(176, 20);
            this.meterID.TabIndex = 3;
            this.meterID.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // billingPeriod
            // 
            this.billingPeriod.Location = new System.Drawing.Point(153, 186);
            this.billingPeriod.Name = "billingPeriod";
            this.billingPeriod.Size = new System.Drawing.Size(176, 20);
            this.billingPeriod.TabIndex = 4;
            this.billingPeriod.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // billlingDate
            // 
            this.billlingDate.Location = new System.Drawing.Point(153, 239);
            this.billlingDate.Name = "billlingDate";
            this.billlingDate.Size = new System.Drawing.Size(176, 20);
            this.billlingDate.TabIndex = 5;
            this.billlingDate.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.Color.Crimson;
            this.btnshow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnshow.Location = new System.Drawing.Point(519, 279);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(132, 50);
            this.btnshow.TabIndex = 14;
            this.btnshow.Text = "Show All";
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 354);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(832, 200);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DeepPink;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(165, 280);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 46);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btndelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndelete.Location = new System.Drawing.Point(338, 279);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(146, 47);
            this.btndelete.TabIndex = 16;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Browsbtn
            // 
            this.Browsbtn.BackColor = System.Drawing.Color.Green;
            this.Browsbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browsbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Browsbtn.Location = new System.Drawing.Point(707, 273);
            this.Browsbtn.Name = "Browsbtn";
            this.Browsbtn.Size = new System.Drawing.Size(116, 49);
            this.Browsbtn.TabIndex = 18;
            this.Browsbtn.Text = "Brows";
            this.Browsbtn.UseVisualStyleBackColor = false;
            this.Browsbtn.Click += new System.EventHandler(this.Browsbtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(674, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Description";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(663, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(856, 566);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Browsbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.billlingDate);
            this.Controls.Add(this.status);
            this.Controls.Add(this.billingPeriod);
            this.Controls.Add(this.serviceCharge);
            this.Controls.Add(this.meterID);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.billMonth);
            this.Controls.Add(this.customerID);
            this.Controls.Add(this.totalBill);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.texes);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btninsertbill);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Bill Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btninsertbill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox texes;
        private System.Windows.Forms.TextBox totalBill;
        private System.Windows.Forms.TextBox billMonth;
        private System.Windows.Forms.TextBox serviceCharge;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox customerID;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.TextBox meterID;
        private System.Windows.Forms.TextBox billingPeriod;
        private System.Windows.Forms.TextBox billlingDate;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Browsbtn;
        private System.Windows.Forms.Label label6;
    }
}

