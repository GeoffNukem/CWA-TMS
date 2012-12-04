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
        private String[] m_roomCols = { "Name", "Label", "Capacity", "LecturerPC", "SmartBoard", "Television", "Projector", "NetworkLab", "Colour" };
        private String[] m_groupCols = { "Name", "Label", "TotalStudents", "Colour" };

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
                m_writer.WriteStartElement("Lecturers");
                m_writer.WriteAttributeString("Count", DataCollection.Instance.Lecturers.Count.ToString());
                int i = 0;
                // For each person, write each property into the XML document.
                foreach (Lecturer lect in DataCollection.Instance.Lecturers)
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
            XmlDocument xml = new XmlDocument();
            xml.Load(m_reader);
            XmlNodeList nodes = xml.GetElementsByTagName("Lecturers");
            if ((nodes.Item(0).Attributes["Count"].Value.Equals("0")))
                return;

            foreach (XmlNode node in nodes.Item(0).ChildNodes)
            {
                String name = null;
                String label = null;
                int hoursPerWeek = 0;
                Color color = Color.Empty;

                foreach (XmlNode data in node.ChildNodes)
                {
                    try
                    {
                        if(data.Name.Equals(m_lecturerCols[0]))
                        {
                            name = data.InnerText;
                        }
                        else if (data.Name.Equals(m_lecturerCols[1]))
                        {
                            label = data.InnerText;
                        }
                        else if (data.Name.Equals(m_lecturerCols[2]))
                        {
                            hoursPerWeek = int.Parse(data.InnerText);
                        }
                        else if (data.Name.Equals(m_lecturerCols[3]))
                        {
                            color = Color.FromArgb(int.Parse(data.InnerText));
                        }

                        if (name != null && label != null && hoursPerWeek != 0 && color != Color.Empty)
                        {
                            DataCollection.Instance.Add(new Lecturer(name, hoursPerWeek, label, color));
                        }
                    }
                    catch
                    {
                        return;
                    }
                }
            }
        
        }

        public void LoadModules()
        {
            m_reader = new XmlTextReader(m_fileName);
            XmlDocument xml = new XmlDocument();
            xml.Load(m_reader);
            XmlNodeList nodes = xml.GetElementsByTagName("Modules");
            if ((nodes.Item(0).Attributes["Count"].Value.Equals("0")))
                return;

            foreach (XmlNode node in nodes.Item(0).ChildNodes)
            {
                String name = null;
                String label = null;
                String courseLevel = null;
                Color color = Color.Empty;

                foreach (XmlNode data in node.ChildNodes)
                {
                    try
                    {
                        if (data.Name.Equals(m_moduleCols[0]))
                        {
                            name = data.InnerText;
                        }
                        else if (data.Name.Equals(m_moduleCols[1]))
                        {
                            label = data.InnerText;
                        }
                        else if (data.Name.Equals(m_moduleCols[2]))
                        {
                            courseLevel = data.InnerText;
                        }
                        else if (data.Name.Equals(m_moduleCols[3]))
                        {
                            color = Color.FromArgb(int.Parse(data.InnerText));
                        }

                        if (name != null && label != null && courseLevel != null && color != Color.Empty)
                        {
                            DataCollection.Instance.Add(new Module(name, courseLevel, label, color));
                        }
                    }
                    catch
                    {
                        return;
                    }
                }
            }
        }

        public void LoadRooms()
        {
            m_reader = new XmlTextReader(m_fileName);
            XmlDocument xml = new XmlDocument();
            xml.Load(m_reader);
            XmlNodeList nodes = xml.GetElementsByTagName("Rooms");
            if ((nodes.Item(0).Attributes["Count"].Value.Equals("0")))
                return;

            foreach (XmlNode node in nodes.Item(0).ChildNodes)
            {
                String name = null;
                String label = null;
                int capacity = 0;
                Boolean lecturerPC = false;
                Boolean smartboard = false;
                Boolean tv = false;
                Boolean projector = false;
                Boolean networkLab = false;
                Color color = Color.Empty;

                foreach (XmlNode data in node.ChildNodes)
                {
                    try
                    {
                        if (data.Name.Equals(m_roomCols[0]))
                        {
                            name = data.InnerText;
                        }
                        else if (data.Name.Equals(m_roomCols[1]))
                        {
                            label = data.InnerText;
                        }
                        else if (data.Name.Equals(m_roomCols[2]))
                        {
                            capacity = int.Parse(data.InnerText);
                        }
                        else if (data.Name.Equals(m_roomCols[3]))
                        {
                            lecturerPC = Boolean.Parse(data.InnerText);
                        }
                        else if (data.Name.Equals(m_roomCols[4]))
                        {
                            smartboard = Boolean.Parse(data.InnerText);
                        }
                        else if (data.Name.Equals(m_roomCols[5]))
                        {
                            tv = Boolean.Parse(data.InnerText);
                        }
                        else if (data.Name.Equals(m_roomCols[6]))
                        {
                            projector = Boolean.Parse(data.InnerText);
                        }
                        else if (data.Name.Equals(m_roomCols[7]))
                        {
                            networkLab = Boolean.Parse(data.InnerText);
                        }
                        else if (data.Name.Equals(m_roomCols[8]))
                        {
                            color = Color.FromArgb(int.Parse(data.InnerText));
                        }

                        if (name != null && label != null && capacity != 0 && color != Color.Empty)
                        {
                            Room room = new Room(name, label, color, capacity);
                            room.SetEquipment(0, lecturerPC);
                            room.SetEquipment(1, smartboard);
                            room.SetEquipment(2, tv);
                            room.SetEquipment(3, projector);
                            room.SetEquipment(4, networkLab);
                            DataCollection.Instance.Add(room);
                        }
                    }
                    catch
                    {
                        return;
                    }
                }
            }
            
        }

        public void LoadGroups()
        {
            m_reader = new XmlTextReader(m_fileName);
            XmlDocument xml = new XmlDocument();
            xml.Load(m_reader);
            XmlNodeList nodes = xml.GetElementsByTagName("Groups");
            if ((nodes.Item(0).Attributes["Count"].Value.Equals("0")))
                return;

            foreach (XmlNode node in nodes.Item(0).ChildNodes)
            {
                String name = null;
                String label = null;
                int numStudents = 0;
                Color color = Color.Empty;

                foreach (XmlNode data in node.ChildNodes)
                {
                    try
                    {
                        if (data.Name.Equals(m_groupCols[0]))
                        {
                            name = data.InnerText;
                        }
                        else if (data.Name.Equals(m_groupCols[1]))
                        {
                            label = data.InnerText;
                        }
                        else if (data.Name.Equals(m_groupCols[2]))
                        {
                            numStudents = int.Parse(data.InnerText);
                        }
                        else if (data.Name.Equals(m_groupCols[3]))
                        {
                            color = Color.FromArgb(int.Parse(data.InnerText));
                        }

                        if (name != null && label != null && numStudents != 0 && color != Color.Empty)
                        {
                            DataCollection.Instance.Add(new Group(name, label, color, numStudents));
                        }
                    }
                    catch
                    {
                        return;
                    }
                }
            }
        }

        public void LoadLessons()
        {
            m_reader = new XmlTextReader(m_fileName);
            XmlDocument xml = new XmlDocument();
            xml.Load(m_reader);
            XmlNodeList nodes = xml.GetElementsByTagName("Lessons");
            if ((nodes.Item(0).Attributes["Count"].Value.Equals("0")))
                return;

            foreach (XmlNode node in nodes.Item(0).ChildNodes)
            {
                Lecturer lect = null;
                Module mod = null;
                Room room = null;
                Group group = null;
                int day = 0;
                int time = 0;

                int num = 0;

                foreach (XmlNode data in node.ChildNodes)
                {
                    try
                    {
                        if (data.Name.Equals("Lecturer"))
                        {
                            num = int.Parse(data.InnerText);
                            if (num > -1)
                                lect = DataCollection.Instance.Lecturers[num];
                        }
                        else if (data.Name.Equals("Module"))
                        {
                            num = int.Parse(data.InnerText);
                            if (num > -1)
                                mod = DataCollection.Instance.Modules[num];
                        }
                        else if (data.Name.Equals("Room"))
                        {
                            num = int.Parse(data.InnerText);
                            if (num > -1)
                                room = DataCollection.Instance.Rooms[num];
                        }
                        else if (data.Name.Equals("Group"))
                        {
                            num = int.Parse(data.InnerText);
                            if (num > -1)
                                group = DataCollection.Instance.Groups[num];
                        }
                        else if (data.Name.Equals("Day"))
                        {
                            day = int.Parse(data.InnerText);
                        }
                        else if (data.Name.Equals("Time"))
                        {
                            time = int.Parse(data.InnerText);
                        }

                        if (lect != null || mod != null || room != null || group != null)
                        {
                            Lesson lesson = new Lesson();
                            lesson.Lecturer = lect;
                            lesson.Module = mod;
                            lesson.Room = room;
                            lesson.Group = group;
                            lesson.Day = day;
                            lesson.Time = time;
                            DataCollection.Instance.Add(lesson);
                        }
                    }
                    catch
                    {
                        return;
                    }
                }
            }
        }

    }
}
