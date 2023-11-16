using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; // til �ess a� nota TMP texta og svo framvegis.
public class ItemCollector : MonoBehaviour
{
    int coins = 0; // byrjar � 0 peningum .
    [SerializeField] TMP_Text coinsText; 
    private void OnTriggerEnter(Collider other) // �etta er til �ess a� ef a� playerinn snertir pening �� ey�ir �etta peningnum og pl�sar 1 vi� n�verandi magn af peningum.
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coins++;
            coinsText.text = "Coins: " + coins;
        }

    }
}
