using System;
namespace c2_cw3
{
    class Program
    {
        static void Main(string[] args)
        {
            double playerSpeed = 2.5;

            double SetSpeed(){
                return playerSpeed;
            }
             void GetSpeed() {
                Console.WriteLine("The current player speed is {0} ",playerSpeed);
            }
           GetSpeed();
        }
    } 
}
