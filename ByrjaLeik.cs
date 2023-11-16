using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ByrjaLeik : MonoBehaviour // Klasi
{
    public void Byrja() // Þetta er til þess að byrja leikinn 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
