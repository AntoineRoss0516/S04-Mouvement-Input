using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poursuite : MonoBehaviour
{
    [SerializeReference] GameObject poissonCible;
    [SerializeField] private float vitesse;

    void Update()
    {
        transform.LookAt(poissonCible.transform);
        transform.Translate(0, 0, vitesse * Time.deltaTime, Space.Self);
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
