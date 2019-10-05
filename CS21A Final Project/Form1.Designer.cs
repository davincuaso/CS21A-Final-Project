namespace CS21A_Final_Project
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPrintInventory = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.quantityPacks = new System.Windows.Forms.NumericUpDown();
            this.buttonRelease = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.donateGood = new System.Windows.Forms.ComboBox();
            this.buttonDonate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.donateQuantity = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.unit = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.releaseRate = new System.Windows.Forms.TextBox();
            this.addGood = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityPacks)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonPrintInventory);
            this.groupBox1.Controls.Add(this.buttonClearAll);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(281, 524);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tools";
            // 
            // buttonPrintInventory
            // 
            this.buttonPrintInventory.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintInventory.Location = new System.Drawing.Point(7, 457);
            this.buttonPrintInventory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPrintInventory.Name = "buttonPrintInventory";
            this.buttonPrintInventory.Size = new System.Drawing.Size(262, 28);
            this.buttonPrintInventory.TabIndex = 8;
            this.buttonPrintInventory.Text = "PRINT INVENTORY";
            this.buttonPrintInventory.UseVisualStyleBackColor = true;
            this.buttonPrintInventory.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearAll.Location = new System.Drawing.Point(7, 421);
            this.buttonClearAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(262, 28);
            this.buttonClearAll.TabIndex = 7;
            this.buttonClearAll.Text = "CLEAR ALL";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.quantityPacks);
            this.groupBox4.Controls.Add(this.buttonRelease);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(7, 322);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(262, 91);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Release Packs";
            // 
            // quantityPacks
            // 
            this.quantityPacks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityPacks.Location = new System.Drawing.Point(167, 22);
            this.quantityPacks.Name = "quantityPacks";
            this.quantityPacks.Size = new System.Drawing.Size(87, 18);
            this.quantityPacks.TabIndex = 7;
            // 
            // buttonRelease
            // 
            this.buttonRelease.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRelease.Location = new System.Drawing.Point(6, 48);
            this.buttonRelease.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRelease.Name = "buttonRelease";
            this.buttonRelease.Size = new System.Drawing.Size(248, 28);
            this.buttonRelease.TabIndex = 6;
            this.buttonRelease.Text = "RELEASE";
            this.buttonRelease.UseVisualStyleBackColor = true;
            this.buttonRelease.Click += new System.EventHandler(this.buttonRelease_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Quantity";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.donateGood);
            this.groupBox3.Controls.Add(this.buttonDonate);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.donateQuantity);
            this.groupBox3.Location = new System.Drawing.Point(7, 192);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(262, 122);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Donate Goods";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Good";
            // 
            // donateGood
            // 
            this.donateGood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.donateGood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donateGood.FormattingEnabled = true;
            this.donateGood.Location = new System.Drawing.Point(106, 23);
            this.donateGood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.donateGood.Name = "donateGood";
            this.donateGood.Size = new System.Drawing.Size(149, 25);
            this.donateGood.TabIndex = 9;
            // 
            // buttonDonate
            // 
            this.buttonDonate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDonate.Location = new System.Drawing.Point(6, 79);
            this.buttonDonate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDonate.Name = "buttonDonate";
            this.buttonDonate.Size = new System.Drawing.Size(249, 28);
            this.buttonDonate.TabIndex = 6;
            this.buttonDonate.Text = "DONATE";
            this.buttonDonate.UseVisualStyleBackColor = true;
            this.buttonDonate.Click += new System.EventHandler(this.buttonDonate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity";
            // 
            // donateQuantity
            // 
            this.donateQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.donateQuantity.Location = new System.Drawing.Point(106, 56);
            this.donateQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.donateQuantity.Name = "donateQuantity";
            this.donateQuantity.Size = new System.Drawing.Size(149, 15);
            this.donateQuantity.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.unit);
            this.groupBox2.Controls.Add(this.buttonAdd);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.releaseRate);
            this.groupBox2.Controls.Add(this.addGood);
            this.groupBox2.Location = new System.Drawing.Point(7, 25);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(262, 159);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New Goods";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Release Rate";
            // 
            // unit
            // 
            this.unit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unit.FormattingEnabled = true;
            this.unit.Items.AddRange(new object[] {
            "kg",
            "l",
            "packs",
            "cans"});
            this.unit.Location = new System.Drawing.Point(106, 83);
            this.unit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(149, 25);
            this.unit.TabIndex = 8;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(6, 116);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(250, 28);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Unit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Good";
            // 
            // releaseRate
            // 
            this.releaseRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.releaseRate.Location = new System.Drawing.Point(106, 53);
            this.releaseRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.releaseRate.Name = "releaseRate";
            this.releaseRate.Size = new System.Drawing.Size(149, 15);
            this.releaseRate.TabIndex = 1;
            // 
            // addGood
            // 
            this.addGood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addGood.Location = new System.Drawing.Point(106, 23);
            this.addGood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addGood.Name = "addGood";
            this.addGood.Size = new System.Drawing.Size(149, 15);
            this.addGood.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.richTextBox1);
            this.groupBox5.Location = new System.Drawing.Point(299, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(269, 524);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Output Window";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(6, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(257, 498);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(7, 492);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(262, 32);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 550);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Relief Center";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityPacks)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonRelease;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox donateGood;
        private System.Windows.Forms.Button buttonDonate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox donateQuantity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox unit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox releaseRate;
        private System.Windows.Forms.TextBox addGood;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonPrintInventory;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.NumericUpDown quantityPacks;
        private System.Windows.Forms.Button buttonDelete;
    }
}

