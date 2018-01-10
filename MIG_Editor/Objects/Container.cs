using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MIG_Editor.Objects.Map;

namespace MIG_Editor.Objects
{
    [Serializable]
    public class Container
    {
        public List<Food> foodList;
        public List<Wall> wallList;
        public List<Powerup> pList;

        public Container()
        {
            foodList = new List<Food>();
            wallList = new List<Wall>();
            pList = new List<Powerup>();
        }

        public void AddPower()
        {
            pList.Add(new Powerup("powerup"));
        }
    }
}
