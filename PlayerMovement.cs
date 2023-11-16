using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour //hérna addar maður components inn í scriptið inn í spilara objectið. meðal annars til þess að leyfa spilara aðeins að hoppa ef að hann er á jörðinni, svo ekki sé hægt að hoppa í miðju lofti.
{
    Rigidbody rb;
    [SerializeField] float movementSpeed = 7f;
    [SerializeField] float jumpForce = 6f;

    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //value fyrir rigidbody til þess að breyta því.
    }


    void Update() // hérna eru allskonar formúlur og gildi til þess að hreyfa spilarann, eins og til þess að hoppa, fara áfram, aftur, hægri og vinstri.
    {
        float horizonalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horizonalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);

        if (Input.GetButtonDown("Jump") && IsGrounded()) // má bara hoppa ef ýtt er á space og er á jörðinni
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        }
    }

    bool IsGrounded() // skoðar hvort að lítill kubbur undir spilaranum sé á jörðinni.
    {
        return Physics.CheckSphere(groundCheck.position, 0.1f, ground);
    }
}