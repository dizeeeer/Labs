namespace DZ
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxMaxDistanceNechet = new System.Windows.Forms.TextBox();
            this.labelMaxDistanceNechet = new System.Windows.Forms.Label();
            this.buttonNechetFind = new System.Windows.Forms.Button();
            this.textBoxNumberOfPotoks1 = new System.Windows.Forms.TextBox();
            this.labelNumberOfPotoks1 = new System.Windows.Forms.Label();
            this.labelNumberOfPotoks2 = new System.Windows.Forms.Label();
            this.textBoxNumberOfPotoks2 = new System.Windows.Forms.TextBox();
            this.textBoxTimeNechetFind = new System.Windows.Forms.TextBox();
            this.labelTimeNechetFind = new System.Windows.Forms.Label();
            this.buttonSaveReport = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выбрать файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Время чтения из файла";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(329, 30);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(134, 24);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonFind
            // 
            this.buttonFind.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFind.Location = new System.Drawing.Point(11, 73);
            this.buttonFind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(105, 54);
            this.buttonFind.TabIndex = 3;
            this.buttonFind.Text = "Четкий Поиск";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Слово для поиска";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxFind
            // 
            this.textBoxFind.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFind.Location = new System.Drawing.Point(329, 88);
            this.textBoxFind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(134, 24);
            this.textBoxFind.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Время четкого поиска";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(204, 146);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(107, 20);
            this.textBox3.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(29, 192);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(444, 232);
            this.listBox1.TabIndex = 8;
            // 
            // textBoxMaxDistanceNechet
            // 
            this.textBoxMaxDistanceNechet.Location = new System.Drawing.Point(660, 175);
            this.textBoxMaxDistanceNechet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMaxDistanceNechet.Name = "textBoxMaxDistanceNechet";
            this.textBoxMaxDistanceNechet.Size = new System.Drawing.Size(103, 20);
            this.textBoxMaxDistanceNechet.TabIndex = 10;
            // 
            // labelMaxDistanceNechet
            // 
            this.labelMaxDistanceNechet.AutoSize = true;
            this.labelMaxDistanceNechet.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxDistanceNechet.ForeColor = System.Drawing.Color.Black;
            this.labelMaxDistanceNechet.Location = new System.Drawing.Point(430, 144);
            this.labelMaxDistanceNechet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaxDistanceNechet.Name = "labelMaxDistanceNechet";
            this.labelMaxDistanceNechet.Size = new System.Drawing.Size(330, 19);
            this.labelMaxDistanceNechet.TabIndex = 11;
            this.labelMaxDistanceNechet.Text = "Максимальное расстояние для нечеткого поиска:\r\n";
            // 
            // buttonNechetFind
            // 
            this.buttonNechetFind.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNechetFind.Location = new System.Drawing.Point(598, 54);
            this.buttonNechetFind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNechetFind.Name = "buttonNechetFind";
            this.buttonNechetFind.Size = new System.Drawing.Size(142, 62);
            this.buttonNechetFind.TabIndex = 12;
            this.buttonNechetFind.Text = "Параллельный нечеткий поиск";
            this.buttonNechetFind.UseVisualStyleBackColor = true;
            this.buttonNechetFind.Click += new System.EventHandler(this.buttonNechetFind_Click);
            // 
            // textBoxNumberOfPotoks1
            // 
            this.textBoxNumberOfPotoks1.Location = new System.Drawing.Point(684, 239);
            this.textBoxNumberOfPotoks1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNumberOfPotoks1.Name = "textBoxNumberOfPotoks1";
            this.textBoxNumberOfPotoks1.Size = new System.Drawing.Size(76, 20);
            this.textBoxNumberOfPotoks1.TabIndex = 13;
            // 
            // labelNumberOfPotoks1
            // 
            this.labelNumberOfPotoks1.AutoSize = true;
            this.labelNumberOfPotoks1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfPotoks1.Location = new System.Drawing.Point(618, 207);
            this.labelNumberOfPotoks1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumberOfPotoks1.Name = "labelNumberOfPotoks1";
            this.labelNumberOfPotoks1.Size = new System.Drawing.Size(142, 19);
            this.labelNumberOfPotoks1.TabIndex = 14;
            this.labelNumberOfPotoks1.Text = "Количество потоков";
            // 
            // labelNumberOfPotoks2
            // 
            this.labelNumberOfPotoks2.AutoSize = true;
            this.labelNumberOfPotoks2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfPotoks2.Location = new System.Drawing.Point(528, 272);
            this.labelNumberOfPotoks2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumberOfPotoks2.Name = "labelNumberOfPotoks2";
            this.labelNumberOfPotoks2.Size = new System.Drawing.Size(232, 19);
            this.labelNumberOfPotoks2.TabIndex = 15;
            this.labelNumberOfPotoks2.Text = "Вычисленное количество потоков\r\n";
            // 
            // textBoxNumberOfPotoks2
            // 
            this.textBoxNumberOfPotoks2.Location = new System.Drawing.Point(684, 305);
            this.textBoxNumberOfPotoks2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNumberOfPotoks2.Name = "textBoxNumberOfPotoks2";
            this.textBoxNumberOfPotoks2.ReadOnly = true;
            this.textBoxNumberOfPotoks2.Size = new System.Drawing.Size(76, 20);
            this.textBoxNumberOfPotoks2.TabIndex = 16;
            // 
            // textBoxTimeNechetFind
            // 
            this.textBoxTimeNechetFind.Location = new System.Drawing.Point(651, 377);
            this.textBoxTimeNechetFind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTimeNechetFind.Name = "textBoxTimeNechetFind";
            this.textBoxTimeNechetFind.ReadOnly = true;
            this.textBoxTimeNechetFind.Size = new System.Drawing.Size(109, 20);
            this.textBoxTimeNechetFind.TabIndex = 17;
            this.textBoxTimeNechetFind.TextChanged += new System.EventHandler(this.textBoxTimeNechetFind_TextChanged);
            // 
            // labelTimeNechetFind
            // 
            this.labelTimeNechetFind.AutoSize = true;
            this.labelTimeNechetFind.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeNechetFind.Location = new System.Drawing.Point(594, 340);
            this.labelTimeNechetFind.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimeNechetFind.Name = "labelTimeNechetFind";
            this.labelTimeNechetFind.Size = new System.Drawing.Size(166, 19);
            this.labelTimeNechetFind.TabIndex = 18;
            this.labelTimeNechetFind.Text = "Время нечеткого поиска";
            // 
            // buttonSaveReport
            // 
            this.buttonSaveReport.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveReport.Location = new System.Drawing.Point(220, 459);
            this.buttonSaveReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSaveReport.Name = "buttonSaveReport";
            this.buttonSaveReport.Size = new System.Drawing.Size(117, 63);
            this.buttonSaveReport.TabIndex = 19;
            this.buttonSaveReport.Text = "Сохранение Отчета";
            this.buttonSaveReport.UseVisualStyleBackColor = true;
            this.buttonSaveReport.Click += new System.EventHandler(this.buttonSaveReport_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(348, 459);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(104, 63);
            this.buttonClose.TabIndex = 20;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 547);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSaveReport);
            this.Controls.Add(this.labelTimeNechetFind);
            this.Controls.Add(this.textBoxTimeNechetFind);
            this.Controls.Add(this.textBoxNumberOfPotoks2);
            this.Controls.Add(this.labelNumberOfPotoks2);
            this.Controls.Add(this.labelNumberOfPotoks1);
            this.Controls.Add(this.textBoxNumberOfPotoks1);
            this.Controls.Add(this.buttonNechetFind);
            this.Controls.Add(this.labelMaxDistanceNechet);
            this.Controls.Add(this.textBoxMaxDistanceNechet);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Енин Александр ИУ5-34Б";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxMaxDistanceNechet;
        private System.Windows.Forms.Label labelMaxDistanceNechet;
        private System.Windows.Forms.Button buttonNechetFind;
        private System.Windows.Forms.TextBox textBoxNumberOfPotoks1;
        private System.Windows.Forms.Label labelNumberOfPotoks1;
        private System.Windows.Forms.Label labelNumberOfPotoks2;
        private System.Windows.Forms.TextBox textBoxNumberOfPotoks2;
        private System.Windows.Forms.TextBox textBoxTimeNechetFind;
        private System.Windows.Forms.Label labelTimeNechetFind;
        private System.Windows.Forms.Button buttonSaveReport;
        private System.Windows.Forms.Button buttonClose;
    }
}

