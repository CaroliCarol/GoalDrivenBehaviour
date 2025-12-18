using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GoToWaitingRoom : GAction
{
    public override bool PrePreform()
    {
        return true;
    }

    public override bool PostPreform()
    {
        return true;
    }
}
