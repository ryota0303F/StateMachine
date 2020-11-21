using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    private IState state = null;

    private StateList stateList = new StateList();

    public StateList GetStateList() { return stateList; }

    public IState GetState() { return state; }

    //Stateを変更する際に通す関数
    //自動でEnterとExitに通るようになっている
    public void ChangeState(StateTagList _tag,MonoBehaviour _mono)
    {

        IState _state = stateList.Getstate(_tag);

        state?.Exit(_mono);
        state = _state;
        state?.Enter(_mono);
    }

    //StateMachineを持たせているscriptのUpdateでこの関数を回してやる
    //引数に自分のGameObjectを持たせてやる
    public void Update(MonoBehaviour _mono)
    {
        if(state != null)
        {
            StateTagList _tag = state.Execute(_mono);   
            if (_tag != StateTagList.none) 
            {
                ChangeState(_tag, _mono);
            }
        }
    }

}
