namespace UnitTestWinForms
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
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.txtOne = new System.Windows.Forms.TextBox();
            this.txtTwo = new System.Windows.Forms.TextBox();
            this.txtThree = new System.Windows.Forms.TextBox();
            this.btnCheckOne = new System.Windows.Forms.Button();
            this.btnCheckTwo = new System.Windows.Forms.Button();
            this.btnCheckThree = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.lblSum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(12, 12);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(75, 23);
            this.btnOne.TabIndex = 0;
            this.btnOne.Text = "First";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(12, 41);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(75, 23);
            this.btnTwo.TabIndex = 1;
            this.btnTwo.Text = "Second";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(12, 70);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(75, 23);
            this.btnThree.TabIndex = 2;
            this.btnThree.Text = "Third";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // txtOne
            // 
            this.txtOne.Location = new System.Drawing.Point(103, 14);
            this.txtOne.Name = "txtOne";
            this.txtOne.Size = new System.Drawing.Size(65, 20);
            this.txtOne.TabIndex = 3;
            // 
            // txtTwo
            // 
            this.txtTwo.Location = new System.Drawing.Point(103, 43);
            this.txtTwo.Name = "txtTwo";
            this.txtTwo.Size = new System.Drawing.Size(65, 20);
            this.txtTwo.TabIndex = 4;
            // 
            // txtThree
            // 
            this.txtThree.Location = new System.Drawing.Point(103, 72);
            this.txtThree.Name = "txtThree";
            this.txtThree.Size = new System.Drawing.Size(65, 20);
            this.txtThree.TabIndex = 5;
            // 
            // btnCheckOne
            // 
            this.btnCheckOne.Location = new System.Drawing.Point(183, 11);
            this.btnCheckOne.Name = "btnCheckOne";
            this.btnCheckOne.Size = new System.Drawing.Size(75, 23);
            this.btnCheckOne.TabIndex = 6;
            this.btnCheckOne.Text = "Check";
            this.btnCheckOne.UseVisualStyleBackColor = true;
            this.btnCheckOne.Click += new System.EventHandler(this.btnCheckOne_Click);
            // 
            // btnCheckTwo
            // 
            this.btnCheckTwo.Location = new System.Drawing.Point(183, 40);
            this.btnCheckTwo.Name = "btnCheckTwo";
            this.btnCheckTwo.Size = new System.Drawing.Size(75, 23);
            this.btnCheckTwo.TabIndex = 7;
            this.btnCheckTwo.Text = "Check";
            this.btnCheckTwo.UseVisualStyleBackColor = true;
            this.btnCheckTwo.Click += new System.EventHandler(this.btnCheckTwo_Click);
            // 
            // btnCheckThree
            // 
            this.btnCheckThree.Location = new System.Drawing.Point(183, 70);
            this.btnCheckThree.Name = "btnCheckThree";
            this.btnCheckThree.Size = new System.Drawing.Size(75, 23);
            this.btnCheckThree.TabIndex = 8;
            this.btnCheckThree.Text = "Check";
            this.btnCheckThree.UseVisualStyleBackColor = true;
            this.btnCheckThree.Click += new System.EventHandler(this.btnCheckThree_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(12, 99);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(75, 23);
            this.btnSum.TabIndex = 9;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(100, 104);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(0, 13);
            this.lblSum.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 280);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnCheckThree);
            this.Controls.Add(this.btnCheckTwo);
            this.Controls.Add(this.btnCheckOne);
            this.Controls.Add(this.txtThree);
            this.Controls.Add(this.txtTwo);
            this.Controls.Add(this.txtOne);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Name = "Form1";
            this.Text = "Lab Assignment 01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.TextBox txtOne;
        private System.Windows.Forms.TextBox txtTwo;
        private System.Windows.Forms.TextBox txtThree;
        private System.Windows.Forms.Button btnCheckOne;
        private System.Windows.Forms.Button btnCheckTwo;
        private System.Windows.Forms.Button btnCheckThree;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Label lblSum;
    }
}

