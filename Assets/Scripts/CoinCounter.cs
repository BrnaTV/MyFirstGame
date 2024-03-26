using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    private static int coinAmount;

    private void OnTriggerEnter(Collider col)
    {
        CoinCounter.coinAmount += 1;
        Destroy(gameObject);  
    }
}
