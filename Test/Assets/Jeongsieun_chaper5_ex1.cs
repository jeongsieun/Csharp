using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jeongsieun_chaper5_ex1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //        ������� ������ �Է¹޾� 90�� �̻��� ��A��, 
        //80�� �̻��� ��B��, 70�� �̻��� ��C��, 
        //69�� ���� ������ ��F�� �� ��µǴ� ���α׷���
        //����� �ּ���

        string userInput = "70";
        int userScore = int.Parse(userInput);

        string score = " ";

        if(userScore >= 90)
        {
            score = "A";
            //Debug.Log($"�Է��Ͻ� ���� {userScore}��(��)" + $"A���� �Դϴ�.");
        }
        else if(userScore >= 80)
        {
            score = "B";
            //Debug.Log($"�Է��Ͻ� ���� {userScore}��(��)" + $"B���� �Դϴ�.");
        }
        else if(userScore >= 70)
        {
            score = "C";
            //Debug.Log($"�Է��Ͻ� ���� {userScore}��(��)" + $"C���� �Դϴ�.");
        }
        else
        {
            score = "F";
            //Debug.Log($"�Է��Ͻ� ���� {userScore}��(��)" + $"F���� �Դϴ�.");
        }

        Debug.Log($"�Է��Ͻ� ���� {userScore}��(��)" + $"{score} ���� �Դϴ�.");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
