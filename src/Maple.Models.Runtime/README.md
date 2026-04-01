# Maple.Models.Runtime

`Maple.Models.Runtime` contains mutable MapleStory runtime graphs and the shared JSON persistence layer used by Edelstein tooling.

## Scope

- Mutable inventory, locker, trunk, and item-slot models
- Character and account-world runtime aggregates
- Temporary-stat, skill, quest, wishlist, quickslot, and function-key runtime graphs
- Shared JSON serializers and source-generated contexts for persisted runtime payloads

## Package Boundary

Use `Maple.Models.Runtime` when you need editable runtime state or persisted runtime JSON contracts.

Immutable template/catalog/value-object contracts live in `Maple.Models`.

## Target Framework

- `net10.0`

## Source

- Repository: https://github.com/Bia10/Maple.Models
