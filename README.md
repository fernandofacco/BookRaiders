# BookRaiders

Abaixo está escrito o passo-a-passo para configurar o ambiente para poder trabalhar no projeto BookRaiders

O PowerApps é a solução cloud usada para visualizar a solução (FrontEnd) bem como também armazena, em algum lugar, a lógica de negócio escrita em CSharp que está presente aqui no GitHub.
Os códigos em CSharp que estão aqui disponíveis no GitHub precisam ser enviados para o PowerApps através do Plugin Registration Tool. Já a função do GitHub neste projeto é unicamente para todos os integrantes do projeto terem acesso à versão mais atualizada dos códigos, ou seja, não há integração entre o PowerApps e o GitHub diretamente.

1. Baixar "PluginRegistration.zip" na raíz do repositório
2. Abrir o PluginRegistration.exe
3. Clicar em Create New Connection
4. Selecione Office 365
5. Marque o checkbox "Display list of available organizations
6. Marque o checkbox Show Advanced
7. No dropdown de Online Region selecione South America
8. User Name e Password coloque seu login da Unisinos e clique em Login
9. Instalar .NET 4.7.1 (https://dotnet.microsoft.com/en-us/download/dotnet-framework/thank-you/net471-developer-pack-offline-installer)
10. Baixar o Visual Studio (não confundir com Visual Studio Code)
11. Configurar o Visual Studio para o pacote .NET (pacote necessário para trabalhar com a linguagem de programação CSharp)
12. Configurar o Visual Studio para importar o código a partir deste repositório (clonar a partir do link https://github.com/fernandofacco/BookRaiders/ e abrir solução)
13. Talvez seja necessário mudar "Target Application" (ou em português Estrutura de Destino) para ".NET Framework 4.7.1". Isso é feito clicando com o botão direito em cima do nome do projeto BookRaiders dentro do Visual Studio

A partir desde momento você está pronto para fazer modificações no projeto.

Após uma modificação ser feita, você deve fazer o seguinte:


1. Atualizar o código no PowerApps (para que a solução tenha o código mais atualizado) via Plugin Registration Tool
2. Testar plugin no power apps (validar se o código modificado tá funcionando)
3. Atualizar o código modificado em seu visual studio para o GitHub (para os outros colegas terem acesso ao código mais atual)
