using System;

class Program
{
    static void Main()
    {
        // Example 1: Using 'is' operator for type checking
        object obj1 = "Hello World";
        object obj2 = 42;

      #region IS_REGION
          if (obj1 is string)
          {
              Console.WriteLine("obj1 is a string");
              string str = (string)obj1;  // Traditional casting
              Console.WriteLine($"Value: {str}");
          }
  
      #endregion
        // Example 2: Using 'as' operator for safe casting
        #region AS_REGION
            string text = obj1 as string;  // Will return null if cast fails
            if (text != null)
            {
                Console.WriteLine($"Successfully cast to string: {text}");
            }
            // This will return null instead of throwing an exception
            string invalidCast = obj2 as string;
            Console.WriteLine($"Invalid cast result: {invalidCast}");  // Outputs: null
        #endregion

        // Example 3: Pattern matching with 'is'
        #region IS
            object value = 100;
            if (value is int number)
            {
                // 'number' is automatically declared and assigned
                Console.WriteLine($"Got a number: {number}");
            }
        #endregion

        // Example 4: Type checking with inheritance
        Animal animal = new Dog();
        if (animal is Dog)
        {
            Dog dog = animal as Dog;
            dog?.Bark();
        }
    }
}

class Animal { }

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Woof!");
    }
}
