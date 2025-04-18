using System;
using System.IO;

class Program
{
    static void Main()
    
       
    {
      
        string myFile = new  ("MyDetails.txt");


       using StreamWriter writer = new StreamWriter(myFile);
        writer.WriteLine("Name: Taylor Puente");
        writer.WriteLine("Age: 26");
        writer.WriteLine("Name: El Paso,TX");
        writer.Close();

        StreamReader reader = new StreamReader(myFile);
        string line;

        while ((line = reader.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }



    }
}