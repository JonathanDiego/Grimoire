using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grimoire
{
    public class ClassScriptItem
    {
        [Category("1.Basic Info")]
        [Description("Name of the Script")]
        [DisplayName("1.Name")]
        public string Name { get; set; }

        [Category("1.Basic Info")]
        [Description("Name of the Program. Use cmd.exe to execute prompt line commands")]
        [DisplayName("2.Program")]
        public string Program { get; set; }

        [Category("1.Basic Info")]
        [Description("Parameters of the program")]
        [DisplayName("3.Parameters")]
        public string Parameters { get; set; }

        [Category("2.Behavior")]
        [Description("Close after run")]
        [DisplayName("1.Close")]
        public bool Close { get; set; }
    }


    public class ClassObjGrimoire
    {
        public void Copy(ClassObjGrimoire model)
        {
            if (isComputer)
            {
                this.Name = model.Name == null ? this.Name : model.Name;
                this.Description = model.Description == null ? this.Description : model.Description;
                this.Host = model.Host == null ? this.Host : model.Host;
                this.IP = model.IP == null ? this.IP : model.IP;

                this.aUserName1 = model.aUserName1 == null ? this.aUserName1 : model.aUserName1;
                this.aPassWord1 = model.aPassWord1 == null ? this.aPassWord1 : model.aPassWord1;
                this.aUserName2 = model.aUserName2 == null ? this.aUserName2 : model.aUserName2;
                this.aPassWord2 = model.aPassWord2 == null ? this.aPassWord2 : model.aPassWord2;
                this.aUserName3 = model.aUserName3 == null ? this.aUserName3 : model.aUserName3;
                this.aPassWord3 = model.aPassWord3 == null ? this.aPassWord3 : model.aPassWord3;
                this.Observation1 = model.Observation1 == null ? this.Observation1 : model.Observation1;
                this.Observation2 = model.Observation2 == null ? this.Observation2 : model.Observation2;
                this.Observation3 = model.Observation3 == null ? this.Observation3 : model.Observation3;

                if (model.Scripts.Count > 0)
                {
                    this.Scripts.Clear();

                    foreach (ClassScriptItem item in model.Scripts)
                    {
                        ClassScriptItem itemNew = new ClassScriptItem();
                        itemNew.Name = item.Name;
                        itemNew.Program = item.Program;
                        itemNew.Parameters = item.Parameters;
                        itemNew.Close = item.Close;

                        ((ClassObjGrimoire)this).Scripts.Add(itemNew);
                    }
                }
            }
        }

        public ClassObjGrimoire Duplicate()
        {
            ClassObjGrimoire newOne;

            if (isComputer)
            {
                newOne = new ClassObjGrimoire();
                newOne.isComputer = this.isComputer;
                newOne.Description = this.Description;
                newOne.Host = this.Host;
                newOne.IP = this.IP;
                newOne.aUserName1 = this.aUserName1;
                newOne.aPassWord1 = this.aPassWord1;
                newOne.aUserName2 = this.aUserName2;
                newOne.aPassWord2 = this.aPassWord2;
                newOne.aUserName3 = this.aUserName3;
                newOne.aPassWord3 = this.aPassWord3;
                newOne.Observation1 = this.Observation1;
                newOne.Observation2 = this.Observation2;
                newOne.Observation3 = this.Observation3;

                foreach (ClassScriptItem item in this.Scripts)
                {
                    ClassScriptItem itemNew = new ClassScriptItem();
                    itemNew.Name = item.Name;
                    itemNew.Program = item.Program;
                    itemNew.Parameters = item.Parameters;
                    itemNew.Close = item.Close;

                    ((ClassObjGrimoire)newOne).Scripts.Add(itemNew);
                }
            }
            else
            {
                newOne = new ClassObjGrimoire();
                newOne.isComputer = false;
            }

            newOne.Name = Name;

            return newOne;
        }

        [BrowsableAttribute(false)]
        public List<ClassObjGrimoire> Children { get; set; }

        public ClassObjGrimoire()
        {
            Scripts = new List<ClassScriptItem>();
            isComputer = false;
            Owner = null;
            Children = new List<ClassObjGrimoire>();
        }

        public ClassObjGrimoire(bool comp)
        {
            isComputer = comp;
            Owner = null;
            Children = new List<ClassObjGrimoire>();
        }

        public ClassObjGrimoire(bool comp, TreeNode tnOwner)
        {
            isComputer = comp;
            Owner = tnOwner;
            Children = new List<ClassObjGrimoire>();
        }

        public ClassObjGrimoire(TreeNode tnOwner)
        {
            Scripts = new List<ClassScriptItem>();
            isComputer = false;
            Owner = tnOwner;
            Children = new List<ClassObjGrimoire>();
        }
        public TreeNode Owner { get; set; }

        [Category("1.Basic Info")]
        [Description("This Item is a Computer or a Folder?")]
        [DisplayName("Computer")]
        [ReadOnly(true)]
        public bool isComputer { get; set; }


        private string sName;
        [Category("1.Basic Info")]
        [Description("Name of the Item\nSCRIPT TAG: [NAME]")]
        [DisplayName("Name")]
        public string Name
        {
            get
            {
                return sName;
            }

            set
            {
                sName = value;
                if (Owner != null)
                    Owner.Text = sName;
            }
        }

        [Category("2.Computer")]
        [Description("Description of the Computer\nSCRIPT TAG: [DESCRIPTION]")]
        [DisplayName("Description")]
        public string Description { get; set; }

        [Category("2.Computer")]
        [Description("Host Name\nSCRIPT TAG: [HOST]")]
        [DisplayName("Host")]
        public string Host { get; set; }

        [Category("2.Computer")]
        [Description("Internet Protocol\nSCRIPT TAG: [IP]")]
        [DisplayName("IP")]
        public string IP { get; set; }

        [Category("3.1.Credentials")]
        [Description("Username 1 to access\nSCRIPT TAG: [USERNAME1]")]
        [DisplayName("1.Username")]
        public string aUserName1 { get; set; }

        [Category("3.1.Credentials")]
        [Description("Password 1 to access\nSCRIPT TAG: [PASSWORD1]")]
        [DisplayName("2.Password")]
        public string aPassWord1 { get; set; }

        [Category("3.2.Credentials")]
        [Description("Username 2 to access\nSCRIPT TAG: [USERNAME2]")]
        [DisplayName("1.Username")]
        public string aUserName2 { get; set; }

        [Category("3.2.Credentials")]
        [Description("Password 2 to access\nSCRIPT TAG: [PASSWORD2]")]
        [DisplayName("2.Password")]
        public string aPassWord2 { get; set; }

        [Category("3.3.Credentials")]
        [Description("Username 3 to access\nSCRIPT TAG: [USERNAME3]")]
        [DisplayName("1.Username")]
        public string aUserName3 { get; set; }

        [Category("3.3.Credentials")]
        [Description("Password 3 to access\nSCRIPT TAG: [PASSWORD3]")]
        [DisplayName("2.Password")]
        public string aPassWord3 { get; set; }

        [Category("4.Observations")]
        [Description("Observation number 1\nSCRIPT TAG: [OBS1]")]
        [DisplayName("Observation 1")]
        public string Observation1 { get; set; }

        [Category("4.Observations")]
        [Description("Observation number 2\nSCRIPT TAG: [OBS2]")]
        [DisplayName("Observation 2")]
        public string Observation2 { get; set; }

        [Category("4.Observations")]
        [Description("Observation number 3\nSCRIPT TAG: [OBS3]")]
        [DisplayName("Observation 3")]
        public string Observation3 { get; set; }

        [Category("5.Command Line")]
        [Description("Command Line Scripts")]
        [DisplayName("Scripts")]
        public List<ClassScriptItem> Scripts { get; set; }

        public List<ClassScriptItem> GetScripts()
        {
            List<ClassScriptItem> result = new List<ClassScriptItem>();

            foreach (ClassScriptItem item in Scripts)
            {
                ClassScriptItem nitem = new ClassScriptItem();
                nitem.Name = item.Name;
                nitem.Close = item.Close;
                nitem.Program = item.Program;
                nitem.Program = nitem.Program.Replace("[NAME]", this.Name);
                nitem.Program = nitem.Program.Replace("[DESCRIPTION]", this.Description);
                nitem.Program = nitem.Program.Replace("[HOST]", this.Host);
                nitem.Program = nitem.Program.Replace("[IP]", this.IP);
                nitem.Program = nitem.Program.Replace("[USERNAME1]", this.aUserName1);
                nitem.Program = nitem.Program.Replace("[USERNAME2]", this.aUserName2);
                nitem.Program = nitem.Program.Replace("[USERNAME3]", this.aUserName3);
                nitem.Program = nitem.Program.Replace("[PASSWORD1]", this.aPassWord1);
                nitem.Program = nitem.Program.Replace("[PASSWORD2]", this.aPassWord2);
                nitem.Program = nitem.Program.Replace("[PASSWORD3]", this.aPassWord3);
                nitem.Program = nitem.Program.Replace("[OBS1]", this.Observation1);
                nitem.Program = nitem.Program.Replace("[OBS2]", this.Observation2);
                nitem.Program = nitem.Program.Replace("[OBS3]", this.Observation3);

                nitem.Parameters = item.Parameters;
                nitem.Parameters = nitem.Parameters.Replace("[NAME]", this.Name);
                nitem.Parameters = nitem.Parameters.Replace("[DESCRIPTION]", this.Description);
                nitem.Parameters = nitem.Parameters.Replace("[HOST]", this.Host);
                nitem.Parameters = nitem.Parameters.Replace("[IP]", this.IP);
                nitem.Parameters = nitem.Parameters.Replace("[USERNAME1]", this.aUserName1);
                nitem.Parameters = nitem.Parameters.Replace("[USERNAME2]", this.aUserName2);
                nitem.Parameters = nitem.Parameters.Replace("[USERNAME3]", this.aUserName3);
                nitem.Parameters = nitem.Parameters.Replace("[PASSWORD1]", this.aPassWord1);
                nitem.Parameters = nitem.Parameters.Replace("[PASSWORD2]", this.aPassWord2);
                nitem.Parameters = nitem.Parameters.Replace("[PASSWORD3]", this.aPassWord3);
                nitem.Parameters = nitem.Parameters.Replace("[OBS1]", this.Observation1);
                nitem.Parameters = nitem.Parameters.Replace("[OBS2]", this.Observation2);
                nitem.Parameters = nitem.Parameters.Replace("[OBS3]", this.Observation3);

                result.Add(nitem);
            }

            return result;
        }
    }

    public class ClassGrimoireFolder
    {
        public ClassGrimoireFolder(ClassObjGrimoire ow) : base() 
        {
            Owner = ow;
        }

        public ClassObjGrimoire Owner { get; set; }


        [Category("1.Basic Info")]
        [Description("Name of the folder")]
        [DisplayName("Name")]
        public string Name
        {
            get
            {
                return Owner.Name;
            }

            set
            {
                Owner.Name = value;
            }
        }
    }
}
