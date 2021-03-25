using System;

namespace PersonClassInheritanceReview
{
    class Program
    {
        static void Main(string[] args)
        {
          

            


            Child c2 = new Child("Reggie",2,"Hot Wheels");
            DisplayName(c2);

            

            
            Child c1 = new Child();
            c1.Age = 2;
            c1.Name = "Molly";
            c1.Toy = "jack-in-the-box";
            c1.DisplayAge();
            c1.Cry();


            Console.ReadLine();


        }

        private static void DisplayName(Person p)
        {
         
            // i guess there is a new keyword "is"
            // protects us until we are sure that we have a child
            if (p is Child)
            {
                Child myChild = (Child)p;
                Console.WriteLine(myChild.Toy);
            }
            else
            {
                Console.WriteLine(p.Name);
            }
        }

      
    }
}
