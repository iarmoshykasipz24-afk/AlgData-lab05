using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var students = new List<Student>
{
    new("Ткаченко", "ІПЗ-3/1", 85, 2024),
    new("Бондар", "ІПЗ-3/2", 92, 2023),
    new("Іваненко", "ІПЗ-3/1", 85, 2024),
    new("Коваль", "ІПЗ-3/2", 78, 2024),
    new("Сидоренко", "ІПЗ-3/1", 85, 2023),
    new("Мельник", "ІПЗ-3/2", 92, 2024),
    new("Гриценко", "ІПЗ-3/1", 78, 2023),
    new("Дяченко", "ІПЗ-3/2", 85, 2023)
};

var uk = StringComparer.Create(new CultureInfo("uk-UA"), false);

void printAll(string title, IEnumerable<Student> items)
{
    Console.WriteLine(title);
    foreach (var s in items)
        Console.WriteLine($"{s.Surname}, {s.Group}, {s.Grade}, {s.Year}");
    Console.WriteLine();
}

printAll("Original", students);

printAll("1. By surname", students.OrderBy(s => s.Surname, uk));
printAll("2. By grade, descending", students.OrderByDescending(s => s.Grade));
printAll("3. By group, then by grade descending", students.OrderBy(s => s.Group, uk).ThenByDescending(s => s.Grade));

record Student(string Surname, string Group, int Grade, int Year);