# Prototype

## Applicability

Use the Prototype pattern when:

* When the classes to instantiate are specified at run-time, for example, by dynamic loading; or
* To avoid building a class hierarchy of factories that parallels the class hierarchy or products; or
* When instances of a class can have one of only a few different combinations of state. It may be more convenient to install a corresponding number of prototypes and clone them rather than instantiating the class manually, each time with the appropriate state. 

## Consequences

* Adding and removing products at run-time.
* Specifying new objects by varying values.
* Specifying new objects by varying structure.
* Reduced subclassing
* Configuring an application with classes dynamically.

## Diagram

![singleton](https://www.dofactory.com/images/diagrams/net/prototype.gif)