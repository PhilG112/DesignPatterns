# Singleton

## Applicability

Use the Singleton pattern when:

* There must be exactly one instance of a class, and it must be accessible to clients from a well-known access points.
* When the sole instance should be extensible by subclassing, and clients should be able to use an extended instance without modifying their code.

## Consequences

* Controlled access to sole instance.
* Reduced name space, avoids polluting the global namespace.
* Permits refinement of operations and representation.
* Permits a variable number of instances.
* More flexible than class operations.

## Diagram

![singleton](https://www.dofactory.com/images/diagrams/net/singleton.gif)