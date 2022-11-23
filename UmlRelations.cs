// // Uncomment this to generate diagrams correctly


// using System;
// using System.Collections.Generic;
// using Aggregation;
// using Association;
// using Composition;
// using Dependency;

// namespace Relations
// {

//     public class Car
//     {
//         [PlantUmlAssociation(Name = "Engine", Association = "*-->", LeafLabel = "engine", Label = "Composition", RootLabel = "Engine part of")]
//         public Engine engine = new Engine();

//         [PlantUmlAssociation(Name = "Wheel", Association = "*-->", LeafLabel = "wheel", Label = "Composition", RootLabel = "Wheel part of")]
//         public Wheel leftWheel = new Wheel();
//     }

//     public class Person
//     {
//         [PlantUmlAssociation(Name = "Address", Association = "o--", LeafLabel = "0..*", Label = "Aggregation")]
//         public IList<Address> Addresses { get; set; }
//     }

//     public class Picture
//     {
//         [PlantUmlAssociation(Name = "Pencil", Association = "..>", LeafLabel = "1", Label = "Dependency", RootLabel = "depends on Pencil")]
//         public Pencil pencil;
//     }

//     public class MathClass
//     {
//         [PlantUmlAssociation(Name = "Student", Association = "-->", LeafLabel = "1", Label = "Association" RootLabel = "associated with")]
//         public Student student;
//     }

//     public class Three
//     {
//         [PlantUmlAssociation(Name = "Nest", Association = "+--", LeafLabel = "one nest", Label = "Nesting")]
//         public Nest _nesting;

//         public class Nest
//         {

//         }

//     }

//     public class Cat : Mammal
//     {

//     }
//     public class Dog : Mammal
//     {

//     }
//     public abstract class Mammal
//     {

//     }

// }