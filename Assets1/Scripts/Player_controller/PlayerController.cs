using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ShipInterface;
namespace PlayerController
{

    public class PlayerControllerClass : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D playerRB; // точка, €вл€юща€с€ ма€ком дл€ изменени€ корпуса. »менно она перемещаетс€ в пространстве
        float speed;
        Vector3 _currentSpeed;
        Vector3 _currentPosition;
        void Start()
        {
            playerRB = GetComponent<Rigidbody2D>();
        }
        private void FixedUpdate()
        {
            _currentPosition = gameObject.transform.position;
            for (int i = 0; i < Input.touchCount; i++)
            {
                Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.touches[i].position);
                _currentSpeed = (touchPosition - _currentPosition);
                playerRB.AddForce((_currentSpeed * speed));
            }

        }
        /// <summary>
        /// »змен€ет физическое значение массы, трение, а также скорость текущего корабл€
        /// </summary>
        /// <param name="currShip"></param>
        public void changeCurrent(IShip currShip)
        {
            playerRB.mass = currShip._mass;
            playerRB.drag = currShip._drag;
            speed = currShip._speed;
        }
    }
}