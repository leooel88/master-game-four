using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using Assets.View.Player_moves;

namespace Assets.View.TurnBasedSystem
{

    public class TurnBasedManager : MonoBehaviour
    {
        #region Attributes
        public UnityEvent<bool> OnBlockPlayerInput, OnUnblockPlayerInput;
        public UnityEvent<bool> OnBlockEnemyInput, OnUnblockEnemyInput;

        public bool isEnemyTurn;
        [SerializeField] GameObject turnContainer;
        #endregion
        // Start is called before the first frame update
        void Start()
        {
            this.isEnemyTurn = false;
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        #region Public methods
        public void NextTurn()
        {
            Text turnText = turnContainer.GetComponent<Text>();
            //Debug.Log("TurnValue" + turnContainer.GetComponent<Text>());
            this.isEnemyTurn = !this.isEnemyTurn;
            if (this.isEnemyTurn)
            {
                turnText.text = "Purple";
                OnBlockPlayerInput.Invoke(this.isEnemyTurn);
            } else
            {
                turnText.text = "Yellow";
                OnBlockEnemyInput.Invoke(this.isEnemyTurn);
            }
            foreach(Boat boat in FindObjectsOfType<Boat>())
            {
                if (boat.IsEnemy() == this.isEnemyTurn)
                {
                    boat.WaitTurn();
                }
            }
        }
        #endregion
    }

}
