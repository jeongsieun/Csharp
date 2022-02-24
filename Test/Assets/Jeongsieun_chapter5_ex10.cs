using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jeongsieun_chapter5_ex10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 4; i > 0; i--)
        {
            string star = " ";

            for(int j = 1; j < 5; j++)
            {
                star += "¡Ú"; 
            }
            for (int k = i; k > 0; k--)
            {
                star += "¡Ù";
            }



            Debug.Log(star);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
