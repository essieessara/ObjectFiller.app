
using ObjectFiller.Models;
using System;
using System.Collections.Generic;
using Tynamix.ObjectFiller;

//Console.WriteLine("Hello, World!");

    String num = "0123456789";
    int length = 10;
    var random = new Random();
    var filler = new Filler<StudentModel>();
    filler.Setup()
        .OnProperty(x => x.StudentId).Use(Guid.NewGuid())
        .OnProperty(x => x.StudentName).Use(new RealNames(NameStyle.FirstNameLastName))
        .OnProperty(x => x.StudentAge).Use(Enumerable.Range(5, 25))
        .OnProperty(x => x.StudentEmail).Use(new EmailAddresses())
        .OnProperty(x => x.StudentPhone).Use(new string(Enumerable.Repeat(num,length)
                                    .Select(x => x[random.Next(x.Length)]).ToArray()));

    IEnumerable<StudentModel> Students = filler.Create(5);
    foreach (var Student in Students)
    {
       Console.WriteLine("Student Id: " + Student.StudentId);
       Console.WriteLine("Student Name: " + Student.StudentName);
       Console.WriteLine("Student Age: " + Student.StudentAge);
       Console.WriteLine("Student Email: "+ Student.StudentEmail);
       Console.WriteLine("Student Phone: "+"0"+ Student.StudentPhone);
       Console.ReadLine();
    }

//Console.WriteLine(Students[1]);

