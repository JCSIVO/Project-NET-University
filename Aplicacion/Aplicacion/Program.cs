class Program
{

    static void Main(string[] args)
    {
        char letra;
        string frase;
        string nueva;
        /*int numero;
        Console.WriteLine("Introduce un numero PAR entre 100 y 200 ");
        numero = Convert.ToInt32(Console.ReadLine());
        if (numero < 100 || numero > 200 || numero % 2 != 0)
            Console.WriteLine("El numero introducido es incorrecto");
        else {
            while (numero > 100 && numero <= 200)
                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero);
                    numero += 2;
                }
        }*/

        Console.WriteLine("Introduce un caracter ");
        letra = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Introduce un String");
        frase = Convert.ToString(Console.ReadLine());

        Console.WriteLine("La letra escogida es: " + letra);
        Console.WriteLine("La frase escogida es: " + frase);

        if (frase.Contains(letra))
        {
            for (int i = 0; i < frase.Length; i++)
            {
             
                
                    Console.WriteLine(frase.IndexOf(letra));
                                    
                
            }
            

            Console.WriteLine("Contiene la letra " + frase.Contains(letra));
            
        }



    }
}