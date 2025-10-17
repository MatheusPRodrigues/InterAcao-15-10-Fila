// Lista de contato
using ListaDeContatos;

Lista lista = new Lista();

Contato c1 = new Contato() { Nome = "Alice", Telefone = "1234-5678" }; 
Contato c2 = new Contato() { Nome = "Carlos", Telefone = "2345-6789" }; 
Contato c3 = new Contato() { Nome = "Bruno", Telefone = "3456-7890" }; 
Contato c4 = new Contato() { Nome = "Zumira", Telefone = "4567-8901" }; 
Contato c5 = new Contato() { Nome = "Matheus", Telefone = "5678-9012" };

lista.InserirContato(c2);
lista.InserirContato(c5);
lista.InserirContato(c4);
lista.InserirContato(c3);
lista.InserirContato(c1);