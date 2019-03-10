# Factory Method

## Applicability

Use the Factory Method pattern when:

* A class can't anticipate the class of objects it must create.
* A class wants its subclasses to specify the objects it creates.
* Classes delegate responsibility to one of several helper subclasses, and you want to localize the knowledge of which helper subclasses in the delegate.

## Consequences

* Provides hooks for subclasses. Creating objects inside a class with a factory method is always more flexible than creating an object directly. Factory Method gives subclasses a hook for providing an extended version of an object.
* Connects parallel class hierarchies.
* Clients might have to subclass the Creator class just to create a particular Concrete object. Subclassing is fine when the client has to subclass the Creator class anyway, but otherwise the client now must deal with another point of evolution.

## Diagram

![factory](https://www.dofactory.com/images/diagrams/net/factory.gif)