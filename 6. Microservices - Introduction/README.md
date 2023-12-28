### **Introduction To Microservices**

  * 5 Components
    - Microservices
    - API gateway
    - Docker Containers
    - Service mesh
    - Service discovery

    https://www.linkedin.com/feed/update/urn:li:activity:7109024832578617344/


  * **API Gateway**

    - Reverse proxy to redirect/route requests to the endpoints of the internal microservices
    - Provides a single endpoint or URL for the client apps and then internally maps the requests to a group of internal microservices
    - Decouple the client apps from the microservices

  * **Service Discovery**

      - Helps us know where each instance is located (acts as a registry in which the addresses of all microservices are tracked)


  * **Docker Containers**

      - Microservices-based application typically runs in virtualized or containerized environments

  * **Service mesh**

      - Mechanism for managing communications between the individual services in a microservice-based system


  *	**Event-driven Architecture**

        - Refers to how microservices subscribe/publish to a service bus
        - Gives us a decoupled architecture


  * **Microservices communication stategies**

    https://www.linkedin.com/feed/update/urn:li:activity:7109942231335137281/

        - sync vs async:
            * Can you do another request to get the same results from the other service?
                -> sync
            * Possible Data loss?
                -> async/queues


  * **Monolith → Microservices: Migration Strategy**

    - Strangler Application Pattern (Gradually, 3 phases: Transform + Coexist + Eliminate)

    1. Identify interaction points in monolith application; ie. HTTP Endpoints (API) / File Share / Queues
    2. Group interation points into Capabilities (Functionnality) → (Group/Decompose into) Microservices
    3. For each microservice (group of interaction points):
      a. Resolve missing dependencies
      b. Reroute traffic by using/activating the newly migrated microservice URL routes
        » Problem?            → Redirect back to monolith URLs
        » OK?                 → Eliminate legacy version (monolithic part)

    4. Repeat Step (2)


  ### What's Next?

  - Better repo structure
  - More demo projects (clean architecture)
  - Connect projects as microservices
  - Docker