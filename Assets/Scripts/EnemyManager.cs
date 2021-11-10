using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{ 
    private void OnCollisionEnter(Collision collision)
    { 
            if (collision.gameObject.tag == "player")
            {
                this.gameObject.SetActive(false);
            }    
    }

    void update()
    {
        transform.Rotate(new Vector3(15, 30, 40) * Time.deltaTime);
    }

}
