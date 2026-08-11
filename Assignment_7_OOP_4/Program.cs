namespace Assignment_7_OOP_4;

internal class Program
{
    static void Main(string[] args)
    {
        #region Question1
        // a) What is the difference between Method Overloading and Method Overriding?
        // => Overloading is having multiple methods with the same name but different parameters, Overriding is providing a new implementation for a method inherited from a base class

        // b)  What is the difference between Static Binding and Dynamic Binding?
        // => Static Binding is resolved by the compiler at compile-time, Dynamic Binding is resolved at run-time
        #endregion

        #region Question2
        // a)  What is the purpose of the sealed keyword when applied to a class?
        // => prevents the class from being inherited

        // b)  What is the difference between a sealed class and a sealed method?
        // => Sealed Class Prevents inheritance of the entire class, Sealed Method Prevents overriding

        // c)  Can a sealed method be overridden? Why?
        // => No, The sealed method terminate the inheritance chain for that specific method
        #endregion
    }
}