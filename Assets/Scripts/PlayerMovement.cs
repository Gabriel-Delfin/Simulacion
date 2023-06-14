using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            transform.Translate(0,1f,0);
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            transform.Translate(0,-1f,0);
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            transform.Translate(-1,0,0);
        else if (Input.GetKeyDown(KeyCode.RightArrow))
            transform.Translate(1,0,0);
    }
}
