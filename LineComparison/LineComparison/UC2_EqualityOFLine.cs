using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class UC2_EqualityOFLine
    {
    double len2;
    int X1, X2, Y1, Y2;
    int A1, A2, B1, B2;
    public void checkequal()
    {
        
            Console.WriteLine("Enter value for  coordinate x1 y1 x2 y2");
            X1 = Convert.ToInt16(Console.ReadLine());
            X2 = Convert.ToInt16(Console.ReadLine());
            Y1 = Convert.ToInt16(Console.ReadLine());
            Y2 = Convert.ToInt16(Console.ReadLine());

        double LineLength = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
        double len = Math.Round(LineLength, 2);

        Console.WriteLine("Length of Line1 is: " + len);

        Console.WriteLine("Enter value for  coordinate A1 B1 A2 B2");
        A1 = Convert.ToInt16(Console.ReadLine());
        A2 = Convert.ToInt16(Console.ReadLine());
        B1 = Convert.ToInt16(Console.ReadLine());
        B2 = Convert.ToInt16(Console.ReadLine());

        double LineLength1 = Math.Sqrt(Math.Pow((A2 - A1), 2) + Math.Pow((B2 - B1), 2));
        double len1 = Math.Round(LineLength1, 2);

      
        Console.WriteLine("Length of Line2 is: " + len1);

        if (len.Equals(len1))
        {
            Console.WriteLine("Value of both the lines are equal\n\n");
        }
        else
        {
            Console.WriteLine("Value of both the lines are not equal\n\n");
        }
    }
    
        
    }
   
    

