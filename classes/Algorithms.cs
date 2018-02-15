
using System;
public static class Algorithms{


    //simple array sum
   public  static int simpleArraySum(int[] ar) {
        // Complete this function
        int result = 0;
        for(int i=0; i<ar.Length; i++){
            result+=ar[i];
        }
        return result;
    }

}