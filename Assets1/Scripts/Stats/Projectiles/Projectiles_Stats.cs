using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace cProjectile
{

    public interface IProjectile
    {
        float _damage { get; set; }
        float _speed { get; set; }
    }
}