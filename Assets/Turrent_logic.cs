using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turrent_logic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TurretRotate();
    }

    private void TurretRotate()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.Rotate(0, -90, 0);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            transform.Rotate(0, 90, 0);
        }
    }
    void ShootGun()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("fire!");
        }
    }
}
