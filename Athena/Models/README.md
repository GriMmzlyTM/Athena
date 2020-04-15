# Models

### What is a model? 
Models are strict and reusable data container signatures and contain methods to use and manipulate said data. 

### Why use models?
Models provide a strict signature for our data and allow us to do things like map JSON/YML configs as well as using Dependency Injection to ensure high availability of data. 

### Dependency Injection 

Models can be DI'd in-order to ensure high availability. 

This means you can have access to data (Such as a config) while using services to update said data with no coupling. 

All models must use `Lifestyle.Singleton`. If a model does not need to be a singleton it likely doesn't need to be DI'd to begin with and can live within a service instead. 

### How to DI

Models must be DI'd in their own folder and should be registered as concrete since they don't use interfaces. 

```
Models
    -> Account
        -> AccountModel.cs
        -> BootstrapAccountModels.cs
    -> Payloads -- MUST NOT BE DI'D
        -> Account
            -> ...
Services
    -> Account
        -> BootstrapAccount.cs -- DI ACCOUNT SERVICES
        
```

```csharp=
//BootstrapAccountModels.cs
container.Register<AccountModel>(Lifestyle.Singleton);
```

### Code and styling rules 

##### A model must:
- Serve a single purpose as a data container/propegator
- Be used to help reduce coupling
- Make data highly available
- Be usable with no services if required
- Contain self-documenting property names
- Implement the `Model` base class
- Plug & Play
- Be properly organized and follow the same folder structure as its services.
- Contain exclusively public properties. 

#### A model must not: 
- Overcomplicate design or create coupling
- Be impossible to use without its services
- Be used as a payload. Payloads and models serve different purposes.
- Be DI'd as anything other than a singleton. Models serve as a way to store, manipulate and propegate data. If your model isn't a singleton if doesn't need to be injected.
- Be manipulated across services in different domains. A model in `Services/Accounts` must propegate and make available data from that domain exclusively. A new model must be made for the other domain. If the two models are identical, consider why you need a separate service. 

#### A payload must: 
- Implement IServicePayload 
- Be used for a single service. 
- Contain exclusively public properties
- Follow the same coding practices as Models (Including Domain oriented structure)

#### A payload must not:
- Contain methods
- Be injected