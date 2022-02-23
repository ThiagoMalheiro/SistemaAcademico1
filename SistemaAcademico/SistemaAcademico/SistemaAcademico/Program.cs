using System;
using SistemaAcademico.Model;

namespace SistemaAcademico
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno objAluno = new Aluno(); //Aluno() método construtor
            Professor joao = new Professor();
            int x;            
            objAluno.cpf = 44328063870;
            objAluno.dataNascimento = DateTime.Parse("25/09/1990");
            joao.cpf = 221323;
            objAluno.nome = "Maria";
            joao.nome = "João Pedro";
            joao.dataNascimento = DateTime.Parse("25/10/1995");
            joao.endereco = "Rua Pedro gomes";
            joao.telefone = "9999999999";

            Console.WriteLine(objAluno.cpf);
            Console.WriteLine(objAluno.nome);
            Console.WriteLine(objAluno.dataNascimento.ToString("dd/MM/yyyy"));
            Console.WriteLine(joao.cpf);
            Console.WriteLine(joao.nome);
            Console.WriteLine(joao.dataNascimento.ToString("dd/MM/yyyy"));
            Console.WriteLine(joao.endereco);
            Console.WriteLine(joao.telefone);
            Console.ReadKey();
        }
    }
}
