
# UML: A diagram is worth a thousand words

How to generate a diagram:

## Step 1

Ctrl+Shift+P
type class = > C# to PLantUML :Class-diagram

## Step 2

Ctrl+Shift+P
type: PlantUML: Export   -> choose png

# Class Relationships

![Diagrams UML](images/UmlRelations.png?raw=true "UML Class Diagram")

## Association

Association is reference based relationship between two classes. In this project a class 'Math Class' holds a class level reference to class 'Student'. Association can be represented by a line between these classes with an arrow indicating the navigation direction. In case arrow is on the both sides, association has bidirectional navigation.

## Dependency

Dependency is created when you receive a reference to a class as part of a particular operation or a particular method. It indicates that you may invoke one of the APIs of the received class reference and any modification to that class may break your class as well. Dependency is represented by a **dashed arrow** starting from the dependent class to its dependency.

## Aggregation

Aggregation is a subsets of association meaning it is a specific case of association. An object of one class "owns" object of another class. But there is a subtle difference, because Aggregation implies a relationship where the child can exist independently of the parent. Example: Person (parent) and Address (child). Delete the Person and the Address still exist.
It is  indicated by line connecting two classes with addition of a empty diamond at end of the class who owns the creational responsibility.

If inheritance gives us **'is-a'** and composition gives us **'part-of'**, we could argue that aggregation gives us a **'has-a' **relationship.
Therefore **Aggregation** gives us an** 'has-a'** relationship.

## Composition

Composition is a subsets of association meaning it is a specific case of association, a strong coupled one.
Composition implies a relationship where the child cannot exist independent of the parent. Example: Car (parent) and Engine  (child). Engine don't exist separate to a Car.
Composition is usually indicated by line connecting two classes with addition of a solid diamond at end of the class who owns the creational responsibility.

 **Composition** gives us an **'part-of '** relationship.

## Generalisation (Inheritance)

Generalization is the term that we use to denote abstraction of common properties into a base class in UML. The UML diagram's Generalization association is also known as Inheritance.

Generalization is  indicated by line connecting two classes with addition of a solid arrow at end of the class who is the parent.

**Inheritance** gives us an** 'is-a'** relationship.
# Commands

- dotnet add package PlantUml.net
- dotnet run
- dotnet build
  
# Reference

- <https://github.com/pierre3/PlantUmlClassDiagramGenerator>
- [How to generate diagram from C#](https://betterprogramming.pub/generating-class-diagrams-for-net-core-c4913db9398b)
- UML definition: <https://www.visual-paradigm.com/guide/uml-unified-modeling-language/uml-class-diagram-tutorial/>
- <https://www.plantuml.com/>
- <https://www.planttext.com/>
- <https://paulrumyancev.medium.com/uml-class-diagram-arrows-guide-37e4b1bb11e>
  