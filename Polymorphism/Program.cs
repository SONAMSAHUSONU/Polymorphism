/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism 
    //means one object multiple form  it is called Pollymorphism exam: switch power : one time presh one and second time switched on .
    //there are two typ polymorphism 1. static pilymorphism(Compiltime Polymorpism): compiletime Polymorpishm we can achive using method overloading. 
    //2. Dynamic pollymorphism (Run time polymorphism): Run time polymorphishm we can achhive using method overrieding.
{
    class Program
    {
        static void Main(string[] args)// one think many form 
        {
        }
        public void Sum(int x, int y)
        {
        }
        public void Sum(int x, int y, int z)
        {
        }
        public void Sum(int x)
        {
        }
        public void Sum(int x, int y, int z , int l)
        {
        }
    }
}*/
/*using System;
public class CustomerA//methord overloading 
{
    public string RegisterCustomer(string Fname, String Lname, int age, long MobileNum, string Email)
    {
        return Fname + Lname;
    }
    public string RegisterCustomer(string Fname, String Lname, int age, long MobileNum )
    {
        return "Fname+Lname";
    }
    public string RegisterCustomer(string Fname, String Lname, long MobileNum)
    {
        return "";
    }
    public string RegisterCustomer(long Mobilenum  )
    {
        return "";
    }
    public static void Main()
    {

    }
    public class customerB : CustomerA
    {
        public void Ctest()
        {
            CustomerA customerA = new CustomerA();
            customerA.RegisterCustomer(7411971341);
            Console.WriteLine("I am Ctest method");


        }
    }
}*/
//In Dynamic poliymorphishm it is complesory have to inheritance without iheriting we can't achhive dynamic polimorphism

/*using System;
public class CustomerA//methord overried : method name same and method parameter also same, method don't have diffrent parameter 
    //methodoverried should be vertual 
    //method overried should we the overried in child class. And base class mehod should  be vertual
    // method retun type also same
    //
{
    public virtual void Atest()//
    {

    }
    public static void Main()
    {

    }
    public class customerB : CustomerA
    {
        public void Ctest()
        {
            CustomerA customerA = new CustomerA();


        }
    }
}*/

using System;
public interface IA
{
    void test(int a, int b);
}
public interface IB
{
    void test(int a, int b);

}
public class C : IA, IB
{
    // void IA.test(int a, int b)//explicitly
    // {
    //  throw new NotImplementedException();
    //}

    //void IB.test(int a, int b)
    //  {
    //  throw new NotImplementedException();
    // }
    public void test(int a, int b)//implicitly
    {
        throw new NotImplementedException();
    }
}
public class D
{
}