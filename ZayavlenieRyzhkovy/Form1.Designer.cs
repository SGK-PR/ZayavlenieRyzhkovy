namespace ZayavlenieRyzhkovy
{
    partial class Form1
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
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.cbSurname = new System.Windows.Forms.ComboBox();
            this.cbView = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbGroup
            // 
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Location = new System.Drawing.Point(60, 45);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(146, 21);
            this.cbGroup.TabIndex = 0;
            // 
            // cbSurname
            // 
            this.cbSurname.FormattingEnabled = true;
            this.cbSurname.Location = new System.Drawing.Point(253, 45);
            this.cbSurname.Name = "cbSurname";
            this.cbSurname.Size = new System.Drawing.Size(155, 21);
            this.cbSurname.TabIndex = 1;
            // 
            // cbView
            // 
            this.cbView.FormattingEnabled = true;
            this.cbView.Location = new System.Drawing.Point(451, 45);
            this.cbView.Name = "cbView";
            this.cbView.Size = new System.Drawing.Size(182, 21);
            this.cbView.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(60, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(174, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(253, 200);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(220, 33);
            this.btOpen.TabIndex = 4;
            this.btOpen.Text = "Получить документ";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbView);
            this.Controls.Add(this.cbSurname);
            this.Controls.Add(this.cbGroup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.ComboBox cbSurname;
        private System.Windows.Forms.ComboBox cbView;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btOpen;
    }
}

