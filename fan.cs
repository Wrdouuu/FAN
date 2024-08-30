using System;
using System.Globalization;
namespace FAN
{
    class Fan
    {
        static void Main(string[] args)
        {
            //Đối tượng Fan 1: Gán giá trị lớn nhất cho speed, radius là 10,
            //color là yellow và quạt ở trạng thái bật.
            FAN fan1 = new FAN(FAN.FAST, true, 10, "yellow");
            //Đối tượng Fan 2: Gán giá trị trung bình cho speed, radius là 5,
            //color là blue và quạt ở trạng thái tắt
            FAN fan2 = new FAN(FAN.MEDIUM, true, 5, "blue");
            Console.WriteLine(fan2.ToString());
        }
    }
}