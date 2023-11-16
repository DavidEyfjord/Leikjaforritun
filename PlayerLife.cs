using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    bool dead = false; // spilari byrjar ekki dáinn.

    private void Update() // þetta er til þess að ef að spilarinn dettur af kortinu þá deyr hann, en það er ekki hægt eins og ég byggði kortið.
    {
      if (transform.position.y < -1f && !dead)
        {
            Die(); 
        }
    }
    private void OnCollisionEnter(Collision collision) // þetta er til þess að ef að spilarinn fer í hindrun þá deir hann og "respawnar"
    {
        if (collision.gameObject.CompareTag("EnemyBody"))
        {
            Die();
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<PlayerMovement>().enabled = false;
        }
    }

    void Die() // fallið til þess að deyja, með einna sekúndna bið, til þess að það líti út þæginlegra.
    {
        Invoke(nameof(ReloadLevel), 1.0f); 
        dead = true;
    }

    void ReloadLevel() // reloadar levelinu.
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
