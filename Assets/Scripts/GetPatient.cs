using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GetPatient : GAction
{
    public override bool PrePreform()
    {
        target = GWorld.Instance.RemovePatient();
        if (target == null)
        {
            return false;
        }
        return true;
    }

    public override bool PostPreform()
    {
        return true;
    }
}
