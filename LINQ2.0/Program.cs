
//right click file, properties, copy to output dir, copy if newer
var fileContent = await File.ReadAllTextAsync("data.json");
var cars = System.Text.Json.JsonSerializer.Deserialize<List<CarData>>(fileContent);



//Print Make and Model for all Makes that start with T
cars
    .Where(order => order.Make.StartsWith("T"))
    .Select(order => $"{order.Make} {order.Model}")
    .ToList()
    .ForEach(order => Console.WriteLine(order));//cant assign to variable, returns void


//Display list of 2 items with highest price
cars
    .OrderByDescending(car => car.HP)
    .Take(10)
    .Select(car => $"{car.Make} {car.Model}")
    .ToList()
    .ForEach(order => Console.WriteLine(order));//cant assign to variable, returns void


//Grouping means go through distinct column. Uses group key value. Key is the make since GroupBy says so.
cars
    .Where(car => car.Year > 1995) 
    .GroupBy(car => car.Make)
    //The output of GroupBy is a collection (IEnumerable<T>) of IGrouping<int, AO>
    //Each IGrouping<int, AO> contains a Key property, which, in this case, is the Make ,
    //and an IEnumerable<AO>, containing all the AO objects that have a Make property the same as the Key
    .Select(c => new { c.Key, NumberOfModels = c.Count() })
    //The.Select then takes that result and transforms it into a new AO containing the same Key,
    //but now instead of all the objects in the IEnumerable<AO>, it takes a .Count() of them and stores that as the NumberOfModels property
    //So that then gives you an IEnumerable<newAO>
    .ToList()
    .ForEach(item => Console.WriteLine($"{item.Key}: {item.NumberOfModels}"));


cars
    .Where(car => car.Year > 1995)
    .GroupBy(car => car.Make)
    .Select(c => new { c.Key, NumberOfModels = c.Count() })
    .ToList()
    .ForEach(item => Console.WriteLine($"{item.Key}: {item.NumberOfModels}"));



//For debugging
var groupedCars = cars.GroupBy(car => car.Make);
var selectedCars = groupedCars.Select(c => new { c.Key, NumberOfModels = c.Count() });
selectedCars.ToList()
    .ForEach(item => Console.WriteLine($"{item.Key}: {item.NumberOfModels}"));

class CarData
{
    public int Id { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int NumberOfdoors { get; set; }
    public int HP { get; set; }

}
