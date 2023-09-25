using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.View.Common.Scripts.ScriptableObjects
{
    public interface IAdvancedCharacter : ICharacter
    {
        public IEnumerator RegenLife();
        public IEnumerator RegenStamina();

    }
}
