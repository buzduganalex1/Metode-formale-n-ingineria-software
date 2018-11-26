#include <stdio.h>

int GetSmallestIntegerBiggerThanInputThatDividesBoth(int n){
    if(n > 1){ 
        int m = n + 1;
                
        int positiveInteger = 2;

        while(m % positiveInteger != 0 || n % positiveInteger != 0){

            if(positiveInteger > m / 2){
                m = m + 1;
                
                positiveInteger = 2;
            }
            else{
                positiveInteger = positiveInteger + 1;
            }
        }

        return m;
    }

    return -1;
}

int main(){
    printf("For input %d the result is %d \n", 0, GetSmallestIntegerBiggerThanInputThatDividesBoth(0));
    
    printf("For input %d the result is %d \n", 1, GetSmallestIntegerBiggerThanInputThatDividesBoth(1));
    
    printf("For input %d the result is %d \n", 2, GetSmallestIntegerBiggerThanInputThatDividesBoth(2));

    printf("For input %d the result is %d \n", 5, GetSmallestIntegerBiggerThanInputThatDividesBoth(5));
}

