namespace prjCreatingIndexes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat pabloJr = new Cat(3, 134, "Pablo Jr", "Pablo Escobar", "Jaguar");
            Cat manuela = new Cat(4, 127, "Manuela", "Pablo Escobar", "Jaguar");
            Cat donBlanco = new Cat(8, 9, "Don Blanco", "Pablo Escobar", "Ocelote");
            Cat pepe = new Cat(4, 1499, "Pepe", "Pablo Escobar", "Definitely a Cat and not a Hippopotamus");

            Console.WriteLine("Welcome to Don Pablo Escobar's Cat Zoo");
            Console.WriteLine("Cat 1");
            Console.WriteLine("Name: " + pabloJr[2]);
            Console.WriteLine("Age: " + pabloJr[0]);
            Console.WriteLine("Weight: " + pabloJr[1] + "KG");
            Console.WriteLine("Breed: " + pabloJr[4]);
            Console.WriteLine("Owner: " + pabloJr[3]);
            Console.WriteLine("Name: " + pabloJr["name"]);
            Console.WriteLine("Age: " + pabloJr["age"]);
            Console.WriteLine("Weight: " + pabloJr["weight"] + "KG");
            Console.WriteLine("Breed: " + pabloJr["breed"]);
            Console.WriteLine("Owner: " + pabloJr["owner"]);
            Console.WriteLine();
            Console.WriteLine("Cat 2");
            Console.WriteLine("Name: " + manuela[2]);
            Console.WriteLine("Age: " + manuela[0]);
            Console.WriteLine("Weight: " + manuela[1] + "KG");
            Console.WriteLine("Breed: " + manuela[4]);
            Console.WriteLine("Owner: " + manuela[3]);
            Console.WriteLine("Name: " + manuela["name"]);
            Console.WriteLine("Age: " + manuela["age"]);
            Console.WriteLine("Weight: " + manuela["weight"] + "KG");
            Console.WriteLine("Breed: " + manuela["breed"]);
            Console.WriteLine("Owner: " + manuela["owner"]);
            Console.WriteLine();
            Console.WriteLine("Cat 3");
            Console.WriteLine("Name: " + donBlanco[2]);
            Console.WriteLine("Age: " + donBlanco[0]);
            Console.WriteLine("Weight: " + donBlanco[1] + "KG");
            Console.WriteLine("Breed: " + donBlanco[4]);
            Console.WriteLine("Owner: " + donBlanco[3]);
            Console.WriteLine("Name: " + donBlanco["name"]);
            Console.WriteLine("Age: " +  donBlanco["age"]);
            Console.WriteLine("Weight: " + donBlanco["weight"] + "KG");
            Console.WriteLine("Breed: " + donBlanco["breed"]);
            Console.WriteLine("Owner: " + donBlanco["owner"]);
            Console.WriteLine();
            Console.WriteLine("Cat 4");
            Console.WriteLine("Name: " + pepe[2]);
            Console.WriteLine("Age: " + pepe[0]);
            Console.WriteLine("Weight: " + pepe[1] + "KG");
            Console.WriteLine("Breed: " + pepe[4]);
            Console.WriteLine("Owner: " + pepe[3]);
            Console.WriteLine("Name: " + pepe["name"]);
            Console.WriteLine("Age: " + pepe["age"]);
            Console.WriteLine("Weight: " + pepe["weight"] + "KG");
            Console.WriteLine("Breed: " + pepe["breed"]);
            Console.WriteLine("Owner: " + pepe["owner"]);

        }
    }
}

