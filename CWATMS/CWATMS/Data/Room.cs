using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWATMS
{
    public class Room : Data
    {
        private int m_capacity;
        private List<Boolean> m_equipmentList;

        public Room(String name, String label, Color colour, int capacity)
            : base(name, label, colour)
        {
            m_capacity = capacity;
            m_equipmentList = new List<bool>(5);
        }

        public int Capacity
        {
            get { return m_capacity; }
            set { m_capacity = value; }
        }

        /// <summary>
        /// Set whether room has equipment.
        /// </summary>
        /// <param name="index">index number of equipment. 0 = Projector, 1 = Smartboard, 2 = LecturerPC, 3 = TV, 4 = Network Lab</param>
        /// <param name="flag"></param>
        public void SetEquipment(int index, bool flag)
        {
            m_equipmentList[index] = false;
        }
    }
}
