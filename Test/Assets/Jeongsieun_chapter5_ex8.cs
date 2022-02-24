using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jeongsieun_chapter5_ex8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int userInput = 1;
        string season = " ";
        if (userInput == 0 || userInput > 12)
        {
            Debug.Log("잘못된 입력");
        }
        else
        {
            if (userInput >= 3 && userInput <= 5)
            {
                season = "봄";
            }
            else if (userInput >= 6 && userInput <= 8)
            {
                season = "여름";
            }
            else if (userInput >= 9 && userInput <= 11)
            {
                season = "가을";
            }
            else if (userInput <= 2 || userInput <= 12)
            {
                season = "겨울";
            }
            Debug.Log($"{userInput}월 : {season}");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
