using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState
{
    //始めに呼ばれる関数
    StateTagList Enter(MonoBehaviour mono);
    //フレーム呼ばれる関数
    StateTagList Execute(MonoBehaviour mono);
    //消去時に呼ばれる関数
    StateTagList Exit(MonoBehaviour mono);
}
