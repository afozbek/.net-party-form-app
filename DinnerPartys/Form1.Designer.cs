namespace DinnerPartys
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
            this.numberofLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.fancy_Check = new System.Windows.Forms.CheckBox();
            this.healty_Check = new System.Windows.Forms.CheckBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Birthday_Tab = new System.Windows.Forms.TabControl();
            this.DinnerTab = new System.Windows.Forms.TabPage();
            this.BirthdayTab = new System.Windows.Forms.TabPage();
            this.birthText_Label = new System.Windows.Forms.Label();
            this.birth_text = new System.Windows.Forms.TextBox();
            this.costB_label = new System.Windows.Forms.Label();
            this.fancy_CheckB = new System.Windows.Forms.CheckBox();
            this.costResult_label = new System.Windows.Forms.Label();
            this.numberB_label = new System.Windows.Forms.Label();
            this.numB_numeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.Birthday_Tab.SuspendLayout();
            this.DinnerTab.SuspendLayout();
            this.BirthdayTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numB_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // numberofLabel
            // 
            this.numberofLabel.AutoSize = true;
            this.numberofLabel.Location = new System.Drawing.Point(27, 34);
            this.numberofLabel.Name = "numberofLabel";
            this.numberofLabel.Size = new System.Drawing.Size(92, 13);
            this.numberofLabel.TabIndex = 0;
            this.numberofLabel.Text = "Number of People";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(145, 32);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // fancy_Check
            // 
            this.fancy_Check.AutoSize = true;
            this.fancy_Check.Location = new System.Drawing.Point(83, 78);
            this.fancy_Check.Name = "fancy_Check";
            this.fancy_Check.Size = new System.Drawing.Size(115, 17);
            this.fancy_Check.TabIndex = 2;
            this.fancy_Check.Text = "Fancy Decorations";
            this.fancy_Check.UseVisualStyleBackColor = true;
            this.fancy_Check.CheckedChanged += new System.EventHandler(this.fancy_Check_CheckedChanged);
            // 
            // healty_Check
            // 
            this.healty_Check.AutoSize = true;
            this.healty_Check.Location = new System.Drawing.Point(83, 118);
            this.healty_Check.Name = "healty_Check";
            this.healty_Check.Size = new System.Drawing.Size(90, 17);
            this.healty_Check.TabIndex = 3;
            this.healty_Check.Text = "Healty Option";
            this.healty_Check.UseVisualStyleBackColor = true;
            this.healty_Check.CheckedChanged += new System.EventHandler(this.healty_Check_CheckedChanged);
            // 
            // costLabel
            // 
            this.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costLabel.Location = new System.Drawing.Point(145, 177);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(100, 23);
            this.costLabel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cost";
            // 
            // Birthday_Tab
            // 
            this.Birthday_Tab.Controls.Add(this.DinnerTab);
            this.Birthday_Tab.Controls.Add(this.BirthdayTab);
            this.Birthday_Tab.Location = new System.Drawing.Point(12, 2);
            this.Birthday_Tab.Name = "Birthday_Tab";
            this.Birthday_Tab.SelectedIndex = 0;
            this.Birthday_Tab.Size = new System.Drawing.Size(290, 253);
            this.Birthday_Tab.TabIndex = 6;
            // 
            // DinnerTab
            // 
            this.DinnerTab.Controls.Add(this.numberofLabel);
            this.DinnerTab.Controls.Add(this.costLabel);
            this.DinnerTab.Controls.Add(this.label1);
            this.DinnerTab.Controls.Add(this.numericUpDown1);
            this.DinnerTab.Controls.Add(this.fancy_Check);
            this.DinnerTab.Controls.Add(this.healty_Check);
            this.DinnerTab.Location = new System.Drawing.Point(4, 22);
            this.DinnerTab.Name = "DinnerTab";
            this.DinnerTab.Padding = new System.Windows.Forms.Padding(3);
            this.DinnerTab.Size = new System.Drawing.Size(282, 227);
            this.DinnerTab.TabIndex = 0;
            this.DinnerTab.Text = "Dinner Party";
            this.DinnerTab.UseVisualStyleBackColor = true;
            // 
            // BirthdayTab
            // 
            this.BirthdayTab.Controls.Add(this.birthText_Label);
            this.BirthdayTab.Controls.Add(this.birth_text);
            this.BirthdayTab.Controls.Add(this.costB_label);
            this.BirthdayTab.Controls.Add(this.fancy_CheckB);
            this.BirthdayTab.Controls.Add(this.costResult_label);
            this.BirthdayTab.Controls.Add(this.numberB_label);
            this.BirthdayTab.Controls.Add(this.numB_numeric);
            this.BirthdayTab.Location = new System.Drawing.Point(4, 22);
            this.BirthdayTab.Name = "BirthdayTab";
            this.BirthdayTab.Padding = new System.Windows.Forms.Padding(3);
            this.BirthdayTab.Size = new System.Drawing.Size(282, 227);
            this.BirthdayTab.TabIndex = 1;
            this.BirthdayTab.Text = "Birthday Party";
            this.BirthdayTab.UseVisualStyleBackColor = true;
            // 
            // birthText_Label
            // 
            this.birthText_Label.AutoSize = true;
            this.birthText_Label.Location = new System.Drawing.Point(53, 133);
            this.birthText_Label.Name = "birthText_Label";
            this.birthText_Label.Size = new System.Drawing.Size(65, 13);
            this.birthText_Label.TabIndex = 14;
            this.birthText_Label.Text = "CakeWriting";
            // 
            // birth_text
            // 
            this.birth_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.birth_text.ForeColor = System.Drawing.Color.Red;
            this.birth_text.Location = new System.Drawing.Point(130, 130);
            this.birth_text.Name = "birth_text";
            this.birth_text.Size = new System.Drawing.Size(100, 20);
            this.birth_text.TabIndex = 13;
            this.birth_text.Text = "Happy Birthday";
            this.birth_text.TextChanged += new System.EventHandler(this.cakeText_Changed);
            // 
            // costB_label
            // 
            this.costB_label.AutoSize = true;
            this.costB_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.costB_label.Location = new System.Drawing.Point(53, 177);
            this.costB_label.Name = "costB_label";
            this.costB_label.Size = new System.Drawing.Size(40, 17);
            this.costB_label.TabIndex = 11;
            this.costB_label.Text = "Cost";
            // 
            // fancy_CheckB
            // 
            this.fancy_CheckB.AutoSize = true;
            this.fancy_CheckB.Location = new System.Drawing.Point(84, 92);
            this.fancy_CheckB.Name = "fancy_CheckB";
            this.fancy_CheckB.Size = new System.Drawing.Size(115, 17);
            this.fancy_CheckB.TabIndex = 9;
            this.fancy_CheckB.Text = "Fancy Decorations";
            this.fancy_CheckB.UseVisualStyleBackColor = true;
            this.fancy_CheckB.CheckedChanged += new System.EventHandler(this.fancy_CheckB_CheckedChanged);
            // 
            // costResult_label
            // 
            this.costResult_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costResult_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.costResult_label.Location = new System.Drawing.Point(144, 171);
            this.costResult_label.Name = "costResult_label";
            this.costResult_label.Size = new System.Drawing.Size(100, 23);
            this.costResult_label.TabIndex = 12;
            // 
            // numberB_label
            // 
            this.numberB_label.AutoSize = true;
            this.numberB_label.Location = new System.Drawing.Point(34, 52);
            this.numberB_label.Name = "numberB_label";
            this.numberB_label.Size = new System.Drawing.Size(92, 13);
            this.numberB_label.TabIndex = 7;
            this.numberB_label.Text = "Number of People";
            // 
            // numB_numeric
            // 
            this.numB_numeric.Location = new System.Drawing.Point(164, 50);
            this.numB_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numB_numeric.Name = "numB_numeric";
            this.numB_numeric.Size = new System.Drawing.Size(100, 20);
            this.numB_numeric.TabIndex = 8;
            this.numB_numeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numB_numeric.ValueChanged += new System.EventHandler(this.numB_numeric_ValueChanged);
            this.numB_numeric.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterPressed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 258);
            this.Controls.Add(this.Birthday_Tab);
            this.Name = "Form1";
            this.Text = "Party";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.Birthday_Tab.ResumeLayout(false);
            this.DinnerTab.ResumeLayout(false);
            this.DinnerTab.PerformLayout();
            this.BirthdayTab.ResumeLayout(false);
            this.BirthdayTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numB_numeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label numberofLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox fancy_Check;
        private System.Windows.Forms.CheckBox healty_Check;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl Birthday_Tab;
        private System.Windows.Forms.TabPage DinnerTab;
        private System.Windows.Forms.TabPage BirthdayTab;
        private System.Windows.Forms.TextBox birth_text;
        private System.Windows.Forms.Label costB_label;
        private System.Windows.Forms.CheckBox fancy_CheckB;
        private System.Windows.Forms.Label costResult_label;
        private System.Windows.Forms.Label numberB_label;
        private System.Windows.Forms.NumericUpDown numB_numeric;
        public System.Windows.Forms.Label birthText_Label;
    }
}

