using System;
namespace Pets
{
    public class Cat : Pet
    {
        public Cat(string name,string owner,double weight) : base("cat",name,owner,weight)
        { 
        }
        public string meow(int count)
        {
            string sound="Meow!";
            for(;count>0;count--)
            {
                sound+="Meow!";
            }
            return(sound);
        }
      
    }
}