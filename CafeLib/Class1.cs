using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib
{
    public interface IMood
    {
         string Mood
        {
            get;
        }
            
    }

    public interface ITakeOrder
    {
        void TakeOrder();
        
    }

    public abstract class HotDrink
    {
        public bool instant;
        public bool milk;
        private byte sugar;
        public string brand;
        public string size;

        public Customer customer;

        public virtual void AddSugar(byte amount)
        {
        }

        public abstract void Steam();

        public HotDrink()
        {

        }

        public HotDrink(string brand)
        {

        }
    }

    public class Waiter
    {
        public string name;

        public string Mood
        {
            get;
        }
        public void ServeCustomer(HotDrink cup)
        {

        }
    }

    public class Customer
    {
        public string name;

        public string credicCardNumber;

        public string Mood
        {
            get;
        }
    }

    public class CupOfCoffee : HotDrink
    {
        public string beanType;


        public CupOfCoffee(string brand) : base(brand)
        {
            
        }

        public override void Steam()
        {
        }

        public void TakeOrder()
        {

        }
    }

    public class CupOfTea : HotDrink
    {
        public string leafType;

        public override void Steam()
        {
            
        }

        public void TakeOrder()
        {

        }

        public CupOfTea(bool customerIsWealthy)
        {

        }
    }

    public class CupOfCocoa : HotDrink
    {
        public static int numCups;

        public bool marshmallows;

        private string source;

        public string Source
        {
            set
            {

            }
        }

        public override void Steam()
        {

        }

        public override void AddSugar(byte amount)
        {
        }

        public void TakeOrder()
        {

        }

       

        public CupOfCocoa(bool marshmallows) : base("Expensive Organic Brand")
        {

        }
    }

}
