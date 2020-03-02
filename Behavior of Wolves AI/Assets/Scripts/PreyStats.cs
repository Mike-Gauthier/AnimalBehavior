using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreyStats : MonoBehaviour
{
    public enum PreyStates
    {
        Idle,
        Graze,
        Defend, //does not fight but holds position
        Flee
    }

    public float preyHealth; //health of the prey animal
    public float nervousness; //nervousness = preyhealh * 2
    public int threshHold; //if threshhold > nervousness enter flee state
    public bool isSick; //random number select, penalizes health if true
    public bool isOld; //random number select penalizes health if true
    public bool isAlone;//if animal splits away from herd increase priority
    public Rigidbody rb;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
