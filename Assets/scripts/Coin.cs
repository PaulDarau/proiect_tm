using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Coin : MonoBehaviour
{
    
    void Start()
    {
       
    }
    void Update()
    {
        transform.Rotate(20 * Time.deltaTime, 0, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            Debug.Log("Coins:" + PlayerManager.numberOfCoins);
            PlayerManager.numberOfCoins += 1;
            Destroy(gameObject);

        }
    }
}
