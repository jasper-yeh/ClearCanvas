ClearCanvas Modernization Project
=================================

This is the README for the ClearCanvas Modernization Project.
Ignore the old README.md, it is out of date, and we will update it closer to the end of modernization.

## Updates

Certain parts of this documentation should be regularly kept up to date as things change throughout the course of the project, primarily to track progress and provide context for next phases:
* [Repository Structure](#repository-structure)
* [Third Party Libraries](#third-party-libraries)
* [Tech Stack Replacements](#tech-stack-replacements)
* [Project Phases](#project-phases)

## Motivation

* This legacy code base is built on tech that existed 20 years ago
* We want to revive it for the modern era, using modern supported technologies
* Drop dead weight libraries that have been superseded or have modern open source equivalents
* And correct certain bad designs along the way
* While keeping the overall syntax and flexible core architecture and API that has served so well over those years
* Remain open source first, last and always.

## Repository Structure

The old repository structure differs significantly from how we want it.
Everything was treated as code-adjacent, and so all things were organized in folders at the root, i.e. there is no separation of code
from, say, documentation. We will change that here.
We are also change the casing of folders to prefer lower case, except for what will end up as .NET code namespaces.

Subdirectory    | Contents              | Former equivalents
--------------- | --------------------- | ---------------------------------------------------
docs/           | Documentation         | Docs/
lib/            | External libraries if needed, and cannot be NPMed
ReferencedAssemblies/ | Legacy external libraries, prior to modernization | ReferencedAssemblies/
resources/      | Resource files        | e.g. Icons/
licenses/       | License file text     | Licenses/
examples/       | Example code/apps     | Samples/
src/            | Source code           | All former root folders which were code namespaces

## Development Guidelines and Coding Style

### Versioning

At this point in the project, versioning isn't terribly important. Label things `0.0.0.anything`.

Changes are documented in `CHANGELOG.md`.

### Terminology

Term             | Definition by example
---------------- | ---------------------------
Upper camel case | ExampleOfUpperCamelCase
Lower camel case | exampleOfLowerCamelCase
Upper snake case | EXAMPLE_OF_UPPER_SNAKE_CASE
Lower snake case | example_of_lower_snake_case
Kebab case       | example-of-kebab-case

## Tech Stack Replacements

We have selected a bunch of modern tech stack replacements.

Old                             | New
------------------------------- | ---------------------------
.NET Framework (<=4.8)          | .NET 8 at least
WinForms/WPF                    | Blazor/web
WCF                             | gRPC
any other inter-component API   | gRPC
public API                      | REST

## Third Party Libraries

Empty table for now. Remove example and update at some point, but not immediately relevant at the start.

Library       | Version | License(s)   | Notes
------------- | ------- | ------------ | ------------------------------------------------------------
dummy example | 0.0     | GPL          |

## Project Phases

Because this is a pretty large code base, we want to break up the project into distinct phases that limit the
scope of changes while we figure out how things go, before working on the more complex stuff.
This means the new overall solution may not build completely.

### Phase 0 - Administrative

* **In-progress**
* Define and setup the modernization project.

### Phase 1 - Application Framework, Console Application

* **Legacy Focus Directories**: Common/
* We still desire the flexible plugin-based application framework, but it cannot discover dynamically any more - way too dangerous in the modern era.
    * No more pre-compiled executables. Existing "...Executable" projects become examples.
    * Root executable references and loads all plugins into domain.
        * If you absolutely must have discoverable plugins, you can choose to implement that here, but we aren't providing that out of the box.
* Core `ServiceRegistry` implementation for dependency injection (DI).
    * Root executable initializes one root service registry, holding main singletons, and stands up the rest of the application.
    * Components can be created via DI by asking the service registry for it.
    * If custom dependencies are required at any time, construct a scoped registry, possibly using any other instance(s) as a fallback, and replace/add to service registrations.
    * Use attributes to declare service interfaces implemented. (Standard attribute in framework, if available)
    * Try to maintain API compatibility on the "extensions" framework. These concepts should largely map onto the service registry, except with the flexibility for non-default constructors.
        * Extension attributes now simply map to a service declaration attribute, since it points to an ExtensionPoint which has the service interface.
* **PHASE GATE:** a console application with a handful of services to demonstrate extension loading capability.

### Phase 2 - Desktop Application