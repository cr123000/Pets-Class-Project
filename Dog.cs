using System;
namespace Pets
{
    public class Dog : Pet
    {

        public Dog(string name,string owner,double weight) : base("dog",name,owner,weight)
        { 
        }
        public string bark(int count)
        {
            string sound="Bark!";
            for(;count>0;count--)
            {
                sound+="Bark!";
            }
            return(sound);
        }
      
    }
}