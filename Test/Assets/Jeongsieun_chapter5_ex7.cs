using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jeongsieun_chapter5_ex7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int userInput = 7;
        int day = 0;
        Debug.Log($"����� �ñ��ϼ���? {userInput}");

        switch(userInput)
        {
            case 1:
                day = 31;
                break;
            case 2:
                day = 28;
                break;
            case 3:
                day = 31;
                break;
            case 4:
                day = 30;
                break;
            case 5:
                day = 31;
                break;
            case 6:
                day = 30;
                break;
            case 7:
                day = 31;
                break;
            case 8:
                day = 31;
                break;
            case 9:
                day = 30;
                break;
            case 10:
                day = 31;
                break;
            case 11:
                day = 30;
                break;
            case 12:
                day = 31;
                break;
        }
        if (userInput > 12)
        {
            Debug.Log("�߸��� �Է� �Դϴ�.");
        }
        else
        {
            Debug.Log($"{userInput}���� : {day}�� ���� �ֽ��ϴ�.");
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
