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
        public List<Lesson> Lessons;

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
            Lessons = new List<Lesson>();
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

        public void Add(Lesson lesson)
        {
            Lessons.Add(lesson);
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

        public void Insert(Lesson lesson, int index)
        {
            Lessons.Insert(index, lesson);
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

        public void Remove(Lesson lesson)
        {
            if (Lessons.Contains(lesson))
                Lessons.Remove(lesson);
        }

        public static DataCollection Instance
        {
            get
            {
                return instance;
            }
        }
        public Lesson FindLesson(Data data, int time, int day)
        {
            if (data is Lecturer)
            {
                foreach (Lesson lesson in Lessons)
                {
                    if (lesson.Lecturer == data && (lesson.Time == time && lesson.Day == day))
                    {
                        return lesson;
                    }
                }
            }
            else if (data is Module)
            {
                foreach (Lesson lesson in Lessons)
                {
                    if (lesson.Module == data && (lesson.Time == time && lesson.Day == day))
                    {
                        return lesson;
                    }
                }
            }
            else if (data is Room)
            {
                foreach (Lesson lesson in Lessons)
                {
                    if (lesson.Room == data && (lesson.Time == time && lesson.Day == day))
                    {
                        return lesson;
                    }
                }
            }
            else if (data is Group)
            {
                foreach (Lesson lesson in Lessons)
                {
                    if (lesson.Group == data && (lesson.Time == time && lesson.Day == day))
                    {
                        return lesson;
                    }
                }
            }
            return null;

        }

        public Lesson FindLesson(Lesson data, int time, int day)
        {
            foreach (Lesson lesson in Lessons)
            {
                if (lesson == data && (lesson.Time == time && lesson.Day == day))
                {
                    return lesson;
                }
            }
            return null;
        }

        /// <summary>
        ///     Check if a lesson clashes with another.
        ///     For example, 2 lecturers booked in the same room.
        /// </summary>
        /// <param name="lesson">Lesson to check</param>
        /// <returns></returns>
        public bool DoesLessonClash(Lesson lesson)
        {
            foreach (Lesson l in Lessons)
            {
                if ((lesson.Lecturer != null && lesson.Lecturer != l.Lecturer) && (lesson.Room != null && lesson.Room == l.Room) && (lesson.Day == l.Day && l.Time == l.Day))
                {
                    return true;
                }
                else if ((lesson.Module != null && lesson.Module != l.Module) && (lesson.Room != null && lesson.Room == l.Room) && (lesson.Day == l.Day && l.Time == l.Day))
                {
                    return true;
                }
                else if ((lesson.Room != null && lesson.Room != l.Room) && (lesson.Lecturer != null && lesson.Lecturer == l.Lecturer) && (lesson.Day == l.Day && l.Time == l.Day))
                {
                    return true;
                }
                else if ((lesson.Room != null && lesson.Room != l.Room) && (lesson.Group != null && lesson.Group == l.Group) && (lesson.Day == l.Day && l.Time == l.Day))
                {
                    return true;
                }
                else if ((lesson.Room != null && lesson.Group != l.Group) && (lesson.Group != null && lesson.Room == l.Room) && (lesson.Day == l.Day && l.Time == l.Day))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
