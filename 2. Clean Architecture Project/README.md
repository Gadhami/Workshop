### **Séance 2**: Architecture Clean (2) + Introduction to Microservices

  * **Rappel**

    * **Create an ASP.NET Core Web API-only solution**

      `dotnet new ca-sln -cf None -o YourProjectName`

    * **Launch the app**

      `cd src/Web`

      `dotnet run`

---

  * **New Workshop Repo**

    - Contain video URLs, demo projects, logs, summary, etc.
    - `git clone https://github.com/Gadhami/Workshop.git`

---

  * **Clean Architecture: Pros**

    * **Clear Separation of Concerns**: Promotes organization and separation of code into distinct layers (Domain, Application, Infrastructure, Presentation), enhancing readability and maintainability.

    * **Testability**: The decoupled nature of the architecture makes unit testing more straightforward, especially for business logic in the Domain and Application layers.

    * **Flexibility and Scalability**: Due to its modular structure, it's easier to add new features or update existing ones. The architecture scales well for large and complex applications.

    * **Dependency Rule**: Core business logic is independent of frameworks and external agencies, ensuring that business rules are not affected by external changes.

    * **Database Independence**: Business logic is not tied to a specific database, allowing for flexibility in database choice and easy migration.

    * **Framework Independence**: Reduces dependency on specific frameworks, making it easier to adapt to new technological changes or swap out frameworks if necessary.

    * **Adherence to SOLID Principles**: Promotes adherence to SOLID principles, resulting in a robust, flexible, and maintainable codebase.

    * **Support for Multiple UIs**: Easily supports different types of clients (web, mobile, desktop) due to the decoupled presentation layer.

---

  * **Clean Architecture: Cons**

    * **Complexity**: Can be overkill for simple applications, adding unnecessary layers and complexity which can increase development time and learning curve.

    * **Initial Setup Time**: Requires more upfront time to set up the architecture correctly, which might delay the initial development phase.

    * **Potential for Misuse**: If not implemented correctly, it can lead to misuse of patterns (e.g., over-abstracting, misuse of repositories), which can negate its benefits.

    * **Increased Development Effort**: More effort is required to develop and maintain the multiple layers and their interactions compared to a monolithic design.

    * **Requires Experienced Team**: Effective implementation requires a team with a good understanding of architectural principles, which can be a challenge for teams new to this approach.

    * **Possible Performance Overhead**: The multiple layers and abstractions can introduce performance overhead, particularly in scenarios requiring high throughput or low latency.

    * **Dependency Management**: Requires careful management of dependencies to ensure the integrity of the architecture, which can be complex.

    * **Potential for Over-Engineering**: There's a risk of over-engineering solutions, especially when developers are too rigid in applying the architecture principles.

---

  * **Architecture Clean Template -> .NET 8**

    - Nouveautés du template: .NET 8 support + use case (via commandline)

    - To create a new **command**:

    `dotnet new ca-usecase --name CreateTodoList --feature-name TodoLists --usecase-type command --return-type int`

    - To create a **query**:

    `dotnet new ca-usecase -n GetTodos -fn TodoLists -ut query -rt TodosVm`

---

  * **Demo Project (1): Generic Handlers**

    - Show generic handlers code + demo in Postman

---

  ### What's Next?

  - Better repo structure
  - More demo projects (clean architecture)
  - Connect projects as microservices
  - Docker