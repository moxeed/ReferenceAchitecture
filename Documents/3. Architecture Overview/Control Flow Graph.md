A **Control Flow Graph** is a directed graph that represents all paths that program execution can take.  
Each node is a **basic block** (a straight-line sequence of instructions with no internal jumps), and edges represent **possible transfers of control**.

CFGs are fundamental in:
- Compilers
- Static analysis
- Control-flow–based testing
- Optimization
- Security analysis (taint flow, vulnerability detection)

A CFG abstracts the runtime paths into a mathematical structure that tools can analyze.
# Structure of a CFG

A typical CFG contains:
- **Entry Node**  
    Start of execution for the function or program.
- **Basic Blocks (BBs)**  
    Groups of instructions with:
    - One entry point
    - One exit point
    - No branches inside
- **Edges**  
    Directed arrows that show possible control jumps:
    - Sequential flow
    - Conditional branches
    - Loops
    - Exception jumps
    - Function calls (in extended models)
- **Exit Node**  
    End of execution (return, halt, exception exit, etc.)