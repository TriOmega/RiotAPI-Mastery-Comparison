using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MingweiSamuel.Camille;

namespace RiotAPI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MasteryComparisonApp());

            var riotApi = RiotApi.NewInstance("RGAPI-e0aa5040-e568-4e0e-8873-a44066bb97bd");
            

            //var summoner
        }
    }
}
