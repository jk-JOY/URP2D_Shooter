using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/MovementData")]
public class MovementDataSO : ScriptableObject 
{

    [Range(1,10)] public float maxSpeed = 5;

    [Range(0.1f,100)] public float aceleration =50, deAceleration = 50; //가속도  /감속



}
