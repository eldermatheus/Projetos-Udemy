using ContaBancaria;

Console.WriteLine("Entre o número da conta:");
int numero = int.Parse(Console.ReadLine());
Console.WriteLine("Entre o titular da conta:");
string nome = Console.ReadLine();

Conta conta = new Conta(numero, nome);

Console.WriteLine("Haverá depósito inicial (s/n)?");
string depositoInicial = Console.ReadLine().ToLower();


if (depositoInicial.StartsWith('s')) {
    
    Console.WriteLine("Entre o valor de depósito inicial:");
    decimal valorDepositoInicial = decimal.Parse(Console.ReadLine());    
    conta.Saldo = valorDepositoInicial;
}

Console.WriteLine("Dados da conta:");
Console.WriteLine(conta.ToString());

//Operações

Console.WriteLine("Entre um valor para depósito:");
conta.Depositar(decimal.Parse(Console.ReadLine()));

Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(conta.ToString());

Console.WriteLine("Entre um valor para saque:");
conta.Sacar(decimal.Parse(Console.ReadLine()));

Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(conta.ToString());