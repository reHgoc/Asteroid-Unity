using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIManager : MonoBehaviour
{
    [Header("Speed category")]
    protected float SpeedShip;
    protected float ChangeSpeed = 0.05f;
    protected float rotSpeed    = 50f;

    [Header("Moving and Rotatate vectors")]
    protected Vector2 vertical = Vector2.zero;
    protected Vector2 rot      = Vector2.zero;
    protected Vector2 newPos;

    [Header("Bullet and target position")]
    protected Transform firePoint;
    protected Transform Target;

    protected int Lives;
    protected int BulletCounts;

    protected float LaserRate;
    protected float FireRate;


}
