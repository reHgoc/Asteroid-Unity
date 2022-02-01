using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float SpeedShip = 3f;
    public void Moving()
    {
        transform.Translate(Vector3.up * SpeedShip * Time.fixedDeltaTime);
    }
}
