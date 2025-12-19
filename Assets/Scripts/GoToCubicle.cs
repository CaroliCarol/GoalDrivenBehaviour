using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GoToCubicle : GAction
{
    public override bool PrePreform()
    {
        target = inventory.FindItemWithTag("Cubicle");
        if (target == null )
        {
            return false;
        }
        return true;
    }

    public override bool PostPreform()
    {
        GWorld.Instance.GetWorld().ModifyState("TreatingPatient", 1);
        GWorld.Instance.AddCubicle(target);
        inventory.RemoveItem(target);
        GWorld.Instance.GetWorld().ModifyState("FreeCubicle", 1);
        return true;
    }
}
