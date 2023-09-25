using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.View.Common.Scripts.Interfaces
{
    public interface ICheckPoint
    {
        void Save();
        void ResetCheckPoint();
        void Load();
    }
}
