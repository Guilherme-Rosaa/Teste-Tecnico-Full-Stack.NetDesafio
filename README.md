# Nome do Projeto

## Backend
### Requisitos

**Clonar o repositório**: Clone este repositório para sua máquina local:

	git clone https://github.com/Guilherme-Rosaa/Teste-Tecnico-Full-Stack.NetDesafio.git

**Configuração**: A única configuração necessária para o backend é garantir que o projeto esteja pronto para ser iniciado. Não é necessário configurar variáveis de ambiente ou instalar dependências específicas.

**Rodando o Backend**: Navegue até o diretório do backend e execute o seguinte comando para iniciar o projeto:

    dotnet run

Isso iniciará o backend da aplicação.

## Frontend
### Requisitos

**Instalar a versão do Node.js**: Certifique-se de que você está usando a versão 18.19.1 do Node.js ou uma versão similar. Você pode verificar sua versão do Node com o comando:

	node -v

Se necessário, faça o download e instale a versão correta, o projeto esta na versão 16 do angular.

**Instalar dependências**: Navegue até o diretório do frontend e instale as dependências com o seguinte comando:

	npm install

**Configuração da API**: Verifique se a rota da API está correta no arquivo `lead.service.ts`. Garanta que o URL da API esteja apontando para o backend corretamente. Altere a variável `baseUrl` no arquivo para refletir a URL da sua API, se necessário.

**Rodando o Frontend**: Para iniciar o frontend, execute o comando:

    ng serve

Isso iniciará o servidor de desenvolvimento do Angular, e a aplicação estará disponível em https://localhost:4200.

## Estrutura de Diretórios

- `TesteTecnico/:` Contém o código do backend.
- `TesteTecnicoFrontEnd/:` Contém o código do frontend.
