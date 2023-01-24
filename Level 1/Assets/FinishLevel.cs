using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{
    public float hits = 0;
    [SerializeField] GameObject levelComplete;


    void OnTriggerEnter(Collider damage)
    {

        if (damage.tag == "checkpoint")
        {
            hits++;
            if (hits == 4)
            {
                hits = 0;
                Time.timeScale = 0f;
                levelComplete.SetActive(true);

            }
            //Destroy(gameObject);
            //gameObject.SetActive(false);
        }
    }

    

    
}
