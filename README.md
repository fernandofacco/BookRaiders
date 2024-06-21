# BookRaiders

Abaixo está escrito o passo-a-passo para configurar o ambiente para poder trabalhar no projeto BookRaiders

O PowerApps é a solução cloud usada para visualizar a solução (FrontEnd) bem como também armazena, em algum lugar, a lógica de negócio escrita em CSharp que está presente aqui no GitHub.
Os códigos em CSharp que estão aqui disponíveis no GitHub precisam ser enviados para o PowerApps através do Plugin Registration Tool. Já a função do GitHub neste projeto é unicamente para todos os integrantes do projeto terem acesso à versão mais atualizada dos códigos, ou seja, não há integração entre o PowerApps e o GitHub diretamente.

1. Baixar "PluginRegistration.zip" na raíz do repositório
2. Instalar .NET 4.7.1 (https://dotnet.microsoft.com/en-us/download/dotnet-framework/thank-you/net471-developer-pack-offline-installer)
3. Baixar o Visual Studio
4. Configurar o Visual Studio para o pacote .NET (pacote necessário para trabalhar com a linguagem de programação CSharp)
5. Configurar o Visual Studio para importar o código a partir deste repositório (clonar a partir do link https://github.com/fernandofacco/BookRaiders/ e abrir solução)
6. Talvez seja necessário mudar "Target Application" para ".NET Framework 4.7.1"

A partir desde momento você está pronto para fazer modificações no projeto.

Após uma modificação ser feita, você deve fazer o seguinte:


1. Atualizar o código no PowerApps (para que a solução tenha o código mais atualizado) via Plugin Registration Tool
2. Testar plugin no power apps (validar se o código modificado tá funcionando)
3. Atualizar o código modificado em seu visual studio para o GitHub (para os outros colegas terem acesso ao código mais atual)
