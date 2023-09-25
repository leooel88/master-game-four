using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.View.Common.Scripts.ScriptableObjects.Roles { 
    public class Role: ScriptableObject
    {
        #region PrivateFields

        #region Serialized fields

        [SerializeField] private int _attack;
        [SerializeField] private int _defense;

        #endregion

        #endregion

        #region Getters

        // Retourne la valeur d'attaque
        public int GetAttack()
        {
            return this._attack;
        }

        // Retourne la valeur de d�fense
        public int GetDefense()
        {
            return this._defense;
        }
        #endregion

        #region Setters

        // Ajoute de l'attaque � celle d�j� pr�sente
        public void AddAttack(int pAttack)
        {
            this._attack += pAttack;
        }

        // Ajoute de la d�fense � celle d�j� pr�sente
        public void AddDefense(int pDefense)
        {
            this._defense += pDefense;
        }
        #endregion

        #region Private Mehtods

        // D�fini la valeure d'attaque
        private void SetAttack(int pAttack)
        {
            this._attack = pAttack;
        }

        // D�fini la valeure de d�fense
        private void SetDefense(int pDefense)
        {
            this._defense = pDefense;
        }
        #endregion

        #region Public Methods

        // Retourne le role player sous format string
        public override string ToString()
        {
            return "Attaque : " + this._attack + "\nDefense : " + this._defense + "";
        }
        #endregion
    }
}
