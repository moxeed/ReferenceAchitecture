### (Placement, Responsibilities, and Boundaries)

## 1. Definitions

### Business Event

A **Business Event** is something that _the business cares about_ and that _changes the state of the domain_.  
Examples:
- _OrderPlaced_
- _PaymentFailed_
- _UserSubscribed_
- _InventoryDepleted_

Characteristics:
- Describes **why** something happened in business terms.
- Part of the **domain layer**.
- Must be expressed in **ubiquitous language**.
- Triggers domain rules, workflows, invariants, or sagas.

### System Event

A **System Event** is something that _the system emits or handles_ for plumbing, integration, and technical operations.  
Examples:
- _CacheInvalidated_
- _WebhookRetryScheduled_
- _BackgroundJobStarted_
- _ServiceHealthDegraded_
- _EmailDeliveryRequested_

Characteristics:
- Technical, not domain-driven.
- Part of the **application layer** or **infrastructure layer**.
- Supports system functioning—not business logic.

---

## 2. Where to Put Each Event in Architecture

```
+-----------------------------------------------------+
|                     Presentation                    |
+---------------------------+-------------------------+
|         Application       |        Library          |
|  (Use Cases, Commands)    | (System Events)         |
+---------------------------+-------------------------+
|                          Domain                     |
|          Business Events  + Aggregates + Rules      |
+---------------------------+-------------------------+
|                   Infrastructure                    |
|         (System Event Handlers, Message Bus)        |
+-----------------------------------------------------+

```
### Business Events → Domain

Place in:
- **Domain Model (Entities, Aggregates, Value Objects)**
- **Domain Event classes**
- **Domain Services (if needed)**

Why:
- They represent state transitions of business concepts.
- They drive domain workflows.
- They enforce invariants.

**Rule:**  
Business events never depend on infrastructure code.

### System Events → Library

Place in:

- **Application Services** (use cases)
- **Background job schedulers**
- **Integration adapters**
- **Monitoring hooks**
- **Messaging infrastructure**

Why:
- They drive system coordination, not business meaning.
- They coordinate external resources, retries, orchestration.

**Rule:**  
System events must never have business rules inside them.

---

## 3. Examples

### Business Event Example (Domain Layer)

```csharp
public record OrderPlaced(
    Guid OrderId,
    Guid CustomerId,
    Money TotalAmount
) : IDomainEvent;
```

### System Event Example (Application/Infra Layer)

```csharp
public record CacheInvalidated(string Key) : ISystemEvent;
```

---

## 4. Architecture Guidelines

### When to Use Business Events

Use when something changes the **meaning** of the domain.
- Aggregate state change
- Workflow progression
- Policy evaluation
- Real-world event translated into domain language

### When to Use System Events

Use when the system must respond to technical concerns:
- Retry a failed integration
- Start an async operation
- Run a scheduled batch process
- Notify internal subsystems
- Refresh or rebuild caches

---

## 5. How They Interact

### Workflow Example

1. A domain rule triggers **OrderPlaced** (business event).
2. Application layer listens to it and triggers a **system event** such as:
    - Publish integration message
    - Send email
    - Schedule a background task

This keeps business meaning and system plumbing cleanly separated.

---
## 6. Summary Table

|Aspect|Business Event|System Event|
|---|---|---|
|Meaning|Business fact|Technical operation|
|Layer|Domain|Application / Infrastructure|
|Dependency|No infra dependencies|Can depend on infra|
|Triggers|Domain rules, workflows|External systems, schedulers, technical processes|
|Examples|PaymentFailed, OrderPlaced|CacheInvalidated, EmailDeliveryRequested|
