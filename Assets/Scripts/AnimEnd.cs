using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimEnd : StateMachineBehaviour {

	// Mecanimのアニメーションコントローラーの再生の修了用
	// 新しいステートに移り変わった時に実行される関数なので
	// 最後に空のステートを作ってAdd Behaviourでこのスクリプトを追加する
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
		Destroy(animator.gameObject);
    }
}
