using System.Windows.Forms;

namespace Lab2DavidAlvarado
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
            this.btn_SignIn = new System.Windows.Forms.Button();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.txb_LastName = new System.Windows.Forms.TextBox();
            this.txb_Age = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_id = new System.Windows.Forms.TextBox();
            this.txb_Email = new System.Windows.Forms.TextBox();
            this.txb_Pass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_PassConf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chk_showPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.Font = new System.Drawing.Font("Russo One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_SignIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_SignIn.Location = new System.Drawing.Point(148, 251);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(74, 45);
            this.btn_SignIn.TabIndex = 0;
            this.btn_SignIn.Text = "Registrar";
            this.btn_SignIn.UseVisualStyleBackColor = true;
            this.btn_SignIn.Click += new System.EventHandler(this.btn_SignIn_Click);
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(148, 26);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(100, 23);
            this.txb_Name.TabIndex = 2;
            this.txb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // txb_LastName
            // 
            this.txb_LastName.Location = new System.Drawing.Point(148, 55);
            this.txb_LastName.Name = "txb_LastName";
            this.txb_LastName.Size = new System.Drawing.Size(100, 23);
            this.txb_LastName.TabIndex = 3;
            // 
            // txb_Age
            // 
            this.txb_Age.Location = new System.Drawing.Point(148, 84);
            this.txb_Age.MaxLength = 3;
            this.txb_Age.Name = "txb_Age";
            this.txb_Age.Size = new System.Drawing.Size(100, 23);
            this.txb_Age.TabIndex = 4;
            this.txb_Age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_Age_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cedula:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email:";
            // 
            // txb_id
            // 
            this.txb_id.Location = new System.Drawing.Point(148, 113);
            this.txb_id.Name = "txb_id";
            this.txb_id.Size = new System.Drawing.Size(100, 23);
            this.txb_id.TabIndex = 10;
            // 
            // txb_Email
            // 
            this.txb_Email.Location = new System.Drawing.Point(148, 142);
            this.txb_Email.Name = "txb_Email";
            this.txb_Email.Size = new System.Drawing.Size(100, 23);
            this.txb_Email.TabIndex = 11;
            // 
            // txb_Pass
            // 
            this.txb_Pass.Location = new System.Drawing.Point(148, 171);
            this.txb_Pass.Name = "txb_Pass";
            this.txb_Pass.PasswordChar = '*';
            this.txb_Pass.Size = new System.Drawing.Size(100, 23);
            this.txb_Pass.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Edad:";
            // 
            // txb_PassConf
            // 
            this.txb_PassConf.Location = new System.Drawing.Point(148, 201);
            this.txb_PassConf.Name = "txb_PassConf";
            this.txb_PassConf.PasswordChar = '*';
            this.txb_PassConf.Size = new System.Drawing.Size(100, 23);
            this.txb_PassConf.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Contraseña:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Confirmar Contraseña: ";
            // 
            // chk_showPass
            // 
            this.chk_showPass.AutoSize = true;
            this.chk_showPass.Location = new System.Drawing.Point(254, 175);
            this.chk_showPass.Name = "chk_showPass";
            this.chk_showPass.Size = new System.Drawing.Size(55, 19);
            this.chk_showPass.TabIndex = 17;
            this.chk_showPass.Text = "Show";
            this.chk_showPass.UseVisualStyleBackColor = true;
            this.chk_showPass.CheckedChanged += new System.EventHandler(this.chk_showPass_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(363, 336);
            this.Controls.Add(this.chk_showPass);
            this.Controls.Add(this.btn_SignIn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txb_PassConf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_Pass);
            this.Controls.Add(this.txb_Email);
            this.Controls.Add(this.txb_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_Age);
            this.Controls.Add(this.txb_LastName);
            this.Controls.Add(this.txb_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SignIn;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.TextBox txb_LastName;
        private System.Windows.Forms.TextBox txb_Age;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_id;
        private System.Windows.Forms.TextBox txb_Email;
        private System.Windows.Forms.TextBox txb_Pass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_PassConf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private CheckBox chk_showPass;
    }
}

