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
        public DataCollection()
        {
            Lecturers = new List<Lecturer>();
            Rooms = new List<Room>();
            Modules = new List<Module>();
            Groups = new List<Group>();
        }

        public void Add(Lecturer lecturer)
        {
            Lecturers.Add(lecturer);
        }

        public void Add(Room room)
        {
            Rooms.Add(room);
        }

        public void Add(Module module)
        {
            Modules.Add(module);
        }

        public void Add(Group group)
        {
            Groups.Add(group);
        }

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

        public static DataCollection Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
