using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turrent_logic : MonoBehaviour
{

    [SerializeField] GameObject cannon;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TurretRotate();
        ShootCannon();
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
    void ShootCannon()
    {
        if (Input.GetButton("Jump"))
        {
            FireCannon(true);
            Debug.Log("fire!");
        }
        else
        {
            FireCannon(false);
        }
    }
    //shoot particle 1 at a time
    void FireCannon(bool isActive)
    {
        var shell = cannon.GetComponent<ParticleSystem>().emission;
        shell.enabled = isActive;
    }

}

