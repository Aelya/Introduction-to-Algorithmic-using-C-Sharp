using System;

namespace Equation
{
    class ApplicationEquation
    {
        public static void Main(string[] args)
        {

        double A, B, C, Delta;
        double X, X1, X2;

        System.Console.Write("Entrer A : ");
        A = Double.Parse(System.Console.ReadLine());

        System.Console.Write("Entrer B : ");
        B = Double.Parse(System.Console.ReadLine());

        System.Console.Write("Entrer C : ");
        C = Double.Parse(System.Console.ReadLine());

        Delta = B*B - 4*A*C;

        if (Delta < 0)

        {

        System.Console.WriteLine(" Il n'ya pas de solution");
                        
        }


        if (Equals(Delta, 0))

        {

        X = (-B / 2 * A);
        System.Console.WriteLine("La solutions est" + X);

        }

        if (Delta > 0)

        {
                
        X1 = (-B + Math.Sqrt(Delta)) / (2 * A);
        X2 = (-B - Math.Sqrt(Delta)) / (2 * A);
        System.Console.WriteLine(" Il y'a deux solutions dans R " + X1 + "et" + X2);

        }
       
        }
    }
}        	            
       

           
        

                    
                
            
        
    



                    

        



