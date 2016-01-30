using UnityEngine;
using System.Collections.Generic;

public class Spawn : MonoBehaviour
{
    public Transform player;

    private static Spawn instance = null;
    public static Spawn Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start()
    {
        SpawnPlayer();
    }

    public void SpawnPlayer()
    {
        // Create Player
        Transform p = (Transform)Instantiate(player, transform.localPosition, transform.localRotation);
        p.gameObject.layer = LayerMask.NameToLayer("Player");
    }
}
