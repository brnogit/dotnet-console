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

var valores = Console.ReadLine(); // "1 2 3 4 5"
var matrizValores = valores.Split(" "); // 0, 1, 2, 3, 4

for (var i = 0; i < matrizValores.Length; i++) {
    Console.WriteLine(matrizValores[i]);
}