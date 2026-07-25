# Práctica 4 - Calculadora Interactiva con Eventos

**Asignatura:** Introducción al Desarrollo de Aplicaciones Móviles  
**Período:** 2016-C1  
**Semana:** 4  
**Instructor:** Michael Grullon  
**Nombre:** [Tu nombre completo]  
**Matrícula:** [Tu matrícula]  
**Fecha de entrega:** [Fecha]

## Portada

Título: **Práctica 4 - Calculadora Interactiva con Eventos**

## 1. Proyecto Creado

- Captura 1: Solution Explorer mostrando el proyecto creado.

## 2. Diseño de la Interfaz

- Captura 2: Código XAML del Grid con botones.
- Captura 3: Calculadora en el emulador mostrando todos los botones.

## 3. Implementación de Eventos

- Captura 4: Código C# con todos los métodos.
- Captura 5: Calculadora ejecutando una operación simple.
- Captura 6: Calculadora mostrando el resultado de una operación.

## 4. Comparación con Android

| Aspecto | Android (Java/Kotlin) | .NET MAUI (C#) |
|---|---|---|
| Listener | OnClickListener | Evento Clicked |
| Implementación | `button.setOnClickListener(...)` | `Clicked="OnButtonClicked"` |
| Sintaxis | Interface o Lambda | Método directo |
| Código | `onClick(View v)` | `OnButtonClicked(object sender, EventArgs e)` |
| Obtener texto | `((Button)v).getText()` | `((Button)sender).Text` |

### Preguntas

1. ¿Qué ventaja tiene el sistema de eventos de MAUI sobre los listeners de Android?  
   Respuesta: La sintaxis es más simple, no requiere implementar interfaces y el manejo es más directo.

2. ¿Cómo identificas qué botón se presionó en ambos sistemas?  
   Respuesta: En Android se usa `View v`; en MAUI se usa `object sender`. En ambos casos se puede castear a `Button` para leer su texto.

3. ¿Qué equivalente tiene `sender` en Android?  
   Respuesta: El parámetro `View v` del método `onClick`.

## 5. Bonus Opcional: Historial de Operaciones

- Captura Bonus 1: Código del historial implementado.
- Captura Bonus 2: Historial funcionando con 3 operaciones.

## Observaciones

- La calculadora implementa `+`, `-`, `×` y `÷`.
- La división por cero muestra `Error`.
- El historial conserva las últimas 3 operaciones.
