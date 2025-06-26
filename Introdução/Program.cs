using System.Globalization;
using System.Threading; 

class Program
{
    static void Main(String[] args)
    {
        // C# Possui uma tipagem forte que significa que não é possível ter seu tipo alterado.
        // int i = 5;
        // string i = "Felipe";
        // int i = 6;

        // Separação de strings com Substring(). 
        string pessoaRecebida = "leticia;leticia@leticia.com";
        string email = pessoaRecebida.Substring(8, 19); // Pega caracteres que ficam em posições específicas daquela string.
        Console.WriteLine(email);

        // Divisão com Split(), faz a divisão com base nos parâmetros que será passados, no caso ;
        string pessoaCadastrada = "felipe;felipe@gmail.com";
        string[] pessoaEmail = pessoaCadastrada.Split(";");
        Console.WriteLine(pessoaEmail);
        // Então o Split() vai devolver um array de string com duas posições (System.string[]), sendo que quero pegar apenas o email

        // Split() , separando a string e pegando um elemento específico
        string cadastroUsuario = "roberto;roberto@gmail.com";
        string[] cadastroEmail = cadastroUsuario.Split(";");
        Console.WriteLine(cadastroEmail[1]);  // Pegando a posição do email.      

        // Formatação de data e hora. No c# existe uma classe específica apenas pra trabalhar com data e hora
        DateTime data = new DateTime();
        Console.WriteLine(data);

        // Então vamos usar como por exemplo a data: 01/05/2019 e a hora 13:52:22. Passando os dados no construtor. Ele espera os valores de: ano, mês, dia, hora, minuto, segundo.
        int ano = 2025;
        int mes = 07;
        int dia = 12;
        int hora = 14;
        int minuto = 30;
        int segundo = 14;
        DateTime dataEntrada = new DateTime(ano, mes, dia, hora, minuto, segundo);
        Console.WriteLine(dataEntrada);

        // Então vamos colocar a modificação do horário antes da formatação da data.
        Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR", false);
        int anoData = 2025;
        int mesData = 07;
        int diaData = 12;
        int horaData = 14;
        int minutoData = 30;
        int segundoData = 14;
        DateTime dataHoraioEntrada = new DateTime(anoData, mesData, diaData, horaData, minutoData, segundoData);
        Console.WriteLine(dataHoraioEntrada);

        // Pegando a data atual
        DateTime dataAtual = DateTime.Now;
        Console.WriteLine(dataAtual);

        // Instanciando um objeto da classe Livro
        Livro livro = new Livro()
        {
            Titulo = "As 48 Leis do Poder",
            Autor = "Robert Greene",
            NumeroPaginas = 400,
            PossuiISBN = true,
            AnoPublicacao = new DateTime(2022, 1, 1),
            ISBN = "978-65-86110-00-5"
        };

        Pessoa pessoa = new();
        pessoa.Cpf = "111.222.333-54";
        pessoa.Nome = "Joseh Cabriolo";
        pessoa.Idade = 22;
        pessoa.Email = "joseh@gmail.com";
        





        
        



    }
}
