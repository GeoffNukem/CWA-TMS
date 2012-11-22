using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Drawing;

namespace CWATMS
{
    class DataFile
    {
        
        private static readonly DataFile instance = new DataFile();

        public void openAllXML(String file)
        {
                XmlTextReader xml = new XmlTextReader(file);

                String nodeName = "";
                int col = 0;
                Lecturer lect = new Lecturer("", "", 0, Color.Empty);
                Module mod = new Module("", "", 0, Color.Empty);
                Room room = new Room("", "", 0, Color.Empty);
                Group group = new Group("", "", 0, Color.Empty);
                
                while (xml.Read())
                {
                    switch (xml.NodeType)
                    {
                        case XmlNodeType.Element:
                            nodeName = xml.Name;
                            break;
                        case XmlNodeType.Text:
                            switch (nodeName)
                            {
                                case "Lecturer":
                                    lect = new Lecturer("", "", 0, Color.Empty);
                                    lect.Name = xml.Value;
                                    break;
                                case "Label":
                                    lect.Label = xml.Value;
                                    break;
                                case "ContractedHours":
                                    int hours;
                                    if (int.TryParse(xml.Value.ToString(), out hours))
                                        lect.HoursPerWeek = hours;
                                    break;
                                case "Colour":
                                    xml.Value.ToString();
                                    
                                   
                                    break;
                            }
                            break;
                            switch (nodeName)
                            {
                                case "Module":
                                    mod = new Module("", "", "", Color.Empty);
                                    mod.Name = xml.Value;
                                    break;
                                case "Label":
                                    mod.Label = xml.Value;
                                    break;  
                                case "Course Level":
                                    mod.CourseLevel = xml.Value;
                                    break;
                                case "Colour":
                                    //xml.Value.ToString(R,G,B).
                                    mod.Colour = Color.FromArgb(xml.Value.ToString());

                                    break;
                                
                            }
                            break;
                            switch (nodeName)
                            {
                                case "Room":
                                    room = new Room("", "", 0, Color.Empty);
                                    room.Name = xml.Value;
                                    break;
                                case "Label":
                                    room.Label = xml.Value;
                                    break;
                                case "Capacity":
                                    int capacity;
                                    if (int.TryParse(xml.Value.ToString(), out capacity))
                                        room.Capacity = capacity;
                                    break;
                                case "Colour":
                                    //xml.Value.ToString(R,G,B).
                              
                                   
                                    //mod.Colour = Color.FromArgb(xml.Value.ToString());
                                    break;
                                
                            }
                            break;
                            switch (nodeName)
                            {
                                case "Group":
                                    group = new Group("", "", 0, Color.Empty);
                                    group.Name = xml.Value;
                                    break;
                                case "Label":
                                    group.Label = xml.Value;
                                    break;                  
                                case "Total Students":
                                    int totalStu;
                                    if (int.TryParse(xml.Value.ToString(), out totalStu))
                                        group.TotalStudents = totalStu;
                                    break;
                                case "Colour":
                                    //xml.Value.ToString(R,G,B).
                                     //xml.WriteString(mod.Colour.R.ToString() + "," + mod.Colour.G.ToString() + "," + mod.Colour.B.ToString());
                                     group.Colour = colRGB;

                                     

                                     //xml.WriteString(lect.Colour.R.ToString() + "," + lect.Colour.G.ToString() + "," + lect.Colour.B.ToString());
                                    break;
                                
                            }
                            break;
                }
            }
        }

