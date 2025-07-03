# 🚗 Desafio Estacionamento DIO

Este projeto é uma aplicação de console em C# desenvolvida como parte de um desafio da **Digital Innovation One (DIO)**. Ele simula um sistema de controle de estacionamento de veículos, permitindo adicionar, remover e listar placas.

---

## 📁 Estrutura do Projeto

```
DesafioEstacionamentoDIO/
│
├── Models/
│   └── Estacionamento.cs        # Classe principal com a lógica de negócio
│
├── Program.cs                   # Entrada principal da aplicação
├── DesafioEstacionamentoDIO.csproj  # Arquivo de projeto do .NET
```

---

## 🚀 Funcionalidades

- ✅ Adicionar veículo (placa)
- ✅ Remover veículo e calcular valor a pagar
- ✅ Listar veículos estacionados

---

## 🧠 Lógica de Remoção

- O usuário digita a **placa do veículo** e a **quantidade de horas** estacionado.
- O sistema verifica se a placa está presente.
- Calcula o valor total:  
  `valorTotal = precoInicial + precoPorHora * horas`
- Remove o veículo da lista.

---

## 🧪 Exemplo de Uso

```plaintext
Digite a opção desejada:
1 - Cadastrar veículo
2 - Remover veículo
3 - Listar veículos
4 - Encerrar
```

---

## 💻 Como Executar

1. Certifique-se de ter o [.NET SDK](https://dotnet.microsoft.com/download) instalado.
2. Clone o repositório ou copie os arquivos.
3. No terminal, execute:

```bash
dotnet build
dotnet run
```

---

## 🛠 Tecnologias Utilizadas

- C# 10
- .NET 6 ou superior
- Console Application

---

## 📌 Observações

- As placas não são validadas por formato.
- A comparação é feita sem diferenciar maiúsculas e minúsculas (`ToUpper()`).
- O sistema usa `List<string>` para armazenar os veículos temporariamente (sem persistência em arquivo ou banco).

---

## ✍️ Autor

Projeto baseado no desafio prático da DIO, com personalizações próprias para fins de aprendizado.

---
