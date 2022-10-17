using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    //variables
    public int playerAge = 22;
    public float playerSpeed = 3.45f;
    public string playerName = "harck";
    public bool gameOver = false;

    public string message = "Hola mundo";
    public int points = 256;


    /*   private void Start()
       {
           Debug.Log(message) ;
           Debug.Log(points);
           Debug.Log($"Tengo {points} puntos");
           Debug.Log(message: string.Format("Tengo {0} puntos", points));
           Debug.Log(message: string.Format("Hola {0} tienes {1} puntos", playerName, points));
           Debug.Log(message: "Tengo " + points + " puntos");
       }
   }*/

    public float x = 0;
    public float y = 2;
    private void Start()
    {
        x = x + y;
        Debug.Log(x);

    }
}