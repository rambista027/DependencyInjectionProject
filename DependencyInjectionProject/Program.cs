using DependencyInjectionProject.Abstractions;
using DependencyInjectionProject.Implementations;
using System;

namespace DependencyInjectionProject
{
    class Program
    {
        private static bool _isValid = false;
        private static string _input;
        private static IPerson _boy = new Boy();
        private static IPerson _girl = new Girl();
        //private static Human _human;

        //Program(Human human) {
        //    _human = human;
        //}

        public static void Main()
        {
            Console.WriteLine(StringConstant.WelcomeMessage);
            Process();
        }

        /// <summary>
        /// Process helps to get the gender of a person
        /// on the basis input by means of dependency injection
        /// </summary>
        public static void Process()
        {
            while (!_isValid)
                ReadLine();

            Human human = new Human(GetPersonInstance());
            //Human human = new Human();
            human.DisplayHelloMessage();
            _isValid = false;

            DisplayTryAgainMsg();
            while (!_isValid)
            {
                _input = Console.ReadLine();
                ValidateTryAgainInput();
            }
            if (_input.ToLower() == "y")
            {
                _isValid = false;
                Console.WriteLine("\n");
                Process();
            }
        }
        public static void ReadLine()
        {
            DisplayInputMsg();
            _input = Console.ReadLine();
            _isValid = ValidateInput();
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Get the instance of person
        /// 1 for boy and 2 for girl
        /// </summary>
        public static IPerson GetPersonInstance()
        {
            return _input == "1" ? _boy : _girl;
        }

        #region Validator
        public static bool ValidateInput()
        {
            if (_input == "1" || _input == "2")
                return true;

            Console.WriteLine(StringConstant.InvalidErrorMessage);
            return false;
        }

        public static bool ValidateTryAgainInput()
        {
            if (_input.ToLower() == "y" || _input.ToLower() == "n")
            {
                _isValid = true;
                return true;
            }

            Console.WriteLine(StringConstant.InvalidErrorMessage);
            DisplayTryAgainMsg();
            Console.WriteLine("\n");
            return false;
        }
        #endregion

        #region Display Message
        public static void DisplayInputMsg() =>
            Console.WriteLine(StringConstant.InputMessage);

        public static void DisplayTryAgainMsg() =>
           Console.WriteLine(StringConstant.TryAgainMessage);
        #endregion

    }
}

