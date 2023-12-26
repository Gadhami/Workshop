### **Séance 1**: Introduction Architecture Clean

  - Lien Youtube:       https://youtu.be/S7ztumyghto
  - Template utilisée:  https://github.com/jasontaylordev/CleanArchitecture

---

### Keynotes

  * **Clean Architecture**

    - To install the [.NET template](https://github.com/jasontaylordev/CleanArchitecture):

      `dotnet new install Clean.Architecture.Solution.Template::8.0.2`

    - To create an ASP.NET Core Web API-only solution

      `dotnet new ca-sln -cf None -o YourProjectName`

    - Launch the app:

      `cd src/Web`
      `dotnet run`


  *	**Clean Code**

      https://medium.com/swlh/the-must-know-clean-code-principles-1371a14a2e75

	  -	Follow SOLID principles

      https://www.linkedin.com/feed/update/urn:li:activity:7109416053008433152/

	  -	Avoid duplicated code (DRY)
	  -	Good Naming Practises	(clear/descriptive/specific - NOT generic/single-responsibility)
	  -	Minimize Comments		(self-documenting code)  /  Refactor regularly  /  Avoid Zombie Code
	  -	1 function = 1 thing ONLY
    - Less method Parameters are better. Pass an object if >= 3 parameters
    -	Declare local variables closest to their usage
    - Declare instance variables on top
	  -	Use DI (dependency injection)
	  -	Tests: Small, fast, isolated, independant from each other, repeatable, 1 assert/test
	  -	Multi-threading: keep locked sections small, hard to debug/use wisely
	  -	Exception: throw exceptions rather than error status + throw "meaningful" exception to help dev quickly understand
	  -	Aim to ↑ Cohesion (class components support the same functions/data type) *AND* ↓ coupling (= improve decoupling between objects)


  *	**Other good Practices**

	  -	Commit often, commit early
	  -	Commit related code (i.e. NOT multiple tickets!)
    - *NO* Long Scrollbars!
    - YAGNI (You Aren't Gonna Need It)


  * **SOLID principles**

    https://en.wikipedia.org/wiki/SOLID

    1. Single Responsibility

        * 1 class = 1 responsibility ONLY (+ CQRS → applied @ architectural level): one class should do one thing only

    2. Software entities (classes, modules, methods, ...) should be:

        * Open for extension/Closed for modification

    3. Dependency inversion:

        * Depend upon abstractions, not concretions: Low/loosely coupled modules.
        * high-level classes should NOT depend upon low-level classes. Both should depend upon abstractions.

    4. Interface segregation:

        * Many client-specific interfaces are better than one general-purpose interface

    5. Liskov substitution

        * Extended module should preserve the functionality of the original