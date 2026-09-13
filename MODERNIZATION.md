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

## Motivations

* This legacy code base is built on tech that existed 20 years ago
* We want to revive it for the modern era, using modern supported technologies
* Drop dead weight libraries that have been superseded or have modern open source equivalents
* And correct certain bad designs along the way
* While keeping the overall syntax and flexible core architecture and API that has served so well over those years
* Remain open source first, last and always.

### Modernization Guidelines

* Modern times call for modern tools
    * Make this stuff work easily on modern platforms, e.g. VSCode instead of full VS
    * Optimizing for standard/common/free tooling, instead of paid tools (but not excluding)
        * And instead of custom MSBuild tasks
* Break up some projects that may do too many things (and thus too many wide ranging dependencies).
* Make it easy for code written before to transition to new stuff.
    * Don't care about needing to update dependencies, or which assembly provides what, because you would have to retarget from .NETFX 4.x to .NET 8+ anyway.
    * The bulk of the work is going to be in correcting code/syntax, so reduction of the effort there is helpful. If things can be left backward compatible, do it.
    * Failing that, make it easy for lower model AIs to do it (and on a budget).
* Test test test.
    * There's a lot of pre-existing unit tests - keep them! and augment them!

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
NHibernate                      | try Entity Framework. otherwise, keep.

## Third Party Libraries

Empty table for now. Remove example and update at some point, but not immediately relevant at the start.

Library       | Version | License(s)   | Notes
------------- | ------- | ------------ | ------------------------------------------------------------
dummy example | 0.0     | GPL          |

### ReferencedAssemblies

The old repo structure had pre-built binaries for libraries in a separate ReferencedAssemblies repository that was usually symlinked into here.
We want to switch to loading from NPM as much as possible.
For things where we cannot, but have source code, we should just build it inline, or as a separate repo.
Anything where we don't even have the source code, we should drop.

Library                     | Resolution
--------------------------- | -------------------------------
Codecs/                     | Build inline - actually first party library, just partially C++ (may need to break the underlying library into a separate repo)
Interpolators/              | Build inline - actually first party library (break into separate repo, *if* there's actually any performance gain these days to be doing this in C++)
Itk/                        | Not sure we still use this? Revaluate and potentially drop
log4net                     | NPM
MSBuild                     | Drop. Switch to doing standard builds without need for custom actions stuff.
NHibernate                  | ....
SqlCe                       | Drop. Replace with other tech.
ViewerFunctions             | Build inline - actually first party library, maybe as a separate repo cause it's still C++
Vtk                         | Used for MPR stuff... split to different repo, if it's not available prebuilt via NPM
DotNetMagic2005             | Drop. Replace with other tech.
SharpZipLib                 | Check for modern, NPM ready stuff.
NHapi                       | ....?
NMock                       | NPM. or should we use Nsubsitute? either way, NPM.
NPlot                       | NPM
NUnit                       | NPM

## Project Phases

Because this is a pretty large code base, we want to break up the project into distinct phases that limit the
scope of changes while we figure out how things go, before working on the more complex stuff.
This means the new overall solution may not build completely.

### Phase 0 - Administrative

* **In-progress**
* Define and setup the modernization project (this file).
* Mass reorganization of repository structure to fit the desired directory structure.
    * Includes reworking project directories for SDK-style projects.
    * Still keep them organized by top level namespaces, e.g.
        ```
        src/
            Common/
                ClearCanvas.Common/
                ClearCanvas.Common.Configuration/
                etc.
        ```

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
* **PHASE COMPLETION** is a console application with a handful of services to demonstrate extension loading capability

### Phase 1.Z - Continuous Integration

* By this point, we should have a buildable core project. Get it wired up for CI.

### Phase 2 - Desktop Application

* **PHASE COMPLETION** is a bare desktop application with basic infrastructural things, and some components to demo controls and binding.

### Phase 3 - Viewer Application

* **PHASE COMPLETION** is a PACS viewer application

### Phase 4 - Server Application

* **PHASE COMPLETION** is a PACS server application