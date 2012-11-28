using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using System.Xml;
using System.Xml.Schema;
using System.Diagnostics;

namespace CWATMS
{
    public class DataFile
    {
        private String m_fileName;

        private String[] m_lecturerCols = { "Name", "Label", "HoursPerWeek", "Colour" };
        private String[] m_moduleCols = { "Name", "Label", "CourseLevel", "Colour" };
        private String[] m_roomCols = { "Name", "Label", "LecturerPC", "Projector", "SmartBoard", "Television", "NetworkLab", "Capacity", "Colour" };
        private String[] m_groupCols = { "Name", "Label", "NumberStudents", "Colour" };

        private XmlTextWriter m_writer;
        private XmlTextReader m_reader;

        private readonly static DataFile instance = new DataFile();

        public DataFile()
        {
        }

        public static DataFile Instance
        {
            get { return instance; }
        }

        public String FileName
        {
            get { return m_fileName; }
            set { m_fileName = value; }
        }

        public void SaveAll()
        {
            if (m_fileName != null)
            {
                m_writer = new XmlTextWriter(m_fileName, null);
                m_writer.Formatting = Formatting.Indented;
                m_writer.WriteStartDocument();
                m_writer.WriteStartElement("Data");
                SaveLecturers();
                SaveModules();
                SaveRooms();
                SaveGroups();
                SaveLessons();
                m_writer.WriteEndElement();
                m_writer.WriteEndDocument();
                m_writer.Flush();
                m_writer.Close();
            }
        }

        public void LoadAll()
        {
            if (m_fileName != null)
            {
                LoadLecturers();
                LoadModules();
                LoadRooms();
                LoadGroups();
                LoadLessons();
                m_reader.Close();
            }
        }

        public void SaveLecturers()
        {
            if (m_fileName != null)
            {
                m_writer.Formatting = Formatting.Indented;

                m_writer.WriteStartDocument();
                m_writer.WriteStartElement("Lecturers");
                m_writer.WriteAttributeString("Count", DataCollection.Instance.Lecturers.Count.ToString());
                int i = 0;
                // For each person, write each property into the XML document.
                foreach(Lecturer lect in DataCollection.Instance.Lecturers)
                {
                    m_writer.WriteStartElement("Lecturer");
                    m_writer.WriteAttributeString("ID", i.ToString());
                    i++;

                    m_writer.WriteStartElement(m_lecturerCols[0]);
                    m_writer.WriteValue(lect.Name);
                    m_writer.WriteEndElement();

                    m_writer.WriteStartElement(m_lecturerCols[1]);
                    m_writer.WriteValue(lect.Label);
                    m_writer.WriteEndElement();

                    m_writer.WriteStartElement(m_lecturerCols[2]);
                    m_writer.WriteValue(lect.HoursPerWeek);
                    m_writer.WriteEndElement();

                    m_writer.WriteStartElement(m_lecturerCols[3]);
                    m_writer.WriteValue(lect.Colour.ToArgb());
                    m_writer.WriteEndElement();
                    m_writer.WriteEndElement();
                }
                m_writer.WriteEndElement();
            }
        }

        public void SaveModules()
        {
            if (m_fileName != null)
            {
                m_writer.WriteStartElement("Modules");
                m_writer.WriteAttributeString("Count", DataCollection.Instance.Modules.Count.ToString());
                int i = 0;
                // For each person, write each property into the XML document.
                foreach (Module mod in DataCollection.Instance.Modules)
                {
                    m_writer.WriteStartElement("Module");
                    m_writer.WriteAttributeString("ID", i.ToString());
                    i++;

                    m_writer.WriteStartElement(m_moduleCols[0]);
                    m_writer.WriteValue(mod.Name);
                    m_writer.WriteEndElement();

                    m_writer.WriteStartElement(m_moduleCols[1]);
                    m_writer.WriteValue(mod.Label);
                    m_writer.WriteEndElement();

                    m_writer.WriteStartElement(m_moduleCols[2]);
                    m_writer.WriteValue(mod.CourseLevel);
                    m_writer.WriteEndElement();

                    m_writer.WriteStartElement(m_moduleCols[3]);
                    m_writer.WriteValue(mod.Colour.ToArgb());
                    m_writer.WriteEndElement();
                    m_writer.WriteEndElement();
                }
                m_writer.WriteEndElement();
            }
        }

