using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaProgramacao

{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            List<Cadastro> listaCadastro = new List<Cadastro>();
            do
            {
                Console.WriteLine("------------------------------------------------"); //utilizar  o count do list para fazer a questão 1
                Console.WriteLine("MENU - Quantidade de cadastros até o momento: " + listaCadastro.Count);
                Console.WriteLine("1 - Incluir");
                Console.WriteLine("2- Alterar");
                Console.WriteLine("3- Excluir");
                Console.WriteLine("4- Listar");
                Console.WriteLine("5- Pesquisar");
                Console.WriteLine("9- Sair");

                

                Console.Write("Digite a opção desejada: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1": //INCLUIR
                        listaCadastro.Add(incluirCadastro());
                        break;

                    case "2": //ALTERAR


                        Console.WriteLine("Insira o ID do cadastro que deseja alterar: ");
                        int alterarCadastro = int.Parse(Console.ReadLine());
                        Cadastro buscaAlterar = listaCadastro.Find(x => x.Id == alterarCadastro);
                        if (buscaAlterar != null)
                        {
                            Console.Write("Cadastro localizado: ");
                            Console.WriteLine(buscaAlterar);

                            listaCadastro.Remove(buscaAlterar);
                            listaCadastro.Add(incluirCadastro());

                            Console.WriteLine("Cadastro alterado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("ID não encontrado!");
                        }

                        break;

                    case "3": //EXCLUIR



                        Console.WriteLine("Insira o ID do cadastro que deseja excluir: ");

                        int excluirCadastro = int.Parse(Console.ReadLine());

                        Cadastro buscaExcluir = listaCadastro.Find(x => x.Id == excluirCadastro);

                        Console.WriteLine("Deseja realmente excluir o cadastro? Digite 1 para SIM, e 2 para NÃO");
                        int escolha = int.Parse(Console.ReadLine());

                        if ((escolha == 1) && (buscaExcluir != null))

                        {
                            listaCadastro.Remove(buscaExcluir);
                            Console.WriteLine("Cadastro excluído com sucesso! ");
                        }

                        else if ((escolha == 2) && (buscaExcluir !=null))
                        {
                            Console.WriteLine("O cadastro será mantido");
                        }
                
                        else
                        {
                            Console.WriteLine("ID não encontrado / Opção inválida");
                        }


                        break;

                    case "4": //LISTAR

                        Console.WriteLine("Lista de cadastrados: ");
                        foreach (Cadastro cadastro in listaCadastro)
                        {
                            Console.WriteLine(cadastro);
                        }

                        break;

                    case "5": //PESQUISAR

                        Console.WriteLine("Insira o ID do cadastro que deseja pesquisar: ");
                        int pesquisaId = int.Parse(Console.ReadLine());

                        Cadastro pesquisar = listaCadastro.Find(pesq => pesq.Id == pesquisaId);

                        if (pesquisar != null)
                        {
                            Console.WriteLine("Cadastro localizado: " + pesquisar);

                        }
                        else
                        {
                            Console.WriteLine("ID não encontrado!");
                        }



                        break;

                    case "9": //SAIR

                        Console.WriteLine("Você está saindo do sistema!");

                        continuar = false;

                        break;

                    default:

                        Console.WriteLine("OPÇÃO INVÁLIDA!");

                        break;

                }

            }
            while (continuar);

            Console.ReadKey();
        }


        private static Cadastro incluirCadastro()
        {

            Cadastro cadastro = new Cadastro();
            Console.WriteLine("Insira os seguintes dados: ");
            Console.Write("ID: ");
            cadastro.Id = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            cadastro.Nome = Console.ReadLine();
            Console.Write("Telefone: ");
            cadastro.Telefone = Console.ReadLine();
            Console.Write("Data de Nascimento: ");
            cadastro.DataNasc = Console.ReadLine();
            Console.Write("Altura: ");
            cadastro.Altura = float.Parse(Console.ReadLine());

            return (cadastro);
        }
    }
}