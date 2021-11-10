![query-analysis](https://user-images.githubusercontent.com/8418700/140911412-9fee2581-b96c-4e7b-ba99-a0127321a335.png)

```cs
var query = new List<DynamicModel>();

query.Add(new DynamicFilter()
{
     ComparisonMethod = ComparisonMethod.DoesNotContain,
     PropertyValue = "s",
     PropertyName = "FamilyName"
});
query.Add(new DynamicFilter()
{
     ComparisonMethod = ComparisonMethod.Contains,
     PropertyValue = "a",
     PropertyName = "Name"
});

var users = _dbContext.Users.DynamicWhere(query).ToList();
```

It supports these comparison methods:

```
LessThan,
LessThanEqual,
GreaterThan,
GreaterThanEqual,
Equal,
NotEqual,
IsNullOrEmpty,
IsNotNullOrEmpty,
Contains,
DoesNotContain,
StartsWith,
DoesNotStartWith,
EndsWith,
DoesNotEndWith,
Like,
NotLike
```

<hr/>
<div>Icons made by <a href="https://www.flaticon.com/authors/flat-icons" title="Flat Icons">Flat Icons</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a></div>