        public void saveAllXML(String file)
        {
            int tn = 0;
            int i = 0;

            // Create XML File.
            XmlTextWriter xml = new XmlTextWriter(file, null);

            // Set XML writer in indent elements.
            xml.Formatting = Formatting.Indented;

            // Write in the XML document.
            xml.WriteStartDocument();
            xml.WriteStartElement("DataTables");
            //xml.WriteAttributeString("Count", dgv.RowCount.ToString());
            do
            {
                switch (tn)
                {
                    case 0:
                        //dgv = dadataLecTable;
                        //DataCollection.Instance.Lecturers;
                        // For each attribute, write each property into the XML document.
                        i = 0;
                        foreach(Lecturer lect in DataCollection.Instance.Lecturers)
                        {
                            xml.WriteStartElement("LecturerTable");
                            xml.WriteAttributeString("ID", i.ToString());
                            xml.WriteStartElement("Lecturer");
                            xml.WriteString(lect.Name);
                            xml.WriteEndElement();
                            xml.WriteStartElement("Label");
                            xml.WriteString(lect.Label);
                            xml.WriteEndElement();
                            xml.WriteStartElement("ContractedHours");
                            xml.WriteString(lect.HoursPerWeek.ToString());
                            xml.WriteEndElement();
                            xml.WriteStartElement("Colour");
                            xml.WriteString(lect.Colour.R.ToString() + "," +lect.Colour.G.ToString() + "," +lect.Colour.B.ToString() );
                            i++;
                        }
                        break;

                    case 1:
                        i = 0;
                        foreach(Module mod in DataCollection.Instance.Modules)
                        {
                            xml.WriteStartElement("SubjectTable");
                            xml.WriteAttributeString("ID", i.ToString());
                            xml.WriteStartElement("Subject");
                            xml.WriteString(mod.Name);
                            xml.WriteEndElement();
                            xml.WriteStartElement("Label");
                            xml.WriteString(mod.Label);
                            xml.WriteEndElement();
                            xml.WriteStartElement("Course Level");
                            xml.WriteString(mod.CourseLevel);
                            xml.WriteEndElement();
                            xml.WriteStartElement("Colour");
                            xml.WriteString(mod.Colour.R.ToString() + "," + mod.Colour.G.ToString() + "," + mod.Colour.B.ToString());
                            xml.WriteEndElement();
                        }
                        break;

                    case 2:

                        i = 0;
                        foreach(Room room in DataCollection.Instance.Rooms)
                        {
                            xml.WriteStartElement("RoomTable");
                            xml.WriteAttributeString("ID", i.ToString());
                            xml.WriteStartElement("Room No");
                            xml.WriteString(room.Name);
                            xml.WriteEndElement();
                            //xml.WriteStartElement("Smartboard");
                            //xml.WriteString(room.Name.Smart);
                            //xml.WriteEndElement();
                            //xml.WriteStartElement("TV");
                            //xml.WriteString(mod.Name);
                            //xml.WriteEndElement();
                            //xml.WriteStartElement("Projector");
                            //xml.WriteString(mod.Name);
                            //xml.WriteEndElement();
                            //xml.WriteStartElement("Network Lab");
                            //xml.WriteString(mod.Name);
                            //xml.WriteEndElement();
                            xml.WriteStartElement("Label");
                            xml.WriteString(room.Label);
                            xml.WriteEndElement();
                            xml.WriteStartElement("Capacity");
                            xml.WriteString(room.Capacity.ToString());
                            xml.WriteEndElement();
                            xml.WriteStartElement("Colour");
                            xml.WriteString(room.Colour.R.ToString() + "," + room.Colour.G.ToString() + "," + room.Colour.B.ToString());
                            xml.WriteEndElement();
                        }
                        break;

                    case 3:

                        i = 0;
                        foreach(Group group in DataCollection.Instance.Groups)
                        {
                            xml.WriteStartElement("ClassTable");
                            xml.WriteAttributeString("ID", i.ToString());
                            xml.WriteStartElement("Class");
                            xml.WriteString(group.Name);
                            xml.WriteEndElement();
                            xml.WriteStartElement("Label");
                            xml.WriteString(group.Label);
                            xml.WriteEndElement();
                            xml.WriteStartElement("Number Students");
                            
                            xml.WriteString(group.TotalStudents.ToString());
                            xml.WriteEndElement();
                            xml.WriteStartElement("Colour");
                            xml.WriteString(group.Colour.R.ToString() + "," + group.Colour.G.ToString() + "," + group.Colour.B.ToString());
                        }
                        break;

                    default:

                        MessageBox.Show("Error saving data, please try again!");

                        break;
                }

                tn++;
            } while (tn < 4);

            xml.WriteEndElement();
            xml.WriteEndDocument();
            xml.Flush();
            xml.Close();
        }
        
        public static DataFile Instance
        {
            get { return instance; }
        }
    
    }
}
