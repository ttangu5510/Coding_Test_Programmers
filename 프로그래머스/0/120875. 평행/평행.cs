using System;

public class Solution {
    public int solution(int[,] dots) {        
        int gradX12, gradX34, gradX13, gradX24, gradX14, gradX23;
        int gradY12, gradY34, gradY13, gradY24, gradY14, gradY23;
        gradX12 = dots[0,0] - dots[1,0];
        gradX34 = dots[2,0] - dots[3,0];
        gradX13 = dots[0,0] - dots[2,0];        
        gradX24 = dots[1,0] - dots[3,0];        
        gradX14 = dots[0,0] - dots[3,0];        
        gradX23 = dots[1,0] - dots[2,0];
        
        gradY12 = dots[0,1] - dots[1,1];
        gradY34 = dots[2,1] - dots[3,1];
        gradY13 = dots[0,1] - dots[2,1];
        gradY24 = dots[1,1] - dots[3,1];
        gradY14 = dots[0,1] - dots[3,1];
        gradY23 = dots[1,1] - dots[2,1];
        
        if(gradX12*gradY34==gradX34*gradY12||gradX13*gradY24==gradX24*gradY13||gradX14*gradY23==gradX23*gradY14)
        {
            return 1;
        }
        else{
            return 0;
        }
        
    }
}