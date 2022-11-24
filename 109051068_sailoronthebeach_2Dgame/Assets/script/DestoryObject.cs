using UnityEngine;


namespace Jay 
{
    ///<summery>///
    ///刪除物件///
    ///</summery>>///
    public class DestoryObject : MonoBehaviour
    {
        [SerializeField, Header("刪除時間"), Range(0, 3)]
        private float destoryTime = 0.5f;

        private void Awake()
        {
            //gameObject 此腳本刪除遊戲物件
            //刪除(物件,刪除時間)
            Destroy(gameObject, destoryTime);
        }
            //不可見事件 :當渲染元件(renderer) 消失在 Scene 或 Game 時執行一次
        private void OnBecameVisible()
        {
            
        }
            //不可見事件 :當渲染元件(renderer) 消失在 Scene 或 Game 時執行一次
        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }
    }

}

