### Exercise 1 ###
The goal of this exercise is to design a class using contracts. The
design will be realized using the Microsoft CodeContracts online tool. The class
to be designed should implement sets of integers using arrays. The class must
include the following two methods:
addElem(x) - adds the integer x to the set given by the object state. If x is
already in the set, then this remains unchanged.
delElem(x) - removes the integer x from the set, if any.
Contracts specific requirements:
1. Write the object (class) invariants that ensure that arrays represent sets
of Integers.
2. for each methods, write the precondition and the postcondition. The
precondition should be as demanding as possible such that the operation
can be safely performed. The postcondition should be as strong as possible
such that a client is confident that it gets a correctly updated set.

3. the loop invariants will be checked at run-time, using the assert state-
ments.

### Exercise 2 ###
Use Microsoft Dafny online tool for statically checking the loop
invariants and the termination of the two methods from the first exercise. Since
Dafny has its own language, it is very likely that the syntax of the methods has
to be modified.
The ZIP archive will include:
• a pdf file describing how the class was designed, the interaction with the

tools (what messages you get from the tool, how did you solved the re-ported issues), screen shots with the result if the analysis given by the tools.

- Text files with the source code (running the source code should reproduce the results reported in the pdf file).

- References 1. Microsoft Research Software Engineering Tools: https://rise4fun.com/

- Description of the Contract Class: https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.contracts.contract?view=netframework-4.7.2
- Code Contracts Web site: https://www.microsoft.com/en-us/research/
project/code-contracts/from=http%3A%2F%2Fresearch.microsoft.com%2Fcontracts
4. Dafny Guide: https://rise4fun.com/Dafny/tutorial/Guide