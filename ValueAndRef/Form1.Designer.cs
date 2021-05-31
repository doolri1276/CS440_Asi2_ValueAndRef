
namespace ValueAndRef
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDoubleB = new System.Windows.Forms.Label();
            this.lblDoubleA = new System.Windows.Forms.Label();
            this.btnSwapDouble = new System.Windows.Forms.Button();
            this.btnSwapString = new System.Windows.Forms.Button();
            this.lblStringA = new System.Windows.Forms.Label();
            this.lblStringB = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSwapStringRef = new System.Windows.Forms.Button();
            this.btnSwapStudent = new System.Windows.Forms.Button();
            this.lblStudentA = new System.Windows.Forms.Label();
            this.lblStudentB = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Double";
            // 
            // lblDoubleB
            // 
            this.lblDoubleB.AutoSize = true;
            this.lblDoubleB.Location = new System.Drawing.Point(331, 91);
            this.lblDoubleB.Name = "lblDoubleB";
            this.lblDoubleB.Size = new System.Drawing.Size(71, 32);
            this.lblDoubleB.TabIndex = 3;
            this.lblDoubleB.Text = "13.28";
            // 
            // lblDoubleA
            // 
            this.lblDoubleA.AutoSize = true;
            this.lblDoubleA.Location = new System.Drawing.Point(166, 91);
            this.lblDoubleA.Name = "lblDoubleA";
            this.lblDoubleA.Size = new System.Drawing.Size(58, 32);
            this.lblDoubleA.TabIndex = 4;
            this.lblDoubleA.Text = "5.19";
            // 
            // btnSwapDouble
            // 
            this.btnSwapDouble.Location = new System.Drawing.Point(453, 84);
            this.btnSwapDouble.Name = "btnSwapDouble";
            this.btnSwapDouble.Size = new System.Drawing.Size(237, 46);
            this.btnSwapDouble.TabIndex = 5;
            this.btnSwapDouble.Text = "Swap Double";
            this.btnSwapDouble.UseVisualStyleBackColor = true;
            this.btnSwapDouble.Click += new System.EventHandler(this.btnSwapDouble_Click);
            // 
            // btnSwapString
            // 
            this.btnSwapString.Location = new System.Drawing.Point(453, 158);
            this.btnSwapString.Name = "btnSwapString";
            this.btnSwapString.Size = new System.Drawing.Size(237, 46);
            this.btnSwapString.TabIndex = 9;
            this.btnSwapString.Text = "Swap String";
            this.btnSwapString.UseVisualStyleBackColor = true;
            this.btnSwapString.Click += new System.EventHandler(this.btnSwapString_Click);
            // 
            // lblStringA
            // 
            this.lblStringA.AutoSize = true;
            this.lblStringA.Location = new System.Drawing.Point(166, 165);
            this.lblStringA.Name = "lblStringA";
            this.lblStringA.Size = new System.Drawing.Size(70, 32);
            this.lblStringA.TabIndex = 8;
            this.lblStringA.Text = "Hello";
            this.lblStringA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStringB
            // 
            this.lblStringB.AutoSize = true;
            this.lblStringB.Location = new System.Drawing.Point(331, 165);
            this.lblStringB.Name = "lblStringB";
            this.lblStringB.Size = new System.Drawing.Size(77, 32);
            this.lblStringB.TabIndex = 7;
            this.lblStringB.Text = "World";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 32);
            this.label8.TabIndex = 6;
            this.label8.Text = "String";
            // 
            // btnSwapStringRef
            // 
            this.btnSwapStringRef.Location = new System.Drawing.Point(453, 220);
            this.btnSwapStringRef.Name = "btnSwapStringRef";
            this.btnSwapStringRef.Size = new System.Drawing.Size(237, 46);
            this.btnSwapStringRef.TabIndex = 10;
            this.btnSwapStringRef.Text = "Swap String Ref";
            this.btnSwapStringRef.UseVisualStyleBackColor = true;
            this.btnSwapStringRef.Click += new System.EventHandler(this.btnSwapStringRef_Click);
            // 
            // btnSwapStudent
            // 
            this.btnSwapStudent.Location = new System.Drawing.Point(453, 285);
            this.btnSwapStudent.Name = "btnSwapStudent";
            this.btnSwapStudent.Size = new System.Drawing.Size(237, 46);
            this.btnSwapStudent.TabIndex = 14;
            this.btnSwapStudent.Text = "Swap Student";
            this.btnSwapStudent.UseVisualStyleBackColor = true;
            this.btnSwapStudent.Click += new System.EventHandler(this.btnSwapStudent_Click);
            // 
            // lblStudentA
            // 
            this.lblStudentA.AutoSize = true;
            this.lblStudentA.Location = new System.Drawing.Point(154, 285);
            this.lblStudentA.Name = "lblStudentA";
            this.lblStudentA.Size = new System.Drawing.Size(60, 32);
            this.lblStudentA.TabIndex = 13;
            this.lblStudentA.Text = "Tom";
            this.lblStudentA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStudentB
            // 
            this.lblStudentB.AutoSize = true;
            this.lblStudentB.Location = new System.Drawing.Point(325, 285);
            this.lblStudentB.Name = "lblStudentB";
            this.lblStudentB.Size = new System.Drawing.Size(60, 32);
            this.lblStudentB.TabIndex = 12;
            this.lblStudentB.Text = "Sam";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(33, 285);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(97, 32);
            this.l.TabIndex = 11;
            this.l.Text = "Student";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.btnSwapStudent);
            this.Controls.Add(this.lblStudentA);
            this.Controls.Add(this.lblStudentB);
            this.Controls.Add(this.l);
            this.Controls.Add(this.btnSwapStringRef);
            this.Controls.Add(this.btnSwapString);
            this.Controls.Add(this.lblStringA);
            this.Controls.Add(this.lblStringB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSwapDouble);
            this.Controls.Add(this.lblDoubleA);
            this.Controls.Add(this.lblDoubleB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDoubleB;
        private System.Windows.Forms.Label lblDoubleA;
        private System.Windows.Forms.Button btnSwapDouble;
        private System.Windows.Forms.Button btnSwapString;
        private System.Windows.Forms.Label lblStringA;
        private System.Windows.Forms.Label lblStringB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSwapStringRef;
        private System.Windows.Forms.Button btnSwapStudent;
        private System.Windows.Forms.Label lblStudentA;
        private System.Windows.Forms.Label lblStudentB;
        private System.Windows.Forms.Label l;
    }
}

