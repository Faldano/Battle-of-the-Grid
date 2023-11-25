using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turrent_logic : MonoBehaviour
{
    // Shooting Variable
    [SerializeField] ParticleSystem cannon;
    [SerializeField] float fireRate;
    bool fireCooldown;

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
    //---------------Shooting Controller
    void ShootCannon()
    {
        if (Input.GetButton("Jump"))
        { 
            if (fireCooldown) return;
            cannon.Emit(1); //shoot particle 1 at a time
            fireCooldown = true;
            StartCoroutine(StopCoolDownAfterTime());
        }
        else
        {
            return;
        }

        IEnumerator StopCoolDownAfterTime()
        {
            yield return new WaitForSeconds(fireRate);
            fireCooldown = false;
        }
    }
    


}

