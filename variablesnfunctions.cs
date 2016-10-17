using system;

public class VariablesAndFunctions{
    //Variables are a specific box of information. They are assigned a value, any information quantity either known or unknown.
    int someNumber = 12;
    //"int" is a specified variable meant for a whole number. "someNumber" is the name of the new variable. And "= 12" is the assigned value of the initialized variable.

    //Functions are specific instructions given to a program to peform a task in sequence. These instructions are packaged together into a single unit, very much like a variable or object.
    void someFunction(){
        someNumber = 9
        Debug.Log (someNumber * 3);
        //"Debug.Log" is a command in C# that prints the subject in the console window, much the same as "Console.log" does in JavaScript.
    }
    //This function "void" doesn't return anything after it has performed its task. Other functions that you create can be named and specified to do other things in its task.
    int MultiplySomeNumberByThree(int number){
        int ret;
        ret = number * 3;
        return ret;
    }
    //Functions have parameters set by parentheses "( )" following the name of the function. Inside the curly brackets "{ }" are the actual workings of the function. In this function, the function is set to "ret" return the specified number after the function "MultiplySomeNumberByThree" has run.
}

//Putting the whole thing together:
public class VariablesAndFunctions{
    int someNumber = 12;

    void someFunction(){
        //A function must be "called" in order to run. Simply creating it only defines the function. Calling it brings it up to actually perform the task.
        someNumber = MultiplySomeNumberByThree(someNumber);
        //By placing "someNumber =" in front, it tells the program that the variable "someNumber" will change its value to become the result of the function, rather than the original value designated to it.
    }
    int MultiplySomeNumberByThree(int number){
        int ret;
        ret = number * 3;
        return ret;
    }
}
//In full, the function runs by multiplying "someNumber" by three, returning the product, and then assigning the variable "someNumber" with the new value.