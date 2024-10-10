Empresa ulbra = new Empresa();
Funcionario marcelo = new Funcionario("marcelo" , 35);
Gerente lucas = new Gerente("Lucas",32,50);
Estagiario pedro = new Estagiario("Pedro", 19);

ulbra.AdicionarFuncionario(marcelo);
ulbra.AdicionarFuncionario(lucas);
ulbra.AdicionarFuncionario(pedro);
ulbra.ListarFuncionario();
