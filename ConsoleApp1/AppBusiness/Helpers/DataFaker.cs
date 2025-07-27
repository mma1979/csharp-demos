using AppBusiness.Parents;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBusiness.Helpers;

public static class DataFaker
{
    public static List<Parents.Parent> GenerateParents(int count)
    {
        var parents = new List<Parents.Parent>();
        for (int i = 0; i < count; i++)
        {
            var parent = new Parents.Parent
            {
                Id = i + 1,
                Name = $"Parent {i + 1}",
                Email = $"parent{i + 1}@gmail.com",
                PhoneNumber = $"123-456-789{i % 10}",
            };

            parents.Add(parent);

        }
        return parents;
    }

    public static List<Parents.Child> GenerateChildren(int count)
    {
        var children = new List<Parents.Child>();
        for (int i = 0; i < count; i++)
        {
            var child = new Parents.Child
            {
                Id = i + 1,
                Name = $"Child {i + 1} of Parent{ i +1 }",
                Age = i + 5,
                Grade = $"Grade {i % 12 + 1}",
                ParentId = (i % 5) + 1

            };
            children.Add(child);
        }
        return children;
    }

    public static List<Parents.Parent> GenerateParentsWithChildren(int parentCount, int childrenPerParent)
    {
        var parents = GenerateParents(parentCount);
        var children = GenerateChildren(parentCount * childrenPerParent);
        for (int i = 0; i < parents.Count; i++)
        {
            parents[i].Children = children.Where(c => c.ParentId == parents[i].Id).ToList();
        }
        return parents;
    }
}
