using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    

    float SpeedShip;
    float ChangeSpeed = 0.05f;
    float rotSpeed = 20f;
    Vector2 vertical = Vector2.zero;
    Vector2 rot = Vector2.zero;
    Vector2 newRot;
    Vector2 newPos;
    PlayerControls controls;

    void Awake()
    {
        controls = new PlayerControls();

        controls.Player.Move.performed += context => vertical = context.ReadValue<Vector2>();
        controls.Player.Look.performed += cntx    => rot      = cntx.ReadValue<Vector2>();
        controls.Player.Look.canceled  += cntx    => rot      = Vector2.zero;
        controls.Player.Move.canceled  += context => vertical = newPos;

      
    }

     void Start()
    {
       
        
    }

  

     void Movement()
    {
        SpeedShip = Mathf.Clamp((SpeedShip + ChangeSpeed) * Time.fixedDeltaTime, 0.3f, 3f);
        newPos = vertical * SpeedShip;
        transform.Translate(newPos * Time.fixedDeltaTime);

    }

    public void Rotate()
    {

        // float angle = Mathf.Atan2(rot.y, rot.x) * Mathf.Rad2Deg;
        // transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle + rot.x)).normalized;
        this.transform.Rotate(new Vector3(0f,0f, (rot.x * rotSpeed) * -1f)  * Time.fixedDeltaTime);
        print(rot);
    }

    private void FixedUpdate()
    {
        Movement();
        
        if(rot.magnitude != 0f)
        {
            Rotate();
            
        }
        

    }


     void OnEnable()
    {
        controls.Player.Enable();
    }
     void OnDisable()
    {
        controls.Player.Disable();
    }
}
