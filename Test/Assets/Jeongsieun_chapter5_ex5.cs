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
                Debug.Log("�հ�");
            }
            else if (score >100 || score < 0)
            {
                Debug.Log("�߸��� �Է�");
            }
            else
            {
                Debug.Log("���հ�");
            }
        }
        else if (year != 4 && year < 4)
        {
            if(score >= 60 && score <= 100)
            {
                Debug.Log("�հ�");
            }
            else if (score > 100 || score < 0)
            {
                Debug.Log("�߸��� �Է�");
            }
            else
            {
                Debug.Log("���հ�");
            }

        }
        else
        {
            Debug.Log("�߸��� �Է�");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
