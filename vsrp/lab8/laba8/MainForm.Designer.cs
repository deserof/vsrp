namespace laba8
{
    partial class MainForm
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
            this.listBoxMedicine = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonOintment = new System.Windows.Forms.RadioButton();
            this.radioButtonPills = new System.Windows.Forms.RadioButton();
            this.buttonEnterData = new System.Windows.Forms.Button();
            this.buttonShortData = new System.Windows.Forms.Button();
            this.buttonShowData = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxMedicine
            // 
            this.listBoxMedicine.FormattingEnabled = true;
            this.listBoxMedicine.ItemHeight = 16;
            this.listBoxMedicine.Location = new System.Drawing.Point(339, 22);
            this.listBoxMedicine.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxMedicine.Name = "listBoxMedicine";
            this.listBoxMedicine.Size = new System.Drawing.Size(509, 228);
            this.listBoxMedicine.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonOintment);
            this.groupBox1.Controls.Add(this.radioButtonPills);
            this.groupBox1.Location = new System.Drawing.Point(39, 127);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите";
            // 
            // radioButtonOintment
            // 
            this.radioButtonOintment.AutoSize = true;
            this.radioButtonOintment.Location = new System.Drawing.Point(8, 78);
            this.radioButtonOintment.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonOintment.Name = "radioButtonOintment";
            this.radioButtonOintment.Size = new System.Drawing.Size(62, 20);
            this.radioButtonOintment.TabIndex = 1;
            this.radioButtonOintment.Text = "Мазь";
            this.radioButtonOintment.UseVisualStyleBackColor = true;
            // 
            // radioButtonPills
            // 
            this.radioButtonPills.AutoSize = true;
            this.radioButtonPills.Checked = true;
            this.radioButtonPills.Location = new System.Drawing.Point(8, 34);
            this.radioButtonPills.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonPills.Name = "radioButtonPills";
            this.radioButtonPills.Size = new System.Drawing.Size(91, 20);
            this.radioButtonPills.TabIndex = 0;
            this.radioButtonPills.TabStop = true;
            this.radioButtonPills.Text = "Таблетки";
            this.radioButtonPills.UseVisualStyleBackColor = true;
            // 
            // buttonEnterData
            // 
            this.buttonEnterData.Location = new System.Drawing.Point(39, 57);
            this.buttonEnterData.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEnterData.Name = "buttonEnterData";
            this.buttonEnterData.Size = new System.Drawing.Size(267, 28);
            this.buttonEnterData.TabIndex = 2;
            this.buttonEnterData.Text = "Ввести данные";
            this.buttonEnterData.UseVisualStyleBackColor = true;
            this.buttonEnterData.Click += new System.EventHandler(this.buttonEnterData_Click);
            // 
            // buttonShortData
            // 
            this.buttonShortData.Location = new System.Drawing.Point(484, 268);
            this.buttonShortData.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShortData.Name = "buttonShortData";
            this.buttonShortData.Size = new System.Drawing.Size(167, 28);
            this.buttonShortData.TabIndex = 3;
            this.buttonShortData.Text = "Краткие сведения";
            this.buttonShortData.UseVisualStyleBackColor = true;
            this.buttonShortData.Click += new System.EventHandler(this.buttonShortData_Click);
            // 
            // buttonShowData
            // 
            this.buttonShowData.Location = new System.Drawing.Point(484, 304);
            this.buttonShowData.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowData.Name = "buttonShowData";
            this.buttonShowData.Size = new System.Drawing.Size(167, 28);
            this.buttonShowData.TabIndex = 4;
            this.buttonShowData.Text = "Просмотреть данные";
            this.buttonShowData.UseVisualStyleBackColor = true;
            this.buttonShowData.Click += new System.EventHandler(this.buttonShowData_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 347);
            this.Controls.Add(this.buttonShowData);
            this.Controls.Add(this.buttonShortData);
            this.Controls.Add(this.buttonEnterData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxMedicine);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMedicine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonEnterData;
        private System.Windows.Forms.RadioButton radioButtonOintment;
        private System.Windows.Forms.RadioButton radioButtonPills;
        private System.Windows.Forms.Button buttonShortData;
        private System.Windows.Forms.Button buttonShowData;
    }
}

