using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinState : BrainState
{
    public WinState(BrainManager brainManager, BrainFactory brainFactory)
    : base (brainManager, brainFactory){}


    public override void CheckSwitchState()
    {
        // logic to execute to see if we want to change state
        // to change state call SwitchState(_Factory.StateNameinFactory()); 
        if(_Brain._menuAsked){
            SwitchState(_Factory.MainMenu());
        }
        if(_Brain._hubAsked){
            SwitchState(_Factory.HubState());
        }
    }

    public override void EnterState()
    {
        // logic to execute when we enter the state
        SceneManager.LoadScene("WinScreen");
    }

    public override void ExitState()
    {
        // logic to execute when leaving this state
    }

    public override void UpdateState()
    {
        // called every frame from the Brain
        CheckSwitchState();
    }
}
