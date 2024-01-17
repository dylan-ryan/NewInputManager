using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; // new input system

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //OnMove is based on "Move" name inside player input manager //OnLook would == "Look" //OnFire would == "Fire"
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        Vector3 movementVector3;
        movementVector3.x = movementVector.x;
        movementVector3.y = 0f;
        movementVector3.z = movementVector.y;
        gameObject.transform.Translate(movementVector3);
        
        Debug.Log("movementVector: " + movementVector);
    }
    
}
