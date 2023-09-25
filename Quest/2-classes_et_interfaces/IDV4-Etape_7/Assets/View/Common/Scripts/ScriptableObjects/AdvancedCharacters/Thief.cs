using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.View.Common.Scripts.Models;

namespace Assets.View.Common.Scripts.ScriptableObjects.AdvancedCharacters
{
    public class Thief: AdvancedCharacter
    {
        public Thief()
        {
            this.SetLife(80);
            this.SetMaxLife(80);

            this.SetStamina(4);
            this.SetMaxStamina(4);

            this.SetRegenLife(1);
            this.SetRegenStamina(1);
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
