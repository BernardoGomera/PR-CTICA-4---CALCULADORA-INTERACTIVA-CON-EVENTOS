# PR-CTICA-4---CALCULADORA-INTERACTIVA-CON-EVENTOS

Proyecto .NET MAUI para la práctica 4: calculadora interactiva con eventos.

## Contenido

- `MainPage.xaml`: interfaz con Grid, botones y display.
- `MainPage.xaml.cs`: lógica de eventos para números, operadores, `=`, limpiar y historial opcional.
- `MauiProgram.cs`: configuración básica de MAUI.
- `App.xaml` y `App.xaml.cs`: arranque de la aplicación.

## Nota

El proyecto usa el namespace `Practica4_Calculadora_Interactiva`. Si necesitas ajustarlo al nombre exacto de tu proyecto en Visual Studio, cambia también el atributo `x:Class` en XAML y el namespace en los archivos C#.

## Lógica incluida

- Eventos compartidos para números, operadores, `=` y limpiar.
- Cálculo de `+`, `-`, `×` y `÷`.
- Validación de división por cero.
- Historial opcional de las últimas 3 operaciones.