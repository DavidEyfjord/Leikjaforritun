using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) // i staðinn fyrir að byrja leikinn eins og í Byrjaleik.cs að þá fer þetta í næstu senu.
    {
        if (other.gameObject.name == "Spilari")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
