using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ByrjaLeik : MonoBehaviour // Klasi
{
    public void Byrja() // �etta er til �ess a� byrja leikinn 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
