using System;
using Workshop.Data;
using Workshop.Models;

using workshopContext context = new workshopContext();
foreach(Client c in context.Clients)
{
    Console.WriteLine($"Name: {c.FirstLast}");
}