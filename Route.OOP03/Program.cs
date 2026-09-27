using Route.OOP03.Overloading;
using Route.OOP03.Overriding;
using Route.OOP03.WithoutPolymorphism;

namespace Route.OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 01 - Polymorphism (Overview)
            /*
             * Polymorphism means "many forms": the same method call produces
             * different behavior depending on the actual object behind it.
             *
             * Two types 
             *   - Static  / Compile-time polymorphism -> Overloading, Operator
             *     Overloading, Method Hiding. The compiler decides, based on
             *     the declared (reference/variable) TYPE.
             *   - Dynamic / Run-time polymorphism -> Method Overriding,
             *     abstract methods, interface methods. The CLR decides, based
             *     on the actual OBJECT in memory.
             *
             * 
             */



            #endregion

            #region 02 - Method Overloading
            /*
             * Allows a class to declare several methods with the SAME name
             * but a DIFFERENT parameter list (count, type, and/or order).
             *
             * Rules:
             *   - The method name must match exactly.
             *   - The parameter list must differ (count, type, or order). 
             *
             * The compiler always matches a call to the MOST SPECIFIC applicable overload
             *
             * All of this is resolved entirely at COMPILE time -> zero runtime cost -> this is what makes it "static" polymorphism.
             */

            //WalletPayment wp = new WalletPayment();


            #region Ex01 

            // Second overload
            //Calculator.SumNumbers(10, 10, 10);

            //// First overload
            //Calculator.SumNumbers(4.5, 5.5);

            #endregion

            #region Ex02 

            //Logger.Log("error", "error occured", DateTime.UtcNow);

            #endregion

            #region Ex03 

            //Money price = new Money(100, "EGP");
            //Money tax = new Money(50, "EGP");

            //Money total = price + tax;
            //Console.WriteLine(total);

            #endregion


            #endregion

            #region 03 - Method Hiding
            /*
             * A derived class can HIDE (shadow) an inherited member with the `new` keyword instead of replacing it.
             * The base version is not deleted - both versions exist, and the compiler picks one based on the declared REFERENCE type,
             * not the object's real type.
             *
             * Leaving out `new` still hides the member, but the compiler warns with CS0108, asking you to make the intent explicit.
             *
             */

            // "[Full-Time] ..." - FullTimeEmployee's own version
            //FullTimeEmployee ft = new FullTimeEmployee(10, "Ahmed", 10000, 1000);
            //ft.PrintInfo();

            // "[Employee] ..." - the reference type decides
            //Employee emp = new FullTimeEmployee(100, "Ali", 50000, 5000);
            //emp.PrintInfo();

            #endregion

            #region 04 - Method Overriding
            /*
             * Lets a derived class supply its OWN implementation of a method
             * the base class already defined.
             *
             * Requirements: the base method must be virtual, abstract, or itself an override the derived member must use `override`
             * name, return type, parameters and access modifier must match EXACTLY. You cannot override static, private, sealed,
             * or plain non-virtual members - there is nothing marked overridable.
             *
             * Unlike hiding, this is resolved at RUN time by the CLR, based on the actual object in memory
             * this is what makes polymorphism dynamic. 
             */

            //FullTimeEmployee fullTimeEmployee  = new FullTimeEmployee(10, "Ahmed", 10000, 1000);
            //Console.WriteLine(fullTimeEmployee.CalculateSalary());

            //Employee employee = new FullTimeEmployee(10, "Ahmed", 10000, 1000);
            //Console.WriteLine(employee.CalculateSalary());

            //Employee ptEmployee = new PartTimeEmployee(10, "Ali", 25, 300);
            //Console.WriteLine(ptEmployee.CalculateSalary());


            //TestEmployee testEmployee = new TestEmployee(10, "Ali", 25, 300, "Senior");
            //Console.WriteLine(testEmployee);
            #endregion

          

        }
    }
}

