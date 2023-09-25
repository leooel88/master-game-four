using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.View.Common.Scripts.ScriptableObjects
{
    public interface ICharacter
    {
        public void Die();
        public bool IsAlive();
    }
}
