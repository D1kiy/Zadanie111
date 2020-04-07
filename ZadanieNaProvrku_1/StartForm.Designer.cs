namespace ZadanieNaProvrku_1
{
    partial class StartForm
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
            this.OpenParametrButton = new System.Windows.Forms.Button();
            this.OpenMdiFormButton = new System.Windows.Forms.Button();
            this.OpenDialogButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OpenParametrButton
            // 
            this.OpenParametrButton.Location = new System.Drawing.Point(12, 55);
            this.OpenParametrButton.Name = "OpenParametrButton";
            this.OpenParametrButton.Size = new System.Drawing.Size(146, 23);
            this.OpenParametrButton.TabIndex = 0;
            this.OpenParametrButton.Text = "OpenParametrButton";
            this.OpenParametrButton.UseVisualStyleBackColor = true;
            this.OpenParametrButton.Click += new System.EventHandler(this.OpenParametrButton_Click_1);
            // 
            // OpenMdiFormButton
            // 
            this.OpenMdiFormButton.Location = new System.Drawing.Point(12, 228);
            this.OpenMdiFormButton.Name = "OpenMdiFormButton";
            this.OpenMdiFormButton.Size = new System.Drawing.Size(146, 23);
            this.OpenMdiFormButton.TabIndex = 1;
            this.OpenMdiFormButton.Text = "OpenMdiFormButton";
            this.OpenMdiFormButton.UseVisualStyleBackColor = true;
            this.OpenMdiFormButton.Click += new System.EventHandler(this.OpenMdiFormButton_Click_1);
            // 
            // OpenDialogButton
            // 
            this.OpenDialogButton.Location = new System.Drawing.Point(12, 110);
            this.OpenDialogButton.Name = "OpenDialogButton";
            this.OpenDialogButton.Size = new System.Drawing.Size(146, 23);
            this.OpenDialogButton.TabIndex = 2;
            this.OpenDialogButton.Text = "OpenDialogButton";
            this.OpenDialogButton.UseVisualStyleBackColor = true;
            this.OpenDialogButton.Click += new System.EventHandler(this.OpenDialogButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(12, 170);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(146, 23);
            this.OpenButton.TabIndex = 3;
            this.OpenButton.Text = "OpenButton";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(657, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(131, 23);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "CloseButton";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 5;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.OpenDialogButton);
            this.Controls.Add(this.OpenMdiFormButton);
            this.Controls.Add(this.OpenParametrButton);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartForm_FormClosing_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenParametrButton;
        private System.Windows.Forms.Button OpenMdiFormButton;
        private System.Windows.Forms.Button OpenDialogButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

