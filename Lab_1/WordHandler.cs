using System.Collections.Generic;

namespace Lab_1
{
    class WordHandler
    {
        //Списое слов в словаре
        List<string> words = new List<string>();
        //Слово, с которым мы сравниваем
        string word;
        //Количество различных литер в заданном слове
        int count_of_literas;

        //Получаем параметры с формы
        public void InputParametrs(List<string> _words, string _word)
        {
            words = _words;
            word = _word;
            count_of_literas = CheckSize(word);
        }

        //Количество различных литер в слове
        public int CheckSize(string _word_)
        {
            List<char> literas_word = new List<char>();
            foreach (char ch in _word_)
            {
                if (!literas_word.Contains(ch))
                {
                    literas_word.Add(ch);
                }
            }
            return literas_word.Count;
        }

        public int Run()
        {
            int result = 0;
            foreach (string wrd in words)
            {
                //Сначала идет проверка на вхождение литер в исходное слово, а затем уже сравнение их различных литер
                //Т.к. все литеры исходного слова должны быть задействованы хоть раз
                /*if ((Check(wrd)) && (CheckSize(wrd) == count_of_literas))
                {
                    result++;
                }*/
                if (Check(wrd))
                {
                    result++;
                }
            }
            return result;
        }

        public bool Check(string listwrd)
        {
            bool result = true;

            /*for (int i = 0; i < listwrd.Length && result; i++)
            {
                result = literas_word.Contains(listwrd[i]);
            }*/

            for (int i = 0; i < listwrd.Length && result; i++)
            {
                bool sub_check = false;
                for (int j = 0; j < word.Length && !sub_check; j++)
                {
                    sub_check = (listwrd[i] == word[j]);
                }
                result = sub_check;
            }

            return result;
        }
    }
}
