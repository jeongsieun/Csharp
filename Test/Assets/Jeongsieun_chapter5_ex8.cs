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
            Debug.Log("�߸��� �Է�");
        }
        else
        {
            if (userInput >= 3 && userInput <= 5)
            {
                season = "��";
            }
            else if (userInput >= 6 && userInput <= 8)
            {
                season = "����";
            }
            else if (userInput >= 9 && userInput <= 11)
            {
                season = "����";
            }
            else if (userInput <= 2 || userInput <= 12)
            {
                season = "�ܿ�";
            }
            Debug.Log($"{userInput}�� : {season}");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
