using c_sharp_basics_example.ConditionalStatementsExample;
using c_sharp_basics_example.FunctionsExample;
using c_sharp_basics_example.LoopsOrIterationsExample;
using c_sharp_basics_example.ObjectOrientedProgramming;

using System;

namespace c_sharp_basics_example
{
    class Program
    {
        public static object CalculatorFunctions { get; private set; }

        static void Main(string[] args)
        {
            new Functions();
            new CalculatorFunction();
            new FactorialFunction();
            new PortfolioFunction();
            new RecursiveOutputFunction();

            // Variables.RunExample();
            // ConditionalStatements.RunExample();
            // LoopsOrIterations.RunExample();
            // Functions.RunExample();

            /**
             * ======================
             * | Practical Examples |
             * ======================
             */
            // Conditional Statement Example
            // ClassPicker.RunExample();
            // EvenOrOddNumber.RunExample();
            // LetterGrade.RunExample();
            // LoginAuthentication.RunExample();

            // Loops or Iterations Example
            // ElementsFinder.RunExample();
            // MinOrMaxElementFinder.RunExample();
            // SortingAnArray.RunExample();

            // Functions Example
            // CalculatorFunction.RunExample();
            // FactorialFunction.RunExample();
            // PortfolioFunction.RunExample();
            // RecursiveOutputFunction.RunExample();

            // Object-Oriented Programming
            // OOPExample.RunExample();

            // Pass By Reference VS Pass By Value
            // PassByReferenceVsPassByValue.RunExample();
        }
    }
}
