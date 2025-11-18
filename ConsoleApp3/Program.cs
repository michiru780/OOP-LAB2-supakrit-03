using System;

namespace temperature   //เรียกใช้ namespace System ซึ่งมีคลาสที่จำเป็น เช่น Console สำหรับรับ–ส่งข้อมูลทางหน้าจอ
{
    class Program
    {
        static void Main(string[] args) //จุดเริ่มต้นของโปรแกรม เป็นฟังก์ชันที่รันก่อนทุกอย่าง
        {
            float body = 37.5f; //ประกาศตัวแปรชนิด float ชื่อ body และกำหนดค่าเริ่มต้น 37.5
            float temperature;     //ไว้สำหรับเก็บค่าที่ผู้ใช้

            Console.Write("Enter body temperature value: ");
            float.TryParse(Console.ReadLine(), out temperature);

            if (temperature >= body)
            {
                Console.WriteLine("result: มีไข้");
            }
            else if (temperature < body)
            {
                Console.WriteLine("result: ไม่มีไข้");
            }
        }
    }
}
