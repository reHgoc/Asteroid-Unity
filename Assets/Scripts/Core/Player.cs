using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    float SpeedShip;
    float ChangeSpeed = 0.25f;
    Vector2 vertical = Vector2.zero;
    PlayerControls controls;

    void Awake()
    {
        controls = new PlayerControls();

        controls.Player.Move.performed += context => vertical = context.ReadValue<Vector2>();
        controls.Player.Move.canceled += context => vertical = Vector2.zero;
    }

    private void Start()
    {
        SpeedShip = Mathf.Clamp(SpeedShip, .3f, 3f);
    }

  

     void Movement()
    {
        Vector2 currentPosition = gameObject.transform.position;
        SpeedShip += Time.fixedDeltaTime * ChangeSpeed;
        Vector2 newPos = currentPosition + (vertical * SpeedShip);
        transform.Translate(newPos * Time.fixedDeltaTime);

        
    }
    
    private void FixedUpdate()
    {
        Movement();
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
