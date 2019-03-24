using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.CONTROL
{
    public class FControlCalender
    {


        public void FRegisterDataInCalender(DateTime prStartTime, DateTime prEndTime, string prServico, string prhandleService, string prTeam, string prClient, string prReference, string prStreet, string prNeigh, string prNumber, string prPhone, string prCity)
        {
            DateTime vStartTime = prStartTime;
            DateTime vEndTime = prEndTime;
            String vServico = prServico;

            String vAgroup = prhandleService + "     || Servico: " + prServico + " da Equipe: " + prTeam + " || Cliente: " + prClient + " | Referencia: " + prReference;
            CalendarDemo.DemoForm demoForm = new CalendarDemo.DemoForm(vAgroup, prStartTime, prEndTime, 1);
            demoForm.Show();
            

        }

    }


}
