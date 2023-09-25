using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.View.Common.Scripts.Models;

namespace Assets.View.Common.Scripts.ScriptableObjects.AdvancedCharacters
{
    public class Barbarian: AdvancedCharacter
    {
        public Barbarian()
        {
            this.SetLife(150);
            this.SetMaxLife(150);

            this.SetStamina(6);
            this.SetMaxStamina(6);

            this.SetRegenLife(2);
            this.SetRegenStamina(1);
            this.SetTimeBeforeRegenLife(5);
            this.SetTimeBeforeRegenStamina(10);
        }
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
