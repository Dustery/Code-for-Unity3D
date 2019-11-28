using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlayer : MonoBehaviour
{
    
    public GameObject player1;
    public float range = 1f, moveSpeed = 5f, turnSpeed = 25f;
   
    void Start()
    {
        player1 = (GameObject)this.gameObject;
    }

    
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
            player1.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
            player1.transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
            player1.transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            player1.transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
            


}

}
