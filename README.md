# Pitcher

Pitcher is a utility library to simplify throwing exceptions, especially when checking arguments. It's also usable to move `throw` statements out of methods, since they block inlining.

Supported frameworks:

* .NET 4.0+
* .NET Standard 1.0+

## Installation


### Pitcher

The Pitcher NuGet package is the prefered way to install and use it.

```powershell
install-package Pitcher -pre
```

### Pitcher.Sources

For non-SDK `.csproj` projects, a .Sources package is also available. This adds a new source file, `Helpers\Throw.cs` to your project with an internal class`Throw`. This avoids introducing a dependency to your project.

```powershell
install-package Pitcher.Sources -pre
```

SDK-style projects do not support .Sources packages.

## Usage

To use Pitcher, add a using to your source file:

```csharp
using Pitcher;
```

Then, you can use `Throw` or `Throw<T>` to throw exceptions.

### Throw

Throw an exception directly:
```csharp
Throw.This(new ArgumentNullException(nameof(args));
```

Throw an exception based on a condition:
```csharp
Throw.When(args == null, new ArgumentNullException(nameof(args)); // This will always allocate the exception
```

#### ArgumentNullException

There are helpers for simplifying argument checking and throwing an `ArgumentNullException`.

```csharp
// Throw ArgumentNullException for parameter
Throw.ArgumentNull.For(nameof(args));

// Throw ArgumentNullException for parameter, with message
Throw.ArgumentNull.For(nameof(args), "Args is a required parameter");

// Throw ArgumentNullException for parameter, when a condition is met
Throw.ArgumentNull.When(args == null, nameof(args));

// Throw ArgumentNullException for parameter with a message, when a condition is met
Throw.ArgumentNull.When(args == null, nameof(args), "Args is a required parameter");

// Throw ArgumentNullException for parameter, when the parameter is null
Throw.ArgumentNull.WhenNull(args, nameof(args));

// Throw ArgumentNullException for parameter with a message, when the parameter is null
Throw.ArgumentNull.WhenNull(args, nameof(args), "Args is a required parameter");
```

#### ArgumentOutOfRangeException

Specific helpers are available for throwing an `ArgumentOutOfRangeException`.

```csharp
// Throw ArgumentOutOfRangeException for parameter
Throw.ArgumentOutOfRange.For(nameof(args));

// Throw ArgumentOutOfRangeException for parameter, with message
Throw.ArgumentOutOfRange.For(nameof(args), "Args is out of the acceptable range");

// Throw ArgumentOutOfRangeException for parameter, when a condition is met
Throw.ArgumentOutOfRange.When(args < 0, nameof(args));

// Throw ArgumentOutOfRangeException for parameter with a message, when a condition is met
Throw.ArgumentOutOfRange.When(args < 0, nameof(args), "Args is out of the acceptable range");

```

### Throw&lt;T&gt;

For exceptions without parameters or when you don't care about the parameters, you can use `Throw<T>`.

```csharp
// Throw an exception
Throw<InvalidOperationException>.Now();

//Throw an exception based on a condition
Throw<InvalidOperationException>.When(obj == null);
```

## License

Pitcher uses the MIT license, see the LICENSE file.