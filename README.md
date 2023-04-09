# 7Core-MUI-UI-jQuery-UI

Para instalar o jQuery UI via Bower no projeto .NET Core 7, siga os passos abaixo:

Abra o terminal ou prompt de comando e navegue para a pasta root do seu projeto.

Certifique-se de ter instalado o Bower globalmente. Caso não tenha, instale digitando o seguinte comando:

Diff
Copy
Insert
New
npm install -g bower
Agora, instale o pacote jQuery UI digitando o seguinte comando:
Diff
Copy
Insert
New
bower install jquery-ui --save
O parâmetro --save adicionará uma entrada ao arquivo bower.json, que lista todas as suas dependências.

Feito isso, você poderá encontrar todos os arquivos do jQuery UI instalados na pasta /lib/jquery-ui.

Por fim, é preciso referenciar o arquivo no seu HTML.

Diff
Copy
Insert
New
<!-- Carrega o jQuery a partir da CDN -->
<script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>

<!-- Carrega o jQuery UI usando o caminho local -->
<link rel="stylesheet" href="~/lib/jquery-ui/jquery-ui.css" />
<script src="~/lib/jquery-ui/jquery-ui.min.js"></script>
Com esses passos, você deve conseguir instalar e utilizar o jQuery UI no seu projeto .NET Core 7!


O seu sistema não está encontrando o comando bower. Para resolvê-lo, você precisa adicionar o diretório do Bower ao PATH do Windows.

Siga os passos abaixo:

Pressione a tecla "Windows" + "R" para abrir a caixa de diálogo "Executar".

Digite SystemPropertiesAdvanced e clique em "OK". Isso abrirá as "Propriedades do sistema".

Clique no botão "Variáveis de ambiente".

Na seção "Variáveis do sistema", localize a variável "Path" e clique em "Editar".

Clique em "Novo" e adicione o caminho para o diretório Bower. Por exemplo: C:\Users\SeuUsuario\AppData\Roaming\npm\node_modules\bower\bin

Clique em "OK" para salvar a variável de ambiente.

Feche todas as janelas abertas e tente executar novamente o comando bower install jquery-ui --save.

Agora, o sistema deve encontrar o comando bower e você poderá usar o jQuery UI em seu projeto .NET Core 7.