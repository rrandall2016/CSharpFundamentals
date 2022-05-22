
var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
var names = new[] { "Tim", "Todd", "Randy" };

var orders = new[]
{
    new{Product = 1, Price = 10, Name = "Tim"},
    new{Product = 2, Price = 15, Name = "Todd" },
    new{Product = 3, Price = 20, Name = "Randy"}
};
var cars = new[]
{
    new{Make = 1, Price = 10, Name = "a"},
    new{Make = 1, Price = 15, Name = "b" },
    new{Make = 2, Price = 20, Name = "c"},
    new{Make = 2, Price = 20, Name = "d"},
    new{Make = 2, Price = 20, Name = "e"}
};

//Example using method, now you can use Where with LINQ instead
var result = Filter(numbers, number => number % 2 == 0);
var result3 = Filter(names, name => name.StartsWith("T"));

//Filter the collection with WHERE or other LINQ methods
var result4 = numbers.Where(number => number % 2 == 0);
var result5 = numbers.Select(number => number * 2);
var result6 = numbers.FirstOrDefault(number => number > 2);//Give me first number above 2 or default number
var result7 = numbers.Single(number => number == 2);//Give me single item
var result8 = orders.Sum(item => item.Price);
var result9 = numbers.OrderByDescending(n => n);

foreach (var item in result)
{
    Console.WriteLine(item);
}

//Where replaces this in LINQ. Func is input and return type
static IEnumerable<T> Filter<T>(IEnumerable<T> numbers, Func<T, bool> predicate)
{
    foreach (var number in numbers)
    {
        if (predicate(number))
        {
            yield return number;
        }
    }
}