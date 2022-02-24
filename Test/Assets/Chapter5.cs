using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5 : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("1");
        goto JUMP;
        Debug.Log("2");
        Debug.Log("3");
        JUMP:
        Debug.Log("4");

        //for(int i = 0; i < 10; i++)
        //{
        //    if(i % 2 == 0)
        //    {
        //        continue;
        //    }
        //    Debug.Log($"{i} : 홀수");
        //}

        //int i = 0;

        //while(i>=0)
        //{
        //    if(i==10)
        //    {
        //        break;
        //    }
        //    Debug.Log(i++);
        //}
        //Debug.Log("Prison Break");

        //int[] arr = new int[] { 0, 1, 2, 3, 4 };
        //foreach(int a in arr)
        //{
        //    Debug.Log(a);
        //}

        //// 학생 수가 5명인 학급의 성적을 변수로 선언
        //int students1 = 100;
        //int students2 = 90;
        //int students3 = 98;
        //int students4 = 95;
        //int students5 = 99;

        //for(int i = 0; i<5; i++)
        //{
        //    for(int j = 0; j <= i; j++)
        //    {
        //        Debug.Log("*"); 
        //    }
        //}

        //for(int i = 0; i>5; i++)
        //{
        //    Debug.Log(i);
        //}

        //int i = 3;

        //do
        //{
        //    Debug.Log($"a) i : {i--}");
        //}
        //while (i > 0);

        //do
        //{
        //    Debug.Log($"b) i : {i--}");
        //}
        //while (i > 0);

        //int i = 10;

        //while(i>0)
        //{
        //    Debug.Log($"i:{i--}");
        //}

        ////enum CharacterState { IDLE, WALK, ATTACK, JUMP, DIE }
        //CharacterState player = CharacterState.WALK;
        //switch (player)
        //{
        //    case CharacterState.IDLE:
        //        Debug.Log("플레이어는 대기상태입니다.");
        //        break;
        //    case CharacterState.WALK:
        //        Debug.Log("플레이어는 걷는 중입니다.");
        //        break;
        //    case CharacterState.ATTACK:
        //        Debug.Log("플레이어는 공격 중입니다.");
        //        break;
        //    case CharacterState.JUMP:
        //        Debug.Log("플레이어가 점프 중입니다.");
        //        break;
        //    case CharacterState.DIE:
        //        Debug.Log("플레이어가 죽었습니다.");
        //        break;
        //}

        //enum CharacterState { IDLE, WALK, ATTACK,}
        //// 여러분이 원하는 요일을 입력하세요.
        //string day = "수";

        //switch(day)
        //{
        //    case "일":
        //        Debug.Log("Sunday");
        //        break;
        //    case "월":
        //        Debug.Log("Munday");
        //        break;
        //    case "화":
        //        Debug.Log("Tuseday");
        //        break;
        //    case "수":
        //        Debug.Log("Wednesday");
        //        break;
        //    case "목":
        //        Debug.Log("Thursday");
        //        break;
        //    case "금":
        //        Debug.Log("Friday");
        //        break;
        //    case "토":
        //        Debug.Log("Saturday");
        //        break;
        //    default:
        //        Debug.Log($"{day}는(은) 요일이 아닙니다.");
        //        break;
        //}

        //string userInput = "10";

        //int number = int.Parse(userInput);
        //if(number > 0)
        //{
        //    //if (number % 2 == 0)
        //    //{
        //    //    Debug.Log("0보다 큰 짝수.");
        //    //}
        //    //else
        //    //{
        //    //    Debug.Log("0보다 큰 홀수.");
        //    //}

        //    string result = (number % 2 == 0) ? "0보다 큰 짝수" : "0보다 큰 홀수";
        //    Debug.Log(result);
        //}
        //else
        //{
        //    Debug.Log("0보다 작거나 같은 수.");
        //}

        //string userinput = "10";

        //int number = int.Parse(userinput);
        //if (number < 0)
        //{
        //    Debug.Log("음수");
        //}
        //else if (number > 0)
        //{
        //    Debug.Log("양수");
        //}
        //else
        //{
        //    Debug.Log("0");
        //}

        //if(number % 2 == 0)
        //{
        //    Debug.Log("짝수");
        //}
        //else
        //{
        //    Debug.Log("홀수");
        //}

        //string result = (number % 2 == 0) ? "짝수" : "홀수";
        //Debug.Log((number % 2 == 0) ? "짝수" : "홀수");
    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
