public class Empresa
{
    List<Funcionario> Funcionarios;
    public Empresa()
    {
        Funcionarios = new List<Funcionario>();
    }
    public void AdicionarFuncionario(Funcionario funcionario)
    {
        Funcionarios.Add(funcionario);
    }

    public void ListarFuncionario()
    {
        foreach(var funcionario in Funcionarios)
        {
            Console.WriteLine($"Nome do funcionário: {funcionario.Nome}");
            Console.WriteLine($"Idade do funcionário: {funcionario.Idade}");
            Console.WriteLine($"Sálario do funcionario {funcionario.CalcularSalario()}");
        }
    }
}