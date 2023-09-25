using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.View.Player_moves
{
    public class Boat: MonoBehaviour
    {
        #region Attributes
        private Position position;
        private float currentMovemenPoints;
        [SerializeField]
        private float maxMovementPoints;
        [SerializeField]
        private String boatName;
        public UnityEvent FinishedMoving;

        [SerializeField]
        private bool isEnemy;
        [SerializeField]
        private int attackRange;
        [SerializeField]
        private int attackPoints;
        private bool hasAttacked;
        [SerializeField]
        private int hp;
        [SerializeField]
        private int maxHp;
        #endregion

        // Start is called before the first frame update
        void Start()
        {
            ResetMovementPoints();
            ResetAttack();
        }

        #region Private methods
        private void ResetMovementPoints()
        {
            currentMovemenPoints = maxMovementPoints;
        }

        private void ResetAttack()
        {
            this.hasAttacked = false;
        }
        #endregion

        #region Public methods
        public String GetBoatName()
        {
            return this.boatName;
        }
        public bool IsEnemy()
        {
            return this.isEnemy;
        }
        public bool CanStillMove()
        {
            return currentMovemenPoints > 0;
        }

        public int GetAttackRange()
        {
            return this.attackRange;
        }

        public int GetAttackPoints()
        {
            return this.attackPoints;
        }

        public bool CanStillAttack()
        {
            return !this.hasAttacked;
        }

        public virtual bool CanAttackThere(Vector3 attackPosition)
        {
            float distance = Mathf.Abs(transform.position.x - attackPosition.x) + Mathf.Abs(transform.position.y - attackPosition.y);
            return (attackRange >= distance);
        }

        public int GetHp()
        {
            return this.hp;
        }

        public int GetMaxHp()
        {
            return this.maxHp;
        }

        public void SetHasAttacked(bool hasAttacked)
        {
            this.hasAttacked = hasAttacked;
        }

        public void TakesDamage(int damage)
        {
            this.hp -= damage;
            if (this.hp < 0)
            {
                this.hp = 0;
            }
        }

        public void WaitTurn()
        {
            ResetMovementPoints();
            ResetAttack();
        }

        public void HandleMovement(Vector3 endPosition) {
            float distance = Mathf.Abs(transform.position.x - endPosition.x) + Mathf.Abs(transform.position.y - endPosition.y);
            if (distance <= currentMovemenPoints)
            {
                currentMovemenPoints -= distance;
                transform.position = endPosition;
            }
        }

        public virtual void playSelectAttack(GridManager gridManager, Vector3 boatPosition)
        {
            gridManager.transform.Find($"Tile {boatPosition.x} {boatPosition.y}").GetComponent<Tile>().range(this.GetAttackRange(), Color.red);
        }

        public void HandleAttack(Boat attackedBoat, Vector3 attackedPosition)
        {
            if (this.CanStillAttack())
            {
                if ((this.IsEnemy() && !attackedBoat.IsEnemy()) || (!this.IsEnemy() && attackedBoat.IsEnemy()))
                {
                    if (CanAttackThere(attackedPosition))
                    {
                        attackedBoat.TakesDamage(this.GetAttackPoints());
                        this.SetHasAttacked(true);
                    }
                }
            }
        }
        public int GetMovePoints()
        {
            return (int)currentMovemenPoints;
        }
        #endregion
    }
}
