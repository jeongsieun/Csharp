using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jeongsieun_chapter5_ex4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput1 = "16";
        string userInput2 = "20";
        string userInput3 = "30";
        int number1 = int.Parse(userInput1);
        int number2 = int.Parse(userInput2);
        int number3 = int.Parse(userInput3);
        int maxNum = 0;
        int minNum = 0;
        
        if (number1 > number2 && number1 > number3)
        {
            maxNum = number1;
            
        }
        else if (number2 > number1 && number2 > number3)
        {
            maxNum = number2;
        }
        else
        {
            maxNum = number3;
        }

        if (number1 < number2 && number1 < number3)
        {
            minNum = number1;

        }
        else if (number2 < number1 && number2 < number3)
        {
            minNum = number2;
        }
        else
        {
            minNum = number3;
        }
        int sum = number1 + number2 + number3;
        int average = sum/3;

        Debug.Log($"�ִ밪 : {maxNum}");
        Debug.Log($"�ּҰ� : {minNum}");
        Debug.Log($"�հ� : {sum}");
        Debug.Log($"��� : {average}");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
