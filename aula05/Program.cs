BST arvoreBinaria = new BST();

Node raiz = new Node(3);

arvoreBinaria.insert(raiz, 5);
arvoreBinaria.insert(raiz, 2);

Console.WriteLine(raiz.Right.Key);
Console.WriteLine(raiz.Left.Key);

Console.WriteLine("\n");

Node procura = arvoreBinaria.Search(raiz, 2);

Console.WriteLine(procura.Key);

// Note: Normalmente não faço deste jeito, somente hoje para poder terminar o desafio mais rápido
// -- Lucas Sacco Parisi UwU
