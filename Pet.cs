using System;
namespace Pets
{
    public class Pet
    {
        public string type, name, owner;
        public double weight;
        // public Pet(){this.type="No Type";this.name="No Name";this.owner="No Owner";this.weight=-1;}
        // public Pet(string type){this.type=type;this.name="No Name";this.owner="No Owner";this.weight=-1;}
        // public Pet(string type,string name){this.type=type;this.name=name;this.owner="No Owner";this.weight=-1;}
        // public Pet(string type,string name,string owner){this.type=type;this.name=name;this.owner=owner;this.weight=-1;}

        public Pet(string type, string name,string owner,double weight){
            this.type=type;
            this.name=name;
            this.owner=owner;
            this.weight=weight;
        }
        public string getTag(){
            return("If lost call "+owner);
        }
    }
}