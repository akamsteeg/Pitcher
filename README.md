# Pitcher

Pitcher is a utility library to simplify throwing exceptions, especially when checking arguments. It makes methods easier to inline, by reducing code size.


[![Build Status](https://interastra.visualstudio.com/OSS%20-%20CI/_apis/build/status/Pitcher%20CI?branchName=master)](https://dev.azure.com/interastra/OSS%20-%20CI/_build?definitionId=14&_a=summary&branchName=master) [![Azure DevOps coverage](https://img.shields.io/azure-devops/coverage/interastra/OSS%20-%20CI/14.svg?cacheSeconds=3600)](https://dev.azure.com/interastra/OSS%20-%20CI/_build?definitionId=14&_a=summary) 

## Platform support

| .NET Framework     |     .NET Core      |
|:------------------:|:------------------:|
| :heavy_check_mark: | :heavy_check_mark: |

## Installation

The Pitcher NuGet package is the prefered way to install and use it.

[![NuGet](https://img.shields.io/nuget/v/Pitcher.svg?cacheSeconds=3600)](https://www.nuget.org/packages/Pitcher/)

```powershell
install-package Pitcher
```

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

Throw an exception based on a condition, with a `Func<T>` to create the exception in a more complex way:

```csharp
Throw.When(args == null, () => new ArgumentNullException(nameof(args));
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

// Throw ArgumentNullException for a null or empty string
Throw.ArgumentNull.WhenNullOrEmpty(args, nameof(args));

// Throw ArgumentNullException with a message for a null or empty string
Throw.ArgumentNull.WhenNullOrEmpty(args, nameof(args), "Args is a required parameter");

// Throw ArgumentNullException for a null, empty or whitespace string
Throw.ArgumentNull.WhenNullOrWhitespace(args, nameof(args));

// Throw ArgumentNullException with a message for a null, empty or whitespace string
Throw.ArgumentNull.WhenNullOrWhitespace(args, nameof(args), "Args is a required parameter");

// Throw ArgumentNullException for a null or empty IEnumerable<T>
Throw.ArgumentNull.WhenNullOrEmpty(new List<string>(), nameof(args));

// Throw ArgumentNullException with a message for a null or empty IEnumerable<T>
Throw.ArgumentNull.WhenNullOrEmpty(new List<string>(), nameof(args), "Args is a required parameter");
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
