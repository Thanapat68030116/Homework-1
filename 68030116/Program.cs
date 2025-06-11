// See https://aka.ms/new-console-template for more information
using System;

public class AgeClassifier
{
    public static void Main(string[] args)
    {
        Console.WriteLine("กรุณากรอกอายุของคุณ (ตัวเลข):");

        // ตัวแปรสำหรับเก็บอายุ
        int age;

        // วนซ้ำจนกว่าจะได้รับค่าอายุที่ถูกต้อง
        while (true)
        {
            string input = Console.ReadLine(); // อ่านค่าที่ผู้ใช้พิมพ์เข้ามา

            // ลองแปลงค่าที่อ่านได้ให้เป็นตัวเลข
            // int.TryParse จะคืนค่า true ถ้าแปลงสำเร็จ และใส่ค่าที่แปลงได้ลงในตัวแปร age
            // ถ้าแปลงไม่สำเร็จ จะคืนค่า false
            if (int.TryParse(input, out age))
            {
                // ตรวจสอบว่าอายุเป็นบวกหรือไม่
                if (age >= 0)
                {
                    break; // ออกจาก loop ถ้าอายุถูกต้อง (เป็นตัวเลขและไม่ติดลบ)
                }
                else
                {
                    Console.WriteLine("อายุต้องเป็นตัวเลขที่ไม่ติดลบ กรุณาลองใหม่อีกครั้ง:");
                }
            }
            else
            {
                Console.WriteLine("กรุณากรอกอายุเป็นตัวเลขเท่านั้น:");
            }
        }

        // ตรวจสอบอายุและแสดงผลลัพธ์
        if (age >= 1 && age <= 12)
        {
            Console.WriteLine("คุณอยู่ในวัย: เด็ก");
        }
        else if (age >= 13 && age <= 19)
        {
            Console.WriteLine("คุณอยู่ในวัย: วัยรุ่น");
        }
        else if (age >= 20 && age <= 50)
        {
            Console.WriteLine("คุณอยู่ในวัย: วัยผู้ใหญ่");
        }
        else if (age >= 51)
        {
            Console.WriteLine("คุณอยู่ในวัย: วัยชรา");
        }
        else
        {
            // กรณีที่อายุเป็น 0 หรือค่าที่อยู่นอกช่วง 1-12 แต่ไม่ถึง 51
            // (เช่น ถ้าเราไม่ได้ตรวจสอบ age >= 0 ใน loop ด้านบน)
            // แต่ในโค้ดนี้ เราได้ตรวจสอบ age >= 0 ไปแล้ว ดังนั้นส่วนนี้แทบจะไม่ได้ถูกเรียกใช้
            Console.WriteLine("ไม่สามารถระบุวัยได้จากอายุที่กรอกมา");
        }
    }
}