        public void SaveRooms()
        {
            if (m_fileName != null)
            {
                m_writer.WriteStartElement("Rooms");
                m_writer.WriteAttributeString("Count", DataCollection.Instance.Rooms.Count.ToString());
                int i = 0;
                // For each person, write each property into the XML document.
                foreach (Room room in DataCollection.Instance.Rooms)
                {
                    m_writer.WriteStartElement("Room");
                    m_writer.WriteAttributeString("ID", i.ToString());
                    i++;

                    m_writer.WriteStartElement(m_roomCols[0]);
                    m_writer.WriteValue(room.Name);
                    m_writer.WriteEndElement();

                    m_writer.WriteStartElement(m_roomCols[1]);
                    m_writer.WriteValue(room.Label);
                    m_writer.WriteEndElement();

                    m_writer.WriteStartElement(m_roomCols[2]);
                    m_writer.WriteValue(room.Capacity);
                    m_writer.WriteEndElement();

                    m_writer.WriteStartElement(m_roomCols[3]);
                    m_writer.WriteValue(room.HasLecturerPC());
                    m_writer.WriteEndElement();

                    m_writer.WriteStartElement(m_roomCols[4]);
                    m_writer.WriteValue(room.HasSmartboard());
                    m_writer.WriteEndElement();

                    m_writer.WriteStartElement(m_roomCols[5]);
                    m_writer.WriteValue(room.HasTelevision());
                    m_writer.WriteEndElement();

                    m_writer.WriteStartElement(m_roomCols[6]);
                    m_writer.WriteValue(room.HasProjector());
                    m_writer.WriteEndElement();

                    m_writer.WriteStartElement(m_roomCols[7]);
                    m_writer.WriteValue(room.IsNetworkLab());
                    m_writer.WriteEndElement();

                    m_writer.WriteStartElement(m_roomCols[8]);
                    m_writer.WriteValue(room.Colour.ToArgb());
                    m_writer.WriteEndElement();

                    m_writer.WriteEndElement();
                }
                m_writer.WriteEndElement();
            }
        }

        public void SaveGroups()
        {
            if (m_fileName != null)
            {
                m_writer.WriteStartElement("Groups");
                m_writer.WriteAttributeString("Count", DataCollection.Instance.Groups.Count.ToString());
                int i = 0;
                // For each person, write each property into the XML document.
                foreach (Group group in DataCollection.Instance.Groups)
                {
                    m_writer.WriteStartElement("Group");
                    m_writer.WriteAttributeString("ID", i.ToString());
                    i++;

                    m_writer.WriteStartElement(m_groupCols[0]);
                    m_writer.WriteValue(group.Name);
                    m_writer.WriteEndElement();

                    m_writer.WriteStartElement(m_groupCols[1]);
                    m_writer.WriteValue(group.Label);
                    m_writer.WriteEndElement();

                    m_writer.WriteStartElement(m_groupCols[2]);
                    m_writer.WriteValue(group.TotalStudents);
                    m_writer.WriteEndElement();

                    m_writer.WriteStartElement(m_groupCols[3]);
                    m_writer.WriteValue(group.Colour.ToArgb());
                    m_writer.WriteEndElement();
                    m_writer.WriteEndElement();
                }
                m_writer.WriteEndElement();
            }
        }

        public void SaveLessons()
        {
            if (m_fileName != null)
            {
                m_writer.WriteStartElement("Lessons");
                m_writer.WriteAttributeString("Count", DataCollection.Instance.Lessons.Count.ToString());
                int i = 0;
                // For each person, write each property into the XML document.
                foreach (Lesson lesson in DataCollection.Instance.Lessons)
                {
                    m_writer.WriteStartElement("Lesson");
                    m_writer.WriteAttributeString("ID", i.ToString());
                    i++;

                    m_writer.WriteStartElement("Lecturer");
                    m_writer.WriteValue(DataCollection.Instance.Lecturers.IndexOf(lesson.Lecturer));
                    m_writer.WriteEndElement();

                    m_writer.WriteStartElement("Module");
                    m_writer.WriteValue(DataCollection.Instance.Modules.IndexOf(lesson.Module));
                    m_writer.WriteEndElement();

                    m_writer.WriteStartElement("Room");
                    m_writer.WriteValue(DataCollection.Instance.Rooms.IndexOf(lesson.Room));
                    m_writer.WriteEndElement();

                    m_writer.WriteStartElement("Group");
                    m_writer.WriteValue(DataCollection.Instance.Groups.IndexOf(lesson.Group));
                    m_writer.WriteEndElement();

                    m_writer.WriteStartElement("Day");
                    m_writer.WriteValue(lesson.Day);
                    m_writer.WriteEndElement();

                    m_writer.WriteStartElement("Time");
                    m_writer.WriteValue(lesson.Time);
                    m_writer.WriteEndElement();

                    m_writer.WriteEndElement();
                }
                m_writer.WriteEndElement();
            }
        }

