using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysteryMystery.github.io.Components.Helpers
{
    public class SectionIndex
    {
        private int _index = 0;
        public int Next() => _index++;
        public void Reset() => _index = 0;
    }
}
