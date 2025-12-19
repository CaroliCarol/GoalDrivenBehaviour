using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GetTreated : GAction
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
        GWorld.Instance.GetWorld().ModifyState("isTreated", 1);
        beliefs.ModifyState("isCured", 1);
        inventory.RemoveItem(target);
        return true;
    }
}
