using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) // i sta�inn fyrir a� byrja leikinn eins og � Byrjaleik.cs a� �� fer �etta � n�stu senu.
    {
        if (other.gameObject.name == "Spilari")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
