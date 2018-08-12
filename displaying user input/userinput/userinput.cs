using System;
namespace New_folder
{
    class myClass
    { 
        
        
        public static void Main(string[] args)
        {   
            string Userinput;
            int enterInt;
            Console.Write("enter integer value:  ");
            Userinput=Console.ReadLine();
            enterInt=Convert.ToInt32(Userinput);
            Console.WriteLine("you entered .. {0}", enterInt);
        }
        

    }
}