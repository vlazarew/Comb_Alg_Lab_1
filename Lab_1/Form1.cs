using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class MainForm : Form
    {
        //Объект модуля с вспомогательными методами
        WordHandler Handler = new WordHandler();
        //Список слов в словаре
        List<string> words = new List<string>();

        public MainForm()
        {
            InitializeComponent();
        }

        //При нажатии на кнопку Добавить
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string word = textBoxWord.Text;
            if (word == "")
            {
                MessageBox.Show(this, "Слово не может быть пустым", "Ошибка ввода!");
                textBoxWord.Focus();
            }
            else
            {
                bool success = true;
                for (int i = 0; i < word.Length && success; i++)
                {
                    //Если у нас символы не буквы
                    if (!Char.IsLetter(word[i]))
                    {
                        success = false;
                        MessageBox.Show(this, "Слово не может состоять из цифр или иных служебных символов!", "Ошибка ввода!");
                        textBoxWord.Clear();
                        textBoxWord.Focus();
                    }
                }
                if (success)
                {
                    dataGridViewVocalubary.Rows.Add(word);
                    //words.Add(word);
                    words.Add(word.ToLower());
                    textBoxWord.Clear();
                    textBoxWord.Focus();
                }
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Слово и словарь. Даны слово и словарь, представляющий собой набор слов.\n"
                + "Необходимо подсчитать количество слов в словаре, которые можно составить из букв исходного слова.\n"
                + "Разрешается использовать одну букву несколько раз.", "Условие задачи");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            dataGridViewVocalubary.Rows.Clear();
            words.Clear();
            textBoxWord.Clear();
            textBoxResult.Clear();
        }

        //Загрузить словарь из текстового файла
        private void buttonLoadFromFile_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Текстовый файл|*.txt";
            openFile.Title = "Выберите текстовый файл со словарем";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                filePath = openFile.FileName;
                var fileStream = openFile.OpenFile();
            }
            StreamReader reader = new StreamReader(filePath);

            fileContent = reader.ReadLine();
            while (fileContent != null)
            {
                dataGridViewVocalubary.Rows.Add(fileContent);
                //words.Add(fileContent);
                words.Add(fileContent.ToLower());
                fileContent = reader.ReadLine();
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            textBoxResult.Clear();
            Handler.InputParametrs(words, textBoxWord.Text);
            textBoxResult.Text = Handler.Run().ToString();
        }

        private void textBoxWord_TextChanged(object sender, EventArgs e)
        {
            if (textBoxWord.Text.Length == 0)
            {
                buttonRun.Enabled = false;
            }
            else
            {
                buttonRun.Enabled = true;
            }
        }
    }
}
