using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class InputFrame
{
    public int Frame;
    public Vector3 pos;
}

public class InputStream
{
    private List<InputFrame> FrameData = new List<InputFrame>();

    public void AddFrameData(int frame, Vector3 pos)
    {
        // Only add if it differs from the last frame
        InputFrame lastFrame = GetFrameData(frame);
#if UNITY_EDITOR
        if(lastFrame != null && lastFrame.Frame == frame)
        {
            throw new System.ArgumentException("Frame data already present", "frame");
        }
#endif

        if(lastFrame == null
            || lastFrame.pos != pos)
        {
            InputFrame thisFrame = new InputFrame();
            thisFrame.Frame = frame;
            thisFrame.pos = pos;
            FrameData.Add(thisFrame);
            FrameData.Sort((x, y) => x.Frame.CompareTo(y.Frame));
        }
    }

    public InputFrame GetFrameData(int frame)
    {
        return Count == 0 ? null : FrameData.Last(x => x.Frame <= frame);
    }

    public int Count
    {
        get
        {
            return FrameData.Count;
        }
    }

    public void Trim()
    {
        FrameData.TrimExcess();
    }
}
