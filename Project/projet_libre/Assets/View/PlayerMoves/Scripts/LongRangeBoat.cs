using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using Assets.View.Player_moves;

namespace Assets.View.Boat_classes
{
    public class LongRangeBoat : Boat
    {
        #region Attributes
        [SerializeField]
        private int attackMinRange;
        [SerializeField]
        private int attackMaxRange;
        #endregion

        #region Public methods

        public override void playSelectAttack(GridManager gridManager, Vector3 boatPosition)
        {
            gridManager.transform.Find($"Tile {boatPosition.x} {boatPosition.y}").GetComponent<Tile>().circle(this.attackMinRange, this.attackMaxRange, Color.red);
        }

        public override bool CanAttackThere(Vector3 attackPosition)
        {
            float distance = Mathf.Abs(transform.position.x - attackPosition.x) + Mathf.Abs(transform.position.y - attackPosition.y);

            return (distance >= attackMinRange && distance <= attackMaxRange);

        }

        public int GetAttackMinRange()
        {
            return this.attackMinRange;
        }

        public int GetAttackMaxRange()
        {
            return this.attackMaxRange;
        }
        #endregion
    }
}
