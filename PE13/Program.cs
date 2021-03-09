using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE13
{
    public class Pets
    {
        List<Pet> petList = new List<Pet>();
        
        public abstract class Pet
        {
            private string Name;

            public int age;
        }

            

         public Pet this[int nPetEl]
         {
             get
             {
                 Pet returnVal;
                 try
                 {
                     returnVal = (Pet)petList[nPetEl];
                 }
                 catch
                 {
                     returnVal = null;
                 }

                 return (returnVal);
             }

             set
             {
                 // if the index is less than the number of list elements
                 if (nPetEl < petList.Count)
                 {
                     // update the existing value at that index
                     petList[nPetEl] = value;
                 }
                 else
                 {
                     // add the value to the list
                     petList.Add(value);
                 }
             }
         }
         public int Count
        {
            get
            {
                return petList.Count;
            }
        }
    }
    public class Cat
    {
        public Eat()
        {

        }
    }
    static void Main(string[] args)
    {
        Pets thisPet = null;
        Dog dog = null;
        Cat cat = null;
        IDog iDog = null;
        ICat iCat = null;

        Pets pets = new Pets();

        Random rand = new Random();

        for(int i = 0; i <= 50; i++)
        {
            if (rand.Next(1,11) == 1)
            {
                if (rand.Next(0,2) == 0)
                {
                    // add a dog
                    thisPet = dog;
                }
                else
                {
                    //else add a cat
                    thisPet = cat;
                }
            }
            else if( rand.Next(0,2) != 1)
            {
                
            }
            else
            {
                //choose a random pet from pets and choose a random activity for the pet to do

            }
        }

    }
}
