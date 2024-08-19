
Console.WriteLine(" Digite sua idade");
int idade = int.Parse(Console.ReadLine());


if( idade < 16){
    Console.WriteLine("Menor de idade, não pode votar nem dirigir.");
}
else if(idade < 18 ){
    Console.WriteLine("Menor de idade,pode votar mas não dirigir.");
}
else {
    Console.WriteLine("Maior de idade,pode votar e dirigir.");
}

int o = 1;for (int i = 1; i <= 10; i++){
Console.WriteLine($"{i}");
}

