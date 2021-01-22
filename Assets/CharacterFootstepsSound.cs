using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFootstepsSound : MonoBehaviour
{
   
    public float footStepDelay = 0.3f;

    private float nextFootstep = 0;



    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S)
            || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W))
        {
            nextFootstep -= Time.deltaTime;
            if (nextFootstep <= 0)
            {
                AkSoundEngine.PostEvent("pcFootsteps", gameObject);
               nextFootstep += footStepDelay;
           }
        }

        

    }










}