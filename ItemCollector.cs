using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; // til þess að nota TMP texta og svo framvegis.
public class ItemCollector : MonoBehaviour
{
    int coins = 0; // byrjar á 0 peningum .
    [SerializeField] TMP_Text coinsText; 
    private void OnTriggerEnter(Collider other) // þetta er til þess að ef að playerinn snertir pening þá eyðir þetta peningnum og plúsar 1 við núverandi magn af peningum.
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coins++;
            coinsText.text = "Coins: " + coins;
        }

    }
}
