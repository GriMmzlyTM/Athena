# ViewModels

### What is a ViewModel
A ViewModel allows a user to directly interact with the application and its underlying logic in a safe and decoupled way. 

```
[USER] -> [VIEWMODEL] -> [SERVICE] -> [MODEL]
```

### Dependency Injection
ViewModels must not be injected as Singletons. A ViewModel should never contain persistent data within itself and should instead inject a Singleton model as it needs it. 

### Coding and styling

ViewModels should follow SOLID design principles and Avalonia standards. 