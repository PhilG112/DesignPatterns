# Abstract Factory

## Applicability

Use the Abstract Factory pattern when:

* A system should be independent of how its products are created, compose, and represented.
* A system should be configured with one of multiple families of products.
* A family of related product objects is designed to be used togther, and you need to enforce this constraint.
* You want to produce a class library of products, and you want to reveal just their interfaces, not their implementations.

## Consequences

* It isolates concrete classes.
* It makes exchanging product families easy.
* It promotes consistency among products.
* Supporting new kinds of products is difficult.

## Diagram

![factory](https://www.dofactory.com/images/diagrams/net/abstract.gif)
