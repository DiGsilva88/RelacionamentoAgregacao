using System.Collections;
using System.ComponentModel.Design.Serialization;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace RelacionamentoAgregacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criar estudantes (eles existem separadamente)

            Estudante c1 = new Estudante { Nome = "Ana", Numero = 1 }; //outra forma de criar objectos
            Estudante c2 = new Estudante { Nome = "Bruno", Numero = 2 };


            //cria dois objetos da classe Estudante.
            //eles nascem antes de qualquer disciplina.
            //Na memória, eles já ocupam um espaço próprio e não dependem de mais nada para existir.

            //criar a disciplina-------------
            //cria o objeto Disciplina,no momento da criação,
            //ele provavelmente tem uma lista interna de estudantes que começa vazia.

            Disciplina d1 = new Disciplina { Nome = "Programação" };

            //Agregar estudantes á disciplina

            d1.AdicionarEstudante(c1);
            d1.AdicionarEstudante(c2);

            //está passando a referência de objetos que já existiam para dentro da lista da disciplina.
            //A Disciplina agora "conhece" a Ana e o Bruno.
            //Se a variável d1 fosse apagada, os objetos c1 e c2 continuariam intactos na memória.



            Console.WriteLine($"Diciplina: {d1.Nome} tem {d1.Estudantes.Count} alunos inscritos: ");
            foreach(Estudante e in d1.Estudantes)
            {
                Console.WriteLine($" {e.Nome}, nº{e.Numero}");


                //O programa acessa a propriedade Estudantes da disciplina(que é uma coleção,
                //como um List<Estudante>) e percorre cada item para exibir os detalhes.



                //notas: os estudantes existem antes da disciplina,
                //e é possivel reutilizar os estudantes para outra disciplina,
                //estarem inscritos noutras disciplinas
            }
        }
    }
}
