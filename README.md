# Animación en Unity

El objeto elegido fue un reloj, construido completamente con figuras básicas (sin uso de assets externos).

El reloj está compuesto por:

* Un **cilindro** que representa la base
* Dos **cubos** que representan:

  * Manecilla de minutos
  * Manecilla de horas

## Animación

La animación del reloj se realiza mediante un script en C#, donde:

* El **minutero** gira a mayor velocidad
* El **horario** gira a menor velocidad

Esto simula el comportamiento de un reloj real.

## Script

Se implementó un script llamado:

RelojController.cs

Este script utiliza:

* Transform
* Rotación en tiempo real
* Time.deltaTime para lograr una animación fluida

## Cómo ejecutar

Abrir el proyecto en Unity Hub y presionar Play.
