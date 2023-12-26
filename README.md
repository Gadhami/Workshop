### **Séance 1** Introduction Architecture Clean

  - Lien Youtube: https://youtu.be/S7ztumyghto
  - Template utilisée: https://github.com/jasontaylordev/CleanArchitecture

---

### **Séance 2**

  - Rappel

    * To create an ASP.NET Core Web API-only solution

      `dotnet new ca-sln -cf None -o YourProjectName`

    * Launch the app:

      `cd src/Web`
      `dotnet run`

  - Clean Architecture: Pros & Cons
    * **Clear Separation of Concerns**: Promotes organization and separation of code into distinct layers (Domain, Application, Infrastructure, Presentation), enhancing readability and maintainability.

    * **Testability**: The decoupled nature of the architecture makes unit testing more straightforward, especially for business logic in the Domain and Application layers.

    * **Flexibility and Scalability**: Due to its modular structure, it's easier to add new features or update existing ones. The architecture scales well for large and complex applications.

    * **Dependency Rule**: Core business logic is independent of frameworks and external agencies, ensuring that business rules are not affected by external changes.

    * **Database Independence**: Business logic is not tied to a specific database, allowing for flexibility in database choice and easy migration.

    * **Framework Independence**: Reduces dependency on specific frameworks, making it easier to adapt to new technological changes or swap out frameworks if necessary.

    * **Adherence to SOLID Principles**: Promotes adherence to SOLID principles, resulting in a robust, flexible, and maintainable codebase.

    * **Support for Multiple UIs**: Easily supports different types of clients (web, mobile, desktop) due to the decoupled presentation layer.

  - Cons of Clean Architecture in .NET
    * **Complexity**: Can be overkill for simple applications, adding unnecessary layers and complexity which can increase development time and learning curve.

    * **Initial Setup Time**: Requires more upfront time to set up the architecture correctly, which might delay the initial development phase.

    * **Potential for Misuse**: If not implemented correctly, it can lead to misuse of patterns (e.g., over-abstracting, misuse of repositories), which can negate its benefits.

    * **Increased Development Effort**: More effort is required to develop and maintain the multiple layers and their interactions compared to a monolithic design.

    * **Requires Experienced Team**: Effective implementation requires a team with a good understanding of architectural principles, which can be a challenge for teams new to this approach.

    * **Possible Performance Overhead**: The multiple layers and abstractions can introduce performance overhead, particularly in scenarios requiring high throughput or low latency.

    * **Dependency Management**: Requires careful management of dependencies to ensure the integrity of the architecture, which can be complex.

    * **Potential for Over-Engineering**: There's a risk of over-engineering solutions, especially when developers are too rigid in applying the architecture principles.

  - Architecture Clean sur .NET 8
    * Nouveautés du template

  - **Demo Project (1): Products Catalog WebApp**
    * Create .NET solution using the clean architecture template
    * Create use cases via command-line (command + query)
    * Create DTOs for Category, Product, Order and Customer
    * Implement AutoMapper profiles
    * Create basic CQRS commands and queries for CRUD operations on **Product** entity
    * Use MediatR for handling these operations.
    * Apply FluentValidation for validating command models.

  - **Demo Project (2): Customers Area**
    * Create .NET solution using the clean architecture template
    * Create use cases via command-line (command + query)
    * Create DTOs for Employee, Professor and Student
    * Implement AutoMapper profiles
    * Create basic CQRS commands and queries for CRUD operations on Course entity
    * Use MediatR for handling these operations.

  - **Demo Project (3): Order Processing**
    * Create .NET solution using the clean architecture template
    * Create use cases via command-line (command + query)
    * Create DTOs for Employee, Professor and Student
    * Implement AutoMapper profiles
    * Create basic CQRS commands and queries for CRUD operations on Course entity
    * Use MediatR for handling these operations.

  - Introduction To Microservices
    * 5 Components
      - Microservices, API gateway, (Docker) Containers, Service mesh, Service discovery
    * **API Gateway**
      - Reverse proxy to redirect/route requests to the endpoints of the internal microservices
      - Provides a single endpoint or URL for the client apps and then internally maps the requests to a group of internal microservices
      - Decouple the client apps from the microservices
    * **Service Discovery**
        → Helps us know where each instance is located (acts as a registry in which the addresses of all microservices are tracked)
    * **Docker Containers**
        → Microservices-based application typically runs in virtualized or containerized environments
    * **Service mesh**
        → Mechanism for managing communications between the individual services in a microservice-based system

    *	**Event-driven Architecture**
      - Refers to how microservices subscribe/publish to a service bus
      - Gives us a decoupled architecture

  ### What's Next?
  - Connect projects as microservices

---
