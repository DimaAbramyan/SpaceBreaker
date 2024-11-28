using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ShipInterface
{
    public interface IShip
    {
        float _speed { get; set; }
        float _mass { get; set; }
        float _drag { get; set; }
        float _max_HP { get; set; }
        float _current_HP { get; set; }

        void shoot();
        void update();
    }
    public class Ships_char : MonoBehaviour
    {

    }
}
