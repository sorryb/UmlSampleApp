// using System;
// using System.Collections.Generic;

// // How to customize with Attributes to generate a diagram
// namespace Composition
// {
//     public class ClassA
//     {
//         public string Name { get; set; }
//         public int Age { get; set; }
//     }
//     public class Parameters
//     {
//         public string A { get; set; }
//         public string B { get; set; }
//     }

//     public class CustomAssociationSample
//     {
//         [PlantUmlAssociation(Name = "Name", Association = "*-->", LeafLabel = "LeafLabel", Label = "Label", RootLabel = "RootLabel")]
//         public ClassA A { get; set; }
//     }

//      public class CompositionAssociationSample
//     {
//         [PlantUmlAssociation(Name = "ClassA", Association = "*-->", LeafLabel = "LeafLabel", Label = "Label", RootLabel = "RootLabel")]
//         public ClassA A = new ClassA();
//     }

//     public class CollectionItemsSample
//     {
//         [PlantUmlAssociation(Name = "Item", Association = "o--", LeafLabel = "0..*", Label = "Items")]
//         public IList<Item> Items { get; set; }
//     }

//     public class Item{/*  */
//         public int Id;
//     }
//     public class MethodParamtersSample
//     {
//         public void Run([PlantUmlAssociation(Association = "..>", Label = "use")] Parameters p)
//         {
//             Console.WriteLine($"{p.A},{p.B}");
//         }

//         private ILogger logger;
//         public void MyClass([PlantUmlAssociation(Association = "..>", Label = "Injection")] ILogger logger)
//         {
//             this.logger = logger;
//         }

//         public interface ILogger{
//             void Log();

//         }
//         public class Item
//         {

//             public int Id;
//         }
//     }
// }