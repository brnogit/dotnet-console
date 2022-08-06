// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Digite seu nome:");

// var nome = Console.ReadLine();
// Console.WriteLine("Hello, " + nome);
// Console.WriteLine($"Hello, {nome}");

// string segundoNome = "Mota"; // string usa aspas duplas e o char usa aspas simples
// int numeroInt = 5;
// float numeroFloat = 5.4f;
// double numeroDouble = 5.4;
// decimal numeroDecimal = 5.3m;
// int[] matrizArray = new int[3] { 1, 2, 3};
// char caractere = 'a';
// DateTime hoje = DateTime.Now;
// DateTime aniversario = new DateTime(1991, 1, 1);

// // if - else

// Console.WriteLine("Digite uma opção entre 1 e 3");
// var opcao = Console.ReadLine();

// if (opcao == "1") {
//     Console.WriteLine("if-else: Opção 1 selecionada.");
// } else if (opcao == "2") {
//     Console.WriteLine("if-else: Opção 2 selecionada.");
// } else if (opcao == "3") {
//     Console.WriteLine("if-else: Opção 3 selecionada.");
// } else {
//     Console.WriteLine("if-else: Opção inválida.");
// }

// switch (opcao) {
//     case "1":
//         Console.WriteLine("switch-case: Opção 1 selecionada.");
//         break;
//     case "2":
//         Console.WriteLine("switch-case: Opção 2 selecionada.");
//         break;
//     case "3":
//         Console.WriteLine("switch-case: Opção 3 selecionada.");
//         break;
//     default:
//         Console.WriteLine("switch-case: Opção inválida");
//         break;
// }

// var valores = Console.ReadLine(); // "1 2 3 4 5"
// var matrizValores = valores.Split(" "); // 0, 1, 2, 3, 4

// Console.WriteLine("Utilizando For.");
// for (var i = 0; i < matrizValores.Length; i++) {
//     Console.WriteLine(matrizValores[i]);
// }

// var contador = 0;

// Console.WriteLine("Utilizando While.");
// while (contador  < matrizValores.Length) {
//     Console.WriteLine(matrizValores[contador]);

//     contador++;
// }

var notasTurma = new List<int> { 10, 5, 2, 3, 10, 4, 3, 2, 7, 2, 5, 1, 4 };

var existeNota1 = notasTurma.Any( n => n == 1);
var primeiroNota10 = notasTurma.First( n => n  == 10);
var singleNota1 = notasTurma.Single( n => n == 1);
var max = notasTurma.Max();
var min = notasTurma.Min();
var sum = notasTurma.Sum();
var media = notasTurma.Average();
//var ordered = notasTurma.OrderBy(n => n);
var ordered = notasTurma.OrderByDescending(n => n);

foreach (var nota in ordered) {
    Console.WriteLine(nota);
}