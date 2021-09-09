
namespace WindowsFormsApp2
{
    partial class LogIn
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbLg = new System.Windows.Forms.TextBox();
            this.TbPswd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnEnt = new System.Windows.Forms.Button();
            this.BtnReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbLg
            // 
            this.TbLg.Location = new System.Drawing.Point(93, 84);
            this.TbLg.Name = "TbLg";
            this.TbLg.Size = new System.Drawing.Size(100, 20);
            this.TbLg.TabIndex = 0;
            // 
            // TbPswd
            // 
            this.TbPswd.Location = new System.Drawing.Point(93, 142);
            this.TbPswd.Name = "TbPswd";
            this.TbPswd.PasswordChar = '*';
            this.TbPswd.Size = new System.Drawing.Size(100, 20);
            this.TbPswd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(124, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(124, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль:";
            // 
            // BtnEnt
            // 
            this.BtnEnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnEnt.Location = new System.Drawing.Point(83, 212);
            this.BtnEnt.Name = "BtnEnt";
            this.BtnEnt.Size = new System.Drawing.Size(122, 37);
            this.BtnEnt.TabIndex = 4;
            this.BtnEnt.Text = "Войти";
            this.BtnEnt.UseVisualStyleBackColor = false;
            this.BtnEnt.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnReg
            // 
            this.BtnReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnReg.Location = new System.Drawing.Point(93, 265);
            this.BtnReg.Name = "BtnReg";
            this.BtnReg.Size = new System.Drawing.Size(100, 23);
            this.BtnReg.TabIndex = 5;
            this.BtnReg.Text = "регистрация";
            this.BtnReg.UseVisualStyleBackColor = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(284, 338);
            this.Controls.Add(this.BtnReg);
            this.Controls.Add(this.BtnEnt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbPswd);
            this.Controls.Add(this.TbLg);
            this.Name = "LogIn";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbLg;
        private System.Windows.Forms.TextBox TbPswd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnEnt;
        private System.Windows.Forms.Button BtnReg;
    }
}

