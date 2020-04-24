# Services

### What is a service?
A service is a single-responsibility dependency injected object that manipulated models to serve a need with or without payloads. 

### Why do we need services?
Services provide us with a loosely coupled and highly available way of updating, manipulating and acting upon data. Services are more "Back-end" than something like a ViewModel. 

While a ViewModel is used to provide a View with readily available and observable data and commands, a Service provides the ViewModel with ways of obtaining and manipulating that data. 

A ViewModel contains logic and data that a user can directly interact with and manipulate

A Service contains logic that reacts to a users actions and contain logic that a ViewModel can directly interact with. 

User clicks `Search X`
ViewModel says `Find me X (Service)`
Service finds `X`
ViewModel gives user `X`

### Service best practices

A service must implement an interfact that itself implements `IService`

This is because when a service is injected, it's injected through its interface and not as a concrete class.

```
Services
    -> Config
        -> ApplicationUpdateConfigService.cs : IApplicationUpdateConfigService.cs
        -> IApplicationUpdateConfigService.cs : IService
        -> BootstrapConfig.cs : IBootstrap
```

### Dependency Injection

All services must have a `Bootstrap[DOMAIN].cs` file which bootstraps it as such
```csharp
container.Register<IMyService, MyService>();
```

There are very few reasons why a service should be a `singleton`. Services are single purpose objects means to execute a single concept. If your Service needs to be a singleton because of persistent data, consider moving that data to a singelton model.

