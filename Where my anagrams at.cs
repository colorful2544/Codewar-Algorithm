using System;
using System.Collections.Generic;

namespace Where_my_anagrams_at
{
    class Program
    {
        /*
            แนวคิด : ถ้าหากเป็น Anagrams จะต้องมีขนาดและตัวอักษรเหมือนกันทุกประการ
            เราจึงทำการ sort เพื่อให้ตัวอักษรอยู่ในตำเเหน่งเดียวกัน จะได้ง่ายต่อการเปรียบเทียบ

            ถ้าหากตัวอักษรที่ทำการ sort แล้วของทั้ง 2 อย่างตรงกัน และมีขนาดเท่ากัน แสดงว่านั่นคือ Anagrams ของ word
        */
        static void Main(string[] args)
        {
            foreach(string result in Anagrams("aabb",new List<string> {"aabb","abcd","bbaa","dada"}))
            {
                Console.Write($"{result} ");
            }
        }
        public static List<string> Anagrams(string word, List<string> words)
        {
            char[] newWord = word.ToCharArray();

            Array.Sort(newWord);
            
            List<string> resultsList = new List<string>();

            foreach(string item in words)
            {
                if(item.Length == word.Length)
                {
                    char[] newItem = item.ToCharArray();

                    Array.Sort(newItem);

                    bool checkChar = true;
                    for(int index = 0; index < newWord.Length; index++)
                    {
                        if(newWord[index] != newItem[index])
                        {
                            checkChar = false;
                        }
                    }

                    if(checkChar == true)
                    {
                        resultsList.Add(item);
                    }
                }
            }

            return resultsList;
        }
    }
}
