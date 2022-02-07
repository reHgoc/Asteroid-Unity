using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    LineRenderer lineRenderer;

    float DelayTime;

    bool isCanShoot = true;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        DelayTime = 4.5f;
        //Invoke()
    }

    public IEnumerator LaserShoot()
    {
        isCanShoot = false;
        //lineRenderer.SetPosition(1, new Vector3(0f, 20f, 0f));
       // lineRenderer.startWidth = 0f;
       // lineRenderer.endWidth = 100f;
        yield return new WaitForSeconds(DelayTime);
        isCanShoot = true;
    }
}
