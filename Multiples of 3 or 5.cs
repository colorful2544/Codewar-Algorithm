using System;

namespace Multiples_of_3_or_5
{
    /*
        โจทย์ :  ถ้าเราแสดงจำนวนธรรมชาติทั้งหมดที่น้อยกว่า 10
                ซึ่งเป็นผลคูณของ 3 หรือ 5 เราจะได้ 3,5,6,9
                ซึ่งจะได้ผลคูณรวทกันทั้งหมด 23

                จงเขียน code เพื่อค้นหาผลคูณของ 3 หรือ 5 พร้อมหาผลรวมในจำนวนธรรมชาติที่ระบุ
    */ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution(10));
        }
        static int Solution(int value)
        {
            int sum = 0;
            for(int num = 0; num < value; num++)
            {
                if((num % 3 == 0) || (num % 5 ==0))
                {
                    sum += num;
                }
            }
            return sum;
        }
    }
}
