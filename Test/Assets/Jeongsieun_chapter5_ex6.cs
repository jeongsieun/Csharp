using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jeongsieun_chapter5_ex6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput1 = "10";
        string userInput2 = "2";
        string userInput3 = "/";
        int number1 = int.Parse(userInput1);
        int number2 = int.Parse(userInput2);
        int result = 0;

        switch(userInput3)
        {
            case "+":
                result = number1 + number2;
                break;
            case "-":
                result = number1 - number2;
                break;
            case "*":
                result = number1 * number2;
                break;
            case "/":
                result = number1 / number2;
                break;
            case "%":
                result = number1 % number2;
                break;
            
        }


        Debug.Log($"입력하신 {userInput1}{userInput3}{userInput2}의 값은 {result}입니다.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
