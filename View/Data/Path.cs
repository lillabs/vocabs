using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace View.Data;

public class Path : ICollection<PathSegment>
{
    private List<PathSegment> _pathSegments = new List<PathSegment>();
    private readonly string _url;
    private string _preLink = "";

    public Path(string url, string preLink = "/")
    {
        _url = url;
        _preLink = preLink;
        GeneratePathSegments();
    }

    public PathSegment this[int index]
    {
        get => _pathSegments[index];
        set => _pathSegments[index] = value;
    }

    private void GeneratePathSegments()
    {
        var urlSegments = _url.Split("/");
        foreach (var segment in urlSegments)
        {
            _preLink += segment + "/";
            _pathSegments.Add(new PathSegment(name: segment, link: _preLink));
        }
    }

    public IEnumerator<PathSegment> GetEnumerator()
    {
        return _pathSegments.GetEnumerator();
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("/");
        foreach (var segment in _pathSegments)
        {
            sb.Append(segment.Name + "/");
        }
        return sb.ToString();
    }

    public string ToBeautifulString()
    {
        var sb = new StringBuilder();
        sb.Append(" /");
        foreach (var segment in _pathSegments)
        {
            sb.Append(" " + segment.Name + " /");
        }
        return sb.ToString();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(PathSegment item)
    {
        _pathSegments.Add(item);
    }

    public void Clear()
    {
        _pathSegments.Clear();
    }

    public bool Contains(PathSegment item)
    {
        return _pathSegments.Contains(item);
    }

    public void CopyTo(PathSegment[] array, int arrayIndex)
    {
        _pathSegments.CopyTo(array, arrayIndex);
    }

    public bool Remove(PathSegment item)
    {
        return _pathSegments.Remove(item);
    }

    public int Count => _pathSegments.Count;
    public bool IsReadOnly => false;
}

public struct PathSegment
{
    public readonly string Name;
    public readonly string Link;

    public PathSegment(string name, string link)
    {
        Name = name;
        Link = link;
    }
}

