using POO; // Para entender os artefatos que estou utilizando nesta classe

Pessoa pessoa = new Pessoa();

pessoa.setNome("João");
pessoa.setIdade(25);
pessoa.setCpf("123.456.789-00");
pessoa.setAltura(1.75);

Console.WriteLine("Nome: " + pessoa.getNome());
Console.WriteLine("Idade: " + pessoa.getIdade());
Console.WriteLine("CPF: " + pessoa.getCpf());
Console.WriteLine("Altura: " + pessoa.getAltura());