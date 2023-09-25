using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.View.Common.Scripts.Controllers
{
    public class MovementController: MonoBehaviour
    {
        #region PrivateFields

        #region Serialized fields

        [SerializeField] private float _speed;
        [SerializeField] private Animator _animator;

        #endregion

        #endregion

        #region Private Methods
        private void Start()
        {
            this._animator = GetComponent<Animator>();
        }
        private void Update()
        {
            Vector2 dir = Vector2.zero;

            if (Input.GetKey(KeyCode.Z))
            {
                Vector3 position = this.transform.position; // These lines are here to create the movement on the player
                position.y += this._speed;                  // It is not in the exercise
                this.transform.position = position;
                _animator.SetInteger("Direction", 3);
                dir = Vector2.up;
            }
            if (Input.GetKey(KeyCode.S))
            {
                Vector3 position = this.transform.position;
                position.y -= this._speed;
                this.transform.position = position;
                _animator.SetInteger("Direction", 2);
                dir = Vector2.down;
            }
            if (Input.GetKey(KeyCode.Q))
            {
                Vector3 position = this.transform.position;
                position.x -= this._speed;
                this.transform.position = position;
                _animator.SetInteger("Direction", 1);
                dir = Vector2.left;
            }
            if (Input.GetKey(KeyCode.D))
            {
                Vector3 position = this.transform.position;
                position.x += this._speed;
                this.transform.position = position;
                _animator.SetInteger("Direction", 0);
                dir = Vector2.right;
            }

            dir.Normalize();
            this._animator.SetBool("IsMoving", dir.magnitude > 0);
        }

        #endregion
    }
}
