```mermaid
---
title: AnimalKingdom
---
    classDiagram
        Animal <|-- Dog
        Animal <|-- Cat
        Animal <|-- Bat
        Animal <|-- Bee
        ICanFly <|.. Bat
        ICanFly <|.. Bee
        IMammal <|.. Dog
        IMammal <|.. Cat
        IMammal <|.. Bat

        class Animal
        class Dog
        class Cat
        class Bat
        class Bee
        class IMammal
        <<interface>> IMammal
        class ICanFly
        <<interface>> ICanFly
```
