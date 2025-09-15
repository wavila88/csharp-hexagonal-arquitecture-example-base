# CSHARP Hexagonal Architecture Example 🎯

This is a base project implementing Hexagonal Architecture.  It can be copied and modified according to your specific needs, demonstrates how to implement **Hexagonal Architecture (Ports & Adapters)** in a C# application using .NET. The goal is to clearly separate business logic from infrastructure concerns, making the system more scalable, testable, and maintainable.

## 🧱 Project Structure

├── Api/ # Input adapter (controllers, DTOs) \
├── Application/ # Use cases and orchestration \
├── Domain/ # Entities, interfaces (ports), business logic \
├── Infra/ # Output adapters (repositories, messaging) \
