using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleControl : MonoBehaviour
{
    private ParticleSystem partsys;
    public void LoopingOnOff()
    {
        partsys = GetComponent<ParticleSystem>();
        partsys.Stop();

        var particlemainSetiings = partsys.main;
        particlemainSetiings.loop ^= true;

        partsys.Play();
    }
}
