using UnityEngine;

namespace Jay
{
    /// <summary>
    /// 玩家移動系統
    /// </summary>
    public class playercontroller : MonoBehaviour
    {
        [Header("取得玩家鋼體")]
        public Rigidbody2D rb;
        [Header("角色前後移動速度"),Range(0,20)]
        public float speed =10f;
        [Header("角色跳躍力道"), Range(0, 1000)]
        public float jumpforce =400f;


        void Update()
        {
            //角色跳躍
            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpforce * Time.fixedDeltaTime);
            }
        }
        private void FixedUpdate()
        {
            Movement();//呼叫移動系統


        }

        void Movement()//移動系統
        {
            float horizontalmove;
            horizontalmove = Input.GetAxis("Horizontal");//取得水平按鍵

            //移動判斷
            if (horizontalmove != 0)
            {
                rb.velocity = new Vector2(horizontalmove * speed, rb.velocity.y);//操縱鋼體水平移動
            }
        }
    }

}


