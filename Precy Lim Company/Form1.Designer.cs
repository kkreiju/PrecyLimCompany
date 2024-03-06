namespace Precy_Lim_Company
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.OrderNumberTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QuantityTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SmallRadioButton = new System.Windows.Forms.RadioButton();
            this.MediumRadioButton = new System.Windows.Forms.RadioButton();
            this.LargeRadioButton = new System.Windows.Forms.RadioButton();
            this.ExtraLargeRadioButton = new System.Windows.Forms.RadioButton();
            this.XXLRadioButton = new System.Windows.Forms.RadioButton();
            this.MonogramCheckbox = new System.Windows.Forms.CheckBox();
            this.PocketCheckbox = new System.Windows.Forms.CheckBox();
            this.AddTshirtButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CompleteOrderButton = new System.Windows.Forms.Button();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CurrentOrderLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OrderTotalLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(141, 46);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(100, 20);
            this.NameTextbox.TabIndex = 0;
            // 
            // OrderNumberTextbox
            // 
            this.OrderNumberTextbox.Location = new System.Drawing.Point(619, 49);
            this.OrderNumberTextbox.Name = "OrderNumberTextbox";
            this.OrderNumberTextbox.Size = new System.Drawing.Size(100, 20);
            this.OrderNumberTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Order Number";
            // 
            // QuantityTextbox
            // 
            this.QuantityTextbox.Location = new System.Drawing.Point(141, 116);
            this.QuantityTextbox.Name = "QuantityTextbox";
            this.QuantityTextbox.Size = new System.Drawing.Size(100, 20);
            this.QuantityTextbox.TabIndex = 4;
            this.QuantityTextbox.TextChanged += new System.EventHandler(this.QuantityTextbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(273, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precy Lim Company";
            // 
            // SmallRadioButton
            // 
            this.SmallRadioButton.AutoSize = true;
            this.SmallRadioButton.Location = new System.Drawing.Point(308, 123);
            this.SmallRadioButton.Name = "SmallRadioButton";
            this.SmallRadioButton.Size = new System.Drawing.Size(50, 17);
            this.SmallRadioButton.TabIndex = 7;
            this.SmallRadioButton.TabStop = true;
            this.SmallRadioButton.Text = "Small";
            this.SmallRadioButton.UseVisualStyleBackColor = true;
            this.SmallRadioButton.CheckedChanged += new System.EventHandler(this.SmallRadioButton_CheckedChanged);
            // 
            // MediumRadioButton
            // 
            this.MediumRadioButton.AutoSize = true;
            this.MediumRadioButton.Location = new System.Drawing.Point(308, 146);
            this.MediumRadioButton.Name = "MediumRadioButton";
            this.MediumRadioButton.Size = new System.Drawing.Size(62, 17);
            this.MediumRadioButton.TabIndex = 8;
            this.MediumRadioButton.TabStop = true;
            this.MediumRadioButton.Text = "Medium";
            this.MediumRadioButton.UseVisualStyleBackColor = true;
            this.MediumRadioButton.CheckedChanged += new System.EventHandler(this.MediumRadioButton_CheckedChanged);
            // 
            // LargeRadioButton
            // 
            this.LargeRadioButton.AutoSize = true;
            this.LargeRadioButton.Location = new System.Drawing.Point(308, 169);
            this.LargeRadioButton.Name = "LargeRadioButton";
            this.LargeRadioButton.Size = new System.Drawing.Size(52, 17);
            this.LargeRadioButton.TabIndex = 9;
            this.LargeRadioButton.TabStop = true;
            this.LargeRadioButton.Text = "Large";
            this.LargeRadioButton.UseVisualStyleBackColor = true;
            this.LargeRadioButton.CheckedChanged += new System.EventHandler(this.LargeRadioButton_CheckedChanged);
            // 
            // ExtraLargeRadioButton
            // 
            this.ExtraLargeRadioButton.AutoSize = true;
            this.ExtraLargeRadioButton.Location = new System.Drawing.Point(308, 192);
            this.ExtraLargeRadioButton.Name = "ExtraLargeRadioButton";
            this.ExtraLargeRadioButton.Size = new System.Drawing.Size(79, 17);
            this.ExtraLargeRadioButton.TabIndex = 10;
            this.ExtraLargeRadioButton.TabStop = true;
            this.ExtraLargeRadioButton.Text = "Extra Large";
            this.ExtraLargeRadioButton.UseVisualStyleBackColor = true;
            this.ExtraLargeRadioButton.CheckedChanged += new System.EventHandler(this.ExtraLargeRadioButton_CheckedChanged);
            // 
            // XXLRadioButton
            // 
            this.XXLRadioButton.AutoSize = true;
            this.XXLRadioButton.Location = new System.Drawing.Point(308, 215);
            this.XXLRadioButton.Name = "XXLRadioButton";
            this.XXLRadioButton.Size = new System.Drawing.Size(45, 17);
            this.XXLRadioButton.TabIndex = 11;
            this.XXLRadioButton.TabStop = true;
            this.XXLRadioButton.Text = "XXL";
            this.XXLRadioButton.UseVisualStyleBackColor = true;
            this.XXLRadioButton.CheckedChanged += new System.EventHandler(this.XXLRadioButton_CheckedChanged);
            // 
            // MonogramCheckbox
            // 
            this.MonogramCheckbox.AutoSize = true;
            this.MonogramCheckbox.Location = new System.Drawing.Point(424, 124);
            this.MonogramCheckbox.Name = "MonogramCheckbox";
            this.MonogramCheckbox.Size = new System.Drawing.Size(76, 17);
            this.MonogramCheckbox.TabIndex = 12;
            this.MonogramCheckbox.Text = "Monogram";
            this.MonogramCheckbox.UseVisualStyleBackColor = true;
            this.MonogramCheckbox.CheckedChanged += new System.EventHandler(this.MonogramCheckbox_CheckedChanged);
            // 
            // PocketCheckbox
            // 
            this.PocketCheckbox.AutoSize = true;
            this.PocketCheckbox.Location = new System.Drawing.Point(424, 148);
            this.PocketCheckbox.Name = "PocketCheckbox";
            this.PocketCheckbox.Size = new System.Drawing.Size(60, 17);
            this.PocketCheckbox.TabIndex = 13;
            this.PocketCheckbox.Text = "Pocket";
            this.PocketCheckbox.UseVisualStyleBackColor = true;
            this.PocketCheckbox.CheckedChanged += new System.EventHandler(this.PocketCheckbox_CheckedChanged);
            // 
            // AddTshirtButton
            // 
            this.AddTshirtButton.Location = new System.Drawing.Point(195, 282);
            this.AddTshirtButton.Name = "AddTshirtButton";
            this.AddTshirtButton.Size = new System.Drawing.Size(75, 23);
            this.AddTshirtButton.TabIndex = 14;
            this.AddTshirtButton.Text = "Add Tshirt";
            this.AddTshirtButton.UseVisualStyleBackColor = true;
            this.AddTshirtButton.Click += new System.EventHandler(this.AddTshirtButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(298, 281);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 15;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CompleteOrderButton
            // 
            this.CompleteOrderButton.Location = new System.Drawing.Point(404, 281);
            this.CompleteOrderButton.Name = "CompleteOrderButton";
            this.CompleteOrderButton.Size = new System.Drawing.Size(124, 23);
            this.CompleteOrderButton.TabIndex = 16;
            this.CompleteOrderButton.Text = "Complete Order";
            this.CompleteOrderButton.UseVisualStyleBackColor = true;
            this.CompleteOrderButton.Click += new System.EventHandler(this.CompleteOrderButton_Click);
            // 
            // SummaryButton
            // 
            this.SummaryButton.Location = new System.Drawing.Point(566, 281);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(75, 23);
            this.SummaryButton.TabIndex = 17;
            this.SummaryButton.Text = "Summary";
            this.SummaryButton.UseVisualStyleBackColor = true;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(604, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Current Order";
            // 
            // CurrentOrderLabel
            // 
            this.CurrentOrderLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentOrderLabel.Location = new System.Drawing.Point(596, 146);
            this.CurrentOrderLabel.Name = "CurrentOrderLabel";
            this.CurrentOrderLabel.Size = new System.Drawing.Size(94, 15);
            this.CurrentOrderLabel.TabIndex = 19;
            this.CurrentOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(614, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Order Total";
            // 
            // OrderTotalLabel
            // 
            this.OrderTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderTotalLabel.Location = new System.Drawing.Point(596, 203);
            this.OrderTotalLabel.Name = "OrderTotalLabel";
            this.OrderTotalLabel.Size = new System.Drawing.Size(94, 15);
            this.OrderTotalLabel.TabIndex = 21;
            this.OrderTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(818, 471);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrderTotalLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CurrentOrderLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SummaryButton);
            this.Controls.Add(this.CompleteOrderButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AddTshirtButton);
            this.Controls.Add(this.PocketCheckbox);
            this.Controls.Add(this.MonogramCheckbox);
            this.Controls.Add(this.XXLRadioButton);
            this.Controls.Add(this.ExtraLargeRadioButton);
            this.Controls.Add(this.LargeRadioButton);
            this.Controls.Add(this.MediumRadioButton);
            this.Controls.Add(this.SmallRadioButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QuantityTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderNumberTextbox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox OrderNumberTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox QuantityTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton SmallRadioButton;
        private System.Windows.Forms.RadioButton MediumRadioButton;
        private System.Windows.Forms.RadioButton LargeRadioButton;
        private System.Windows.Forms.RadioButton ExtraLargeRadioButton;
        private System.Windows.Forms.RadioButton XXLRadioButton;
        private System.Windows.Forms.CheckBox MonogramCheckbox;
        private System.Windows.Forms.CheckBox PocketCheckbox;
        private System.Windows.Forms.Button AddTshirtButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button CompleteOrderButton;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CurrentOrderLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label OrderTotalLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

