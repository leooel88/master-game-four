using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.View.Common.Scripts.Models
{
    public class Character : ScriptableObject
    {

        #region PrivateFields

        #region Serialized fields

        [SerializeField] private int _life;
        [SerializeField] private int _maxLife;

        #endregion

        private bool _isImmortal;
        private bool _isInDanger;

        #endregion

        #region Getters
        // Retourne le nombre de points de vie maximaux du personnage
        public int GetMaxLife()
        {
            return this._maxLife;
        }

        // Retourne le nombre de points de vie actuels du personnage
        public int GetLife()
        {
            return this._life;
        }

        // Vérifie si le personnage est en danger, c'est-à-dire s'il est en combat
        public bool IsInDanger()
        {
            return this._isInDanger;
        }

        // Retourne la valeure de isImmortal
        public bool GetIsImmortal()
        {
            return this._isImmortal;
        }
        #endregion

        #region Setters

        // Définit si le personnage est en danger
        public void SetIsInDanger(bool pAction)
        {
            this._isInDanger = pAction;
        }

        // Définit les points de vie actuels du personnage
        protected void SetLife(int pLife)
        {
            this._life = pLife;
        }

        // Définit les points de vie maximaux du personnage
        public void SetMaxLife(int pMaxLife)
        {
            this._maxLife = pMaxLife;
        }

        // Définie la valeure de isImmortal
        public void SetIsImmortal(bool pIsImmortal)
        {
            this._isImmortal = pIsImmortal;
        }
        #endregion

        #region Public Methods

        // Retourne la classe Character sous format string
        public override string ToString()
        {
            return "Life : " + this._life + "\nMax Life : " + this._maxLife + "\nIs in danger : " + this._isInDanger.ToString() + "";
        }

        // Définit les points de vie du personnage à 0 et charge la scène Home
        public void Die()
        {
            this._life = 0;
            SceneManager.LoadScene("Home");
        }

        // Inflige des dégâts au personnage
        public void Damage(int pDamage)
        {
            this._life -= pDamage;
        }

        // Vérifie si le personnage est en vie
        public bool IsAlive()
        {
            return this._life > 0;
        }

        // Soigne le personnage
        public void Heal(int pHeal)
        {
            this._life += pHeal;
        }

        // Réinitialise les valeurs par défaut des points de vie, de l'immortalité et du danger
        public void ResetCharacter()
        {
            this._life = this._maxLife;
            this._isInDanger = false;
            this._isImmortal = false;
        }

        // Fait appel à la méthode ResetCharacter
        public void OnEnable()
        {
            this.ResetCharacter();
        }
        #endregion

        #region Private Methods

        #endregion
    }
}
