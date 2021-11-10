![query-analysis](https://user-images.githubusercontent.com/8418700/140911412-9fee2581-b96c-4e7b-ba99-a0127321a335.png)

### [Nuget](https://www.nuget.org/packages/MoreDynamicQuery/)

```
Install-Package MoreDynamicQuery

dotnet add package MoreDynamicQuery
```

<hr/>

### How does it work?

This library is an extension for C# `IQueryable` interface. It helps you to access a new type of extension method with `DynamicWhere` name.

`DynamicWhere` takes list of `DynamicFilter` as an argument.

```cs
// DynamicFilter

// The name of property you want to query on it.
public string PropertyName { get; set; }

// The value of property you are looking for it in query.
public object PropertyValue { get; set; }

// The filter you want to compare the property with it.        
public ComparisonFilter ComparisonFilter { get; set; }
```

It supports these comparison filters:

```
LessThan
LessThanEqual
GreaterThan
GreaterThanEqual
Equal
NotEqual
IsNullOrEmpty
IsNotNullOrEmpty
IsNullOrWhiteSpace
IsNotNullOrWhiteSpace
Contains
DoesNotContain
StartsWith
DoesNotStartWith
EndsWith
DoesNotEndWith
Like
NotLike
```

Let's see a working example

```cs
// Data source
var people = PeopleDataGenerator.GetPeople(2500);

var filters = new List<DynamicFilter>();

var df1 = new DynamicFilter()
{
    ComparisonFilter = ComparisonFilter.DoesNotContain,
    PropertyName = nameof(Person.Name),
    PropertyValue = "h"
};

var df2 = new DynamicFilter()
{
    ComparisonFilter = ComparisonFilter.Contains,
    PropertyName = nameof(Person.FamilyName),
    PropertyValue = "f"
};

filters.Add(df1);
filters.Add(df2);

// var result = people.DynamicWhere(df1, df2).ToList();
var result = people.DynamicWhere(filters).ToList();
```

![MoreDynamicQuery](https://user-images.githubusercontent.com/8418700/141125107-9409724b-9165-4cee-9ef6-3e72f6194bf0.png)

`DynamicWhere` works with different data types.

```cs
IQueryable<TModel> DynamicWhere<TModel>(this IQueryable<TModel> queryable, IEnumerable<DynamicFilter> dynamicFilters)
IQueryable<TModel> DynamicWhere<TModel>(this IEnumerable<TModel> enumerable, IEnumerable<DynamicFilter> dynamicFilters)
IQueryable<TModel> DynamicWhere<TModel>(this TModel[] array, IEnumerable<DynamicFilter> dynamicFilters)

IQueryable<TModel> DynamicWhere<TModel>(this IQueryable<TModel> queryable, params DynamicFilter[] dynamicFilters)
IQueryable<TModel> DynamicWhere<TModel>(this IEnumerable<TModel> enumerable, params DynamicFilter[] dynamicFilters)
IQueryable<TModel> DynamicWhere<TModel>(this TModel[] array, params DynamicFilter[] dynamicFilters)
```

<hr/>
<div>Icons made by <a href="https://www.flaticon.com/authors/flat-icons" title="Flat Icons">Flat Icons</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a></div>
