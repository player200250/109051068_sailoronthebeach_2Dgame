using UnityEngine;


namespace Jay
{
    /// <summary>
    /// 相機跟隨玩家移動
    /// </summary>

    public class canmerafollow : MonoBehaviour
    {
        public GameObject player;
        public Vector3 offset = new Vector3(0, 10, -5);

        void Update()
        {
            //把此程式的位置參照 player遊戲物件的位置
            transform.position = player.transform.position + offset;

        }
    }
}

