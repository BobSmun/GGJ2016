using UnityEngine;
using System.Collections;

public class InputStreamReaderWriter : MonoBehaviour
{
    // Record / Playback stuff
    [HideInInspector]
    public InputStream input = new InputStream();

    public bool isGhost = false;
    [HideInInspector]
    public int frameNumber = 0;


    void Awake()
    {
    }

    void FixedUpdate()
    {
        frameNumber++;

        if(isGhost)
        {
            GhostUpdate();
        }
        else
        {
            PlayerUpdate();
        }
    }

    void GhostUpdate()
    {
        InputFrame thisFrame = input.GetFrameData(frameNumber);

        gameObject.transform.localPosition = thisFrame.pos;
        gameObject.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
    }

    void PlayerUpdate()
    {
        input.AddFrameData(frameNumber, gameObject.transform.localPosition);
    }

    public void RebaseInput()
    {
        input = new InputStream();
        frameNumber = 0;
    }
}
