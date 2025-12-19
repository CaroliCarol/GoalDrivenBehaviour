using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Rest : GAction
{
    public override bool PrePreform()
    {
        return true;
    }

    public override bool PostPreform()
    {
        beliefs.RemoveState("exhausted");
        return true;
    }
}
