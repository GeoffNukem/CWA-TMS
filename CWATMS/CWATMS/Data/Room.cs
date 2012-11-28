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
        private Boolean[] m_equipmentList = { false, false, false, false, false };

        public Room(String name, String label, Color colour, int capacity)
            : base(name, label, colour)
        {
            m_capacity = capacity;
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
            m_equipmentList[index] = flag;
        }

        public bool HasLecturerPC()
        {
            return m_equipmentList[0];
        }

        public bool HasSmartboard()
        {
            return m_equipmentList[1];
        }

        public bool HasTelevision()
        {
            return m_equipmentList[2];
        }

        public bool HasProjector()
        {
            return m_equipmentList[3];
        }

        public bool IsNetworkLab()
        {
            return m_equipmentList[4];
        }
    }
}
