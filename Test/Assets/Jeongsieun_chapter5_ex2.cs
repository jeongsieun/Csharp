using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jeongsieun_chapter5_ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "53";
        int number = int.Parse(userInput);


        if(number >= 50)
        {
            Debug.Log("50�̻��� ��");
        }
        else
        {
            Debug.Log("50�̸��� ��");
        }

       // Debug.Log(userScore)

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
