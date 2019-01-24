# Project 2 
### Buzdugan Alexandru MSD 2 

### Exercise 1
The goal is to do live variable analysis for the following program:
```c
1. a = 2;
2. b = 4;
3. if ( b < 2 ) {
4. while (b < c)
5. b = b + 2;
6. a = b;
}
else
7. d = a - c;
8. d = b + 2;
```
1. Build the control flow graph.
2. Define the functions kill and gen.
3. Define the transfer function.
4. Define the system of equations.
5. Apply the algorithm computing the fixed point (based on Knaster-Tarski Theorem).

- Step 1

    In this step we are labeling the commands, identifying the variables and defining the kill and gen functions.

    <img src="Exercise1Functions.jpg" alt="drawing" width="700  "/>

- Step 2

    After that we are builduing the control graph, defining the transfer function and create the equation system.

    <img src="Exercise1FlowGraph.jpg" alt="drawing" width="700  "/>

- Step 3

   After defining the equation system we can apply the algorithm based on Knaster-Tarski to find the solution.
   
   <img src="Exercise1Variables.jpg" alt="drawing" width="700  "/>

### Exercise 2

- Step 1

    <img src="Exercise2Step1.jpg" alt="drawing" width="700  "/>

- Step 2

    <img src="Exercise2Step2.jpg" alt="drawing" width="700  "/>

- Step 3
   
    <img src="Exercise2Step3.jpg" alt="drawing" width="700  "/>

- Step 4

    <img src="Exercise2Step4.jpg" alt="drawing" width="700  "/>

- Step 5

    <img src="Exercise2Step5.jpg" alt="drawing" width="700  "/>

- Step 6

    <img src="Exercise2LastStep.jpg" alt="drawing" width="700  "/>

### Exercise 3

<img src="Exercise3.jpg" alt="drawing" width="700  "/>
