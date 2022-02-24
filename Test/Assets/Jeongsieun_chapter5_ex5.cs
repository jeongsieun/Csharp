using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jeongsieun_chapter5_ex5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userYear = "3";
        string userScore = "160";
        int year = int.Parse(userYear);
        int score = int.Parse(userScore);

        if(year == 4)
        {
            if(score >= 70 && score <= 100)
            {
                Debug.Log("합격");
            }
            else if (score >100 || score < 0)
            {
                Debug.Log("잘못된 입력");
            }
            else
            {
                Debug.Log("불합격");
            }
        }
        else if (year != 4 && year < 4)
        {
            if(score >= 60 && score <= 100)
            {
                Debug.Log("합격");
            }
            else if (score > 100 || score < 0)
            {
                Debug.Log("잘못된 입력");
            }
            else
            {
                Debug.Log("불합격");
            }

        }
        else
        {
            Debug.Log("잘못된 입력");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
