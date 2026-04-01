# Maple.Models

![.NET](https://img.shields.io/badge/net10.0-5C2D91?logo=.NET&labelColor=gray)
![C#](https://img.shields.io/badge/C%23-14.0-239120?labelColor=gray)
[![Build Status](https://github.com/Bia10/Maple.Models/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/Bia10/Maple.Models/actions/workflows/dotnet.yml)
[![codecov](https://codecov.io/gh/Bia10/Maple.Models/branch/main/graph/badge.svg)](https://codecov.io/gh/Bia10/Maple.Models)
[![License](https://img.shields.io/github/license/Bia10/Maple.Models)](https://github.com/Bia10/Maple.Models/blob/main/LICENSE)

MapleStory model types: immutable DTOs and catalog records, plus mutable runtime state for persistence and editors. Cross-platform, trimmable and AOT/NativeAOT compatible.

⭐ Please star this project if you like it. ⭐

[Example](#example) | [Example Catalogue](#example-catalogue) | [Public API Reference](docs/PublicApi.md)

## Packages

| Package | NuGet | Description |
| ------- | ----- | ----------- |
| **Maple.Models** | [![Nuget](https://img.shields.io/nuget/v/Maple.Models?color=purple)](https://www.nuget.org/packages/Maple.Models/) | Immutable DTOs and catalog record types: templates, server snapshots, and shared value objects |
| **Maple.Models.Runtime** | [![Nuget](https://img.shields.io/nuget/v/Maple.Models.Runtime?color=purple)](https://www.nuget.org/packages/Maple.Models.Runtime/) | Mutable runtime state: character/account snapshots, inventories, item slots, quest and skill records, and AOT-safe JSON serialization |

All packages are cross-platform, trimmable and AOT/NativeAOT compatible.

## Example

```csharp
// Create a color from a raw WZ ARGB value (e.g. from item data)
var color = ArgbColor.FromInt32(-16777216); // 0xFF000000 = opaque black
Console.WriteLine(color.ToHexString()); // #FF000000

// Build the base attribute stats contributed by an equip
var stats = new CharacterBaseStats(STR: 10, DEX: 5, INT: 0, LUK: 3);
Console.WriteLine($"STR: {stats.STR}  DEX: {stats.DEX}"); // STR: 10  DEX: 5
```

For more examples see [Example Catalogue](#example-catalogue).

## Benchmarks

Benchmarks.

### Detailed Benchmarks

#### Comparison Benchmarks

##### TestBench Benchmark Results

###### Results will be populated here after running benchmarks locally.

## Example Catalogue

The following examples are available in [ReadMeTest.cs](src/Maple.Models.XyzTest/ReadMeTest.cs).

### Example - Empty

```csharp
// Create a color from a raw WZ ARGB value (e.g. from item data)
var color = ArgbColor.FromInt32(-16777216); // 0xFF000000 = opaque black
Console.WriteLine(color.ToHexString()); // #FF000000

// Build the base attribute stats contributed by an equip
var stats = new CharacterBaseStats(STR: 10, DEX: 5, INT: 0, LUK: 3);
Console.WriteLine($"STR: {stats.STR}  DEX: {stats.DEX}"); // STR: 10  DEX: 5
```

## Public API Reference

See [docs/PublicApi.md](docs/PublicApi.md) for the full generated public API surface.
