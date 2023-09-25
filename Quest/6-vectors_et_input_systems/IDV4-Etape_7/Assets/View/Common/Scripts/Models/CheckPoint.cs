using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Assets.View.Common.Scripts.Interfaces;

namespace Assets.View.Common.Scripts.Models
{
    public class CheckPoint : MonoBehaviour, ICheckPoint
    {
        #region Private fields
        #region Serialized Fields

        [SerializeField] private bool _isSpawner;
        [SerializeField] private bool _active;
        [SerializeField] private RectTransform _spawnArea;
        #endregion
        #endregion

        #region Public Methods
        #region Getters
        public bool GetActive()
        {
            return this._active;
        }

        public RectTransform GetSpawnArea()
        {
            return this._spawnArea;
        }        
        #endregion

        #region Setters
        public void SetActive(bool pActive)
        {
            this._active = pActive;
        }

        public void SetSpawnArea(RectTransform pSpawnArea)
        {
            this._spawnArea = pSpawnArea;
        }
        #endregion

        public void Load()
        {
            
        }

        public void ResetCheckPoint()
        {
            if (this._isSpawner)
            {
                this.Save();
            }
        }

        public void Save()
        {
            this._active = true;
        }
        #endregion
    }
}
