using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using System.Xml;
using System.Xml.Schema;

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

        public void SaveLecturers()
        {
            if (m_fileName != null)
            {
                m_writer = new XmlTextWriter(m_fileName, null);
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
                m_writer.WriteEndDocument();
                m_writer.Flush();
                m_writer.Close();
            }
        }

        public void SaveModules() { }

        public void SaveRooms() { }

        public void SaveGroups() { }

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

        public void LoadModules() { }

        public void LoadRooms() { }

        public void LoadGourps() { }
    }
}
