using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WinServiceIntro
{
    public partial class Service1 : ServiceBase
    {
        readonly string fileName = "mailerror.log"; //warning adli textfile yazacaq
        //const or readonly yazabilirk,readonly class daxilinde deyisei bilir
        public Service1()
        {
            InitializeComponent();
            fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
        }

       

        protected override void OnStart(string[] args)
        {
            File.AppendAllText(fileName, $"before{Environment.NewLine}");
            CheckBirthday();
            File.AppendAllText(fileName, $"before{Environment.NewLine}");
            ////File.WriteAllText(FileName, $"{DateTime.UtcNow.AddHours(4):dd.MM.yyyy HH:mm:ss}Service Invoked OnStart!");
        }

        protected override void OnStop()
        {
            //File.WriteAllText(FileName, $"{DateTime.UtcNow.AddHours(4):dd.MM.yyyy HH:mm:ss}Service Invoked OnStop!");
        }

        internal static void OnDebug()
        {
            //fayla yazmaq ucun:file using lazimdi ilk
            //File.WriteAllText(FileName,"Service Invoked OnDebug!");

            Console.WriteLine("Win Service test Drive P311");
        }

        void CheckBirthday()
        {
            spGetBirthdayTableAdapter1.Fill(dataSetBirthday1.spGetBirthday);
            foreach (var item in dataSetBirthday1.spGetBirthday)
            {
                var result=Extension.Extension.SendEmail(item.Email,item.Message,"Ad Gunun bugun olmasa da Tebrikler{Ferz et ki Bir deste gul ve Tort gonderdim:D}");
                if (result)
                {
                    commonTableAdapter1.spChangeStatus(item.Id);
   
                }
            }
        }
    }
}
