using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
   public LineRenderer lineRenderer;

    float DelayTime;


    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        DelayTime = 4.5f;

    }


    public IEnumerator LaserShoot()
    {
        lineRenderer.enabled = true;
        yield return new WaitForSeconds(DelayTime);
        lineRenderer.enabled = false;
        
    }
}
