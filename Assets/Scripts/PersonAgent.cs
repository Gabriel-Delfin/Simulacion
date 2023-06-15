using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonAgent : MonoBehaviour
{
    public string id;
    public string type;
    public int[] positionToBe = new int[] { 0, 0 }; 
    public Sprite victimSprite;

    public float moveSpeed = 5f;
    public LayerMask whatStopsMovement;

    void Start()
    {
        if (type == "victim")
        {
            // Get the SpriteRenderer component attached to the current GameObject
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

            if (spriteRenderer != null)
            {
                // Change the sprite to the newSprite
                spriteRenderer.sprite = victimSprite;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = new Vector3(positionToBe[0], positionToBe[1], 0);
        transform.position = Vector3.MoveTowards(transform.position, newPosition, moveSpeed * Time.deltaTime);

        // if (Vector3.Distance (transform.position, newPosition) <= .05f)
        // {
        //     if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
        //     {
        //         if (!Physics2D.OverlapCircle(newPosition + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), .2f, whatStopsMovement))
        //         {
        //             newPosition += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
        //         }
        //     }

        //     if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
        //     {
        //         if (!Physics2D.OverlapCircle(newPosition + new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f), .2f, whatStopsMovement))
        //         {
        //             newPosition += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
        //         }
        //     }
        // }

        
    }
}
