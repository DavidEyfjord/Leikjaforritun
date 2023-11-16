using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] float SpeedX; // gildi til þess að gera breytanlegt með serializefield.
    [SerializeField] float SpeedY;
    [SerializeField] float SpeedZ;


    void Update()
    {
        transform.Rotate(360 * SpeedX * Time.deltaTime, 360 * SpeedY * Time.deltaTime, 360 * SpeedZ * Time.deltaTime); // til þess að láta peninga snúast 180 gráður á sekúndu.
    }
}
