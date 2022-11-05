using UnityEngine;

namespace Jay
{
    /// <summary>
    /// ���a���ʨt��
    /// </summary>
    public class playercontroller : MonoBehaviour
    {
        [Header("���o���a����")]
        public Rigidbody2D rb;
        [Header("����e�Ჾ�ʳt��"),Range(0,20)]
        public float speed =10f;
        [Header("������D�O�D"), Range(0, 1000)]
        public float jumpforce =400f;


        void Update()
        {
            //������D
            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpforce * Time.fixedDeltaTime);
            }
        }
        private void FixedUpdate()
        {
            Movement();//�I�s���ʨt��


        }

        void Movement()//���ʨt��
        {
            float horizontalmove;
            horizontalmove = Input.GetAxis("Horizontal");//���o��������

            //���ʧP�_
            if (horizontalmove != 0)
            {
                rb.velocity = new Vector2(horizontalmove * speed, rb.velocity.y);//���a�����������
            }
        }
    }

}


