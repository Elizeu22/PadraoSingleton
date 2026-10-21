
using SistemaConfiguracoes;

Comfiguracao comfiguracao = Comfiguracao.Configurar;
Comfiguracao comfiguracao1 = Comfiguracao.Configurar;

comfiguracao1.Servidor("", "");

comfiguracao.Servidor("", "");

Console.WriteLine(ReferenceEquals(comfiguracao, comfiguracao1));