### Semantic Prefixes
The [[6. Code Navigation]] could be simplified by applying more data, context and attributes to its building parts. It is advised to use semantic prefixes to clear out what does a code block is expected to do. This has two benefits
- Terminating driving the change axis of code block from its location in code base. E.g. any thing in service layer should only carry out business flows. While the location convention is also encouraged but the explicit expression of block purpose is much more clear and independent, helping the developer to easily decide what code belongs to where.
- It greatly improved code navigation, code understanding and decision making flow at the design time. Thus reducing overheads caused by large code base or tangled execution flows.

Semantic prefixes suggested per module type
#### Domain
Classes:
BR000: Identify a business rule with its unique id.
Event000: Identify an event
Command000: Identify a command
Policy000: Identify a policy

Methods:
Mutate: A method only changing state
Validate: Preconditions to run on data and input before processing.
Decide: Decide on which mutations should be done
Apply: Apply decided actions from other entities, and commands on this entity
Ensure: Run entity invariants
Compute: Calculate an intermediate value
Derive: Calculated state, equivalent to [[3. Controller Datapath Model#2. Controllers Without an FSM|controller with no FSM]]
On: To Handle Events

### Application
Classes:
UC001: Identify a use case

Methods:
Handle: To execute commands and external events 
Fetch: Query Data
#### Library
Classes:
Algorithm
Data Structure
Model
Serializer
DeSerializer

Methods:
Compute: Calculate an intermediate value
Generate: Create a classes to return
Satisfy: Consider rules passed from caller
### Project Naming

#### Template 
Asa.Realtime.{Project}.{Context}.{[[4. Software Modules|Type]]}

Context is optional and could be used to differentiate modules with same type but different purposes.
#### Example:
- Asa.Realtime.SmartInvest.Domain
- Asa.Realtime.ClusterManager.Library
- Asa.Realtime.Rmdp.Rlc.Agent
- Asa.Realtime.Rmdp.Api