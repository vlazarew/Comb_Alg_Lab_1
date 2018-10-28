namespace Lab_1
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
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.dataGridViewVocalubary = new System.Windows.Forms.DataGridView();
            this.Слово = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelWord = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonLoadFromFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVocalubary)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxWord
            // 
            this.textBoxWord.Location = new System.Drawing.Point(148, 33);
            this.textBoxWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.Size = new System.Drawing.Size(132, 22);
            this.textBoxWord.TabIndex = 0;
            this.textBoxWord.TextChanged += new System.EventHandler(this.textBoxWord_TextChanged);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(148, 71);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(132, 22);
            this.textBoxResult.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(348, 30);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(243, 28);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить слово в словарь";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(348, 137);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(243, 28);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.Enabled = false;
            this.buttonRun.Location = new System.Drawing.Point(348, 172);
            this.buttonRun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(247, 81);
            this.buttonRun.TabIndex = 5;
            this.buttonRun.Text = "Выполнить";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // dataGridViewVocalubary
            // 
            this.dataGridViewVocalubary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVocalubary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Слово});
            this.dataGridViewVocalubary.Location = new System.Drawing.Point(29, 137);
            this.dataGridViewVocalubary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewVocalubary.Name = "dataGridViewVocalubary";
            this.dataGridViewVocalubary.ReadOnly = true;
            this.dataGridViewVocalubary.Size = new System.Drawing.Size(299, 332);
            this.dataGridViewVocalubary.TabIndex = 6;
            // 
            // Слово
            // 
            this.Слово.HeaderText = "Слово";
            this.Слово.Name = "Слово";
            this.Слово.ReadOnly = true;
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.Location = new System.Drawing.Point(8, 37);
            this.labelWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(56, 17);
            this.labelWord.TabIndex = 7;
            this.labelWord.Text = "Слово: ";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(8, 75);
            this.labelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(128, 17);
            this.labelResult.TabIndex = 8;
            this.labelResult.Text = "Количество слов: ";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.textBoxWord);
            this.groupBox.Controls.Add(this.labelResult);
            this.groupBox.Controls.Add(this.textBoxResult);
            this.groupBox.Controls.Add(this.labelWord);
            this.groupBox.Location = new System.Drawing.Point(29, 17);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox.Size = new System.Drawing.Size(299, 112);
            this.groupBox.TabIndex = 9;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Словарь";
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(348, 101);
            this.buttonAbout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(243, 28);
            this.buttonAbout.TabIndex = 10;
            this.buttonAbout.Text = "Условие";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonLoadFromFile
            // 
            this.buttonLoadFromFile.Location = new System.Drawing.Point(348, 65);
            this.buttonLoadFromFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLoadFromFile.Name = "buttonLoadFromFile";
            this.buttonLoadFromFile.Size = new System.Drawing.Size(243, 28);
            this.buttonLoadFromFile.TabIndex = 11;
            this.buttonLoadFromFile.Text = "Загрузить слова из файла";
            this.buttonLoadFromFile.UseVisualStyleBackColor = true;
            this.buttonLoadFromFile.Click += new System.EventHandler(this.buttonLoadFromFile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 493);
            this.Controls.Add(this.buttonLoadFromFile);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.dataGridViewVocalubary);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAdd);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "5b. Слово и словарь. Одна буква несколько раз";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVocalubary)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.DataGridView dataGridViewVocalubary;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Слово;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonLoadFromFile;
    }
}

