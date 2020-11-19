using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinPicker : MonoBehaviour
{
    public GameObject particleFX;

    private float Coin = 0;

    public TextMeshProUGUI textCoins;

    private void OnTriggerEnter2D(Collider2D other)
    {
       
     if(other.transform.tag == "Coin")
        {
            Coin ++;
            textCoins.text = Coin.ToString();
            Instantiate(particleFX, transform.position, transform.rotation);

            Destroy(other.gameObject);
        }   
    }

}
