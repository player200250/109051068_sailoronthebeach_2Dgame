using UnityEngine;

namespace Jay
{
    ///<summery>
    ///敵人移動系統
    ///</summery>>
    public class movesystem : MonoBehaviour
    {
        [SerializeField, Header("移動速度"), Range(-10, 0)]
        public float speed = 1.5f;

        void Update()
        {
            transform.Translate(Vector2.left * Time.deltaTime * 2f);//自動向左移動
        }
    }
}
