using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.View.Common.Scripts.Models;
using UnityEngine;

namespace Assets.View.Common.Scripts.Models
{
    public class AdvancedCharacter: Character
    {
        #region PrivateFields

        #region Serialized fields

        [SerializeField] private float _stamina;
        [SerializeField] private float _maxStamina;
        [SerializeField] private int _regenLife;
        [SerializeField] private int _regenStamina;
        [SerializeField] private float _timeBeforeRegenLife;
        [SerializeField] private float _timeBeforeRegenStamina;

        #endregion

        #endregion

        #region Getters

        public float GetStamina()
        {
            return this._stamina;
        }

        public float GetMaxStamina()
        {
            return this._maxStamina;
        }

        public int GetRegenLife()
        {
            return this._regenLife;
        }

        public int GetRegenStamina()
        {
            return this._regenStamina;
        }

        public float GetTimeBeforeRegenLife()
        {
            return this._timeBeforeRegenLife;
        }

        public float GetTimeBeforeRegenStamina()
        {
            return this._timeBeforeRegenStamina;
        }
        #endregion

        #region Setters
        public void SetStamina(float pStamina)
        {
            this._stamina = pStamina;
        }

        public void SetMaxStamina(float pMaxStamina)
        {
            this._maxStamina = pMaxStamina;
        }

        public void SetRegenLife(int pRegenLife)
        {
            this._regenLife = pRegenLife;
        }

        public void SetRegenStamina(int pRegenStamina)
        {
            this._regenStamina = pRegenStamina;
        }

        public void SetTimeBeforeRegenStamina(float pTimeBeforeRegenStamina)
        {
            this._timeBeforeRegenStamina = pTimeBeforeRegenStamina;
        }

        public void SetTimeBeforeRegenLife(float pTimeBeforeRegenLife)
        {
            this._timeBeforeRegenLife = pTimeBeforeRegenLife;
        }

        #endregion

        #region Public Methods
        // Vérifie que le personnage n'est pas en danger et régénère la vie jusqu'au maximum selon la vitesse de régénération
        public IEnumerator RegenLife()
        {
            if (!this.IsInDanger())
            {
            
                if (this.GetLife() < this.GetMaxLife())
                {
                    yield return new WaitForSeconds(this._timeBeforeRegenLife);
                    this.Heal(this._regenLife);
                    if (this.GetLife() > this.GetMaxLife())
                    {
                        this.SetLife(this.GetMaxLife());
                    }
                    this.RegenLife();
                }
            }
        }

        // Vérifie que le character n'est pas en danger et régénère la stamina jusqu'au maximum selon la vitesse de régénération
        public IEnumerator RegenStamina()
        {
            if (!this.IsInDanger())
            { 
                if (this._stamina < this._maxStamina)
                {
                    yield return new WaitForSeconds(this._timeBeforeRegenStamina);
                    this._stamina += this._regenStamina;
                    if (this._stamina > this._maxStamina)
                    {
                        this._stamina = this._maxStamina;
                    }
                    this.RegenStamina();
                }
            }
        }

        // Fait appel à la méthode parent ResetCharacter et réinitialise les valeurs par défaut de la stamina
        public new void ResetCharacter()
        {
            base.ResetCharacter();
            this._stamina = this._maxStamina;
        }

        // Fait appel à la méthode ResetCharacter
        public new void OnEnable()
        {
            this.ResetCharacter();
        }
        #endregion
    }
}
