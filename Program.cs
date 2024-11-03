Console.WriteLine("Enter an integer:");
int entero = int.Parse(Console.ReadLine());
int contador = 1;
int factorial = 1;

if(entero<0){
    Console.WriteLine("Undefined");
}

else{
    while(contador <= entero){
        factorial *= contador;
        contador++;
    }

    Console.WriteLine(factorial);    
}


