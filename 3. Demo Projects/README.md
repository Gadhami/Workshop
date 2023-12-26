### **Séance 3**: Demo Projects (Architecture Clean + Microservices)

  * **Rappel**

    * **Create an ASP.NET Core Web API-only solution**

      `dotnet new ca-sln -cf None -o YourProjectName`

    * **Launch the app**

      `cd src/Web`

      `dotnet run`

    * **New Workshop Repo**

      - Contain video URLs, demo projects, logs, summary, etc.
      - `git clone https://github.com/Gadhami/Workshop.git`

---

  * **Demo Project (1): Products Catalog WebApp**

    - Create .NET solution using the clean architecture template
    - Create use cases via command-line (command + query)
    - Create DTOs for Category, Product, Order and Customer
    - Implement AutoMapper profiles
    - Create basic CQRS commands and queries for CRUD operations on **Product** entity
    - Use MediatR for handling these operations.
    - Apply FluentValidation for validating command models.

---

  * **Demo Project (2): Customers Area**
    - Create .NET solution using the clean architecture template
    - Create use cases via command-line (command + query)
    - Create DTOs for Employee, Professor and Student
    - Implement AutoMapper profiles
    - Create basic CQRS commands and queries for CRUD operations on Course entity
    - Use MediatR for handling these operations.

---

  * **Demo Project (3): Order Processing**
    - Create .NET solution using the clean architecture template
    - Create use cases via command-line (command + query)
    - Create DTOs for Employee, Professor and Student
    - Implement AutoMapper profiles
    - Create basic CQRS commands and queries for CRUD operations on Course entity
    - Use MediatR for handling these operations.

---

  ### What's Next?

  - ...