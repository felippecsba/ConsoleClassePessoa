using System;


namespace ConsoleClassePessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Digite o nome:");
            pessoa.nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade:");
            pessoa.idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite Seu RG:");
            pessoa.rg = Console.ReadLine();

            Console.WriteLine("Digite Seu CPF:");
            pessoa.cpf = Console.ReadLine();


            Console.WriteLine("### SEUS DADOS ###");
            Console.WriteLine("Nome: {0}", pessoa.nome);
            Console.WriteLine("idade: {0}", pessoa.idade);
            Console.WriteLine("RG: {0}", pessoa.rg);
            Console.WriteLine("CPF: {0}", pessoa.cpf);

            Console.WriteLine("### OUTROS DADOS ###");
            Pessoa pessoaSilvia = new Pessoa();
            pessoaSilvia.nome = "Silvia Mendes";
            pessoaSilvia.idade = 25;
            pessoaSilvia.rg = "12.000.345-00";
            pessoaSilvia.cpf = "123.000.789-00";

            Console.WriteLine("Nome: {0}", pessoaSilvia.nome);
            Console.WriteLine("idade: {0}", pessoaSilvia.idade);
            Console.WriteLine("RG: {0}", pessoaSilvia.rg);
            Console.WriteLine("CPF: {0}", pessoaSilvia.cpf);

            pessoa.Acenar(pessoaSilvia);
            pessoa.PerguntaIdade(pessoaSilvia);

        }
    }
}
