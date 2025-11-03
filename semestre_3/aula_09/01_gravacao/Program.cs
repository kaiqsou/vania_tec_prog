// Definindo o caminho
var caminho = @"C:\Users\0201392321040\Desktop\caminho\arquivo1.txt";

// Se o arquivo existir, permite a criação. Evita repetições.
if (!File.Exists(caminho))
{
    // Preenche o arquivo com o que for dado, nesse caso: 'Autor Desconhecido'
    File.WriteAllText(caminho, "Autor Desconhecido");
}

// Lê todo o conteúdo do arquivo que for passado para ele
string conteudo = (File.ReadAllText(caminho));

// Adiciona um novo texto no arquivo
var novoTexto = "\r\nQuem canta seus males espanta" + Environment.NewLine +
"Água mole em pedra dura tanto bate até que fura\r\nCasa de ferreiro espeto é de pau";
File.AppendAllText(caminho, novoTexto);

Console.WriteLine(conteudo);