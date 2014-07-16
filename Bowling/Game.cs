using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    public class Game
    {
        int[] frame = new int[20];
        int rolls = 0;
        int score = 0;
        public void Roll(int pins)
        {
            if (pins == 10)
            {
                frame[rolls++] = pins;
                frame[rolls++] = 0;
            }
            else frame[rolls++] = pins;
            //Console.WriteLine("frame[{0}]={1}",i,frame[i]);
        }

        public int GetScore()
        {
            int j = 0;
            for (j = 0; j < 20; j++)
            {
                if ((j % 2 == 0) && (frame[j] == 10) && (frame[j+2]==10))
                    score = score + frame[j+2]+frame[j+4];
                else if ((j % 2 == 0) && (frame[j + 2] == 10))
                    score = score + frame[j + 2] + frame[j + 3];
                else if ((j%2==0) && ((frame[j]+frame[j+1])==10))
                    score=score+frame[j+2];
                
                
                score=score+frame[j];
            }
            return score;
           

        }
    }
}

    

