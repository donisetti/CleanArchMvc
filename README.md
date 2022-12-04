# CleanArchMvc

Este curso apresenta os principais conceitos relacionados com a Clean Architecture e com as boas práticas que aplicadas permitem criar aplicações ASP .NET Core com uma arquitetura limpa.

Os fundamentos apresentados baseiam-se na Clean Architecture que refere-se à organização do projeto de forma que seja fácil de entender e fácil de mudar conforme o projeto cresce. Isso não acontece por acaso. É preciso um planejamento intencional para que isso ocorra.

Durante o curso vamos criar uma aplicação ASP .NET Core MVC no VS 2022 e também no VS Code, identificar os problemas e a seguir propor a solução aplicando os conceitos da Clean Architecture onde vamos separar os arquivos, classes projetos e componentes que podem mudar independentemente entre si.

Desta forma estaremos passando de uma solução monolítica contendo um único projeto para uma solução contendo 5 projetos onde a cada projeto será atribuído as responsabilidades específicas e onde vamos definir os relacionamentos entre os projetos respeitando os princípios da arquitetura limpa e a regra da dependência.

A solução final vai possuir os seguintes projetos : Domain, Application, Infrastructure, IoC e o projeto de apresentação, que é uma aplicação ASP .NET Core MVC, onde vamos aplicar a separação das responsabilidades, a injeção de dependência, usar alguns conceitos do Domain Drive Design e implementar os padrões Repository e CQRS.

Ao final nossa aplicação ASP .NET Core MVC estará aderente às boas práticas e aos princípios da Clean Architecture de forma que a manutenção e também a inclusão de novas funcionalidades poderá ser feita de forma bem mais fácil e onde os testes poderão ser aplicados de forma simples.

Obs: O curso apresenta uma seção onde recria o projeto no .NET 6 usando o Visual Studio 2022