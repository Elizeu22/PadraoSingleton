xercício Singleton — Configuração do Sistema

📌 Sobre o projeto

Este projeto tem como objetivo praticar o padrão de projeto Singleton em C#,
utilizando um sistema de configurações como exemplo.

A ideia é garantir que exista apenas uma instância da classe ConfiguracaoSistema,
permitindo que diferentes partes do programa acessem as mesmas configurações.

🎯 Objetivos

Compreender o funcionamento do padrão Singleton.

Utilizar um construtor privado (private).

Trabalhar com membros estáticos (static).

Compartilhar uma única instância de uma classe.

Verificar se duas variáveis apontam para o mesmo objeto.

🛠️ Tecnologias utilizadas

C#

.NET

Visual Studio

📂 Estrutura do projeto

SingletonExercicio/
├── Program.cs
└── ConfiguracaoSistema.cs

Responsabilidade dos arquivos

Program.cs: executa o programa e verifica se a instância é compartilhada.

ConfiguracaoSistema.cs: implementa o padrão Singleton e armazena as configurações do sistema.

📋 Requisitos do exercício

A classe ConfiguracaoSistema deverá:

Possuir um construtor privado.

Disponibilizar uma única instância por meio da propriedade estática Instancia.

Armazenar o nome do sistema: Sistema Empresa.

Armazenar o servidor: servidor-empresa.com.

Implementar o método ExibirConfiguracoes().

Impedir a criação direta de novas instâncias com new.

No Program.cs, devem ser criadas duas referências à instância e utilizada a expressão ReferenceEquals()
para verificar se ambas apontam para o mesmo objeto.