        public void LoadLecturers() 
        {
            m_reader = new XmlTextReader(m_fileName);

            string currentNode = "";
            Lecturer lect = new Lecturer("", 0, "", Color.Empty);

            while (m_reader.Read())
            {
                switch (m_reader.NodeType)
                {
                    case XmlNodeType.Element:
                        currentNode = m_reader.Name;
                        break;
                    case XmlNodeType.Text:
                            switch (currentNode)
                            {
                                case "Name":
                                    lect = new Lecturer("", 0, "", Color.Empty);
                                    lect.Name = m_reader.Value;
                                    break;
                                case "Label":
                                    lect.Label = m_reader.Value;
                                    break;
                                case "HoursPerWeek":
                                    try
                                    {
                                        lect.HoursPerWeek = int.Parse(m_reader.Value);
                                    }
                                    catch
                                    {
                                        return;
                                    }
                                    break;
                                case "Colour":
                                    try
                                    {
                                        lect.Colour = Color.FromArgb(int.Parse(m_reader.Value));
                                    }
                                    catch
                                    {
                                        return;
                                    }
                                    break;
                                default:
                                    break;
                            }
                        break;
                    case XmlNodeType.EndElement:
                        if (m_reader.Name == "Lecturer")
                        {
                            DataCollection.Instance.Add(lect);
                        }
                        break;
                    default:
                        break;
                }
            }
            m_reader.Close();
        }

