---
---

# Oxpecker

![Oxpecker](https://github.com/Lanayx/Oxpecker/raw/develop/images/oxpecker.png)

**Oxpecker** is a library started as functional wrapper around **ASP.NET Core Endpoint routing**, but now providing fullstack capabilities with **Htmx** and **Solid.js** integrations. Repository is a monorepo with all related projects included and documentation located in Readme files per project.

The server part of the Oxpecker library is a revised version of [Giraffe](https://github.com/giraffe-fsharp/Giraffe), it mostly sticks to Giraffe's successful API (hence the name). Improvements involve changing some core types, performance of template handlers, simplifying handlers and dropping a lot of outdated functionality.

Medium posts:
* [Oxpecker Introduction](https://medium.com/@lanayx/the-oxpecker-ef9df3dfb918)
* [7 reasons to try Oxpecker.ViewEngine](https://medium.com/@lanayx/7-reasons-to-try-oxpecker-viewengine-af642b4d191c)
* [Oxpecker vs Blazor](https://medium.com/@lanayx/blazor-vs-oxpecker-067cbcda9f99)
* [Oxpecker.Solid introduction](https://medium.com/@lanayx/oxpecker-goes-full-stack-45beb1f3da34)

## Features:

- Native [ASP.NET Core Endpoint routing](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/routing) integration
- ViewEngine with convenient DSL for HTML
- Strongly typed route parameters
- Endpoint handlers and endpoint middlewares, flexible composition
- JSON binding and serialization
- Form binding
- URL parameters binding
- Response caching
- Streaming
- Authorization
- eTag support
- IResult support
- Many useful **HttpContext** extensions

## Get started:
- [Empty template](https://github.com/Lanayx/Oxpecker/blob/main/examples/Empty)
- [Empty Solid template](https://github.com/Lanayx/Oxpecker/blob/main/examples/EmptySolid)

## Examples:
- [Dump of different features all in one place](https://github.com/Lanayx/Oxpecker/blob/main/examples/Basic)
- [Full CRUD example with functional DI](https://github.com/Lanayx/Oxpecker/blob/main/examples/CRUD)
- [HTMX sample application](https://github.com/Lanayx/Oxpecker/tree/main/examples/ContactApp)
- [Oxpecker version of the traditional ASP.NET WeatherApp](https://github.com/Lanayx/Oxpecker/tree/main/examples/WeatherApp)
- [SPA application (TODO list) without backend](https://github.com/Lanayx/Oxpecker/tree/main/examples/TodoList)

## Documentation links:

* [Oxpecker](https://lanayx.github.io/Oxpecker/src/Oxpecker/)
* [Oxpecker.ViewEngine](https://lanayx.github.io/Oxpecker/src/Oxpecker.ViewEngine/)
* [Oxpecker.Htmx Readme](https://lanayx.github.io/Oxpecker/src/Oxpecker.Htmx/)
* [Oxpecker.OpenApi Readme](https://lanayx.github.io/Oxpecker/src/Oxpecker.OpenApi/)
* [Oxpecker.Solid Readme](https://lanayx.github.io/Oxpecker/src/Oxpecker.Solid/)
* [Migration from Giraffe](https://lanayx.github.io/Oxpecker/MigrateFromGiraffe)

## develop vs main branch:

**develop** is a development branch, projects are linked with each other using project references. Use this branch to send PRs.

**main** is a production branch, projects and examples are linked with each other using nuget (or npm) packages. Packages are published from this branch.

## Packages

* [Oxpecker Nuget package](https://www.nuget.org/packages/Oxpecker)
* [Oxpecker.ViewEngine Nuget package](https://www.nuget.org/packages/Oxpecker.ViewEngine)
* [Oxpecker.Htmx Nuget package](https://www.nuget.org/packages/Oxpecker.Htmx)
* [Oxpecker.OpenApi Nuget package](https://www.nuget.org/packages/Oxpecker.OpenApi)
* [Oxpecker.Solid Nuget package](https://www.nuget.org/packages/Oxpecker.Solid)
* [Oxpecker.Solid.FablePlugin Nuget package](https://www.nuget.org/packages/Oxpecker.Solid.FablePlugin)
