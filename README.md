# ArrayCompressor

[![.NET](https://img.shields.io/badge/.NET-10.0-blueviolet)](https://dotnet.microsoft.com/)
[![xUnit](https://img.shields.io/badge/xUnit-v3.2.2-green)](https://xunit.net/)

## Описание

Минималистичная библиотека на C# для удаления **подряд идущих дубликатов** из массива чисел.

### Примеры работы

| Входной массив          | Результат      |
|-------------------------|----------------|
| [1, 1, 2, 2, 3]         | [1, 2, 3]      |
| [0, 0, 1, 1, 0]         | [0, 1, 0]      |
| [5, 5, 5]               | [5]            |
| [-5, 5, 2, -1]          | [-5, 5, 2, -1] |
| [] или `null`           | []             |

## Структура проекта

- **ArrayCompressor** – консольное приложение, содержащее:
  - `Program.CompressArray(int[] input)` – основная функция сжатия.
  - `Program.ProcessingInput(string input)` – парсер ввода из строки.
- **ArrayCompressor.Test** – модульные тесты (xUnit):
  - 100% покрытие исполняемого кода (исключая `Main`).

## Сборка и запуск

### Требования
- [.NET 10 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/10.0)  

### Инструкция

1. Клонируйте репозиторий:
   ```bash
   git clone https://github.com/RaySiGZ/ArrayCompressor.git
   cd ArrayCompressor
