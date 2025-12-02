namespace CopyConstructor
{
    public class CopyConstructor
    {
        int age;
        string? name;

        // ✔ Parameterized Constructor
        //   -> Used to initialize the object with given values.
        public CopyConstructor(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        // ✔ Copy Constructor
        //   -> Creates a NEW OBJECT as a COPY of an EXISTING OBJECT.
        //   -> Copies the values of 'age' and 'name' from object 'c'.
        public CopyConstructor(CopyConstructor c)
        {
            this.age = c.age;     // copying age
            this.name = c.name;   // copying name
        }

        // ✔ Display method
        public void getData()
        {
            Console.WriteLine("Name is: " + name + ", Age is: " + age);
        }
    }

    internal class Program
    {
        static void Main()
        {
            // ✔ Creating original object
            CopyConstructor obj1 = new CopyConstructor(25, "Parth");

            // ✔ Creating duplicate object using Copy Constructor
            CopyConstructor obj2 = new CopyConstructor(obj1);

            // ✔ Displaying data of both objects
            obj1.getData();
            obj2.getData();

            Console.ReadLine();
        }
    }
}
