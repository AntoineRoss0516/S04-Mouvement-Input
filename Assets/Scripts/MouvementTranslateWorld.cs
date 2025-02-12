using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementTranslateWorld : MonoBehaviour
{
    [SerializeField] private Vector3 _deplacement;
    void Update()
    {
        transform.Translate(0, 0, 1f * Time.deltaTime);
        //Space.World(ChoseGlobale)ouSpace.Self(ChoseLocal)

        //For Translate(), [SerializeField] et la déclarer*/
        Vector3 deplacementCetFrame = _deplacement * Time.deltaTime;
        transform.Translate(deplacementCetFrame.x, deplacementCetFrame.y, deplacementCetFrame.z, Space.Self);
        //transform.Translate(deplacementCetFrame, Space.Self); Sert à affecter les trois directions sans le répéter.

        //Vector3 deplacement = new Vector3(1f, 0, 0);
        //transform.Translate(deplacement * Time.deltaTime, Space.World);
    }
}
