using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.View.Common.Scripts.Models;

namespace Assets.View.Common.Scripts.ScriptableObjects.AdvancedCharacters
{
    public class Mage: AdvancedCharacter
    {
        public Mage()
        {
            this.SetLife(75);
            this.SetMaxLife(75);

            this.SetStamina(10);
            this.SetMaxStamina(10);

            this.SetRegenLife(1);
            this.SetRegenStamina(2);
            this.SetTimeBeforeRegenLife(10);
            this.SetTimeBeforeRegenStamina(5);
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
