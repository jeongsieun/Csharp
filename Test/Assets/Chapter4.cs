using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a;
        a = 100;
        Debug.Log($"a = 100 : {a}");
        a += 90;
        Debug.Log($"a += 90 : {a}");
        a -= 80;
        Debug.Log($"a -= 80 : {a}");
        a *= 70;
        Debug.Log($"a *= 70 : {a}");
        a /= 60;
        Debug.Log($"a /= 60 : {a}");
        a %= 50;
        Debug.Log($"a %= 50 : {a}");


        //string result = (10 % 2) == 0 ? "Â¦¼ö" : "È¦¼ö";
        //Debug.Log(result);

        //Debug.Log("Testing &&...");
        //Debug.Log($"1 > 0 && 4 < 5 : {1 > 0 && 4 < 5}");
        //Debug.Log($"1 > 0 && 4 > 5 : {1 > 0 && 4 > 5}");
        //Debug.Log($"1 == 0 && 4 > 5 : {1 == 0 && 4 > 5}");
        //Debug.Log($"1 == 0 && 4 < 5 : {1 == 0 && 4 < 5}");

        //Debug.Log("Testing ||...");
        //Debug.Log($"1 > 0 || 4 < 5 : {1 > 0 || 4 < 5}");
        //Debug.Log($"1 > 0 || 4 > 5 : {1 > 0 || 4 > 5}");
        //Debug.Log($"1 == 0 || 4 > 5 : {1 == 0 || 4 > 5}");
        //Debug.Log($"1 == 0 || 4 < 5 : {1 == 0 || 4 < 5}");

        //Debug.Log("Testing !...");
        //Debug.Log($"!True : {!true}");
        //Debug.Log($"!False : {!false}");

        //Debug.Log($"3 > 4 : {3 > 4}");
        //Debug.Log($"3 >= 4 : {3 >= 4}");
        //Debug.Log($"3 < 4 : {3 < 4}");
        //Debug.Log($"3 <= 4 : {3 <= 4}");
        //Debug.Log($"3 == 4 : {3 == 4}");
        //Debug.Log($"3 != 4 : {3 != 4}");

        //int a = 10;
        //Debug.Log(a++);
        //Debug.Log(++a);

        //Debug.Log(a--);
        //Debug.Log(--a);

        //int a = 111 + 222;
        //Debug.Log($"a : {a}");

        //int b = a - 100;
        //Debug.Log("b : "+b);

        //int c = b * 10;
        //Debug.Log($"c : {c}");

        //float d = c / 6.3f;
        //Debug.Log("d : "+d);

        //Debug.Log($"22 / 7 =  {22/7} ( {22%7} )");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
