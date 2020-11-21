using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StateList
{
    //Dictionaryクラスのオブジェクト生成
    private Dictionary<StateTagList, IState> statelist = new Dictionary<StateTagList, IState>();

    public StateList()
    {

    }

    //この関数でStateリストの追加
    public void AddState(StateTagList _tag,IState _state)
    {
        statelist.Add(_tag, _state);
    }

    //ここにタグを引数として入れればそのStateがかえってくる
    public IState Getstate(StateTagList _tag)
    {
        return statelist[_tag];
    }

}
