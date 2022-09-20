using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    protected Rigidbody2D RB;
    
    [SerializeField] protected float curVelocity;

    private void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    public void MovePlayer(Vector2 movementInput)
    {
        RB.velocity = movementInput.normalized * curVelocity;


    }



}
