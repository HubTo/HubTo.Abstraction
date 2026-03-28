# HubTo.Abstraction

[![Build](https://github.com/HubTo/HubTo.Abstraction/actions/workflows/publish.yml/badge.svg)](https://github.com/HubTo/HubTo.Abstraction/actions/workflows/publish.yml)
[![NuGet](https://img.shields.io/badge/nuget-latest-004880?style=flat&logo=nuget)](https://github.com/orgs/HubTo/packages)
[![License](https://img.shields.io/badge/license-Apache%202.0-D22128?style=flat&logo=apache)](LICENSE.txt)
[![.NET](https://img.shields.io/badge/.NET-2.1-512BD4?logo=dotnet)](https://dotnet.microsoft.com)

Core abstractions for the HubTo ecosystem.  
This package defines the base contracts and types used for building plugins and extending HubTo.

> ⚠️ This project is under active development. APIs may change until v1.0.0.

---

## Purpose

HubTo.Abstraction provides shared types for:

- Plugin categorization
- Core extension contracts
- Cross-boundary communication between core and plugins

---

## Installation
```bash
dotnet add package HubTo.Abstraction
```

---

## Plugin Types
```csharp
public enum PluginType
{
    Artifact = 1,
    Storage  = 2
}
```