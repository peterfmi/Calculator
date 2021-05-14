namespace Calculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
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
            this.button4 = new System.Windows.Forms.Button();
            this.buttonRecip = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonSqr = new System.Windows.Forms.Button();
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonMR = new System.Windows.Forms.Button();
            this.buttonMS = new System.Windows.Forms.Button();
            this.buttonMPlus = new System.Windows.Forms.Button();
            this.buttonMMinus = new System.Windows.Forms.Button();
            this.buttonMC = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonAddition = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonSubtraction = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.labelOperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.SystemColors.Window;
            this.button4.Location = new System.Drawing.Point(12, 273);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 54);
            this.button4.TabIndex = 0;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_click);
            // 
            // buttonRecip
            // 
            this.buttonRecip.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonRecip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRecip.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonRecip.Location = new System.Drawing.Point(213, 154);
            this.buttonRecip.Name = "buttonRecip";
            this.buttonRecip.Size = new System.Drawing.Size(61, 54);
            this.buttonRecip.TabIndex = 1;
            this.buttonRecip.Text = "1/x";
            this.buttonRecip.UseVisualStyleBackColor = false;
            this.buttonRecip.Click += new System.EventHandler(this.buttonRecip_Click);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMultiplication.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonMultiplication.Location = new System.Drawing.Point(213, 275);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(61, 54);
            this.buttonMultiplication.TabIndex = 2;
            this.buttonMultiplication.Text = "*";
            this.buttonMultiplication.UseVisualStyleBackColor = false;
            this.buttonMultiplication.Click += new System.EventHandler(this.operator_click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.SystemColors.Window;
            this.button6.Location = new System.Drawing.Point(146, 275);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(61, 54);
            this.button6.TabIndex = 3;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.SystemColors.Window;
            this.button5.Location = new System.Drawing.Point(79, 275);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 54);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_click);
            // 
            // buttonCE
            // 
            this.buttonCE.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCE.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonCE.Location = new System.Drawing.Point(12, 154);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(61, 54);
            this.buttonCE.TabIndex = 11;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = false;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonC.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonC.Location = new System.Drawing.Point(79, 155);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(61, 54);
            this.buttonC.TabIndex = 10;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonSqr
            // 
            this.buttonSqr.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonSqr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSqr.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonSqr.Location = new System.Drawing.Point(280, 154);
            this.buttonSqr.Name = "buttonSqr";
            this.buttonSqr.Size = new System.Drawing.Size(61, 54);
            this.buttonSqr.TabIndex = 9;
            this.buttonSqr.Text = "x²";
            this.buttonSqr.UseVisualStyleBackColor = false;
            this.buttonSqr.Click += new System.EventHandler(this.buttonSqr_Click);
            // 
            // buttonSqrt
            // 
            this.buttonSqrt.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSqrt.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonSqrt.Location = new System.Drawing.Point(213, 215);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Size = new System.Drawing.Size(61, 54);
            this.buttonSqrt.TabIndex = 8;
            this.buttonSqrt.Text = "√";
            this.buttonSqrt.UseVisualStyleBackColor = false;
            this.buttonSqrt.Click += new System.EventHandler(this.buttonSqrt_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonDelete.Location = new System.Drawing.Point(146, 155);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(61, 54);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "←";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.ForeColor = System.Drawing.SystemColors.Window;
            this.button8.Location = new System.Drawing.Point(79, 215);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(61, 54);
            this.button8.TabIndex = 18;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button_click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.ForeColor = System.Drawing.SystemColors.Window;
            this.button9.Location = new System.Drawing.Point(146, 215);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(61, 54);
            this.button9.TabIndex = 17;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button_click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDivision.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonDivision.Location = new System.Drawing.Point(280, 275);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(61, 54);
            this.buttonDivision.TabIndex = 16;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = false;
            this.buttonDivision.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonPercent
            // 
            this.buttonPercent.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPercent.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonPercent.Location = new System.Drawing.Point(280, 215);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(61, 54);
            this.buttonPercent.TabIndex = 15;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = false;
            this.buttonPercent.Click += new System.EventHandler(this.buttonPercent_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.SystemColors.Window;
            this.button7.Location = new System.Drawing.Point(12, 214);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(61, 54);
            this.button7.TabIndex = 14;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_click);
            // 
            // buttonMR
            // 
            this.buttonMR.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMR.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonMR.Location = new System.Drawing.Point(79, 93);
            this.buttonMR.Name = "buttonMR";
            this.buttonMR.Size = new System.Drawing.Size(61, 54);
            this.buttonMR.TabIndex = 25;
            this.buttonMR.Text = "MR";
            this.buttonMR.UseVisualStyleBackColor = false;
            this.buttonMR.Click += new System.EventHandler(this.buttonMR_Click);
            // 
            // buttonMS
            // 
            this.buttonMS.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMS.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonMS.Location = new System.Drawing.Point(146, 93);
            this.buttonMS.Name = "buttonMS";
            this.buttonMS.Size = new System.Drawing.Size(61, 54);
            this.buttonMS.TabIndex = 24;
            this.buttonMS.Text = "MS";
            this.buttonMS.UseVisualStyleBackColor = false;
            this.buttonMS.Click += new System.EventHandler(this.buttonMS_Click);
            // 
            // buttonMPlus
            // 
            this.buttonMPlus.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonMPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMPlus.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonMPlus.Location = new System.Drawing.Point(213, 93);
            this.buttonMPlus.Name = "buttonMPlus";
            this.buttonMPlus.Size = new System.Drawing.Size(61, 54);
            this.buttonMPlus.TabIndex = 23;
            this.buttonMPlus.Text = "M+";
            this.buttonMPlus.UseVisualStyleBackColor = false;
            this.buttonMPlus.Click += new System.EventHandler(this.buttonMPlus_Click);
            // 
            // buttonMMinus
            // 
            this.buttonMMinus.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonMMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMMinus.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonMMinus.Location = new System.Drawing.Point(280, 93);
            this.buttonMMinus.Name = "buttonMMinus";
            this.buttonMMinus.Size = new System.Drawing.Size(61, 54);
            this.buttonMMinus.TabIndex = 22;
            this.buttonMMinus.Text = "M-";
            this.buttonMMinus.UseVisualStyleBackColor = false;
            this.buttonMMinus.Click += new System.EventHandler(this.buttonMMinus_Click);
            // 
            // buttonMC
            // 
            this.buttonMC.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonMC.Location = new System.Drawing.Point(12, 93);
            this.buttonMC.Name = "buttonMC";
            this.buttonMC.Size = new System.Drawing.Size(61, 54);
            this.buttonMC.TabIndex = 21;
            this.buttonMC.Text = "MC";
            this.buttonMC.UseVisualStyleBackColor = false;
            this.buttonMC.Click += new System.EventHandler(this.buttonMC_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDot.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonDot.Location = new System.Drawing.Point(12, 395);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(61, 54);
            this.buttonDot.TabIndex = 30;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = false;
            this.buttonDot.Click += new System.EventHandler(this.button_click);
            // 
            // buttonAddition
            // 
            this.buttonAddition.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddition.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonAddition.Location = new System.Drawing.Point(213, 335);
            this.buttonAddition.Name = "buttonAddition";
            this.buttonAddition.Size = new System.Drawing.Size(61, 54);
            this.buttonAddition.TabIndex = 29;
            this.buttonAddition.Text = "+";
            this.buttonAddition.UseVisualStyleBackColor = false;
            this.buttonAddition.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEqual.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonEqual.Location = new System.Drawing.Point(146, 395);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(195, 54);
            this.buttonEqual.TabIndex = 28;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button0.ForeColor = System.Drawing.SystemColors.Window;
            this.button0.Location = new System.Drawing.Point(79, 395);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(61, 54);
            this.button0.TabIndex = 27;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button_click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(79, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 54);
            this.button2.TabIndex = 37;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Location = new System.Drawing.Point(146, 334);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 54);
            this.button3.TabIndex = 36;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_click);
            // 
            // buttonSubtraction
            // 
            this.buttonSubtraction.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonSubtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSubtraction.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonSubtraction.Location = new System.Drawing.Point(280, 335);
            this.buttonSubtraction.Name = "buttonSubtraction";
            this.buttonSubtraction.Size = new System.Drawing.Size(61, 54);
            this.buttonSubtraction.TabIndex = 35;
            this.buttonSubtraction.Text = "-";
            this.buttonSubtraction.UseVisualStyleBackColor = false;
            this.buttonSubtraction.Click += new System.EventHandler(this.operator_click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(12, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 54);
            this.button1.TabIndex = 33;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_click);
            // 
            // textBox_Result
            // 
            this.textBox_Result.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox_Result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Result.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_Result.Location = new System.Drawing.Point(12, 43);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(329, 40);
            this.textBox_Result.TabIndex = 38;
            this.textBox_Result.Text = "0";
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelOperation
            // 
            this.labelOperation.AutoSize = true;
            this.labelOperation.BackColor = System.Drawing.SystemColors.WindowText;
            this.labelOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOperation.ForeColor = System.Drawing.SystemColors.Window;
            this.labelOperation.Location = new System.Drawing.Point(28, 20);
            this.labelOperation.Name = "labelOperation";
            this.labelOperation.Size = new System.Drawing.Size(0, 20);
            this.labelOperation.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(352, 461);
            this.Controls.Add(this.labelOperation);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonSubtraction);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.buttonAddition);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonMR);
            this.Controls.Add(this.buttonMS);
            this.Controls.Add(this.buttonMPlus);
            this.Controls.Add(this.buttonMMinus);
            this.Controls.Add(this.buttonMC);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonPercent);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonSqr);
            this.Controls.Add(this.buttonSqrt);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonMultiplication);
            this.Controls.Add(this.buttonRecip);
            this.Controls.Add(this.button4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonAddition;
        private System.Windows.Forms.Button buttonSubtraction;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSqrt;
        private System.Windows.Forms.Button buttonSqr;
        private System.Windows.Forms.Button buttonRecip;
        private System.Windows.Forms.Button buttonPercent;
        private System.Windows.Forms.Button buttonMS;
        private System.Windows.Forms.Button buttonMR;
        private System.Windows.Forms.Button buttonMC;
        private System.Windows.Forms.Button buttonMPlus;
        private System.Windows.Forms.Button buttonMMinus;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label labelOperation;
    }
}