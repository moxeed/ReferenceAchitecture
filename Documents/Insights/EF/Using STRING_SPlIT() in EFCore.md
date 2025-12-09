
Define a TableValuedFunction Method in DbContext

```csharp
public class SplitResult
{
    public string Value { get; set; }
}

 
 public IQueryable<SplitResult> Split(string input, string separator)
     => FromExpression(() => Split(input, separator));
```

Register Function in ModelBuilder

```csharp
modelBuilder
	.HasDbFunction(typeof(DbContext).GetMethod(nameof(Split)))
	.HasName("STRING_SPLIT")
	.IsBuiltIn(); //<-- To Drop [dbo] Schema In Function Call
```

Use This Function as DataSource
```csharp
var query = _context.Set<Instrument>()
    .Join(_context.Split(nscIdsJoinedString, "|"), 
    i => i.InstrumentIdentifier, c => c.Value, (i, _) => i);
```

