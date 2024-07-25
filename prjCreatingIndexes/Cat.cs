using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCreatingIndexes
{
    public class Cat
    {
        double age, weight;
        string name, owner, breed;

        public Cat(double age, double weight, string name, string owner, string breed)
        {
            this.age = age;
            this.weight = weight;
            this.name = name;
            this.owner = owner;
            this.breed = breed;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return this.age;
                else if(index == 1)
                    return this.weight;
                else if(index == 2)
                    return this.name;
                else if(index == 3)
                    return this.owner;
                else if(index == 4)
                    return this.breed;
                else
                    return null;
            }
            set
            {
                if (index == 0)
                    this.age = (double)value;
                else if(index == 1)
                        this.weight = (double)value;
                else if(index == 2)
                    this.name = (string)value;
                else if(index == 3)
                    this.owner = (string)value;
                else if(index == 4)
                    this.breed = (string)value;
            }
        }

        public object this[string attribute]
        {
            get
            {
                if (attribute.ToLower().Equals("age"))
                    return this.age;
                if (attribute.ToLower().Equals("breed"))
                    return this.breed;
                if (attribute.ToLower().Equals("name"))
                    return this.name;
                if (attribute.ToLower().Equals("owner"))
                    return this.owner;
                if (attribute.ToLower().Equals("weight"))
                    return this.weight;
                return null;
            }
            set
            {
                if (attribute.ToLower().Equals("age"))
                    this.age = (double)value;
                if (attribute.ToLower().Equals("breed"))
                    this.breed = (string)value;
                if (attribute.ToLower().Equals("name"))
                    this.name = (string)value;
                if (attribute.ToLower().Equals("owner"))
                    this.owner = (string)value;
                if (attribute.ToLower().Equals("salary"))
                    this.weight = (double)value;
            }
        }
    }
}