        public void LoadModules()
        {
            m_reader = new XmlTextReader(m_fileName);
            string currentNode = "";
            Module mod = new Module("", "", "", Color.Empty);

            while (m_reader.Read())
            {
                switch (m_reader.NodeType)
                {
                    case XmlNodeType.Element:
                        currentNode = m_reader.Name;
                        break;
                    case XmlNodeType.Text:
                        switch (currentNode)
                        {
                            case "Name":
                                mod = new Module("", "", "", Color.Empty);
                                mod.Name = m_reader.Value;
                                break;
                            case "Label":
                                mod.Label = m_reader.Value;
                                break;
                            case "CourseLevel":
                                mod.CourseLevel = m_reader.Value;
                                break;
                            case "Colour":
                                try
                                {
                                    mod.Colour = Color.FromArgb(int.Parse(m_reader.Value));
                                }
                                catch
                                {
                                    return;
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    case XmlNodeType.EndElement:
                        if (m_reader.Name == "Module")
                            DataCollection.Instance.Add(mod);
                        else if (m_reader.Name == "Modules")
                            return;
                        break;
                    default:
                        break;
                }
            }
        }

        public void LoadRooms()
        {
            m_reader = new XmlTextReader(m_fileName);
            string currentNode = "";
            Room room = new Room("", "", Color.Empty, 0);

            while (m_reader.Read())
            {
                switch (m_reader.NodeType)
                {
                    case XmlNodeType.Element:
                        currentNode = m_reader.Name;
                        break;
                    case XmlNodeType.Text:
                        switch (currentNode)
                        {
                            case "Name":
                                room = new Room("", "", Color.Empty, 0);
                                room.Name = m_reader.Value;
                                break;
                            case "Label":
                                room.Label = m_reader.Value;
                                break;
                            case "Capacity":
                                try
                                {
                                    room.Capacity = int.Parse(m_reader.Value);
                                }
                                catch
                                {
                                    Debug.Print("Cannot load Room Capacity");
                                    return;
                                }
                                break;
                            case "LecturerPC":
                                try
                                {
                                    room.SetEquipment(0, bool.Parse(m_reader.Value));
                                }
                                catch
                                {
                                    Debug.Print("Cannot load Room LecturerPC");
                                    return;
                                }
                                break;
                            case "SmartBoard":
                                try
                                {
                                    room.SetEquipment(1, bool.Parse(m_reader.Value));
                                }
                                catch
                                {
                                    Debug.Print("Cannot load Room SmartBoard");
                                    return;
                                }
                                break;
                            case "Television":
                                try
                                {
                                    room.SetEquipment(2, bool.Parse(m_reader.Value));
                                }
                                catch
                                {
                                    Debug.Print("Cannot load Room Television");
                                    return;
                                }
                                break;
                            case "Projector":
                                try
                                {
                                    room.SetEquipment(3, bool.Parse(m_reader.Value));
                                }
                                catch
                                {
                                    Debug.Print("Cannot load Room Projector");
                                    return;
                                }
                                break;
                            case "NetworkLab":
                                try
                                {
                                    room.SetEquipment(4, bool.Parse(m_reader.Value));
                                }
                                catch
                                {
                                    Debug.Print("Cannot load Room NetworkLab");
                                    return;
                                }
                                break;
                            case "Colour":
                                try
                                {
                                    room.Colour = Color.FromArgb(int.Parse(m_reader.Value));
                                }
                                catch
                                {
                                    Debug.Print("Cannot load Room Colour");
                                    return;
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    case XmlNodeType.EndElement:
                        if (m_reader.Name == "Room")
                            DataCollection.Instance.Add(room);
                        else if (m_reader.Name == "Rooms")
                            return;
                        break;
                    default:
                        break;
                }
            }
        }

        public void LoadGroups()
        {
            m_reader = new XmlTextReader(m_fileName);
            string currentNode = "";
            Group group = new Group("", "", Color.Empty, 0);

            while (m_reader.Read())
            {
                switch (m_reader.NodeType)
                {
                    case XmlNodeType.Element:
                        currentNode = m_reader.Name;
                        break;
                    case XmlNodeType.Text:
                        switch (currentNode)
                        {
                            case "Name":
                                group = new Group("", "", Color.Empty, 0);
                                group.Name = m_reader.Value;
                                break;
                            case "Label":
                                group.Label = m_reader.Value;
                                break;
                            case "TotalStudents":
                                try
                                {
                                    group.TotalStudents = int.Parse(m_reader.Value);
                                }
                                catch
                                {
                                    Debug.Print("Cannot load Group TotalStudents");
                                    return;
                                }
                                break;
                            case "Colour":
                                try
                                {
                                    group.Colour = Color.FromArgb(int.Parse(m_reader.Value));
                                }
                                catch
                                {
                                    return;
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    case XmlNodeType.EndElement:
                        if (m_reader.Name == "Group")
                            DataCollection.Instance.Add(group);
                        else if (m_reader.Name == "Groups")
                            return;
                        break;
                    default:
                        break;
                }
            }
        }

        public void LoadLessons()
        {
            m_reader = new XmlTextReader(m_fileName);
            string currentNode = "";
            Lesson lesson = new Lesson();

            while (m_reader.Read())
            {
                switch (m_reader.NodeType)
                {
                    case XmlNodeType.Element:
                        currentNode = m_reader.Name;
                        break;
                    case XmlNodeType.Text:
                        switch (currentNode)
                        {
                            case "Lecturer":
                                lesson = new Lesson();
                                try
                                {
                                    lesson.Lecturer = (Lecturer)DataCollection.Instance.Lecturers[int.Parse(m_reader.Value)];
                                }
                                catch
                                {
                                    return;
                                }
                                break;
                            case "Module":
                                try
                                {
                                    lesson.Module = (Module)DataCollection.Instance.Modules[int.Parse(m_reader.Value)];
                                }
                                catch
                                {
                                    return;
                                }
                                break;
                            case "Room":
                                try
                                {
                                    lesson.Room = (Room)DataCollection.Instance.Rooms[int.Parse(m_reader.Value)];
                                }
                                catch
                                {
                                    return;
                                }
                                break;
                            case "Group":
                                try
                                {
                                    lesson.Group = (Group)DataCollection.Instance.Groups[int.Parse(m_reader.Value)];
                                }
                                catch
                                {
                                    return;
                                }
                                break;
                            case "Day":
                                try
                                {
                                    lesson.Day = int.Parse(m_reader.Value);
                                }
                                catch
                                {
                                    return;
                                }
                                break;
                            case "Time":
                                try
                                {
                                    lesson.Time = int.Parse(m_reader.Value);
                                }
                                catch
                                {
                                    return;
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    case XmlNodeType.EndElement:
                        if (m_reader.Name == "Lesson")
                            DataCollection.Instance.Add(lesson);
                        else if (m_reader.Name == "Lessons")
                            return;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
