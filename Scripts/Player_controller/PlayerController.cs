using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
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
                Touch touch = Input.GetTouch(i);
                if (IsPointerOverUIObject(touch))
                {
                    return;
                }
                Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.touches[i].position);
                _currentSpeed = (touchPosition - _currentPosition);
                playerRB.AddForce((_currentSpeed * speed));
            }
        }
        private bool IsPointerOverUIObject(Touch touch)
        {
            PointerEventData eventData = new PointerEventData(EventSystem.current)
            {
                position = touch.position
            };
            System.Collections.Generic.List<RaycastResult> results = new System.Collections.Generic.List<RaycastResult>();
            EventSystem.current.RaycastAll(eventData, results);
            return results.Count > 0;
        }
        /// <summary>
        /// »змен€ет физическое значение массы, трение, а также скорость текущего корабл€
        /// </summary>
        /// <param name="currShip"></param>
        public void changeCurrent(FirstShip currShip)
        {
            playerRB.mass = currShip.ship_Data._mass;
            playerRB.drag = currShip.ship_Data._drag;
            speed =         currShip.ship_Data._speed;
        }
    }
}