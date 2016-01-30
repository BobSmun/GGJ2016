using UnityEngine;
using System.Collections.Generic;

public class Spawn : MonoBehaviour
{
    public Transform player;
    public Transform ghost;

    public float ghostAlpha = 0.125f;
    private List<InputStream> ghostData = new List<InputStream>();

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
        Physics.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Player"), true);
        Physics.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Ghost"), true);
        Physics.IgnoreLayerCollision(LayerMask.NameToLayer("Ghost"), LayerMask.NameToLayer("Ghost"), true);

        SpawnPlayer();
    }

    public void SpawnPlayer()
    {
        // Create Player
        Transform p = (Transform)Instantiate(player, transform.localPosition, transform.localRotation);
        p.gameObject.layer = LayerMask.NameToLayer("Player");
        
        Timer t = FindObjectOfType<Timer>();
        t.TimeCounter = 0;
        t.enabled = true;

        foreach(InputStream input in ghostData)
        {
            CreateGhostObject(input);
        }
    }

    public void CreateGhostObject(InputStream input)
    {
        // Create Ghost
        Transform p = (Transform)Instantiate(ghost, transform.localPosition, transform.localRotation);
        p.parent = GameObject.Find("/Ghosts").transform;
        p.gameObject.layer = LayerMask.NameToLayer("Ghost");

        InputStreamReaderWriter control = p.GetComponent<InputStreamReaderWriter>();
        control.input = input;
    }

    public void AddGhostData(InputStream input)
    {
        if(input == null
            || input.Count == 0)
        {
            return;
        }

        input.Trim();
        ghostData.Add(input);
    }

    public void ClearGhostData()
    {
        KillCurrentGhosts();
        ghostData.Clear();
    }



    public void KillCurrentGhosts()
    {
        GameObject ghostObject = GameObject.Find("/Ghosts");
        if(ghostObject == null)
        {
            return;
        }
        for(int i = ghostObject.transform.childCount - 1; i >= 0; --i)
        {
            var child = ghostObject.transform.GetChild(i).gameObject;
            Destroy(child);
        }
    }
}
