
string[] fruitbasket = { "apples", "bananas", "oranges"};

Console.WriteLine($"There are {fruitbasket.Length} fruitbasket in your basket.");

for (int i = 0; i < fruitbasket.Length; i++)
{
    Console.WriteLine(fruitbasket[i]);
}


//Console.WriteLine(fruitbasket[0]);
//Console.WriteLine(fruitbasket[1]);
//Console.WriteLine(fruitbasket[2]);

fruitbasket[0] = "pine-apple";
fruitbasket[2] = "peaches";

//Console.WriteLine(fruitbasket[0]);
//Console.WriteLine(fruitbasket[1]);
//Console.WriteLine(fruitbasket[2]);

for (int i=0; i <fruitbasket.Length; i++)
{
    Console.WriteLine(fruitbasket[i]);
}

