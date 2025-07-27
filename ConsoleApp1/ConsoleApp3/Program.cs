using AppBusiness.Helpers;

using System.Collections.Generic;

var parents = DataFaker.GenerateParents(5);
var children = DataFaker.GenerateChildren(10);

var data = parents.Join(
    children,
    parents => parents.Id,
    child => child.ParentId,
    (parent, child) =>
    {
        return new
        {
            ParentId = parent.Id,
            ParentName = parent.Name,
            ChildName = child.Name

        };
    }).ToList();

var data2 = (
    from p in parents
    join c in children on p.Id equals c.ParentId
    select new
    {
        ParentId = p.Id,
        ParentName = p.Name,
        ChildName = c.Name
    }
    ).ToList();

foreach (var item in data)
{
        Console.WriteLine($"Parent: {item.ParentName}, Child: {item.ChildName}");
}

var parentsWithChildren = DataFaker.GenerateParentsWithChildren(5, 2);

var childrenData = parentsWithChildren.Select(e=>e.Children).ToList();

foreach(var list in childrenData)
{
    foreach(var child in list)
    {
        Console.WriteLine($"Parent: {list.First().Parent?.Name}, Child: {child.Name}");
    }
}

var allChildren = parentsWithChildren.SelectMany(e => e.Children).ToList();

foreach (var child in allChildren)
{
    Console.WriteLine($"Parent: {allChildren.First().Parent?.Name}, Child: {child.Name}");
}

var gradeGroups = allChildren.GroupBy(c => c.Grade).ToList();

foreach (var group in gradeGroups)
{
    Console.WriteLine($"Grade: {group.Key}");
    foreach (var child in group)
    {
        Console.WriteLine($"  Child: {child.Name}");
    }
}