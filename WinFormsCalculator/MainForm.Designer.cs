namespace WinFormsCalculator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainContainer = new System.Windows.Forms.Panel();
            this.txtExpression = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.buttonsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonOpenBracket = new System.Windows.Forms.Button();
            this.buttonCloseBracket = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDecimal = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.mainContainer.SuspendLayout();
            this.buttonsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mainContainer.Controls.Add(this.txtExpression);
            this.mainContainer.Controls.Add(this.txtResult);
            this.mainContainer.Controls.Add(this.buttonsContainer);
            this.mainContainer.Location = new System.Drawing.Point(24, 15);
            this.mainContainer.Margin = new System.Windows.Forms.Padding(4);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(327, 327);
            this.mainContainer.TabIndex = 22;
            // 
            // txtExpression
            // 
            this.txtExpression.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExpression.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtExpression.Location = new System.Drawing.Point(12, 4);
            this.txtExpression.Margin = new System.Windows.Forms.Padding(4);
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.ReadOnly = true;
            this.txtExpression.Size = new System.Drawing.Size(297, 22);
            this.txtExpression.TabIndex = 0;
            this.txtExpression.TabStop = false;
            // 
            // txtResult
            // 
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtResult.Location = new System.Drawing.Point(12, 36);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(297, 22);
            this.txtResult.TabIndex = 2;
            this.txtResult.TabStop = false;
            // 
            // buttonsContainer
            // 
            this.buttonsContainer.Controls.Add(this.button7);
            this.buttonsContainer.Controls.Add(this.button8);
            this.buttonsContainer.Controls.Add(this.button9);
            this.buttonsContainer.Controls.Add(this.buttonC);
            this.buttonsContainer.Controls.Add(this.buttonCE);
            this.buttonsContainer.Controls.Add(this.button4);
            this.buttonsContainer.Controls.Add(this.button5);
            this.buttonsContainer.Controls.Add(this.button6);
            this.buttonsContainer.Controls.Add(this.buttonOpenBracket);
            this.buttonsContainer.Controls.Add(this.buttonCloseBracket);
            this.buttonsContainer.Controls.Add(this.button1);
            this.buttonsContainer.Controls.Add(this.button2);
            this.buttonsContainer.Controls.Add(this.button3);
            this.buttonsContainer.Controls.Add(this.buttonMultiplication);
            this.buttonsContainer.Controls.Add(this.buttonDivision);
            this.buttonsContainer.Controls.Add(this.button0);
            this.buttonsContainer.Controls.Add(this.buttonDecimal);
            this.buttonsContainer.Controls.Add(this.buttonEqual);
            this.buttonsContainer.Controls.Add(this.buttonPlus);
            this.buttonsContainer.Controls.Add(this.buttonMinus);
            this.buttonsContainer.Location = new System.Drawing.Point(7, 80);
            this.buttonsContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonsContainer.Name = "buttonsContainer";
            this.buttonsContainer.Size = new System.Drawing.Size(313, 231);
            this.buttonsContainer.TabIndex = 20;
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(4, 4);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(53, 49);
            this.button7.TabIndex = 8;
            this.button7.TabStop = false;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(65, 4);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(53, 49);
            this.button8.TabIndex = 9;
            this.button8.TabStop = false;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(126, 4);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(53, 49);
            this.button9.TabIndex = 10;
            this.button9.TabStop = false;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonC
            // 
            this.buttonC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonC.BackColor = System.Drawing.Color.White;
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonC.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonC.Location = new System.Drawing.Point(187, 4);
            this.buttonC.Margin = new System.Windows.Forms.Padding(4);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(53, 49);
            this.buttonC.TabIndex = 18;
            this.buttonC.TabStop = false;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCE.BackColor = System.Drawing.Color.White;
            this.buttonCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCE.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonCE.Location = new System.Drawing.Point(248, 4);
            this.buttonCE.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(53, 49);
            this.buttonCE.TabIndex = 18;
            this.buttonCE.TabStop = false;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = false;
            this.buttonCE.Click += new System.EventHandler(this.clearEntry_Button_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(4, 61);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 49);
            this.button4.TabIndex = 5;
            this.button4.TabStop = false;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(65, 61);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 49);
            this.button5.TabIndex = 6;
            this.button5.TabStop = false;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(126, 61);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(53, 49);
            this.button6.TabIndex = 7;
            this.button6.TabStop = false;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonOpenBracket
            // 
            this.buttonOpenBracket.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonOpenBracket.BackColor = System.Drawing.Color.Transparent;
            this.buttonOpenBracket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenBracket.ForeColor = System.Drawing.Color.Blue;
            this.buttonOpenBracket.Location = new System.Drawing.Point(187, 61);
            this.buttonOpenBracket.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenBracket.Name = "buttonOpenBracket";
            this.buttonOpenBracket.Size = new System.Drawing.Size(53, 49);
            this.buttonOpenBracket.TabIndex = 14;
            this.buttonOpenBracket.TabStop = false;
            this.buttonOpenBracket.Text = "(";
            this.buttonOpenBracket.UseVisualStyleBackColor = false;
            this.buttonOpenBracket.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonCloseBracket
            // 
            this.buttonCloseBracket.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCloseBracket.BackColor = System.Drawing.Color.Transparent;
            this.buttonCloseBracket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseBracket.ForeColor = System.Drawing.Color.Blue;
            this.buttonCloseBracket.Location = new System.Drawing.Point(248, 61);
            this.buttonCloseBracket.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCloseBracket.Name = "buttonCloseBracket";
            this.buttonCloseBracket.Size = new System.Drawing.Size(53, 49);
            this.buttonCloseBracket.TabIndex = 16;
            this.buttonCloseBracket.TabStop = false;
            this.buttonCloseBracket.Text = ")";
            this.buttonCloseBracket.UseVisualStyleBackColor = false;
            this.buttonCloseBracket.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(4, 118);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 49);
            this.button1.TabIndex = 2;
            this.button1.TabStop = false;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(65, 118);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 49);
            this.button2.TabIndex = 3;
            this.button2.TabStop = false;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(126, 118);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 49);
            this.button3.TabIndex = 4;
            this.button3.TabStop = false;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonMultiplication.BackColor = System.Drawing.Color.Transparent;
            this.buttonMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplication.ForeColor = System.Drawing.Color.Blue;
            this.buttonMultiplication.Location = new System.Drawing.Point(187, 118);
            this.buttonMultiplication.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(53, 49);
            this.buttonMultiplication.TabIndex = 12;
            this.buttonMultiplication.TabStop = false;
            this.buttonMultiplication.Text = "x";
            this.buttonMultiplication.UseVisualStyleBackColor = false;
            this.buttonMultiplication.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDivision.BackColor = System.Drawing.Color.Transparent;
            this.buttonDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDivision.ForeColor = System.Drawing.Color.Blue;
            this.buttonDivision.Location = new System.Drawing.Point(248, 118);
            this.buttonDivision.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(53, 49);
            this.buttonDivision.TabIndex = 13;
            this.buttonDivision.TabStop = false;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = false;
            this.buttonDivision.Click += new System.EventHandler(this.button_Click);
            // 
            // button0
            // 
            this.button0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Location = new System.Drawing.Point(4, 175);
            this.button0.Margin = new System.Windows.Forms.Padding(4);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(53, 49);
            this.button0.TabIndex = 1;
            this.button0.TabStop = false;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonDecimal
            // 
            this.buttonDecimal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDecimal.Location = new System.Drawing.Point(65, 175);
            this.buttonDecimal.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDecimal.Name = "buttonDecimal";
            this.buttonDecimal.Size = new System.Drawing.Size(53, 49);
            this.buttonDecimal.TabIndex = 19;
            this.buttonDecimal.TabStop = false;
            this.buttonDecimal.Text = ".";
            this.buttonDecimal.UseVisualStyleBackColor = true;
            this.buttonDecimal.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonEqual.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEqual.ForeColor = System.Drawing.Color.Lime;
            this.buttonEqual.Location = new System.Drawing.Point(126, 175);
            this.buttonEqual.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(53, 49);
            this.buttonEqual.TabIndex = 17;
            this.buttonEqual.TabStop = false;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.equals_Button_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPlus.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.ForeColor = System.Drawing.Color.Blue;
            this.buttonPlus.Location = new System.Drawing.Point(187, 175);
            this.buttonPlus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(53, 49);
            this.buttonPlus.TabIndex = 14;
            this.buttonPlus.TabStop = false;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonMinus.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinus.ForeColor = System.Drawing.Color.Blue;
            this.buttonMinus.Location = new System.Drawing.Point(248, 175);
            this.buttonMinus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(53, 49);
            this.buttonMinus.TabIndex = 15;
            this.buttonMinus.TabStop = false;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 357);
            this.Controls.Add(this.mainContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainContainer.ResumeLayout(false);
            this.mainContainer.PerformLayout();
            this.buttonsContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.TextBox txtExpression;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.FlowLayoutPanel buttonsContainer;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonOpenBracket;
        private System.Windows.Forms.Button buttonCloseBracket;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDecimal;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
    }
}

