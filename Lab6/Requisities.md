## Exercitii

P3x :
    input: un nr intreg x
    output: partea intreaga a lui radical ^ 3 (x)

1. Sa se specifice preend, postend
2. Sa se scrie un program A care rezolva P3x
3. Sa se arate ca A este corect relativ la specificatii utilizand Floyd-Horm

## Rezolvare
1. preconditie : x apartine Z
   postconditie: q apartine Z a.i. a^3 <= x < (a+1)^3
   [y] = a apartine Z a <= y < a + 1 (partea intreaga)

---
    function getRealNumberFromSquare(x)
    {
        a = 0;

        if(x < 0){
            x *= -1;
        }

        while(true){
            if(pow(x,3) <= x < pow(a+1, 3){
                return true;
            }

            a += 1;
        }  
    }

    function pow(x, n){
        while(n > 0){
            x *= x;
        }
    }

---

2. Rezolvare P3x

---
    P := true
    Q := a*a*a <= x < (a+1)*(a+1)*(a+1)
    |- (| P |) A (| Q |)
    |- (| true |)
    if(x < 0)
        x1 = -x else x1 = x;
    a=0;
    while((a+1)*(a+1)*(a+1) <= a)
        a = a + 1;
    if(x<0)
        a = -a
    (| a^3 <= x < (a+1)^3 |)
