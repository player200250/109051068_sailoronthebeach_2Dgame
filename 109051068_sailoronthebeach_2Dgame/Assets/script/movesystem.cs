using UnityEngine;

namespace Jay
{
    ///<summery>
    ///�ĤH���ʨt��
    ///</summery>>
    public class movesystem : MonoBehaviour
    {
        [SerializeField, Header("���ʳt��"), Range(-10, 0)]
        public float speed = 1.5f;

        void Update()
        {
            transform.Translate(Vector2.left * Time.deltaTime * 2f);//�۰ʦV������
        }
    }
}
