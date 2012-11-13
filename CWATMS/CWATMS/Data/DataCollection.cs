using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWATMS
{
    public sealed class DataCollection
    {
        public List<Lecturer> Lecturers;
        public List<Room> Rooms;
        public List<Module> Modules;
        public List<Group> Groups;

        private static readonly DataCollection instance = new DataCollection();

        /// <summary>
        /// Singleton.
        /// Collection instances of the Data classes: Lecturer, Room, Module & Groups.
        /// </summary>
        private DataCollection()
        {
            Lecturers = new List<Lecturer>();
            Rooms = new List<Room>();
            Modules = new List<Module>();
            Groups = new List<Group>();
        }

        /// <summary>
        /// Add Lecturer
        /// </summary>
        /// <param name="lecturer">Lecturer instance to add into list</param>
        public void Add(Lecturer lecturer)
        {
            Lecturers.Add(lecturer);
        }

        /// <summary>
        /// Add Room
        /// </summary>
        /// <param name="room">Room instance to add into list</param>
        public void Add(Room room)
        {
            Rooms.Add(room);
        }

        /// <summary>
        /// Add Module
        /// </summary>
        /// <param name="module">Module instance to add into list</param>
        public void Add(Module module)
        {
            Modules.Add(module);
        }

        /// <summary>
        /// Add Group
        /// </summary>
        /// <param name="group">Group instance to add into list</param>
        public void Add(Group group)
        {
            Groups.Add(group);
        }

        /// <summary>
        /// Insert Lecturer into the list at a specific Index
        /// </summary>
        /// <param name="lecturer"></param>
        /// <param name="index"></param>
        public void Insert(Lecturer lecturer, int index)
        {
            Lecturers.Insert(index, lecturer);
        }

        public void Insert(Room room, int index)
        {
            Rooms.Insert(index, room);
        }

        public void Insert(Module module, int index)
        {
            Modules.Insert(index, module);
        }

        public void Insert(Group group, int index)
        {
            Groups.Insert(index, group);
        }

        public void Remove(Lecturer lecturer)
        {
            if (Lecturers.Contains(lecturer))
                Lecturers.Remove(lecturer);
        }

        public void Remove(Room room)
        {
            if (Rooms.Contains(room))
                Rooms.Remove(room);
        }

        public void Remove(Module module)
        {
            if (Modules.Contains(module))
                Modules.Remove(module);
        }

        public void Remove(Group group)
        {
            if (Groups.Contains(group))
                Groups.Remove(group);
        }

        public static DataCollection Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
