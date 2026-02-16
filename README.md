# 📘 LoginApp - .NET MAUI

## 📖 Descrição
O **LoginApp** é um projeto de estudo desenvolvido em **.NET MAUI**, com foco em:
- Criação de uma tela de login simples e funcional.  
- Navegação entre páginas (login → boas-vindas → lista de usuários).  
- Aplicação de estilos globais para um visual mais profissional.  
- Adaptação ao tema claro/escuro do Android.  
- Geração de APK para testes em dispositivos reais.

---

## 🛠️ Tecnologias utilizadas
- [.NET MAUI](https://learn.microsoft.com/dotnet/maui)  
- C#  
- XAML  
- MVVM (Model-View-ViewModel)  
- Git/GitHub para versionamento  

---

## 📂 Estrutura do projeto

LoginApp/ <br>
├── Views/        → Páginas XAML (LoginPage, WelcomePage, UserListPage) <br>
├── ViewModels/   → Lógica das telas (LoginViewModel, UserListViewModel) <br> 
├── Models/       → Estruturas de dados (Usuario.cs) <br>
├── Services/     → Regras de negócio (AuthService.cs) <br>
├── App.xaml      → Estilos globais e recursos <br>
├── App.xaml.cs   → Configuração inicial do ap


---

## 🚀 Passo a passo para rodar

### 1. Clonar o repositório
```bash
git clone https://github.com/seuusuario/LoginApp.git
cd LoginApp
```

### 2. Restaurar workloads MAUI
```bash
dotnet workload restore
```

### 3. Executar no emulador Android
- Abra o Android Device Manager no Visual Studio.
- Crie um emulador (ex.: Pixel 7 API 35).
- Selecione o emulador como destino e clique em Executar ▶️.

### 4. Executar em dispositivo físico
- Ative Depuração USB no celular.
- Conecte via cabo USB.
- Selecione o dispositivo físico no Visual Studio e execute.

---

## 📦 Gerar APK para instalação manual

Para compilar em modo Release e gerar o APK:
```bash
dotnet publish -f net9.0-android -c Release
```

O arquivo será gerado em:
```bash
bin/Release/net9.0-android/publish/
```

👉 Copie para o celular e instale manualmente

## 🎨 Estilos globais (App.xaml)

Exemplo de configuração para manter o visual consistente e adaptado ao tema claro/escuro:

```xml
<Style TargetType="Entry">
    <Setter Property="BackgroundColor" Value="{AppThemeBinding Light=White, Dark=#1E1E1E}" />
    <Setter Property="TextColor" Value="{AppThemeBinding Light=Black, Dark=White}" />
    <Setter Property="PlaceholderColor" Value="{AppThemeBinding Light=Gray, Dark=LightGray}" />
</Style>

<Style TargetType="Button">
    <Setter Property="BackgroundColor" Value="#007ACC" />
    <Setter Property="TextColor" Value="White" />
    <Setter Property="CornerRadius" Value="8" />
    <Setter Property="HeightRequest" Value="50" />
    <Setter Property="FontAttributes" Value="Bold" />
</Style>
```

## 📑 Funcionalidades
- Login com validação simples (usuário/senha).
- Navegação entre páginas com `NavigationPage.`
- Tela de boas-vindas após login.
- Página de lista de usuários com CollectionView.
- Suporte a tema claro/escuro com `AppThemeBinding.`

## 📌 Próximos passos
- Implementar autenticação real via API.
- Adicionar persistência de dados (SQLite ou API REST).
- Melhorar design com ícones e animações.
- Publicar na Play Store (AAB).


