using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operations : MonoBehaviour
{

    //operaciones buleanas
    /*public int x = 10;
    public int y = 4;
    private bool areEqual;
    private void Start()
    {
        areEqual = x == y;
        Debug.Log(areEqual);
    }*/

    /* private bool areEqual;

     public string name1 = "roberto";
     public string name2 = "alberto";
     private bool areDiffernt;

     private void Start()
     {

     areDiffernt = name1 != name2;
         Debug.Log(areDiffernt);
     }   */
    /*
    public float x = 2.0f;
    public float y = 0.5f;
    private bool isGreater;
    private void Start()
    {
        isGreater = x > y;
        Debug.Log(isGreater);

    }*/



    //Operaciones normales
    /*    public float x = 10;
        public float y = 5;
        public float result = 0;
        private void Start()
        {
            Debug.Log(result = x + y);
            Debug.Log(result = x - y);
            Debug.Log(result = x * y);
            Debug.Log(result = x / y);
            Debug.Log(result = x % y);
        }*/
    /*public bool isRaining = true;
    public float number;
    private bool isOn;*/
    private void Start()
    {

        /* if (number > 0)
         {
             Debug.Log($"El numero {number} es positivo");

         }
         if (isRaining == true)
         {
             Debug.Log(message: "true");
         }*/
    }
        private void Update ()
        {
        if (imput.getmousebutondown(0))
        {
            (Calculator(2, 3));
        }
        }   
     
    private void Calculator (float num1, float num2)
    {
        float result1 = num1 + num2;
        Debug.Log( message: $"{result1}");
        //Debug.Log( message:$"{x} + {y} = {x + y}");
        //Debug.Log( message:$"{x} - {y} = {x - y}");
        //Debug.Log( message:$"{x} * {y} = {x * y}");
        //Debug.Log( message:$"{x} / {y} = {x / y}");
    }
}