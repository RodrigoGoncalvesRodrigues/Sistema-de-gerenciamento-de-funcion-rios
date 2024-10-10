public class Funcionario
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public virtual double CalcularSalario()
    {
        return 1000.00;
    }

    public Funcionario(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    

}