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
        //    Debug.Log($"{i} : Ȧ��");
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

        //// �л� ���� 5���� �б��� ������ ������ ����
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
        //        Debug.Log("�÷��̾�� �������Դϴ�.");
        //        break;
        //    case CharacterState.WALK:
        //        Debug.Log("�÷��̾�� �ȴ� ���Դϴ�.");
        //        break;
        //    case CharacterState.ATTACK:
        //        Debug.Log("�÷��̾�� ���� ���Դϴ�.");
        //        break;
        //    case CharacterState.JUMP:
        //        Debug.Log("�÷��̾ ���� ���Դϴ�.");
        //        break;
        //    case CharacterState.DIE:
        //        Debug.Log("�÷��̾ �׾����ϴ�.");
        //        break;
        //}

        //enum CharacterState { IDLE, WALK, ATTACK,}
        //// �������� ���ϴ� ������ �Է��ϼ���.
        //string day = "��";

        //switch(day)
        //{
        //    case "��":
        //        Debug.Log("Sunday");
        //        break;
        //    case "��":
        //        Debug.Log("Munday");
        //        break;
        //    case "ȭ":
        //        Debug.Log("Tuseday");
        //        break;
        //    case "��":
        //        Debug.Log("Wednesday");
        //        break;
        //    case "��":
        //        Debug.Log("Thursday");
        //        break;
        //    case "��":
        //        Debug.Log("Friday");
        //        break;
        //    case "��":
        //        Debug.Log("Saturday");
        //        break;
        //    default:
        //        Debug.Log($"{day}��(��) ������ �ƴմϴ�.");
        //        break;
        //}

        //string userInput = "10";

        //int number = int.Parse(userInput);
        //if(number > 0)
        //{
        //    //if (number % 2 == 0)
        //    //{
        //    //    Debug.Log("0���� ū ¦��.");
        //    //}
        //    //else
        //    //{
        //    //    Debug.Log("0���� ū Ȧ��.");
        //    //}

        //    string result = (number % 2 == 0) ? "0���� ū ¦��" : "0���� ū Ȧ��";
        //    Debug.Log(result);
        //}
        //else
        //{
        //    Debug.Log("0���� �۰ų� ���� ��.");
        //}

        //string userinput = "10";

        //int number = int.Parse(userinput);
        //if (number < 0)
        //{
        //    Debug.Log("����");
        //}
        //else if (number > 0)
        //{
        //    Debug.Log("���");
        //}
        //else
        //{
        //    Debug.Log("0");
        //}

        //if(number % 2 == 0)
        //{
        //    Debug.Log("¦��");
        //}
        //else
        //{
        //    Debug.Log("Ȧ��");
        //}

        //string result = (number % 2 == 0) ? "¦��" : "Ȧ��";
        //Debug.Log((number % 2 == 0) ? "¦��" : "Ȧ��");
    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
