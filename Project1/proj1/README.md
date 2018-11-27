# Detailed description

For using z3 follow https://rise4fun.com/z3/tutorial 

### Exxercise 1
##### 1.   
``` 
    The precondition is that n has to be an integer and > 1
    
    The postcondition is that m integer, m > n, m % i == 0 && n % i ==0
``` 
##### 2.
```
    The program implementation in c is in src and the implementation in maude in maude/Exercise1.maude

    To execute it run:

    maude Exercise1.maude
```
##### 3.
```
    The tableaux code for our program is in tableaux.maude

    To execute it run:

    maude Exercise.maude
```
##### 4.
```
    Use v3 to verify the program

    The implications are :
        1. i > m / 2[2 / i][m + 1 / m]
        2. n <= m && (n % i == 0 && m % i == 0)
```