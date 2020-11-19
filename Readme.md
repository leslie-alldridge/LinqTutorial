#### Linq Tutorial

Linq = Language Integrated Query

Available in `System.Linq` namespace

Linq can be used with different data sources (e.g. Objects, EF Core, XML) due to its built in `Providers`. Those providers implement `IQueryProvider` and `IQueryable` interfaces for the datasource so Linq can query it.

Linq provides compile time safety, intellisense support and comes with many built in methods.

To work with a Linq query we need the following:
- Data source
- Query (initialise, condition, selection)
- Execution

There are three ways to write a query:
- Query syntax (uses a query language similar to SQL)
- Method syntax (uses lambda expressions) - great for simple queries - combined with `.` dots
- Mixed syntax (query + method)

**IEnumerable**

It is an interface and available in `System.Collection` namespace.

All of the collections in C# implement IEnumerable. It's a type of iteration design pattern.

Thanks to this interface we can iterate using a `foreach` loop on the collection.

It can also support generic collections using `<T>`

Should be used for in memory data objects.



