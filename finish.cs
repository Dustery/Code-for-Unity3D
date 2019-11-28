using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.UI;

public class finish : MonoBehaviour
{  
    [SerializeField]Collider player1;
    [SerializeField]Collider player2;
   // [SerializeField]Text win;
    private bool winPlace = false;
    private string winner; 


    void OnGUI()
    {
        if (winPlace)
        {
            int w = Screen.width, h = Screen.height;

            GUIStyle style = new GUIStyle();

            Rect rect = new Rect(0, 0, w, h);
            style.alignment = TextAnchor.MiddleCenter;
            style.fontSize = h * 2 / 50;
            style.normal.textColor = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            string text = string.Format("Great! " + winner + " win!");
            GUI.Label(rect, text, style);

            
        }
    }  

    public void OnTriggerEnter(Collider col){ 
        winPlace = true;
        
        if(col.name == "player1"){
            Debug.Log("Player 1 won!");
            winner ="Green player";
        }
            else if(col.name == "player2"){
            Debug.Log("Player 2 won!");
            winner ="Red player";
        }
    }

}