using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User_logic : MonoBehaviour
{
    [SerializeField] float speed = 1;
    public bool userIsAlive;
    // Start is called before the first frame update
    void Start()
    {
        userIsAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        UserMovement();
    }

    void UserMovement()
    {
        if (userIsAlive)
        {
            // gameobject movement control
            // TOBE IMPROVE: improve by make it cannot move diagonal
            float xInput = Input.GetAxis("Horizontal");
            float zInput = Input.GetAxis("Vertical");
            Vector3 direction = new Vector3(xInput, 0, zInput);
            //make sure return in magnitude of 1.
            direction.Normalize();
            // move the gameobject
            transform.Translate(direction * speed * Time.deltaTime, Space.World);
            // turn the face of gameobject to the direction it face
            if( direction != Vector3.zero)
            {
                transform.forward = direction;
            }
        }
    }
}
