namespace Con_Bases
{
    partial class Conversor
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
            this.rbbi = new System.Windows.Forms.RadioButton();
            this.rbde = new System.Windows.Forms.RadioButton();
            this.rboc = new System.Windows.Forms.RadioButton();
            this.txtn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbbi = new System.Windows.Forms.CheckBox();
            this.cbde = new System.Windows.Forms.CheckBox();
            this.cbhe = new System.Windows.Forms.CheckBox();
            this.cboc = new System.Windows.Forms.CheckBox();
            this.txtbi = new System.Windows.Forms.TextBox();
            this.txtde = new System.Windows.Forms.TextBox();
            this.txthe = new System.Windows.Forms.TextBox();
            this.txtoc = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESCOLHA A BASE DESEJADA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ESCOLHA PARA QUAIS BASES DESEJA CONVERTER";
            // 
            // rbbi
            // 
            this.rbbi.AutoSize = true;
            this.rbbi.Location = new System.Drawing.Point(94, 90);
            this.rbbi.Name = "rbbi";
            this.rbbi.Size = new System.Drawing.Size(57, 17);
            this.rbbi.TabIndex = 2;
            this.rbbi.Text = "Binário";
            this.rbbi.UseVisualStyleBackColor = true;
            // 
            // rbde
            // 
            this.rbde.AutoSize = true;
            this.rbde.Location = new System.Drawing.Point(154, 90);
            this.rbde.Name = "rbde";
            this.rbde.Size = new System.Drawing.Size(63, 17);
            this.rbde.TabIndex = 3;
            this.rbde.Text = "Decimal";
            this.rbde.UseVisualStyleBackColor = true;
            // 
            // rboc
            // 
            this.rboc.AutoSize = true;
            this.rboc.Location = new System.Drawing.Point(223, 90);
            this.rboc.Name = "rboc";
            this.rboc.Size = new System.Drawing.Size(50, 17);
            this.rboc.TabIndex = 5;
            this.rboc.Text = "Octal";
            this.rboc.UseVisualStyleBackColor = true;
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(94, 125);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(179, 20);
            this.txtn.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Converter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbbi
            // 
            this.cbbi.AutoSize = true;
            this.cbbi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbbi.Location = new System.Drawing.Point(86, 218);
            this.cbbi.Name = "cbbi";
            this.cbbi.Size = new System.Drawing.Size(58, 17);
            this.cbbi.TabIndex = 8;
            this.cbbi.Text = "Binário";
            this.cbbi.UseVisualStyleBackColor = true;
            // 
            // cbde
            // 
            this.cbde.AutoSize = true;
            this.cbde.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbde.Location = new System.Drawing.Point(80, 244);
            this.cbde.Name = "cbde";
            this.cbde.Size = new System.Drawing.Size(64, 17);
            this.cbde.TabIndex = 9;
            this.cbde.Text = "Decimal";
            this.cbde.UseVisualStyleBackColor = true;
            // 
            // cbhe
            // 
            this.cbhe.AutoSize = true;
            this.cbhe.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbhe.Location = new System.Drawing.Point(57, 270);
            this.cbhe.Name = "cbhe";
            this.cbhe.Size = new System.Drawing.Size(87, 17);
            this.cbhe.TabIndex = 10;
            this.cbhe.Text = "Hexadecimal";
            this.cbhe.UseVisualStyleBackColor = true;
            // 
            // cboc
            // 
            this.cboc.AutoSize = true;
            this.cboc.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cboc.Location = new System.Drawing.Point(93, 296);
            this.cboc.Name = "cboc";
            this.cboc.Size = new System.Drawing.Size(51, 17);
            this.cboc.TabIndex = 11;
            this.cboc.Text = "Octal";
            this.cboc.UseVisualStyleBackColor = true;
            // 
            // txtbi
            // 
            this.txtbi.Location = new System.Drawing.Point(150, 215);
            this.txtbi.Name = "txtbi";
            this.txtbi.ReadOnly = true;
            this.txtbi.Size = new System.Drawing.Size(94, 20);
            this.txtbi.TabIndex = 12;
            // 
            // txtde
            // 
            this.txtde.Location = new System.Drawing.Point(150, 241);
            this.txtde.Name = "txtde";
            this.txtde.ReadOnly = true;
            this.txtde.Size = new System.Drawing.Size(94, 20);
            this.txtde.TabIndex = 13;
            // 
            // txthe
            // 
            this.txthe.Location = new System.Drawing.Point(150, 267);
            this.txthe.Name = "txthe";
            this.txthe.ReadOnly = true;
            this.txthe.Size = new System.Drawing.Size(94, 20);
            this.txthe.TabIndex = 14;
            // 
            // txtoc
            // 
            this.txtoc.Location = new System.Drawing.Point(150, 293);
            this.txtoc.Name = "txtoc";
            this.txtoc.ReadOnly = true;
            this.txtoc.Size = new System.Drawing.Size(94, 20);
            this.txtoc.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(150, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(252, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Conversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtoc);
            this.Controls.Add(this.txthe);
            this.Controls.Add(this.txtde);
            this.Controls.Add(this.txtbi);
            this.Controls.Add(this.cboc);
            this.Controls.Add(this.cbhe);
            this.Controls.Add(this.cbde);
            this.Controls.Add(this.cbbi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.rboc);
            this.Controls.Add(this.rbde);
            this.Controls.Add(this.rbbi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Conversor";
            this.Text = "Conversor de Bases Númericas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbbi;
        private System.Windows.Forms.RadioButton rbde;
        private System.Windows.Forms.RadioButton rboc;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbbi;
        private System.Windows.Forms.CheckBox cbde;
        private System.Windows.Forms.CheckBox cbhe;
        private System.Windows.Forms.CheckBox cboc;
        private System.Windows.Forms.TextBox txtbi;
        private System.Windows.Forms.TextBox txtde;
        private System.Windows.Forms.TextBox txthe;
        private System.Windows.Forms.TextBox txtoc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

