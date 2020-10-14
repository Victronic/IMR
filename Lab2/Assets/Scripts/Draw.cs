using UnityEngine;
using VRTK;
public class Draw : MonoBehaviour
{
    public VRTK_ControllerEvents controller;
    public LineRenderer line;
    public GameObject chalk;
    bool isUsed = false;
    void Start()
    {
        controller.TriggerPressed += InteractableObjectUsed;
        controller.TriggerReleased += InteractableObjectUnused;
    }
    void Update()
    {
        
        if (isUsed)
        {
            line.positionCount++;
            line.SetPosition(line.positionCount - 1, chalk.transform.position);
            
        }
    }
    protected virtual void InteractableObjectUsed (object sender, ControllerInteractionEventArgs e)
    {
        isUsed= true;
    }

    protected virtual void InteractableObjectUnused(object sender, ControllerInteractionEventArgs e)
    {
        isUsed = false;
    }
}