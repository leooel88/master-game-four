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

        // Retourne la valeur de défense
        public int GetDefense()
        {
            return this._defense;
        }
        #endregion

        #region Setters

        // Ajoute de l'attaque à celle déjà présente
        public void AddAttack(int pAttack)
        {
            this._attack += pAttack;
        }

        // Ajoute de la défense à celle déjà présente
        public void AddDefense(int pDefense)
        {
            this._defense += pDefense;
        }
        #endregion

        #region Private Mehtods

        // Défini la valeure d'attaque
        private void SetAttack(int pAttack)
        {
            this._attack = pAttack;
        }

        // Défini la valeure de défense
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
