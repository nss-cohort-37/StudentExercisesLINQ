using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var cohort35 = new Cohort()
            {
                Name = "C35"
            };
            var cohort37 = new Cohort()
            {
                Name = "C37"
            };
            var students = new List<Student>();
            students.Add(new Student
            {
                Cohort = cohort35,
                    FirstName = "Brenda",
                    LastName = "Long",
                    Exercises = new List<Exercise>()
                    {
                        new Exercise()
                            {
                                Name = "LINQ",
                                    Language = "C#"
                            },
                            new Exercise()
                            {
                                Name = "Kennel",
                                    Language = "JS"
                            }
                    }

            });
            students.Add(new Student
            {
                Cohort = cohort37,
                    FirstName = "Adam",
                    LastName = "Sheafer",
                    Exercises = new List<Exercise>()
                    {
                        new Exercise()
                        {
                            Name = "Kennel",
                                Language = "JS"
                        }
                    }
            });
            students.Add(new Student
            {
                Cohort = cohort35,
                    FirstName = "Rose",
                    LastName = "Wiz"
            });

            var exercises = new List<Exercise>
            {
                new Exercise
                {
                Language = "C#",
                Name = "LINQ"
                },
                new Exercise
                {
                Language = "JS",
                Name = "Kennel"
                },
                new Exercise
                {
                Language = "JS",
                Name = "Nutshell"
                },
            };

            var allJsExercise = exercises.Where(exercise =>
            {
                return exercise.Language == "JS";
            });

            foreach (var exercise in allJsExercise)
            {
                Console.WriteLine(exercise.Name);
            }

            var studentsOrderedByLastName = students.OrderByDescending(student =>
            {
                return student.LastName;
            });

            foreach (var student in studentsOrderedByLastName)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

            var studentsWithNoExercises = students.Where(student =>
            {
                int exercisesCount = student.Exercises.Count;
                return exercisesCount == 0;
            });

            Console.WriteLine("These students are not working on any exercises");

            foreach (var student in studentsWithNoExercises)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

            var studentWithMostExercises = students.OrderByDescending(student =>
            {
                return student.Exercises.Count;
            }).FirstOrDefault();

            var groups = students.GroupBy(student => student.Cohort.Name);

            foreach (var group in groups)
            {
                Console.WriteLine($"There are {group.Count()} students in {group.Key}");
            }
        }
    }
}