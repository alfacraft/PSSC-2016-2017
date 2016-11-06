using System;
 using System.Collections.Generic;
 using System.Collections.ObjectModel;
 using System.Diagnostics.Contracts;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;
 using Models.Generics.Exceptions;
 
 namespace Models.Subject
 {
     class SubjectFactory
     {
         public static readonly SubjectFactory Instance = new SubjectFactory();
 
         private SubjectFactory()
         {
 
         }
 
         public Subject SubjectCreate(string nume)
         {
             Contract.Requires<ArgumentNullException>(nume != null, "text");
             Contract.Requires<InvalidValueException>(nume.Length >= 2 && nume.Length <= 20);
             var subject = new Subject();                                     
             return subject;
         }
     }
 }