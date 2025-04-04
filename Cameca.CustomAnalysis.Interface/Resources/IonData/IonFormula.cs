﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cameca.CustomAnalysis.Interface;

public sealed class IonFormula : IReadOnlyDictionary<string, int>, IEquatable<IonFormula>
{
	public static readonly IonFormula Unknown = new IonFormula(Enumerable.Empty<Component>());

	private readonly Dictionary<string, int> _components;

	public record Component(string Name, int Count);

	public IonFormula(IEnumerable<Component> components)
	{
		// Initialize backing components dictionary
		_components = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
		foreach (var component in components)
		{
			_components.Add(component.Name, component.Count);
		}
	}

	public IEnumerator<KeyValuePair<string, int>> GetEnumerator() => _components.GetEnumerator();

	IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

	public int Count => _components.Count;

	public bool ContainsKey(string key) => _components.ContainsKey(key);

	public bool TryGetValue(string key, out int value) => _components.TryGetValue(key, out value);

	public int this[string key] => _components[key];

	public IEnumerable<string> Keys => _components.Keys;

	public IEnumerable<int> Values => _components.Values;

	public bool Equals(IonFormula? other)
	{
		if (ReferenceEquals(null, other))
		{
			return false;
		}

		if (ReferenceEquals(this, other))
		{
			return true;
		}

		if (this.Count != other.Count) return false;

		foreach (var (name, count) in _components)
		{
			if (!other.TryGetValue(name, out int otherCount) || count != otherCount)
				return false;
		}

		// this and other are not null, have equal counts, and all components are present and match
		// this is therefore equal to other
		return true;
	}

	public override bool Equals(object? obj)
	{
		return ReferenceEquals(this, obj) || obj is IonFormula other && Equals(other);
	}

	public override int GetHashCode()
	{
		HashCode hash = new HashCode();
		foreach (var (name, count) in _components.OrderBy(c => c.Key))
		{
			hash.Add(name);
			hash.Add(count);
		}
		return hash.ToHashCode();
	}

	public static bool operator ==(IonFormula? left, IonFormula? right)
	{
		return EqualityComparer<IonFormula>.Default.Equals(left, right);
	}

	public static bool operator !=(IonFormula? left, IonFormula? right)
	{
		return !EqualityComparer<IonFormula>.Default.Equals(left, right);
	}

	private const string CarbonSymbol = "C";
	private const string HydrogenSymbol = "H";

	public override string ToString()
	{
		var sb = new StringBuilder();
		// If carbon, then carbon first, then hydrogen, then all other alphabetically
		if (this.Select(c => c.Key).Contains(CarbonSymbol))
		{
			var carbonComponent = this.First(c => c.Key == CarbonSymbol);
			AddComponent(sb, carbonComponent.Key, carbonComponent.Value);
			if (TryGetValue(HydrogenSymbol, out int hCount))
			{
				AddComponent(sb, HydrogenSymbol, hCount);
			}
			foreach (var (name, count) in this.OrderBy(c => c.Key))
			{
				if (name != CarbonSymbol && name != HydrogenSymbol)
				{
					AddComponent(sb, name, count);
				}
			}
		}
		// If no carbon, then all alphabetically, including hydrogen
		else
		{
			foreach (var (name, count) in this.OrderBy(c => c.Key))
			{
				AddComponent(sb, name, count);
			}
		}
		return sb.ToString();

		static void AddComponent(StringBuilder sb, string name, int count)
		{
			sb.Append(name);
			if (count > 1)
			{
				sb.Append(count);
			}
		}
	}
}
