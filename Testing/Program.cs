// See https://aka.ms/new-console-template for more information
using ViewModel;

Console.WriteLine("Hello, World!");
var PersonDb = new PersonsDb();
var result = PersonDb.SelectALL();
Console.WriteLine(result);