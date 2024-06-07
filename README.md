Self-Assessment: Onion Architecture, MVC, and Web API (.NET Core) with Bottlenecks (Encountered)
Conceptual Understanding:
 
1. Onion Architecture: (Yes/No) 
 
Have you heard of the Onion Architecture principle in software design? No
 
 
 
2. MVC Pattern: (Yes/No) 
 
Are you familiar with the Model-View-Controller (MVC) pattern for building web applications? Yes
 
 
 
3. Web API: (Yes/No) 
 
Do you understand the concept of building RESTful APIs using ASP.NET Core Web API? No
 
 
 

Application & Bottlenecks:
Onion Architecture:
 
 
1. Benefits: (1-3 keywords)
Briefly list some key benefits of using Onion Architecture in .NET Core projects. (e.g., separation of concerns, testability)
- high levels of testability
- maintainability
- scalabiltiy
 
 
 
 
3. Bottlenecks (Encountered): (Yes/No and Briefly Explain)
 
Have you encountered any challenges with Onion Architecture in your projects? If so, briefly describe the bottleneck(s). 
(e.g., Increased complexity for simple projects, difficulty finding developers familiar with the pattern)

- Yes, Onion Architecture can introduce complexity for simple projects due to the overhead of setting up the layers.
 
 
 

MVC:
 
 
1. Components: (1-3 keywords each)
Briefly describe the roles of the Model, View, and Controller in the MVC pattern.
- Data
- Presentation
- Logic
 
 
 
 
3. Bottlenecks (Encountered): (Yes/No and Briefly Explain)
Have you encountered any challenges with tight coupling between Model and Controller in MVC projects? If so, briefly describe the issue(s).
(e.g., Difficulty in unit testing controllers, logic changes rippling through the application)

- Yes, yes, Difficulty in testing. Tight coupling between Model and Controller makes it difficult to write unit tests for controllers in isolation.
- Since the Controller is dependent on the Model, mocking or stubbing the Model becomes necessary to test the Controller effectively.
 
 
 

Web API:
 
1. Differences from MVC: (Yes/No and Briefly Explain)
 
 
Can you differentiate between traditional MVC applications and Web APIs? Briefly explain the main difference.
- Yes, data format. Traditional MVC applications return full webpage views (HTML, CSS, JS), while Web APIs focus on returning data
- (JSON, XML) for consumption by other applications.
 
 
2. Bottlenecks (Encountered): (Yes/No and Briefly Explain)

Have you encountered any performance challenges with traditional MVC applications compared to Web APIs? If so, briefly describe the scenario(s). 
(e.g., Frequent page refreshes causing performance overhead, complex data exchange requiring a more lightweight approach)

- Yes, overhead. Traditional MVC applications can have performance overhead due to full page refreshes compared to Web APIs which are lighter weight and transfer only the necessary data.
