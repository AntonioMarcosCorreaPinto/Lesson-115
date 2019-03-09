using LessonOneHundredFifteen.Entities;
using LessonOneHundredFifteen.Entities.Enums;
using System;

namespace LessonOneHundredFifteen
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment

            };


            Console.WriteLine(order);

            // It coverring type OrderStatus to string
            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(txt);

            // It covering type string to OrderStatus

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); 
            // It have the same value that exist at the enum "OrderStatus"

            Console.WriteLine(os);


        }
    }
}
