using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] float SpeedX; // gildi til �ess a� gera breytanlegt me� serializefield.
    [SerializeField] float SpeedY;
    [SerializeField] float SpeedZ;


    void Update()
    {
        transform.Rotate(360 * SpeedX * Time.deltaTime, 360 * SpeedY * Time.deltaTime, 360 * SpeedZ * Time.deltaTime); // til �ess a� l�ta peninga sn�ast 180 gr��ur � sek�ndu.
    }
}
