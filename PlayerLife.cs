using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    bool dead = false; // spilari byrjar ekki d�inn.

    private void Update() // �etta er til �ess a� ef a� spilarinn dettur af kortinu �� deyr hann, en �a� er ekki h�gt eins og �g bygg�i korti�.
    {
      if (transform.position.y < -1f && !dead)
        {
            Die(); 
        }
    }
    private void OnCollisionEnter(Collision collision) // �etta er til �ess a� ef a� spilarinn fer � hindrun �� deir hann og "respawnar"
    {
        if (collision.gameObject.CompareTag("EnemyBody"))
        {
            Die();
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<PlayerMovement>().enabled = false;
        }
    }

    void Die() // falli� til �ess a� deyja, me� einna sek�ndna bi�, til �ess a� �a� l�ti �t ��ginlegra.
    {
        Invoke(nameof(ReloadLevel), 1.0f); 
        dead = true;
    }

    void ReloadLevel() // reloadar levelinu.
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
