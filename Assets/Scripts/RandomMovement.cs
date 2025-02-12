using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    Vector3 vitesse;
//[SerializeField] private float vitesse;
    // Start is called before the first frame update
    void Start()
    {
        vitesse.z = Random.Range(1f, 3f);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(vitesse * Time.deltaTime, Space.Self);
        if (transform.position.x > 5f)
        {
            Debug.Log(gameObject.name);
        }
;
    }

    //private void OnCollisionEnter(Collision collision)
//{
//if (collision.gameObject.CompareTag("Terminus"))
       // {
           //Debug.Log("Le Saumon est arrivé!!!... Enfin...");
           
       // }
    //}


}
