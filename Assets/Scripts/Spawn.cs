using UnityEngine;
using System.Collections.Generic;

public class Spawn : MonoBehaviour
{
    public Transform player;
    private Transform playerInstance;
    public Transform ghost;
    public Transform timer;
    public Transform leaderboard;

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

        // Create Player
        playerInstance = (Transform)Instantiate(player, transform.localPosition, transform.localRotation);
        playerInstance.gameObject.layer = LayerMask.NameToLayer("Player");

        SpawnPlayer();
    }

    public void SetCursorLock(bool value)
    {
        playerInstance.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = value;
        Cursor.lockState = value ? CursorLockMode.Locked : CursorLockMode.None;
        Cursor.visible = !value;
    }

    public void SpawnPlayer()
    {
        playerInstance.localPosition = transform.localPosition;
        playerInstance.localRotation = transform.localRotation;
        SetCursorLock(true);

        timer.GetComponent<Timer>().TimeCounter = 0;
        timer.GetComponent<Timer>().gameObject.SetActive(true);

        leaderboard.GetComponent<LeaderBoard>().Hide();

        foreach(InputStream input in ghostData)
        {
            CreateGhostObject(input);
        }

        //resume the game
        Time.timeScale = 1;
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

    public void SaveGhost()
    {
        InputStreamReaderWriter control = playerInstance.GetComponent<InputStreamReaderWriter>();
        AddGhostData(control.input);
    }

    private void AddGhostData(InputStream input)
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
