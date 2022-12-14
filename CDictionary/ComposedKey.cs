using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

public class ComposedKey
{
    public string KeyA { get; }
    public string KeyB { get; }

    public ComposedKey(string keyA, string keyB)
    {
        this.KeyA = keyA;
        this.KeyB = keyB;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(this.KeyA, this.KeyB);
    }

    public override bool Equals(object? other)
    {
        return Equals(other as ComposedKey);
    }

    public bool Equals(ComposedKey? other)
    {
        return other != null
            && String.Equals(this.KeyA, other.KeyA)
            && String.Equals(this.KeyB, other.KeyB);
    }

    public override string ToString()
    {
        return $"({this.KeyA} {this.KeyB})";
    }
}