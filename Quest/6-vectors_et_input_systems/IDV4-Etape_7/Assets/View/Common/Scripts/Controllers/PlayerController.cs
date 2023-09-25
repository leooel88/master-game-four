using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Assets.View.Common.Scripts.Models;

namespace Assets.View.Common.Scripts.Controllers
{
    internal class PlayerController: MonoBehaviour
    {
        #region PrivateFields

        #region Serialized fields

        [SerializeField] private Player _player;

        #endregion

        #endregion

        // Update is called once per frame
        void Update()
        {

        }

        void OnTriggerEnter2D()
        {

        }
    }
}
