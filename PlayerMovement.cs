using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour //h�rna addar ma�ur components inn � scripti� inn � spilara objecti�. me�al annars til �ess a� leyfa spilara a�eins a� hoppa ef a� hann er � j�r�inni, svo ekki s� h�gt a� hoppa � mi�ju lofti.
{
    Rigidbody rb;
    [SerializeField] float movementSpeed = 7f;
    [SerializeField] float jumpForce = 6f;

    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //value fyrir rigidbody til �ess a� breyta �v�.
    }


    void Update() // h�rna eru allskonar form�lur og gildi til �ess a� hreyfa spilarann, eins og til �ess a� hoppa, fara �fram, aftur, h�gri og vinstri.
    {
        float horizonalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horizonalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);

        if (Input.GetButtonDown("Jump") && IsGrounded()) // m� bara hoppa ef �tt er � space og er � j�r�inni
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        }
    }

    bool IsGrounded() // sko�ar hvort a� l�till kubbur undir spilaranum s� � j�r�inni.
    {
        return Physics.CheckSphere(groundCheck.position, 0.1f, ground);
    }
}