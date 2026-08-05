namespace oop5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01
            #region Q1
            //Q1:
            //What is an interface in C#?
            // interface define contract that class must follow it define what class do and how to do it
            //Why do we use interfaces instead of depending on concrete classes directly?
            // use conceret class cuases tight coupling - hard to change - hard testing
            //Mention at least three benefits of using interfaces.
            //1- enabling multiple inheritance
            //2- enabling polymorphism without inheritance
            //3- remvoe tight coupling
            #endregion

            #region Q2
            //    interface IEnglishSpeaker
            //{
            //    void Greet();
            //}

            //interface IArabicSpeaker
            //{
            //    void Greet();
            //}

            //class Translator : IEnglishSpeaker, IArabicSpeaker
            //{
            //    public void Greet()
            //    {
            //        Console.WriteLine("Hello / Ahlan");
            //    }
            //}


            //a) What is the problem with this design? Both interfaces have a method called Greet() — how does the class handle it currently?
            //-we have 2 interfaces both have same method signature with one implementation in the class 
            //-class will implement one method for both interfaces / both interface references will call the same implementation

            //b) How would you fix this so IEnglishSpeaker.Greet() says "Hello" and IArabicSpeaker.Greet() says "Ahlan" ?
            //    What is this technique called ?
            //    class Translator : IEnglishSpeaker, IArabicSpeaker
            //{
            //    public void IEnglishSpeaker.Greet()
            //    {
            //        Console.WriteLine("Hello");
            //    }
            //    public void IArabicSpeaker.Greet()
            //    {
            //        Console.WriteLine("Ahlan");
            //    }
            //}
            //Explicit interface implementation

            //c) After applying your fix, can you call Greet() directly on a Translator object(e.g.translator.Greet()) ?
            //Why or why not? How do you call each version ?
            // no , explicit members hidden from class refernce
            // each explicit members being caleed with its interface reference 
            #endregion

            #region Q4
      
            var e1 = new Employee { Title = "Dev", Dept = new Department { Name = "IT" } };
            var e2 = e1.ShallowCopy();
            e2.Title = "QA";
            e2.Dept.Name = "Testing";

            Console.WriteLine($"{e1.Title} - {e1.Dept.Name}");
            // Dev - Testing
            Console.WriteLine($"{e2.Title} - {e2.Dept.Name}");
            //QA -Testing
            // as two objects has same inner references changing inner object effect both copies
            #endregion
            #endregion
        }
    }
    class Department { public string Name; }
    class Employee
    {
        public string Title;
        public Department Dept;
        public Employee ShallowCopy() => (Employee)this.MemberwiseClone();
    }
}
