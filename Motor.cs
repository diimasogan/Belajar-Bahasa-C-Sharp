using System;

namespace Program
{
    public class Motor : BrandMotor
    {
        public string color;
        public int speed;

        public Motor(string Warna,int kecepatan )
        {
            color = Warna;
            speed = kecepatan;
        }
    }
}