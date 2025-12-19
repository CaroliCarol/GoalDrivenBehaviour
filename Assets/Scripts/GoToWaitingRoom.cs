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
        GWorld.Instance.GetWorld().ModifyState("Waiting", 1);
        GWorld.Instance.AddPatient(this.gameObject);
        return true;
    }
}
