using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.View.Common.Scripts.ScriptableObjects.Roles;

namespace Assets.View.Common.Scripts.Models
{
    /// <summary>
    /// Class for Player
    /// </summary>
    public class Player : MonoBehaviour
    {
        #region PrivateFields

        #region Serialized fields

        [SerializeField] private int _gems;
        [SerializeField] private int _symbols;
        [SerializeField] private int _level;
        [SerializeField] private string _name;
        [SerializeField] private Role _role;
        [SerializeField] private AdvancedCharacter _advancedCharacter;

        #endregion

        private int _orbs;
        private float _experiences;
        private float _maxExperiences;


        #endregion

        #region Getters

        // Retourne le nombre total de gemmes poss�d�es par le joueur
        public int GetGems()
        {
            return this._gems;
        }

        // Retourne le nombre total d'orbes poss�d�s par le joueur
        public int GetOrbs()
        {
            return this._orbs;
        }

        // Retourne le nombre total de symboles poss�d�s par le joueur
        public int GetSymbols()
        {
            return this._symbols;
        }

        // Retourne le niveau actuel du joueur
        public int GetLevel()
        {
            return this._level;
        }

        // Retourne le nom du joueur
        public string GetName()
        {
            return this._name;
        }

        // Retourne l'exp�rience acquise par le joueur
        public float GetExperiences()
        {
            return this._experiences;
        }

        // Retourne l'exp�rience requise pour atteindre le prochain niveau
        public float GetMaxExperiences()
        {
            return this._maxExperiences;
        }

        // Retourne le script Role li� au Player
        public Role GetRole()
        {
            return this._role;
        }


        // Retourne le script AdvancedCharacter li� au Player
        public AdvancedCharacter GetCharacter()
        {
            return this._advancedCharacter;
        }
        #endregion

        #region Setters

        // D�finit le nombre de gemmes poss�d�es par le joueur
        private void SetGems(int pGems)
        {
            this._gems = pGems;
        }

        // D�finit le nombre d'orbes poss�d�s par le joueur
        private void SetOrbs(int pOrbs)
        {
            this._orbs = pOrbs;
        }

        // D�finit le nombre de symboles poss�d�s par le joueur
        private void SetSymbols(int pSymbols)
        {
            this._symbols = pSymbols;
        }

        // D�finit le niveau du joueur
        private void SetLevel(int pLevel)
        {
            this._level = pLevel;
        }

        // D�finit l'exp�rience acquise par le joueur
        private void SetExperiences(float pExperiences)
        {
            this._experiences = pExperiences;
        }

        // D�finit l'exp�rience maximum � avoir pour atteindre le prochain niveau du joueur
        private void SetMaxExperiences(float pMaxExperiences)
        {
            this._maxExperiences = pMaxExperiences;
        }

        #endregion

        #region Private Methods

        // V�rifie si le joueur peut augmenter de niveau, c'est-�-dire si l'exp�rience requise est atteinte ou d�pass�e.
        private bool IsReadyToLevelUp()
        {
            return (this._experiences >= this._maxExperiences);
        }

        // Augmente le niveau du joueur et le nombre max d'exp�rience � avoir pour le prochain niveau.
        // Si le joueur poss�de plus d'exp�rience que n�cessaire, l'exc�dent s'ajoute au nouveau niveau.
        private void LevelUp()
        {
            while (this.IsReadyToLevelUp())
            {
                this._level += 1;
                this._experiences -= this._maxExperiences;
                this._maxExperiences *= (float)1.5;
            }
        }

        // D�finit la valeur de _isImmortal � true pendant 1 seconde
        IEnumerator LoadImmortalFrame()
        {
            this._advancedCharacter.SetIsImmortal(true);
            yield return new WaitForSeconds(1);
            this._advancedCharacter.SetIsImmortal(false);
        }
        #endregion

        #region Public Methods
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        // Ajoute des symboles � ceux poss�d�s par le joueur
        public void AddSymbol(int pSymbol)
        {
            this._symbols += pSymbol;
        }

        // Ajoute de l'exp�rience au joueur
        public void AddExperiences(float pExperience)
        {
            this._experiences += pExperience;
        }

        // Retourne le player player sous format string
        public override string ToString()
        {
            return "Name : " + this._name + "\nLevel : " + this._level + "\nGems number : " + this._gems + "\nSymbols number : " + this._symbols + "\nOrbs number : " + this._orbs + "\nExperiences : " + this._experiences + "\nMax experiences : " + this._maxExperiences + ";";
        }
        #endregion
    }

}