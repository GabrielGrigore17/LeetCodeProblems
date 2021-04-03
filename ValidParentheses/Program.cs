using System;
using System.Collections.Generic;

namespace ValidParentheses
{
    class Program
    {
        public static bool IsValid(string s) {
            var numbers = new Stack<char>();
            for(int i = 0; i < s.Length; i++){
                switch(s[i]){
                    case '{':
                        numbers.Push('{');
                        break;
                    case '(':
                        numbers.Push('(');
                        break;
                    case '[':
                        numbers.Push('[');
                        break;
                    case ']':
                        if(numbers.Count != 0){
                            if(numbers.Peek() == '[')
                                numbers.Pop();
                            else
                                return false;
                        }
                        else return false;
                        break;
                    case ')':
                        if(numbers.Count != 0){
                            if(numbers.Peek() == '(')
                                numbers.Pop();
                            else
                                return false;
                        }
                        else return false;
                        break;
                    case '}':
                        if(numbers.Count != 0){
                            if(numbers.Peek() == '{')
                                numbers.Pop();
                            else
                                return false;
                        }
                        else return false;
                        break;
                    default:
                        throw new ArgumentException("The list of arguments is not valid");
                }
            }
            if(numbers.Count == 0)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsValid("}(){}}{"));
        }
    }
}
