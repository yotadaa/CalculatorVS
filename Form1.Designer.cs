
namespace CalculatorApp
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
            this.teks = new System.Windows.Forms.TextBox();
            this.AddZero = new System.Windows.Forms.Button();
            this.commas = new System.Windows.Forms.Button();
            this.resultButton = new System.Windows.Forms.Button();
            this.addOne = new System.Windows.Forms.Button();
            this.substractButton = new System.Windows.Forms.Button();
            this.addThree = new System.Windows.Forms.Button();
            this.addTwo = new System.Windows.Forms.Button();
            this.addFive = new System.Windows.Forms.Button();
            this.addSix = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.addFour = new System.Windows.Forms.Button();
            this.clearEntryButton = new System.Windows.Forms.Button();
            this.addEight = new System.Windows.Forms.Button();
            this.addNine = new System.Windows.Forms.Button();
            this.addSeven = new System.Windows.Forms.Button();
            this.addDoubleZeros = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.sumButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // teks
            // 
            this.teks.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.teks.Location = new System.Drawing.Point(12, 56);
            this.teks.Multiline = true;
            this.teks.Name = "teks";
            this.teks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.teks.Size = new System.Drawing.Size(419, 110);
            this.teks.TabIndex = 0;
            this.teks.TextChanged += new System.EventHandler(this.teks_TextChanged);
            this.teks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.teks_KeyPress);
            // 
            // AddZero
            // 
            this.AddZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.AddZero.Location = new System.Drawing.Point(13, 419);
            this.AddZero.Name = "AddZero";
            this.AddZero.Size = new System.Drawing.Size(79, 76);
            this.AddZero.TabIndex = 1;
            this.AddZero.Text = "0";
            this.AddZero.UseVisualStyleBackColor = true;
            this.AddZero.Click += new System.EventHandler(this.addZero_Click);
            // 
            // commas
            // 
            this.commas.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.commas.Location = new System.Drawing.Point(183, 419);
            this.commas.Name = "commas";
            this.commas.Size = new System.Drawing.Size(79, 76);
            this.commas.TabIndex = 3;
            this.commas.Text = ",";
            this.commas.UseVisualStyleBackColor = true;
            this.commas.Click += new System.EventHandler(this.commas_Click);
            // 
            // resultButton
            // 
            this.resultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.resultButton.Location = new System.Drawing.Point(353, 419);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(79, 76);
            this.resultButton.TabIndex = 4;
            this.resultButton.Text = "=";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // addOne
            // 
            this.addOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.addOne.Location = new System.Drawing.Point(13, 337);
            this.addOne.Name = "addOne";
            this.addOne.Size = new System.Drawing.Size(79, 76);
            this.addOne.TabIndex = 5;
            this.addOne.Text = "1";
            this.addOne.UseVisualStyleBackColor = true;
            this.addOne.Click += new System.EventHandler(this.addOne_Click);
            // 
            // substractButton
            // 
            this.substractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.substractButton.Location = new System.Drawing.Point(268, 337);
            this.substractButton.Name = "substractButton";
            this.substractButton.Size = new System.Drawing.Size(79, 76);
            this.substractButton.TabIndex = 6;
            this.substractButton.Text = "-";
            this.substractButton.UseVisualStyleBackColor = true;
            this.substractButton.Click += new System.EventHandler(this.substractButton_Click);
            // 
            // addThree
            // 
            this.addThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.addThree.Location = new System.Drawing.Point(183, 337);
            this.addThree.Name = "addThree";
            this.addThree.Size = new System.Drawing.Size(79, 76);
            this.addThree.TabIndex = 7;
            this.addThree.Text = "3";
            this.addThree.UseVisualStyleBackColor = true;
            this.addThree.Click += new System.EventHandler(this.addThree_Click);
            // 
            // addTwo
            // 
            this.addTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.addTwo.Location = new System.Drawing.Point(98, 337);
            this.addTwo.Name = "addTwo";
            this.addTwo.Size = new System.Drawing.Size(79, 76);
            this.addTwo.TabIndex = 8;
            this.addTwo.Text = "2";
            this.addTwo.UseVisualStyleBackColor = true;
            this.addTwo.Click += new System.EventHandler(this.addTwo_Click);
            // 
            // addFive
            // 
            this.addFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.addFive.Location = new System.Drawing.Point(98, 255);
            this.addFive.Name = "addFive";
            this.addFive.Size = new System.Drawing.Size(79, 76);
            this.addFive.TabIndex = 12;
            this.addFive.Text = "5";
            this.addFive.UseVisualStyleBackColor = true;
            this.addFive.Click += new System.EventHandler(this.addFive_Click);
            // 
            // addSix
            // 
            this.addSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.addSix.Location = new System.Drawing.Point(183, 255);
            this.addSix.Name = "addSix";
            this.addSix.Size = new System.Drawing.Size(79, 76);
            this.addSix.TabIndex = 11;
            this.addSix.Text = "6";
            this.addSix.UseVisualStyleBackColor = true;
            this.addSix.Click += new System.EventHandler(this.addSix_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.multiplyButton.Location = new System.Drawing.Point(268, 255);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(79, 76);
            this.multiplyButton.TabIndex = 10;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // addFour
            // 
            this.addFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.addFour.Location = new System.Drawing.Point(13, 255);
            this.addFour.Name = "addFour";
            this.addFour.Size = new System.Drawing.Size(79, 76);
            this.addFour.TabIndex = 9;
            this.addFour.Text = "4";
            this.addFour.UseVisualStyleBackColor = true;
            this.addFour.Click += new System.EventHandler(this.addFour_Click);
            // 
            // clearEntryButton
            // 
            this.clearEntryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.clearEntryButton.Location = new System.Drawing.Point(353, 255);
            this.clearEntryButton.Name = "clearEntryButton";
            this.clearEntryButton.Size = new System.Drawing.Size(79, 76);
            this.clearEntryButton.TabIndex = 18;
            this.clearEntryButton.Text = "CE";
            this.clearEntryButton.UseVisualStyleBackColor = true;
            this.clearEntryButton.Click += new System.EventHandler(this.clearEntryButton_Click);
            // 
            // addEight
            // 
            this.addEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.addEight.Location = new System.Drawing.Point(98, 173);
            this.addEight.Name = "addEight";
            this.addEight.Size = new System.Drawing.Size(79, 76);
            this.addEight.TabIndex = 17;
            this.addEight.Text = "8";
            this.addEight.UseVisualStyleBackColor = true;
            this.addEight.Click += new System.EventHandler(this.addEight_Click);
            // 
            // addNine
            // 
            this.addNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.addNine.Location = new System.Drawing.Point(183, 173);
            this.addNine.Name = "addNine";
            this.addNine.Size = new System.Drawing.Size(79, 76);
            this.addNine.TabIndex = 16;
            this.addNine.Text = "9";
            this.addNine.UseVisualStyleBackColor = true;
            this.addNine.Click += new System.EventHandler(this.addNine_Click);
            // 
            // addSeven
            // 
            this.addSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.addSeven.Location = new System.Drawing.Point(13, 173);
            this.addSeven.Name = "addSeven";
            this.addSeven.Size = new System.Drawing.Size(79, 76);
            this.addSeven.TabIndex = 14;
            this.addSeven.Text = "7";
            this.addSeven.UseVisualStyleBackColor = true;
            this.addSeven.Click += new System.EventHandler(this.addSeven_Click);
            // 
            // addDoubleZeros
            // 
            this.addDoubleZeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.addDoubleZeros.Location = new System.Drawing.Point(98, 419);
            this.addDoubleZeros.Name = "addDoubleZeros";
            this.addDoubleZeros.Size = new System.Drawing.Size(79, 76);
            this.addDoubleZeros.TabIndex = 19;
            this.addDoubleZeros.Text = "00";
            this.addDoubleZeros.UseVisualStyleBackColor = true;
            this.addDoubleZeros.Click += new System.EventHandler(this.addMultileZero_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.clearButton.Location = new System.Drawing.Point(353, 337);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(79, 76);
            this.clearButton.TabIndex = 20;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.divideButton.Location = new System.Drawing.Point(268, 173);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(79, 76);
            this.divideButton.TabIndex = 21;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // sumButton
            // 
            this.sumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.sumButton.Location = new System.Drawing.Point(268, 419);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(79, 76);
            this.sumButton.TabIndex = 22;
            this.sumButton.Text = "+";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button1.Location = new System.Drawing.Point(353, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 76);
            this.button1.TabIndex = 23;
            this.button1.Text = "del";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.delButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(418, 38);
            this.textBox1.TabIndex = 24;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Riwayat_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 504);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addDoubleZeros);
            this.Controls.Add(this.clearEntryButton);
            this.Controls.Add(this.addEight);
            this.Controls.Add(this.addNine);
            this.Controls.Add(this.addSeven);
            this.Controls.Add(this.addFive);
            this.Controls.Add(this.addSix);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.addFour);
            this.Controls.Add(this.addTwo);
            this.Controls.Add(this.addThree);
            this.Controls.Add(this.substractButton);
            this.Controls.Add(this.addOne);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.commas);
            this.Controls.Add(this.AddZero);
            this.Controls.Add(this.teks);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teks;
        private System.Windows.Forms.Button AddZero;
        private System.Windows.Forms.Button commas;
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.Button addOne;
        private System.Windows.Forms.Button substractButton;
        private System.Windows.Forms.Button addThree;
        private System.Windows.Forms.Button addTwo;
        private System.Windows.Forms.Button addFive;
        private System.Windows.Forms.Button addSix;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button addFour;
        private System.Windows.Forms.Button clearEntryButton;
        private System.Windows.Forms.Button addEight;
        private System.Windows.Forms.Button addNine;
        private System.Windows.Forms.Button addSeven;
        private System.Windows.Forms.Button addDoubleZeros;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

