using UnityEngine;


namespace Jay
{
    /// <summary>
    /// �۾����H���a����
    /// </summary>

    public class canmerafollow : MonoBehaviour
    {
        public GameObject player;
        public Vector3 offset = new Vector3(0, 10, -5);

        void Update()
        {
            //�⦹�{������m�ѷ� player�C�����󪺦�m
            transform.position = player.transform.position + offset;

        }
    }
}

