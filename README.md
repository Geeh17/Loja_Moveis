# LojasMoveis

**Sistema completo de e‑commerce de móveis** com catálogo, carrinho de compras, processamento de pedidos e painel administrativo com relatórios de vendas.

---

## 📌 Visão Geral
LojasMoveis é uma aplicação web desenvolvida em ASP.NET Core MVC (.NET 6) destinada a lojas de móveis que precisam de:

- Catálogo de produtos filtrável por categorias.
- Carrinho de compras persistente entre sessões.
- Processamento e gerenciamento de pedidos.
- Área administrativa restrita para CRUD de categorias, móveis, imagens e pedidos.
- Relatórios e gráficos de vendas em tempo real.
- Autenticação e autorização com ASP.NET Core Identity (Admin/User).

---

## 🚀 Stack Tecnológico
- **Framework**: ASP.NET Core MVC (.NET 6)
- **ORM**: Entity Framework Core (SQL Server)
- **Autenticação**: ASP.NET Core Identity
- **Paginação**: ReflectionIT.Mvc.Paging
- **Front‑end**: Razor Views, Bootstrap 5
- **IDE**: Visual Studio 2022
- **Linguagem**: C# 10

---

## 🛠️ Requisitos
- Visual Studio 2022 com workload **ASP.NET e desenvolvimento web**
- .NET SDK 6.0
- SQL Server (LocalDB ou instância dedicada)

---

## ⚙️ Instalação e Configuração

1. **Clone o repositório**
   ```bash
   git clone https://github.com/Geeh17/Loja_Moveis.git
   cd Loja_Moveis
   ```

2. **Atualize a connection string**
   - Abra `appsettings.json` e defina sua instância SQL Server:
     ```json
     "ConnectionStrings": {
       "DefaultConnection": "Server=SEU_SERVIDOR;Database=LojasMoveisDb;Trusted_Connection=True;MultipleActiveResultSets=true"
     }
     ```

3. **Crie o banco de dados e aplique migrações**
   - No **Package Manager Console** do VS2022:
     ```powershell
     Update-Database
     ```

4. **Configure o diretório de imagens**
   - Em `appsettings.json`, ajuste:
     ```json
     "ConfigurationPastaImagens": {
       "PastaImagensProdutos": "wwwroot/imagens"
     }
     ```
   - Crie a pasta `wwwroot/imagens` se não existir.

5. **Execute a aplicação**
   - Defina `LojasMoveis` como projeto de inicialização.
   
---

## 👥 Contas para Testes
- **Administrador**
  - Email: `admin@lojasmoveis.com`
  - Senha: `Senha@123`
- **Usuário comum**
  - Email: `user@lojasmoveis.com`
  - Senha: `Senha@123`

> **Importante**: altere credenciais padrão em ambiente de produção.

---

## 📂 Estrutura do Repositório
```
/Areas/Admin        → Área administrativa (Controllers, Views, Serviços)
/Context            → DbContext e configurações do EF Core
/Models             → Classes de domínio (Entidades)
/Repositories       → Interfaces e implementações de repositório
/Services           → Lógicas de negócio (Relatórios, Gráficos)
/Controllers        → Controladores públicos (Home, Movel)
/ViewModels         → ViewModels para transferência de dados
/Views              → Razor Views
/wwwroot            → Arquivos estáticos (CSS, JS, imagens)
/TagHelpers         → TagHelpers personalizados
/Components         → Componentes reutilizáveis
/Migrations         → Migrações do banco de dados
```

## 🖋 Desenvolvido por
**Geraldo Luiz**  
GitHub: https://github.com/Geeh17  
Portfólio: https://portfolio-geeh.netlify.app/
