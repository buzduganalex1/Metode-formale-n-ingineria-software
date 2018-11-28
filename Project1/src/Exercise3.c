#include <stdio.h>

int main()
{
    int array[] = {1, 2, 6, 4, 0};
    
    int result = contains0(array, 5);
    
    printf("%d", result);
}

int contains0(int array[], int arraySize){
    for(int i = 0; i < arraySize; i++){
        if(array[i] == 0){
            printf("Element with id %d is 0.\n", i);
            
            return 0;  
        } 
    }
    
    return -1;    
}
