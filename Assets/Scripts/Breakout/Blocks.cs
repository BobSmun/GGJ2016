using UnityEngine;
using System.Collections;

public class Blocks : MonoBehaviour
{
void OnCollisionEnter(Collision other)
    {     
       Destroy(gameObject);
    }
}