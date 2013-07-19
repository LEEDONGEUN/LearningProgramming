using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaoniDay02
{
    public struct Car
    {
        public String company, name, color;
        public int speed;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car1, car2;

            car1.company = "현대";
            car1.name = "아반떼";
            car1.color = "Red";
            car1.speed = 160;

            car2.company = "기아";
            car2.name = "K5";
            car2.color = "Black";
            car2.speed = 180;

            Console.WriteLine("1번째 차량\n차량 회사 : " + car1.company + "\n차량 이름 : " + car1.name + "\n차량 색상 : " + car1.color + "\n차량 속도 : " + car1.speed + "\n\n");
            Console.WriteLine("2번째 차량\n차량 회사 : " + car2.company + "\n차량 이름 : " + car2.name + "\n차량 색상 : " + car2.color + "\n차량 속도 : " + car2.speed);
        }
    }
}
