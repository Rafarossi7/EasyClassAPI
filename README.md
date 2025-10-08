# 🚀 EasyClassAPI - Backend para o Aplicativo EasyClass

| Tecnologia| Descrição |
| :---: | :---: |
| ![.NET](https://img.shields.io/badge/.NET-8.0-blue?logo=dotnet) | **Framework** |
| ![C#](https://img.shields.io/badge/Language-C%23-239120?logo=csharp) | **Linguagem** |
| ![Database](https://img.shields.io/badge/Database-SQL%20Server-red?logo=microsoftsqlserver) | **Banco de Dados** |
| ![License](https://img.shields.io/badge/License-MIT-green) | **Licença** |
| ![Status](https://img.shields.io/badge/Status-Em%20Desenvolvimento-yellow) | **Status** |

A **EasyClassAPI** é uma API **RESTful** desenvolvida em **ASP.NET Core 8** que serve como **backend** do aplicativo **EasyClass**.

Atualmente, o foco principal é a **autenticação e gerenciamento básico de usuários**, preparando o sistema para futuras expansões.

> ⚠️ **Status do Projeto:** O projeto está em **desenvolvimento**. As próximas implementações planejadas incluem: salas virtuais, envio de atividades e notificações.

---

## ✨ Funcionalidades Atuais

A API implementa o ciclo completo de autenticação e gerenciamento de conta, utilizando **JWT** e **Identity Framework**:

| Funcionalidade | Endpoint (Exemplo) | Descrição |
| :---: | :---: | :---: |
| ✅ **Registro** de usuários | `/api/Auth/register` | Cria uma nova conta de usuário. |
| 🔐 **Login** e Autenticação | `/api/Auth/login` | Gera o token de acesso (JWT). |
| 🔁 **Refresh Token** | `/api/Auth/refresh-token` | Renova o token de acesso expirado. |
| 🚫 **Revogação** de Token | `/api/Auth/revoke/{email}` | Invalida o refresh token de um usuário específico. |
| 👤 **Consulta** de Usuário | `/api/Auth/buscar/{id}` | Busca dados de um usuário pelo ID. |

---

## 🧰 Tecnologias Utilizadas

Este projeto foi construído com as seguintes tecnologias:

* **Backend:** **ASP.NET Core 8** (C#)
* **Banco de Dados:** **SQL Server**
* **Autenticação:** **ASP.NET Identity Framework** + **JWT**
* **Documentação/Testes:** **Swagger UI**

---

## 🧩 Pré-requisitos

Para rodar o projeto localmente, certifique-se de ter instalado:

* **[.NET SDK 8+](https://dotnet.microsoft.com/en-us/download):** Para compilar e executar a aplicação.
* **[SQL Server](https://www.microsoft.com/en-us/sql-server) (ou LocalDB):** Para o banco de dados.
* **[Visual Studio 2022](https://visualstudio.microsoft.com/) ou [VSCode](https://code.visualstudio.com/):** O ambiente de desenvolvimento de sua preferência.
* **Git:** Para clonar o repositório.

---

## 🚀 Como Rodar Localmente

Siga os passos para configurar e executar a EasyClassAPI em sua máquina:

1.  **Clone** o repositório:

    ```bash
    git clone [https://github.com/seu-usuario/EasyClassAPI.git](https://github.com/seu-usuario/EasyClassAPI.git)
    cd EasyClassAPI
    ```

2.  Abra a solução (`.sln`) no **Visual Studio** ou **VSCode**.

3.  **Configure o `appsettings.json`**:
    Você precisará atualizar as *Connection Strings* e as chaves de *JWT* no arquivo `appsettings.json`. Você pode usar o `appsettings.example.json` como modelo.

    **Exemplo de `appsettings.json`:**
    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=SEU_SERVIDOR;Database=EasyClassDB;Trusted_Connection=True;TrustServerCertificate=True"
      },
      "JWT": {
        "SecretKey": "SUA_CHAVE_SECRETA_AQUI_E_GRANDE",
        "Issuer": "EasyClassAPI",
        "Audience": "EasyClassClient",
        "DurationInMinutes": 60
      }
    }
    ```

    > **Nota:** Certifique-se de que o SQL Server esteja rodando e que as credenciais da *Connection String* estejam corretas.

4.  **Execute o projeto** (pode ser pelo Visual Studio ou pelo comando `dotnet run`).

5.  Acesse o **Swagger UI** para testar os endpoints:

    ```
    http://localhost:<porta>/swagger
    ```

---

## 📂 Estrutura do Projeto

A organização do código segue o padrão **Clean Architecture / Repository Pattern**:
```
EasyClassAPI/
├─ Controllers/        # Endpoints da API e tratamento de requisições.
├─ Models/             # Modelos de dados, DTOs e entidades.
├─ Services/           # Lógica de negócios, manipulação de JWT e regras do sistema.
├─ Data/               # Contexto do EF Core e Migrations do banco.
├─ Program.cs          # Configuração de serviços e middleware.
└─ appsettings.json    # Configurações da aplicação (DB, JWT, etc.).
```
---

## 📞 Contato

Para dúvidas ou sugestões, entre em contato:

* **Nome:** Rafael Rossi
* **Email:** rafaelrossi7@outlook.com
