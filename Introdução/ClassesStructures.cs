/*
O que são classes em c# ?
-> classe é um molde para a criação de objetos.
Uma definição bem interessante é a do Everton Araújo, autor do livro Orientação a Objetos em C#, da Casa do Código.
Para Araújo, uma classe "é um conjunto ou um conjunto de objetos que compartilham de propriedades e métodos em comum."
No c# podemos demonstrar uma classe a seguir
*/
public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int NumeroPaginas { get; set; }
        public bool PossuiISBN { get; set; }
        public string ISBN { get; set; }
        public DateTime AnoPublicacao { get; set; }
        public string DadosLivro()
        {
            return $"Título: {this.Titulo}"+
                   $"Autor: {this.Autor}";
        }
    }

    /*
O que são Structures em c#
São bem parecidas com as classes, porém enquanto as Structures são definidas como 
sendo um tipo de valor as classes são definidas como sendo um tipo de referência. 
São utilizadas em casos onde possui menos propriedades pois os objetos criados são mais leves 
e por ser do tipo de valor não trabalham com referências.
*/

public struct Pessoa
    {
        public int Idade { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string ISBN { get; set; }
        public DateTime AnoPublicacao { get; set; }
        public override string ToString()
        {
            return $"Título: {this.Idade}"+
                   $"Autor: {this.Nome}";
        }
    }