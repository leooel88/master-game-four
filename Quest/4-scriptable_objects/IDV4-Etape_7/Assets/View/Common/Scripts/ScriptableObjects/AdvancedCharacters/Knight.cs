using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.View.Common.Scripts.Models;

namespace Assets.View.Common.Scripts.ScriptableObjects.AdvancedCharacters
{
    public class Knight: AdvancedCharacter
    {
        public Knight()
        {
            this.SetLife(125);
            this.SetMaxLife(125);

            this.SetStamina(7);
            this.SetMaxStamina(7);

            this.SetRegenLife(2);
            this.SetRegenStamina(2);
            this.SetTimeBeforeRegenLife(5);
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
